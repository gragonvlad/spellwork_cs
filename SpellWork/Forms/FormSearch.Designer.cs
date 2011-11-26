namespace SpellWork
{
    partial class FormSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearch));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this._rtbSpellInfo = new System.Windows.Forms.RichTextBox();
            this.spellFilter = new SpellWork.Forms.SpellFilter();
            this.panel1 = new System.Windows.Forms.Panel();
            this._bOk = new System.Windows.Forms.Button();
            this._bCancel = new System.Windows.Forms.Button();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            //
            // splitContainer1
            //
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            //
            // splitContainer1.Panel1
            //
            this.splitContainer1.Panel1.Controls.Add(this._rtbSpellInfo);
            //
            // splitContainer1.Panel2
            //
            this.splitContainer1.Panel2.Controls.Add(this.spellFilter);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(672, 455);
            this.splitContainer1.SplitterDistance = 353;
            this.splitContainer1.TabIndex = 0;
            //
            // _rtbSpellInfo
            //
            this._rtbSpellInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this._rtbSpellInfo.Location = new System.Drawing.Point(0, 0);
            this._rtbSpellInfo.Name = "_rtbSpellInfo";
            this._rtbSpellInfo.Size = new System.Drawing.Size(353, 455);
            this._rtbSpellInfo.TabIndex = 11;
            this._rtbSpellInfo.Text = "";
            //
            // spellFilter
            //
            this.spellFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spellFilter.Location = new System.Drawing.Point(0, 0);
            this.spellFilter.Name = "spellFilter";
            this.spellFilter.Size = new System.Drawing.Size(315, 418);
            this.spellFilter.TabIndex = 13;
            this.spellFilter.OnSpellChange += new System.EventHandler(this.spellFilter1_OnSpellChange);
            //
            // panel1
            //
            this.panel1.Controls.Add(this._bOk);
            this.panel1.Controls.Add(this._bCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 418);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 37);
            this.panel1.TabIndex = 11;
            //
            // _bOk
            //
            this._bOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._bOk.Location = new System.Drawing.Point(173, 6);
            this._bOk.Name = "_bOk";
            this._bOk.Size = new System.Drawing.Size(75, 23);
            this._bOk.TabIndex = 11;
            this._bOk.Text = "OK";
            this._bOk.UseVisualStyleBackColor = true;
            this._bOk.Click += new System.EventHandler(this.Ok_Click);
            //
            // _bCancel
            //
            this._bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._bCancel.Location = new System.Drawing.Point(66, 6);
            this._bCancel.Name = "_bCancel";
            this._bCancel.Size = new System.Drawing.Size(75, 23);
            this._bCancel.TabIndex = 12;
            this._bCancel.Text = "Cancel";
            this._bCancel.UseVisualStyleBackColor = true;
            this._bCancel.Click += new System.EventHandler(this.Cancel_Click);
            //
            // FormSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 455);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSearch";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Spell Search";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox _rtbSpellInfo;
        private Forms.SpellFilter spellFilter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button _bOk;
        private System.Windows.Forms.Button _bCancel;
    }
}