namespace SpellWork.Forms
{
    partial class SpellFilter
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._bSearch = new System.Windows.Forms.Button();
            this._tbSearchAttributes = new System.Windows.Forms.TextBox();
            this._tbSearchIcon = new System.Windows.Forms.TextBox();
            this._tbSearchId = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this._cbTarget2 = new System.Windows.Forms.ComboBox();
            this._cbTarget1 = new System.Windows.Forms.ComboBox();
            this._cbSpellEffect = new System.Windows.Forms.ComboBox();
            this._cbSpellAura = new System.Windows.Forms.ComboBox();
            this._cbSpellFamilyName = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this._lvSpellList = new System.Windows.Forms.ListView();
            this.chSpellID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSpellName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._gbAdvansedSearch = new System.Windows.Forms.GroupBox();
            this._cbAdvancedFilter2CompareType = new System.Windows.Forms.ComboBox();
            this._cbAdvancedFilter1CompareType = new System.Windows.Forms.ComboBox();
            this._tbAdvancedFilter2Val = new System.Windows.Forms.TextBox();
            this._tbAdvancedFilter1Val = new System.Windows.Forms.TextBox();
            this._cbAdvancedFilter2 = new System.Windows.Forms.ComboBox();
            this._cbAdvancedFilter1 = new System.Windows.Forms.ComboBox();
            this.groupBox7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this._gbAdvansedSearch.SuspendLayout();
            this.SuspendLayout();
            //
            // groupBox7
            //
            this.groupBox7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox7.BackColor = System.Drawing.Color.LightGray;
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this._bSearch);
            this.groupBox7.Controls.Add(this._tbSearchAttributes);
            this.groupBox7.Controls.Add(this._tbSearchIcon);
            this.groupBox7.Controls.Add(this._tbSearchId);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox7.Location = new System.Drawing.Point(0, 0);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(314, 83);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Spell Search";
            //
            // label6
            //
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Attributes&&X:";
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Icon ID:";
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "ID or Name:";
            //
            // _bSearch
            //
            this._bSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._bSearch.Location = new System.Drawing.Point(263, 11);
            this._bSearch.Name = "_bSearch";
            this._bSearch.Size = new System.Drawing.Size(50, 23);
            this._bSearch.TabIndex = 1;
            this._bSearch.Text = "Search";
            this._bSearch.UseVisualStyleBackColor = true;
            this._bSearch.Click += new System.EventHandler(this._bSearch_Click);
            //
            // _tbSearchAttributes
            //
            this._tbSearchAttributes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tbSearchAttributes.Location = new System.Drawing.Point(73, 57);
            this._tbSearchAttributes.Name = "_tbSearchAttributes";
            this._tbSearchAttributes.Size = new System.Drawing.Size(185, 20);
            this._tbSearchAttributes.TabIndex = 0;
            this._tbSearchAttributes.KeyDown += new System.Windows.Forms.KeyEventHandler(this._tbSearchId_KeyDown);
            //
            // _tbSearchIcon
            //
            this._tbSearchIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tbSearchIcon.Location = new System.Drawing.Point(73, 35);
            this._tbSearchIcon.Name = "_tbSearchIcon";
            this._tbSearchIcon.Size = new System.Drawing.Size(185, 20);
            this._tbSearchIcon.TabIndex = 0;
            this._tbSearchIcon.KeyDown += new System.Windows.Forms.KeyEventHandler(this._tbSearchId_KeyDown);
            //
            // _tbSearchId
            //
            this._tbSearchId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tbSearchId.Location = new System.Drawing.Point(73, 13);
            this._tbSearchId.Name = "_tbSearchId";
            this._tbSearchId.Size = new System.Drawing.Size(185, 20);
            this._tbSearchId.TabIndex = 0;
            this._tbSearchId.KeyDown += new System.Windows.Forms.KeyEventHandler(this._tbSearchId_KeyDown);
            //
            // panel1
            //
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this._cbTarget2);
            this.panel1.Controls.Add(this._cbTarget1);
            this.panel1.Controls.Add(this._cbSpellEffect);
            this.panel1.Controls.Add(this._cbSpellAura);
            this.panel1.Controls.Add(this._cbSpellFamilyName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 110);
            this.panel1.TabIndex = 14;
            //
            // _cbTarget2
            //
            this._cbTarget2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cbTarget2.DropDownHeight = 500;
            this._cbTarget2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbTarget2.DropDownWidth = 302;
            this._cbTarget2.FormattingEnabled = true;
            this._cbTarget2.IntegralHeight = false;
            this._cbTarget2.Location = new System.Drawing.Point(160, 84);
            this._cbTarget2.Name = "_cbTarget2";
            this._cbTarget2.Size = new System.Drawing.Size(151, 21);
            this._cbTarget2.TabIndex = 19;
            this._cbTarget2.SelectedIndexChanged += new System.EventHandler(this._cbSpellFamilyNames_SelectedIndexChanged);
            //
            // _cbTarget1
            //
            this._cbTarget1.DropDownHeight = 500;
            this._cbTarget1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbTarget1.DropDownWidth = 302;
            this._cbTarget1.FormattingEnabled = true;
            this._cbTarget1.IntegralHeight = false;
            this._cbTarget1.Location = new System.Drawing.Point(3, 84);
            this._cbTarget1.Name = "_cbTarget1";
            this._cbTarget1.Size = new System.Drawing.Size(151, 21);
            this._cbTarget1.TabIndex = 18;
            this._cbTarget1.SelectedIndexChanged += new System.EventHandler(this._cbSpellFamilyNames_SelectedIndexChanged);
            //
            // _cbSpellEffect
            //
            this._cbSpellEffect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cbSpellEffect.DropDownHeight = 500;
            this._cbSpellEffect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbSpellEffect.DropDownWidth = 302;
            this._cbSpellEffect.FormattingEnabled = true;
            this._cbSpellEffect.IntegralHeight = false;
            this._cbSpellEffect.Location = new System.Drawing.Point(3, 57);
            this._cbSpellEffect.Name = "_cbSpellEffect";
            this._cbSpellEffect.Size = new System.Drawing.Size(308, 21);
            this._cbSpellEffect.TabIndex = 17;
            this._cbSpellEffect.SelectedIndexChanged += new System.EventHandler(this._cbSpellFamilyNames_SelectedIndexChanged);
            //
            // _cbSpellAura
            //
            this._cbSpellAura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cbSpellAura.DropDownHeight = 500;
            this._cbSpellAura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbSpellAura.DropDownWidth = 302;
            this._cbSpellAura.FormattingEnabled = true;
            this._cbSpellAura.IntegralHeight = false;
            this._cbSpellAura.Location = new System.Drawing.Point(3, 30);
            this._cbSpellAura.Name = "_cbSpellAura";
            this._cbSpellAura.Size = new System.Drawing.Size(308, 21);
            this._cbSpellAura.TabIndex = 16;
            this._cbSpellAura.SelectedIndexChanged += new System.EventHandler(this._cbSpellFamilyNames_SelectedIndexChanged);
            //
            // _cbSpellFamilyName
            //
            this._cbSpellFamilyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cbSpellFamilyName.DropDownHeight = 500;
            this._cbSpellFamilyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbSpellFamilyName.DropDownWidth = 302;
            this._cbSpellFamilyName.FormattingEnabled = true;
            this._cbSpellFamilyName.IntegralHeight = false;
            this._cbSpellFamilyName.ItemHeight = 13;
            this._cbSpellFamilyName.Location = new System.Drawing.Point(3, 3);
            this._cbSpellFamilyName.Name = "_cbSpellFamilyName";
            this._cbSpellFamilyName.Size = new System.Drawing.Size(308, 21);
            this._cbSpellFamilyName.TabIndex = 15;
            this._cbSpellFamilyName.SelectedIndexChanged += new System.EventHandler(this._cbSpellFamilyNames_SelectedIndexChanged);
            //
            // panel2
            //
            this.panel2.Controls.Add(this._lvSpellList);
            this.panel2.Controls.Add(this._gbAdvansedSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 193);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 544);
            this.panel2.TabIndex = 18;
            //
            // _lvSpellList
            //
            this._lvSpellList.AllowColumnReorder = true;
            this._lvSpellList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSpellID,
            this.chSpellName});
            this._lvSpellList.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lvSpellList.FullRowSelect = true;
            this._lvSpellList.GridLines = true;
            this._lvSpellList.HideSelection = false;
            this._lvSpellList.Location = new System.Drawing.Point(0, 72);
            this._lvSpellList.MultiSelect = false;
            this._lvSpellList.Name = "_lvSpellList";
            this._lvSpellList.Size = new System.Drawing.Size(314, 472);
            this._lvSpellList.TabIndex = 17;
            this._lvSpellList.UseCompatibleStateImageBehavior = false;
            this._lvSpellList.View = System.Windows.Forms.View.Details;
            this._lvSpellList.VirtualMode = true;
            this._lvSpellList.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this._lvSpellList_RetrieveVirtualItem);
            this._lvSpellList.SelectedIndexChanged += new System.EventHandler(this._lvSpellList_SelectedIndexChanged);
            //
            // chSpellID
            //
            this.chSpellID.Text = "ID";
            this.chSpellID.Width = 48;
            //
            // chSpellName
            //
            this.chSpellName.Text = "Name";
            this.chSpellName.Width = 259;
            //
            // _gbAdvansedSearch
            //
            this._gbAdvansedSearch.Controls.Add(this._cbAdvancedFilter2CompareType);
            this._gbAdvansedSearch.Controls.Add(this._cbAdvancedFilter1CompareType);
            this._gbAdvansedSearch.Controls.Add(this._tbAdvancedFilter2Val);
            this._gbAdvansedSearch.Controls.Add(this._tbAdvancedFilter1Val);
            this._gbAdvansedSearch.Controls.Add(this._cbAdvancedFilter2);
            this._gbAdvansedSearch.Controls.Add(this._cbAdvancedFilter1);
            this._gbAdvansedSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this._gbAdvansedSearch.Location = new System.Drawing.Point(0, 0);
            this._gbAdvansedSearch.Name = "_gbAdvansedSearch";
            this._gbAdvansedSearch.Size = new System.Drawing.Size(314, 72);
            this._gbAdvansedSearch.TabIndex = 16;
            this._gbAdvansedSearch.TabStop = false;
            this._gbAdvansedSearch.Text = "Advanced Filter";
            //
            // _cbAdvancedFilter2CompareType
            //
            this._cbAdvancedFilter2CompareType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cbAdvancedFilter2CompareType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbAdvancedFilter2CompareType.DropDownWidth = 160;
            this._cbAdvancedFilter2CompareType.FormattingEnabled = true;
            this._cbAdvancedFilter2CompareType.Location = new System.Drawing.Point(141, 41);
            this._cbAdvancedFilter2CompareType.Name = "_cbAdvancedFilter2CompareType";
            this._cbAdvancedFilter2CompareType.Size = new System.Drawing.Size(76, 21);
            this._cbAdvancedFilter2CompareType.TabIndex = 3;
            //
            // _cbAdvancedFilter1CompareType
            //
            this._cbAdvancedFilter1CompareType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cbAdvancedFilter1CompareType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbAdvancedFilter1CompareType.DropDownWidth = 160;
            this._cbAdvancedFilter1CompareType.FormattingEnabled = true;
            this._cbAdvancedFilter1CompareType.Location = new System.Drawing.Point(141, 15);
            this._cbAdvancedFilter1CompareType.Name = "_cbAdvancedFilter1CompareType";
            this._cbAdvancedFilter1CompareType.Size = new System.Drawing.Size(76, 21);
            this._cbAdvancedFilter1CompareType.TabIndex = 2;
            //
            // _tbAdvancedFilter2Val
            //
            this._tbAdvancedFilter2Val.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._tbAdvancedFilter2Val.Location = new System.Drawing.Point(223, 44);
            this._tbAdvancedFilter2Val.Name = "_tbAdvancedFilter2Val";
            this._tbAdvancedFilter2Val.Size = new System.Drawing.Size(85, 20);
            this._tbAdvancedFilter2Val.TabIndex = 1;
            this._tbAdvancedFilter2Val.Text = "0";
            this._tbAdvancedFilter2Val.KeyDown += new System.Windows.Forms.KeyEventHandler(this._tbAdvansedFilterVal_KeyDown);
            //
            // _tbAdvancedFilter1Val
            //
            this._tbAdvancedFilter1Val.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._tbAdvancedFilter1Val.Location = new System.Drawing.Point(223, 15);
            this._tbAdvancedFilter1Val.Name = "_tbAdvancedFilter1Val";
            this._tbAdvancedFilter1Val.Size = new System.Drawing.Size(85, 20);
            this._tbAdvancedFilter1Val.TabIndex = 1;
            this._tbAdvancedFilter1Val.Text = "0";
            this._tbAdvancedFilter1Val.KeyDown += new System.Windows.Forms.KeyEventHandler(this._tbAdvansedFilterVal_KeyDown);
            //
            // _cbAdvancedFilter2
            //
            this._cbAdvancedFilter2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cbAdvancedFilter2.DropDownHeight = 500;
            this._cbAdvancedFilter2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbAdvancedFilter2.FormattingEnabled = true;
            this._cbAdvancedFilter2.IntegralHeight = false;
            this._cbAdvancedFilter2.Location = new System.Drawing.Point(3, 41);
            this._cbAdvancedFilter2.Name = "_cbAdvancedFilter2";
            this._cbAdvancedFilter2.Size = new System.Drawing.Size(134, 21);
            this._cbAdvancedFilter2.TabIndex = 0;
            //
            // _cbAdvancedFilter1
            //
            this._cbAdvancedFilter1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cbAdvancedFilter1.DropDownHeight = 500;
            this._cbAdvancedFilter1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbAdvancedFilter1.FormattingEnabled = true;
            this._cbAdvancedFilter1.IntegralHeight = false;
            this._cbAdvancedFilter1.Location = new System.Drawing.Point(3, 15);
            this._cbAdvancedFilter1.Name = "_cbAdvancedFilter1";
            this._cbAdvancedFilter1.Size = new System.Drawing.Size(134, 21);
            this._cbAdvancedFilter1.TabIndex = 0;
            //
            // SpellFilter
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox7);
            this.Name = "SpellFilter";
            this.Size = new System.Drawing.Size(314, 737);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this._gbAdvansedSearch.ResumeLayout(false);
            this._gbAdvansedSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button _bSearch;
        private System.Windows.Forms.TextBox _tbSearchAttributes;
        private System.Windows.Forms.TextBox _tbSearchIcon;
        private System.Windows.Forms.TextBox _tbSearchId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox _cbTarget2;
        private System.Windows.Forms.ComboBox _cbTarget1;
        private System.Windows.Forms.ComboBox _cbSpellEffect;
        private System.Windows.Forms.ComboBox _cbSpellAura;
        private System.Windows.Forms.ComboBox _cbSpellFamilyName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView _lvSpellList;
        private System.Windows.Forms.ColumnHeader chSpellID;
        private System.Windows.Forms.ColumnHeader chSpellName;
        private System.Windows.Forms.GroupBox _gbAdvansedSearch;
        private System.Windows.Forms.ComboBox _cbAdvancedFilter2CompareType;
        private System.Windows.Forms.ComboBox _cbAdvancedFilter1CompareType;
        private System.Windows.Forms.TextBox _tbAdvancedFilter2Val;
        private System.Windows.Forms.TextBox _tbAdvancedFilter1Val;
        private System.Windows.Forms.ComboBox _cbAdvancedFilter2;
        private System.Windows.Forms.ComboBox _cbAdvancedFilter1;
    }
}
