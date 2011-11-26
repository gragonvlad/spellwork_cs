using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SpellWork
{
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
            SpellSelected = false;
        }

        public SpellEntry Spell { get; private set; }
        private bool SpellSelected;

        private void Ok_Click(object sender, EventArgs e)
        {
            if (SpellSelected)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public static void Search(TextBox tb)
        {
            FormSearch form = new FormSearch();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
                tb.Text = form.Spell.ID.ToString();
            form.Dispose();
        }

        private void spellFilter1_OnSpellChange(object sender, EventArgs e)
        {
            SpellSelected = true;
            Spell = ((Forms.SpellFilter)sender).SelectedSpell;
            new SpellInfo(_rtbSpellInfo, Spell);
        }
    }
}
