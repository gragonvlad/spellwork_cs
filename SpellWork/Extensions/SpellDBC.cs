using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Reflection;
namespace SpellWork
{
    public static class SpellDBC
    {
        #region Spell patcher

        public static string CreateSpellPatch(uint _spell, SpellEntry Current)
        {

            int ssize = Marshal.SizeOf(typeof(SpellEntry)) / sizeof(Int32);
            Int32[] OriginalS = new Int32[ssize];
            Int32[] CurrentS = new Int32[ssize];
            IntPtr O_ptr = Marshal.AllocHGlobal(ssize * sizeof(Int32));
            IntPtr C_ptr = Marshal.AllocHGlobal(ssize * sizeof(Int32));
            SpellEntry O = DBC.Spell[_spell];
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
    }
}
