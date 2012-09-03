using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace SpellWork.Forms
{
    public partial class SpellFilter : UserControl
    {
        private List<SpellEntry> _spellList = new List<SpellEntry>();

        public event EventHandler OnSpellChange;
        public SpellEntry SelectedSpell { get; private set; }
        public SpellFilter()
        {
            InitializeComponent();
            // load items to control's
            
            _cbSpellFamilyName.SetEnumValues<SpellFamilyNames>("SpellFamilyName");
            _cbSpellAura.SetEnumValues<AuraType>("Aura");
            _cbSpellEffect.SetEnumValues<SpellEffects>("Effect");
            _cbTarget1.SetEnumValues<Targets>("Target A");
            _cbTarget2.SetEnumValues<Targets>("Target B");
            
            _cbSpellClassMask.SetEnumValues<ClassFlag>("SpellClassFlag");
            
            _cbAdvancedFilter1.SetStructFields<SpellEntry>();
            _cbAdvancedFilter2.SetStructFields<SpellEntry>();

            _cbAdvancedFilter1CompareType.SetEnumValuesDirect<CompareType>(true);
            _cbAdvancedFilter2CompareType.SetEnumValuesDirect<CompareType>(true);
        }

        private void _lvSpellList_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            e.Item = new ListViewItem(new[] { _spellList[e.ItemIndex].ID.ToString(), _spellList[e.ItemIndex].SpellNameRank });
        }
        private void _tbSearchId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AdvancedSearch();
        }

        private void _bSearch_Click(object sender, EventArgs e)
        {
            AdvancedSearch();
        }

        private void _cbSpellFamilyNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).SelectedIndex != 0)
                AdvancedFilter();
        }

        private void _tbAdvansedFilterVal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AdvancedFilter();
        }

        private void AdvancedSearch()
        {
            string name = _tbSearchId.Text;
            uint id = name.ToUInt32();
            uint ic = _tbSearchIcon.Text.ToUInt32();
         
            _spellList = (from spell in DBC.Spell.Values

                          where ((id == 0 || spell.ID == id)
                              && (ic == 0 || spell.SpellIconID == ic)
                              && ((id != 0 || ic != 0) || spell.SpellName.ContainsText(name)))

                          select spell).ToList();

            _lvSpellList.VirtualListSize = _spellList.Count();
            if (_lvSpellList.SelectedIndices.Count > 0)
                _lvSpellList.Items[_lvSpellList.SelectedIndices[0]].Selected = false;
        }

        private void AdvancedFilter()
        {
            var bFamilyNames = _cbSpellFamilyName.SelectedIndex != 0;
            var fFamilyNames = _cbSpellFamilyName.SelectedValue.ToInt32();

            var bSpellAura = _cbSpellAura.SelectedIndex != 0;
            var fSpellAura = _cbSpellAura.SelectedValue.ToInt32();

            var bSpellEffect = _cbSpellEffect.SelectedIndex != 0;
            var fSpellEffect = _cbSpellEffect.SelectedValue.ToInt32();

            var bTarget1 = _cbTarget1.SelectedIndex != 0;
            var fTarget1 = _cbTarget1.SelectedValue.ToInt32();

            var bTarget2 = _cbTarget2.SelectedIndex != 0;
            var fTarget2 = _cbTarget2.SelectedValue.ToInt32();

            var bSpellFlag = _cbSpellClassMask.SelectedIndex != 0;
            int fSpellFlag = _cbSpellClassMask.SelectedValue.ToInt32();
            string sSpellFlag = _cbSpellClassMask.Text;

            // additional filtert
            var advVal1 = _tbAdvancedFilter1Val.Text;
            var advVal2 = _tbAdvancedFilter2Val.Text;

            var field1 = (MemberInfo)_cbAdvancedFilter1.SelectedValue;
            var field2 = (MemberInfo)_cbAdvancedFilter2.SelectedValue;

            bool use1val = advVal1 != string.Empty;
            bool use2val = advVal2 != string.Empty;

            CompareType field1ct = (CompareType)_cbAdvancedFilter1CompareType.SelectedIndex;
            CompareType field2ct = (CompareType)_cbAdvancedFilter2CompareType.SelectedIndex;

            _spellList = (from spell in DBC.Spell.Values

                          where (!bFamilyNames || spell.SpellFamilyName == fFamilyNames)
                              && (!bSpellEffect || spell.Effect.ContainsElement((uint)fSpellEffect))
                              && (!bSpellAura || spell.EffectApplyAuraName.ContainsElement((uint)fSpellAura))
                              && (!bTarget1 || spell.EffectImplicitTargetA.ContainsElement((uint)fTarget1))
                              && (!bTarget2 || spell.EffectImplicitTargetB.ContainsElement((uint)fTarget2))
                              && (!use1val || spell.CreateFilter(field1, advVal1, field1ct))
                              && (!use2val || spell.CreateFilter(field2, advVal2, field2ct))
                              && (!bSpellFlag || (spell.CheckSpellFamily(sSpellFlag) && spell.CheckSpellMask(fSpellFlag)))

                          select spell).ToList();

            _lvSpellList.VirtualListSize = _spellList.Count();
            if (_lvSpellList.SelectedIndices.Count > 0)
                _lvSpellList.Items[_lvSpellList.SelectedIndices[0]].Selected = false;

        }

        private void _lvSpellList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_lvSpellList.SelectedIndices.Count > 0)
            {
              SelectedSpell=_spellList[_lvSpellList.SelectedIndices[0]];
                if (OnSpellChange!=null)
                 OnSpellChange(this, new EventArgs());
            }
            
        }

        public void Search(String S)
        {
            _tbSearchId.Text = S;
            AdvancedSearch();
        }

        private void _cbSpellClassMask_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).SelectedIndex != 0)
                AdvancedFilter();
        }
    }
}
