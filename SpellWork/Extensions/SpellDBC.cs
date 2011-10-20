using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Reflection;
using MySql.Data.MySqlClient;
namespace SpellWork
{
    public static class SpellDBC
    {
         private static List<string> SpellDBCFields = new List<string>();
         private const BindingFlags B_Flags =BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.IgnoreCase;

        #region Spell patcher

        public static string CreateSpellPatch(SpellEntry Current)
        {

            int ssize = Marshal.SizeOf(typeof(SpellEntry)) / sizeof(Int32);
            Int32[] OriginalS = new Int32[ssize];
            Int32[] CurrentS = new Int32[ssize];
            IntPtr O_ptr = Marshal.AllocHGlobal(ssize * sizeof(Int32));
            IntPtr C_ptr = Marshal.AllocHGlobal(ssize * sizeof(Int32));
            SpellEntry O = DBC.Spell[Current.ID];
            Marshal.StructureToPtr(O, O_ptr, false);
            Marshal.StructureToPtr(Current, C_ptr, false);
            Marshal.Copy(O_ptr, OriginalS, 0, ssize);
            Marshal.Copy(C_ptr, CurrentS, 0, ssize);
            StringBuilder res = new StringBuilder();

            for (int i = 0; i < ssize; i++)
            {

                if (CurrentS[i] != OriginalS[i])
                {
                    res.AppendFormat("{0} {1} ", i.ToString(), CurrentS[i].ToString());
                }
            }

            string result = "";
            if (res.Length > 0)
            {

                StringBuilder diff = new StringBuilder();

                foreach (FieldInfo f in typeof(SpellEntry).GetFields())
                {
                    if (f.GetValueDirect(__makeref(Current)).ToString() != f.GetValueDirect(__makeref(O)).ToString())
                        diff.AppendFormat("{0} ", f.Name);
                    if (f.FieldType.IsArray)
                    {
                        Array a = (Array)f.GetValue(Current);
                        Array b = (Array)f.GetValue(O);
                        for (int i = 0; i < a.Length; i++)
                            if (a.GetValue(i).ToString() != b.GetValue(i).ToString())
                                diff.AppendFormat("{0}{1} ", f.Name, (i + 1).ToString());
                    }

                }
                result = String.Format("REPLACE INTO spell_patch VALUES ({0},'Spell.dbc','{1}','{2}-{0} (Update {3})');\r\n", O.ID, res.ToString().TrimEnd(' '), O.SpellName, diff.ToString());
            }

            Marshal.FreeHGlobal(O_ptr);
            Marshal.FreeHGlobal(C_ptr);
            return result;
        }
        #endregion
        
        #region SpellDBC
        public static void FillSpellDbc(MySqlDataReader reader)
        {
            SpellDBCFields.Clear();
            //Create fields list
            for (int i = 0; i < reader.FieldCount; i++)
                SpellDBCFields.Add(reader.GetName(i));

            Type ObjType = typeof(SpellEntry);

            byte[] rawData = new byte[Marshal.SizeOf(ObjType)]; //zero buffer for SpellEntry init
            SpellEntry str;
            while (reader.Read())
            {

                uint New_ID = reader[0].ToUInt32();
                string SpellName=reader[reader.FieldCount - 1].ToString();
                bool IsNew=!DBC.Spell.ContainsKey(New_ID);
               
                if (IsNew)
                {
                  
                 // Init SpellEntry by zero
                GCHandle handle = GCHandle.Alloc(rawData, GCHandleType.Pinned);
                str = (SpellEntry)Marshal.PtrToStructure(handle.AddrOfPinnedObject(),ObjType);
                handle.Free();
                str.ID = New_ID;
                str.SetName(SpellName);
                }
                else
                {
                     str=DBC.Spell[New_ID];
                     str.SetName("");
                }
                
                TypedReference R = __makeref(str);

                for (int i = 1; i < reader.FieldCount; i++)
                {
                    String fname = SpellDBCFields[i];
                    FieldInfo f = ObjType.GetField(fname,B_Flags);
                    if (f == null)
                    {
                        //Try to find array
                        f = ObjType.GetField(fname.ArrayName(), B_Flags);
                        if (f != null && f.FieldType.IsArray)
                        {

                            Array arr = (Array)f.GetValueDirect(R);
                            for (int j = 0; j < arr.Length && SpellDBCFields[i].ArrayName()== f.Name; j++)
                            {
                              arr.SetValue(Convert.ChangeType(reader[i++].ToString(), f.FieldType.GetElementType()),j);
                            }
                            i--; //correct counter before next iteration
                            
                        }

                    }
                    else
                    {
                        f.SetValueDirect(R, Convert.ChangeType(reader[i].ToString(), f.FieldType));
                    }
                }
                if (IsNew)
                  DBC.Spell.Add(New_ID, str);
                
            }
        }
       #endregion

        #region SpellDBC Generate SQL
        public static StringBuilder CreateSpellSql(SpellEntry Current)
        {
            SpellEntry Old_Spell = DBC.Spell[Current.ID];
            StringBuilder result = new StringBuilder();
            StringBuilder not_found = new StringBuilder();
            StringBuilder update=new StringBuilder();

            Type ObjType = typeof(SpellEntry);
            result.AppendFormatLine("-- Replace DBC values for spell {0} - {1}", Old_Spell.ID,Old_Spell.SpellNameRank);
            result.AppendFormatLine("DELETE FROM `spell_dbc` WHERE ID={0};", Old_Spell.ID);
            result.AppendFormat("INSERT INTO `spell_dbc` (`{0}`)\r\nVALUES (",String.Join("`, `", SpellDBCFields.ToArray()));

            for (int i = 0; i < SpellDBCFields.Count; i++)
            {
                string FieldName = SpellDBCFields[i];
                FieldInfo f = ObjType.GetField(FieldName, B_Flags);

                if (f == null)
                {
                    //Try to find array
                    f = ObjType.GetField(FieldName.ArrayName(), B_Flags);
                    if (f != null && f.FieldType.IsArray)
                    {
                        Array arr = (Array)f.GetValue(Old_Spell);
                        Array arr_new = (Array)f.GetValue(Current);
                        for (int j = 0; j < arr.Length && SpellDBCFields[i].ArrayName()== f.Name; j++)
                        {
                            string old_val = arr.GetValue(j).ToMySqlString();
                            string new_val = arr_new.GetValue(j).ToMySqlString();
                            if (old_val != new_val)
                                update.AppendFormatLine("`{0}`={1}, -- old value = {1}", SpellDBCFields[i], new_val, old_val);
                            result.AppendFormat(" {0} ,", old_val);
                            i++;
                        }
                        i--; //correct counter before next iteration

                    }
                    else
                    {
                        not_found.AppendFormat("{0} ", FieldName);
                    }

                }
                else
                {
                    string old_val=f.GetValue(Old_Spell).ToMySqlString();
                    string new_val=f.GetValue(Current).ToMySqlString();
                    result.AppendFormat(" {0} ,", old_val);
                    if (old_val != new_val)
                        update.AppendFormatLine("`{0}`={1}, -- old value = {2}", SpellDBCFields[i], new_val,old_val);
                }
            }

            result.AppendFormatLine("'{0}');", Old_Spell.SpellName); //assume that the last field is `Comment`
            result.AppendFormatLine("-- Attention! Fields [ {0} ] not mapped", not_found.ToString());
            if (update.Length > 0)
            {
                update.AppendFormatLine("`Comment` = 'Replacement for spell {0} \"{1}\"' ", Current.ID, Current.SpellNameRank);
                result.AppendLine();
                result.AppendLine();
                result.AppendLine("UPDATE `spell_dbc` SET ");
                result.AppendFormat("{0}", update.ToString());
                result.AppendFormatLine("WHERE Id={0};", Current.ID);
            }
            return result;
        }
        #endregion
    }
}
