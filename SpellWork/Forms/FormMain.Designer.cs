namespace SpellWork
{
    partial class FormMain
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this._dbConnect = new System.Windows.Forms.ToolStripStatusLabel();
            this._status = new System.Windows.Forms.ToolStripStatusLabel();
            this._ProcStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this._tsmFile = new System.Windows.Forms.ToolStripMenuItem();
            this._Connected = new System.Windows.Forms.ToolStripMenuItem();
            this._tsmSettings = new System.Windows.Forms.ToolStripMenuItem();
            this._tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this._tsmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this._tsmAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this._tpSpellInfo = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this._rtSpellInfo = new System.Windows.Forms.RichTextBox();
            this.SpellInfo_spellFilter = new SpellWork.Forms.SpellFilter();
            this._tpSpellProcInfo = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer10 = new System.Windows.Forms.SplitContainer();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this._clbProcFlagEx = new System.Windows.Forms.CheckedListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this._clbProcFlags = new System.Windows.Forms.CheckedListBox();
            this._gSpellProcEvent = new System.Windows.Forms.GroupBox();
            this._clbSchools = new System.Windows.Forms.CheckedListBox();
            this._cbProcFitstSpellFamily = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this._tbPPM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._tbChance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._tbCooldown = new System.Windows.Forms.TextBox();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this._cbProcSpellFamilyTree = new System.Windows.Forms.ComboBox();
            this._tvFamilyTree = new System.Windows.Forms.TreeView();
            this._ilPro = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this._rtbProcSpellInfo = new System.Windows.Forms.RichTextBox();
            this.SpellProc_spellFilter = new SpellWork.Forms.SpellFilter();
            this._lvProcAdditionalInfo = new System.Windows.Forms.ListView();
            this._chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._tpCompare = new System.Windows.Forms.TabPage();
            this._scCompareRoot = new System.Windows.Forms.SplitContainer();
            this._bCompareSearch1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this._tbCompareFilterSpell1 = new System.Windows.Forms.TextBox();
            this._rtbCompareSpell1 = new System.Windows.Forms.RichTextBox();
            this._bCompareSearch2 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this._rtbCompareSpell2 = new System.Windows.Forms.RichTextBox();
            this._tbCompareFilterSpell2 = new System.Windows.Forms.TextBox();
            this._tpSqlData = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._cbBinaryCompare = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this._tbSqlManual = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this._bSqlProcEx = new System.Windows.Forms.Button();
            this._bSqlProc = new System.Windows.Forms.Button();
            this._bSqlSchool = new System.Windows.Forms.Button();
            this._tbSqlProcEx = new System.Windows.Forms.TextBox();
            this._tbSqlProc = new System.Windows.Forms.TextBox();
            this._tbSqlSchool = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this._cbSqlSpellFamily = new System.Windows.Forms.ComboBox();
            this._bSelect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this._lvDataList = new System.Windows.Forms.ListView();
            this.entry = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.spellname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.schoolmask = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.spellfamilyname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.spellfamilymaskA0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.spellfamilymaskA1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.spellfamilymaskA2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.spellfamilymaskB0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.spellfamilymaskB1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.spellfamilymaskB2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.spellfamilymaskC0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.spellfamilymaskC1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.spellfamilymaskC2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.procflag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.procEx = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ppmRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customchance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cooldown = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._rtbSqlLog = new System.Windows.Forms.RichTextBox();
            this._bSqlToBase = new System.Windows.Forms.Button();
            this._bSqlSave = new System.Windows.Forms.Button();
            this._tpSpellDBC = new System.Windows.Forms.TabPage();
            this.splitContainer9 = new System.Windows.Forms.SplitContainer();
            this._scSpellDBC = new System.Windows.Forms.SplitContainer();
            this._rbSpellInfo = new System.Windows.Forms.RichTextBox();
            this._rbDBCSQL = new System.Windows.Forms.RichTextBox();
            this.pg_Spell = new System.Windows.Forms.PropertyGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this._bCreatePatch = new System.Windows.Forms.Button();
            this._bSearchSpell = new System.Windows.Forms.Button();
            this._tbSpellID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbDBfields = new System.Windows.Forms.CheckBox();
            this._bWrite = new System.Windows.Forms.Button();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.splitContainer8 = new System.Windows.Forms.SplitContainer();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this._tpSpellInfo.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this._tpSpellProcInfo.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.splitContainer10.Panel1.SuspendLayout();
            this.splitContainer10.Panel2.SuspendLayout();
            this.splitContainer10.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this._gSpellProcEvent.SuspendLayout();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this._tpCompare.SuspendLayout();
            this._scCompareRoot.Panel1.SuspendLayout();
            this._scCompareRoot.Panel2.SuspendLayout();
            this._scCompareRoot.SuspendLayout();
            this._tpSqlData.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            this._tpSpellDBC.SuspendLayout();
            this.splitContainer9.Panel1.SuspendLayout();
            this.splitContainer9.Panel2.SuspendLayout();
            this.splitContainer9.SuspendLayout();
            this._scSpellDBC.Panel1.SuspendLayout();
            this._scSpellDBC.Panel2.SuspendLayout();
            this._scSpellDBC.SuspendLayout();
            this.panel1.SuspendLayout();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            this.splitContainer8.Panel1.SuspendLayout();
            this.splitContainer8.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._dbConnect,
            this._status,
            this._ProcStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 716);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(959, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // _dbConnect
            // 
            this._dbConnect.Name = "_dbConnect";
            this._dbConnect.Size = new System.Drawing.Size(0, 17);
            // 
            // _status
            // 
            this._status.Name = "_status";
            this._status.Size = new System.Drawing.Size(0, 17);
            // 
            // _ProcStatus
            // 
            this._ProcStatus.Name = "_ProcStatus";
            this._ProcStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tsmFile,
            this._tsmHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(959, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // _tsmFile
            // 
            this._tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._Connected,
            this._tsmSettings,
            this._tsmExit});
            this._tsmFile.Name = "_tsmFile";
            this._tsmFile.Size = new System.Drawing.Size(35, 20);
            this._tsmFile.Text = "File";
            // 
            // _Connected
            // 
            this._Connected.Name = "_Connected";
            this._Connected.Size = new System.Drawing.Size(126, 22);
            this._Connected.Text = "Connected";
            this._Connected.Click += new System.EventHandler(this._Connected_Click);
            // 
            // _tsmSettings
            // 
            this._tsmSettings.Name = "_tsmSettings";
            this._tsmSettings.Size = new System.Drawing.Size(126, 22);
            this._tsmSettings.Text = "Setting";
            this._tsmSettings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // _tsmExit
            // 
            this._tsmExit.Name = "_tsmExit";
            this._tsmExit.Size = new System.Drawing.Size(126, 22);
            this._tsmExit.Text = "Exit";
            this._tsmExit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // _tsmHelp
            // 
            this._tsmHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tsmAbout});
            this._tsmHelp.Name = "_tsmHelp";
            this._tsmHelp.Size = new System.Drawing.Size(40, 20);
            this._tsmHelp.Text = "Help";
            // 
            // _tsmAbout
            // 
            this._tsmAbout.Name = "_tsmAbout";
            this._tsmAbout.Size = new System.Drawing.Size(111, 22);
            this._tsmAbout.Text = "About..";
            this._tsmAbout.Click += new System.EventHandler(this.About_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this._tpSpellInfo);
            this.tabControl1.Controls.Add(this._tpSpellProcInfo);
            this.tabControl1.Controls.Add(this._tpCompare);
            this.tabControl1.Controls.Add(this._tpSqlData);
            this.tabControl1.Controls.Add(this._tpSpellDBC);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(959, 692);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // _tpSpellInfo
            // 
            this._tpSpellInfo.Controls.Add(this.splitContainer1);
            this._tpSpellInfo.Location = new System.Drawing.Point(4, 22);
            this._tpSpellInfo.Name = "_tpSpellInfo";
            this._tpSpellInfo.Padding = new System.Windows.Forms.Padding(3);
            this._tpSpellInfo.Size = new System.Drawing.Size(951, 666);
            this._tpSpellInfo.TabIndex = 0;
            this._tpSpellInfo.Text = "Spell Info";
            this._tpSpellInfo.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._rtSpellInfo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer1.Panel2.Controls.Add(this.SpellInfo_spellFilter);
            this.splitContainer1.Size = new System.Drawing.Size(945, 660);
            this.splitContainer1.SplitterDistance = 630;
            this.splitContainer1.TabIndex = 0;
            // 
            // _rtSpellInfo
            // 
            this._rtSpellInfo.BackColor = System.Drawing.Color.Gainsboro;
            this._rtSpellInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this._rtSpellInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._rtSpellInfo.Location = new System.Drawing.Point(0, 0);
            this._rtSpellInfo.Name = "_rtSpellInfo";
            this._rtSpellInfo.ReadOnly = true;
            this._rtSpellInfo.Size = new System.Drawing.Size(630, 660);
            this._rtSpellInfo.TabIndex = 0;
            this._rtSpellInfo.Text = "";
            // 
            // SpellInfo_spellFilter
            // 
            this.SpellInfo_spellFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpellInfo_spellFilter.Location = new System.Drawing.Point(0, 0);
            this.SpellInfo_spellFilter.Name = "SpellInfo_spellFilter";
            this.SpellInfo_spellFilter.Size = new System.Drawing.Size(311, 660);
            this.SpellInfo_spellFilter.TabIndex = 0;
            this.SpellInfo_spellFilter.OnSpellChange += new System.EventHandler(this.SpellInfo_spellFilter_OnSpellChange);
            // 
            // _tpSpellProcInfo
            // 
            this._tpSpellProcInfo.Controls.Add(this.splitContainer2);
            this._tpSpellProcInfo.Location = new System.Drawing.Point(4, 22);
            this._tpSpellProcInfo.Name = "_tpSpellProcInfo";
            this._tpSpellProcInfo.Size = new System.Drawing.Size(951, 666);
            this._tpSpellProcInfo.TabIndex = 2;
            this._tpSpellProcInfo.Text = "Spell Proc Event";
            this._tpSpellProcInfo.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer2.Panel2.Controls.Add(this._lvProcAdditionalInfo);
            this.splitContainer2.Size = new System.Drawing.Size(951, 666);
            this.splitContainer2.SplitterDistance = 583;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.BackColor = System.Drawing.Color.White;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer10);
            this.splitContainer3.Panel1.Controls.Add(this._gSpellProcEvent);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Size = new System.Drawing.Size(951, 583);
            this.splitContainer3.SplitterDistance = 209;
            this.splitContainer3.TabIndex = 0;
            // 
            // splitContainer10
            // 
            this.splitContainer10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer10.Location = new System.Drawing.Point(0, 63);
            this.splitContainer10.Name = "splitContainer10";
            // 
            // splitContainer10.Panel1
            // 
            this.splitContainer10.Panel1.Controls.Add(this.groupBox4);
            // 
            // splitContainer10.Panel2
            // 
            this.splitContainer10.Panel2.Controls.Add(this.groupBox5);
            this.splitContainer10.Size = new System.Drawing.Size(951, 146);
            this.splitContainer10.SplitterDistance = 341;
            this.splitContainer10.TabIndex = 9;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox4.Controls.Add(this._clbProcFlagEx);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(341, 146);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Spell Proc Ex";
            // 
            // _clbProcFlagEx
            // 
            this._clbProcFlagEx.CheckOnClick = true;
            this._clbProcFlagEx.ColumnWidth = 85;
            this._clbProcFlagEx.Dock = System.Windows.Forms.DockStyle.Fill;
            this._clbProcFlagEx.FormattingEnabled = true;
            this._clbProcFlagEx.Location = new System.Drawing.Point(3, 16);
            this._clbProcFlagEx.MultiColumn = true;
            this._clbProcFlagEx.Name = "_clbProcFlagEx";
            this._clbProcFlagEx.Size = new System.Drawing.Size(335, 127);
            this._clbProcFlagEx.TabIndex = 3;
            this._clbProcFlagEx.SelectedIndexChanged += new System.EventHandler(this._clbSchools_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox5.Controls.Add(this._clbProcFlags);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(606, 146);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Spell Proc Flags";
            // 
            // _clbProcFlags
            // 
            this._clbProcFlags.CheckOnClick = true;
            this._clbProcFlags.ColumnWidth = 140;
            this._clbProcFlags.Dock = System.Windows.Forms.DockStyle.Fill;
            this._clbProcFlags.FormattingEnabled = true;
            this._clbProcFlags.Location = new System.Drawing.Point(3, 16);
            this._clbProcFlags.MultiColumn = true;
            this._clbProcFlags.Name = "_clbProcFlags";
            this._clbProcFlags.Size = new System.Drawing.Size(600, 127);
            this._clbProcFlags.TabIndex = 0;
            this._clbProcFlags.SelectedIndexChanged += new System.EventHandler(this._clbSchools_SelectedIndexChanged);
            // 
            // _gSpellProcEvent
            // 
            this._gSpellProcEvent.BackColor = System.Drawing.Color.WhiteSmoke;
            this._gSpellProcEvent.Controls.Add(this._clbSchools);
            this._gSpellProcEvent.Controls.Add(this._cbProcFitstSpellFamily);
            this._gSpellProcEvent.Controls.Add(this.label1);
            this._gSpellProcEvent.Controls.Add(this._tbPPM);
            this._gSpellProcEvent.Controls.Add(this.label2);
            this._gSpellProcEvent.Controls.Add(this._tbChance);
            this._gSpellProcEvent.Controls.Add(this.label3);
            this._gSpellProcEvent.Controls.Add(this._tbCooldown);
            this._gSpellProcEvent.Dock = System.Windows.Forms.DockStyle.Top;
            this._gSpellProcEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._gSpellProcEvent.Location = new System.Drawing.Point(0, 0);
            this._gSpellProcEvent.Name = "_gSpellProcEvent";
            this._gSpellProcEvent.Size = new System.Drawing.Size(951, 63);
            this._gSpellProcEvent.TabIndex = 8;
            this._gSpellProcEvent.TabStop = false;
            this._gSpellProcEvent.Text = "Spell Proc Event";
            // 
            // _clbSchools
            // 
            this._clbSchools.CheckOnClick = true;
            this._clbSchools.ColumnWidth = 100;
            this._clbSchools.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._clbSchools.FormattingEnabled = true;
            this._clbSchools.Location = new System.Drawing.Point(3, 41);
            this._clbSchools.MultiColumn = true;
            this._clbSchools.Name = "_clbSchools";
            this._clbSchools.Size = new System.Drawing.Size(945, 19);
            this._clbSchools.TabIndex = 5;
            this._clbSchools.SelectedIndexChanged += new System.EventHandler(this._clbSchools_SelectedIndexChanged);
            // 
            // _cbProcFitstSpellFamily
            // 
            this._cbProcFitstSpellFamily.DropDownHeight = 500;
            this._cbProcFitstSpellFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbProcFitstSpellFamily.FormattingEnabled = true;
            this._cbProcFitstSpellFamily.IntegralHeight = false;
            this._cbProcFitstSpellFamily.Location = new System.Drawing.Point(3, 14);
            this._cbProcFitstSpellFamily.Name = "_cbProcFitstSpellFamily";
            this._cbProcFitstSpellFamily.Size = new System.Drawing.Size(342, 21);
            this._cbProcFitstSpellFamily.TabIndex = 4;
            this._cbProcFitstSpellFamily.SelectedIndexChanged += new System.EventHandler(this._clbSchools_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "PPM";
            // 
            // _tbPPM
            // 
            this._tbPPM.Location = new System.Drawing.Point(396, 14);
            this._tbPPM.MaxLength = 10;
            this._tbPPM.Name = "_tbPPM";
            this._tbPPM.Size = new System.Drawing.Size(60, 20);
            this._tbPPM.TabIndex = 7;
            this._tbPPM.TextChanged += new System.EventHandler(this._tbCooldown_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Chance";
            // 
            // _tbChance
            // 
            this._tbChance.Location = new System.Drawing.Point(512, 14);
            this._tbChance.MaxLength = 10;
            this._tbChance.Name = "_tbChance";
            this._tbChance.Size = new System.Drawing.Size(60, 20);
            this._tbChance.TabIndex = 7;
            this._tbChance.TextChanged += new System.EventHandler(this._tbCooldown_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(582, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cooldown";
            // 
            // _tbCooldown
            // 
            this._tbCooldown.Location = new System.Drawing.Point(642, 14);
            this._tbCooldown.MaxLength = 10;
            this._tbCooldown.Name = "_tbCooldown";
            this._tbCooldown.Size = new System.Drawing.Size(60, 20);
            this._tbCooldown.TabIndex = 7;
            this._tbCooldown.TextChanged += new System.EventHandler(this._tbCooldown_TextChanged);
            // 
            // splitContainer4
            // 
            this.splitContainer4.BackColor = System.Drawing.Color.White;
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer4.Panel1.Controls.Add(this._cbProcSpellFamilyTree);
            this.splitContainer4.Panel1.Controls.Add(this._tvFamilyTree);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainer4.Size = new System.Drawing.Size(951, 370);
            this.splitContainer4.SplitterDistance = 260;
            this.splitContainer4.TabIndex = 0;
            // 
            // _cbProcSpellFamilyTree
            // 
            this._cbProcSpellFamilyTree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cbProcSpellFamilyTree.DropDownHeight = 500;
            this._cbProcSpellFamilyTree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbProcSpellFamilyTree.FormattingEnabled = true;
            this._cbProcSpellFamilyTree.IntegralHeight = false;
            this._cbProcSpellFamilyTree.Location = new System.Drawing.Point(1, 2);
            this._cbProcSpellFamilyTree.Name = "_cbProcSpellFamilyTree";
            this._cbProcSpellFamilyTree.Size = new System.Drawing.Size(258, 21);
            this._cbProcSpellFamilyTree.TabIndex = 1;
            this._cbProcSpellFamilyTree.SelectedIndexChanged += new System.EventHandler(this._tvFamilyTree_SelectedIndexChanged);
            // 
            // _tvFamilyTree
            // 
            this._tvFamilyTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tvFamilyTree.CheckBoxes = true;
            this._tvFamilyTree.ImageIndex = 0;
            this._tvFamilyTree.ImageList = this._ilPro;
            this._tvFamilyTree.Location = new System.Drawing.Point(1, 23);
            this._tvFamilyTree.Name = "_tvFamilyTree";
            this._tvFamilyTree.SelectedImageIndex = 0;
            this._tvFamilyTree.ShowNodeToolTips = true;
            this._tvFamilyTree.Size = new System.Drawing.Size(258, 376);
            this._tvFamilyTree.TabIndex = 0;
            this._tvFamilyTree.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.FamilyTree_AfterCheck);
            this._tvFamilyTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this._tvFamilyTree_AfterSelect);
            // 
            // _ilPro
            // 
            this._ilPro.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("_ilPro.ImageStream")));
            this._ilPro.TransparentColor = System.Drawing.Color.Transparent;
            this._ilPro.Images.SetKeyName(0, "info.ico");
            this._ilPro.Images.SetKeyName(1, "ok.ico");
            this._ilPro.Images.SetKeyName(2, "drop.ico");
            this._ilPro.Images.SetKeyName(3, "plus.ico");
            this._ilPro.Images.SetKeyName(4, "family.ico");
            this._ilPro.Images.SetKeyName(5, "munus.ico");
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this._rtbProcSpellInfo);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer5.Panel2.Controls.Add(this.SpellProc_spellFilter);
            this.splitContainer5.Size = new System.Drawing.Size(687, 370);
            this.splitContainer5.SplitterDistance = 417;
            this.splitContainer5.TabIndex = 0;
            // 
            // _rtbProcSpellInfo
            // 
            this._rtbProcSpellInfo.BackColor = System.Drawing.SystemColors.MenuBar;
            this._rtbProcSpellInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this._rtbProcSpellInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this._rtbProcSpellInfo.Location = new System.Drawing.Point(0, 0);
            this._rtbProcSpellInfo.Name = "_rtbProcSpellInfo";
            this._rtbProcSpellInfo.Size = new System.Drawing.Size(417, 370);
            this._rtbProcSpellInfo.TabIndex = 0;
            this._rtbProcSpellInfo.Text = "";
            // 
            // SpellProc_spellFilter
            // 
            this.SpellProc_spellFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpellProc_spellFilter.Location = new System.Drawing.Point(0, 0);
            this.SpellProc_spellFilter.Name = "SpellProc_spellFilter";
            this.SpellProc_spellFilter.Size = new System.Drawing.Size(266, 370);
            this.SpellProc_spellFilter.TabIndex = 0;
            this.SpellProc_spellFilter.OnSpellChange += new System.EventHandler(this.SpellProc_spellFilter_OnSpellChange);
            // 
            // _lvProcAdditionalInfo
            // 
            this._lvProcAdditionalInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._chID,
            this._chName});
            this._lvProcAdditionalInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lvProcAdditionalInfo.FullRowSelect = true;
            this._lvProcAdditionalInfo.GridLines = true;
            this._lvProcAdditionalInfo.Location = new System.Drawing.Point(0, 0);
            this._lvProcAdditionalInfo.Name = "_lvProcAdditionalInfo";
            this._lvProcAdditionalInfo.Size = new System.Drawing.Size(951, 79);
            this._lvProcAdditionalInfo.SmallImageList = this._ilPro;
            this._lvProcAdditionalInfo.TabIndex = 0;
            this._lvProcAdditionalInfo.UseCompatibleStateImageBehavior = false;
            this._lvProcAdditionalInfo.View = System.Windows.Forms.View.Details;
            this._lvProcAdditionalInfo.SelectedIndexChanged += new System.EventHandler(this._lvProcAdditionalInfo_SelectedIndexChanged);
            // 
            // _chID
            // 
            this._chID.Text = "Entry";
            this._chID.Width = 100;
            // 
            // _chName
            // 
            this._chName.Text = "Name";
            this._chName.Width = 685;
            // 
            // _tpCompare
            // 
            this._tpCompare.Controls.Add(this._scCompareRoot);
            this._tpCompare.Location = new System.Drawing.Point(4, 22);
            this._tpCompare.Name = "_tpCompare";
            this._tpCompare.Padding = new System.Windows.Forms.Padding(3);
            this._tpCompare.Size = new System.Drawing.Size(951, 666);
            this._tpCompare.TabIndex = 4;
            this._tpCompare.Text = "Compare Spells";
            this._tpCompare.UseVisualStyleBackColor = true;
            // 
            // _scCompareRoot
            // 
            this._scCompareRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this._scCompareRoot.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this._scCompareRoot.Location = new System.Drawing.Point(3, 3);
            this._scCompareRoot.Name = "_scCompareRoot";
            // 
            // _scCompareRoot.Panel1
            // 
            this._scCompareRoot.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this._scCompareRoot.Panel1.Controls.Add(this._bCompareSearch1);
            this._scCompareRoot.Panel1.Controls.Add(this.label13);
            this._scCompareRoot.Panel1.Controls.Add(this._tbCompareFilterSpell1);
            this._scCompareRoot.Panel1.Controls.Add(this._rtbCompareSpell1);
            // 
            // _scCompareRoot.Panel2
            // 
            this._scCompareRoot.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this._scCompareRoot.Panel2.Controls.Add(this._bCompareSearch2);
            this._scCompareRoot.Panel2.Controls.Add(this.label14);
            this._scCompareRoot.Panel2.Controls.Add(this._rtbCompareSpell2);
            this._scCompareRoot.Panel2.Controls.Add(this._tbCompareFilterSpell2);
            this._scCompareRoot.Size = new System.Drawing.Size(945, 660);
            this._scCompareRoot.SplitterDistance = 426;
            this._scCompareRoot.TabIndex = 0;
            // 
            // _bCompareSearch1
            // 
            this._bCompareSearch1.Location = new System.Drawing.Point(238, 1);
            this._bCompareSearch1.Name = "_bCompareSearch1";
            this._bCompareSearch1.Size = new System.Drawing.Size(51, 23);
            this._bCompareSearch1.TabIndex = 3;
            this._bCompareSearch1.Text = "Search";
            this._bCompareSearch1.UseVisualStyleBackColor = true;
            this._bCompareSearch1.Click += new System.EventHandler(this.CompareSearch1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "ID or Name";
            // 
            // _tbCompareFilterSpell1
            // 
            this._tbCompareFilterSpell1.Location = new System.Drawing.Point(86, 3);
            this._tbCompareFilterSpell1.Name = "_tbCompareFilterSpell1";
            this._tbCompareFilterSpell1.Size = new System.Drawing.Size(146, 20);
            this._tbCompareFilterSpell1.TabIndex = 1;
            this._tbCompareFilterSpell1.TextChanged += new System.EventHandler(this.CompareFilterSpell_TextChanged);
            // 
            // _rtbCompareSpell1
            // 
            this._rtbCompareSpell1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._rtbCompareSpell1.BackColor = System.Drawing.Color.Gainsboro;
            this._rtbCompareSpell1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this._rtbCompareSpell1.Location = new System.Drawing.Point(0, 29);
            this._rtbCompareSpell1.Name = "_rtbCompareSpell1";
            this._rtbCompareSpell1.Size = new System.Drawing.Size(423, 628);
            this._rtbCompareSpell1.TabIndex = 0;
            this._rtbCompareSpell1.Text = "";
            // 
            // _bCompareSearch2
            // 
            this._bCompareSearch2.Location = new System.Drawing.Point(243, 1);
            this._bCompareSearch2.Name = "_bCompareSearch2";
            this._bCompareSearch2.Size = new System.Drawing.Size(51, 23);
            this._bCompareSearch2.TabIndex = 3;
            this._bCompareSearch2.Text = "Search";
            this._bCompareSearch2.UseVisualStyleBackColor = true;
            this._bCompareSearch2.Click += new System.EventHandler(this.CompareSearch2_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "ID or Name";
            // 
            // _rtbCompareSpell2
            // 
            this._rtbCompareSpell2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._rtbCompareSpell2.BackColor = System.Drawing.Color.Gainsboro;
            this._rtbCompareSpell2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this._rtbCompareSpell2.Location = new System.Drawing.Point(3, 29);
            this._rtbCompareSpell2.Name = "_rtbCompareSpell2";
            this._rtbCompareSpell2.Size = new System.Drawing.Size(509, 628);
            this._rtbCompareSpell2.TabIndex = 0;
            this._rtbCompareSpell2.Text = "";
            // 
            // _tbCompareFilterSpell2
            // 
            this._tbCompareFilterSpell2.Location = new System.Drawing.Point(91, 3);
            this._tbCompareFilterSpell2.Name = "_tbCompareFilterSpell2";
            this._tbCompareFilterSpell2.Size = new System.Drawing.Size(146, 20);
            this._tbCompareFilterSpell2.TabIndex = 1;
            this._tbCompareFilterSpell2.TextChanged += new System.EventHandler(this.CompareFilterSpell_TextChanged);
            // 
            // _tpSqlData
            // 
            this._tpSqlData.Controls.Add(this.groupBox3);
            this._tpSqlData.Controls.Add(this.groupBox2);
            this._tpSqlData.Location = new System.Drawing.Point(4, 22);
            this._tpSqlData.Name = "_tpSqlData";
            this._tpSqlData.Size = new System.Drawing.Size(951, 666);
            this._tpSqlData.TabIndex = 3;
            this._tpSqlData.Text = "Sql Data";
            this._tpSqlData.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Controls.Add(this._cbBinaryCompare);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this._tbSqlManual);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this._bSqlProcEx);
            this.groupBox3.Controls.Add(this._bSqlProc);
            this.groupBox3.Controls.Add(this._bSqlSchool);
            this.groupBox3.Controls.Add(this._tbSqlProcEx);
            this.groupBox3.Controls.Add(this._tbSqlProc);
            this.groupBox3.Controls.Add(this._tbSqlSchool);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this._cbSqlSpellFamily);
            this.groupBox3.Controls.Add(this._bSelect);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(951, 85);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filter";
            // 
            // _cbBinaryCompare
            // 
            this._cbBinaryCompare.AutoSize = true;
            this._cbBinaryCompare.Location = new System.Drawing.Point(752, 55);
            this._cbBinaryCompare.Name = "_cbBinaryCompare";
            this._cbBinaryCompare.Size = new System.Drawing.Size(100, 17);
            this._cbBinaryCompare.TabIndex = 8;
            this._cbBinaryCompare.Text = "Binary Compare";
            this._cbBinaryCompare.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Manual:";
            // 
            // _tbSqlManual
            // 
            this._tbSqlManual.Location = new System.Drawing.Point(81, 53);
            this._tbSqlManual.Name = "_tbSqlManual";
            this._tbSqlManual.Size = new System.Drawing.Size(272, 20);
            this._tbSqlManual.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Family Name:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(571, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Proc Ex:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(376, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Proc:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(571, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "School:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(376, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Spell ID:";
            // 
            // _bSqlProcEx
            // 
            this._bSqlProcEx.Location = new System.Drawing.Point(718, 51);
            this._bSqlProcEx.Name = "_bSqlProcEx";
            this._bSqlProcEx.Size = new System.Drawing.Size(28, 23);
            this._bSqlProcEx.TabIndex = 4;
            this._bSqlProcEx.Text = "...";
            this._bSqlProcEx.UseVisualStyleBackColor = true;
            this._bSqlProcEx.Click += new System.EventHandler(this.CalcProcFlags_Click);
            // 
            // _bSqlProc
            // 
            this._bSqlProc.Location = new System.Drawing.Point(535, 51);
            this._bSqlProc.Name = "_bSqlProc";
            this._bSqlProc.Size = new System.Drawing.Size(28, 23);
            this._bSqlProc.TabIndex = 4;
            this._bSqlProc.Text = "...";
            this._bSqlProc.UseVisualStyleBackColor = true;
            this._bSqlProc.Click += new System.EventHandler(this.CalcProcFlags_Click);
            // 
            // _bSqlSchool
            // 
            this._bSqlSchool.Location = new System.Drawing.Point(718, 15);
            this._bSqlSchool.Name = "_bSqlSchool";
            this._bSqlSchool.Size = new System.Drawing.Size(28, 23);
            this._bSqlSchool.TabIndex = 4;
            this._bSqlSchool.Text = "...";
            this._bSqlSchool.UseVisualStyleBackColor = true;
            this._bSqlSchool.Click += new System.EventHandler(this.CalcProcFlags_Click);
            // 
            // _tbSqlProcEx
            // 
            this._tbSqlProcEx.Location = new System.Drawing.Point(620, 53);
            this._tbSqlProcEx.Name = "_tbSqlProcEx";
            this._tbSqlProcEx.Size = new System.Drawing.Size(92, 20);
            this._tbSqlProcEx.TabIndex = 3;
            // 
            // _tbSqlProc
            // 
            this._tbSqlProc.Location = new System.Drawing.Point(429, 53);
            this._tbSqlProc.Name = "_tbSqlProc";
            this._tbSqlProc.Size = new System.Drawing.Size(100, 20);
            this._tbSqlProc.TabIndex = 3;
            // 
            // _tbSqlSchool
            // 
            this._tbSqlSchool.Location = new System.Drawing.Point(620, 17);
            this._tbSqlSchool.Name = "_tbSqlSchool";
            this._tbSqlSchool.Size = new System.Drawing.Size(92, 20);
            this._tbSqlSchool.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(429, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // _cbSqlSpellFamily
            // 
            this._cbSqlSpellFamily.DropDownHeight = 500;
            this._cbSqlSpellFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbSqlSpellFamily.FormattingEnabled = true;
            this._cbSqlSpellFamily.IntegralHeight = false;
            this._cbSqlSpellFamily.Location = new System.Drawing.Point(81, 17);
            this._cbSqlSpellFamily.Name = "_cbSqlSpellFamily";
            this._cbSqlSpellFamily.Size = new System.Drawing.Size(272, 21);
            this._cbSqlSpellFamily.TabIndex = 1;
            // 
            // _bSelect
            // 
            this._bSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._bSelect.Location = new System.Drawing.Point(871, 10);
            this._bSelect.Name = "_bSelect";
            this._bSelect.Size = new System.Drawing.Size(75, 23);
            this._bSelect.TabIndex = 0;
            this._bSelect.Text = "Select";
            this._bSelect.UseVisualStyleBackColor = true;
            this._bSelect.Click += new System.EventHandler(this.Select_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.splitContainer6);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(951, 666);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Spell Proc Event   (Select item and press Enter or Mouse double click)";
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.Location = new System.Drawing.Point(3, 16);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this._lvDataList);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer6.Panel2.Controls.Add(this._rtbSqlLog);
            this.splitContainer6.Panel2.Controls.Add(this._bSqlToBase);
            this.splitContainer6.Panel2.Controls.Add(this._bSqlSave);
            this.splitContainer6.Size = new System.Drawing.Size(945, 647);
            this.splitContainer6.SplitterDistance = 333;
            this.splitContainer6.TabIndex = 0;
            // 
            // _lvDataList
            // 
            this._lvDataList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.entry,
            this.spellname,
            this.schoolmask,
            this.spellfamilyname,
            this.spellfamilymaskA0,
            this.spellfamilymaskA1,
            this.spellfamilymaskA2,
            this.spellfamilymaskB0,
            this.spellfamilymaskB1,
            this.spellfamilymaskB2,
            this.spellfamilymaskC0,
            this.spellfamilymaskC1,
            this.spellfamilymaskC2,
            this.procflag,
            this.procEx,
            this.ppmRate,
            this.customchance,
            this.cooldown});
            this._lvDataList.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lvDataList.FullRowSelect = true;
            this._lvDataList.GridLines = true;
            this._lvDataList.HideSelection = false;
            this._lvDataList.Location = new System.Drawing.Point(0, 0);
            this._lvDataList.MultiSelect = false;
            this._lvDataList.Name = "_lvDataList";
            this._lvDataList.Size = new System.Drawing.Size(945, 333);
            this._lvDataList.TabIndex = 0;
            this._lvDataList.UseCompatibleStateImageBehavior = false;
            this._lvDataList.View = System.Windows.Forms.View.Details;
            this._lvDataList.VirtualMode = true;
            this._lvDataList.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this._lvSqlData_RetrieveVirtualItem);
            this._lvDataList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Sql_DataList_KeyDown);
            this._lvDataList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Sql_DataList_MouseDoubleClick);
            // 
            // entry
            // 
            this.entry.Text = "Entry";
            this.entry.Width = 56;
            // 
            // spellname
            // 
            this.spellname.Text = "Spell Name";
            this.spellname.Width = 300;
            // 
            // schoolmask
            // 
            this.schoolmask.Text = "School Mask";
            this.schoolmask.Width = 78;
            // 
            // spellfamilyname
            // 
            this.spellfamilyname.Text = "Spell Family Name";
            this.spellfamilyname.Width = 103;
            // 
            // spellfamilymaskA0
            // 
            this.spellfamilymaskA0.Text = "Spell Family Mask A 0";
            this.spellfamilymaskA0.Width = 120;
            // 
            // spellfamilymaskA1
            // 
            this.spellfamilymaskA1.Text = "Spell Family Mask A 1";
            this.spellfamilymaskA1.Width = 120;
            // 
            // spellfamilymaskA2
            // 
            this.spellfamilymaskA2.Text = "Spell Family Mask A 2";
            this.spellfamilymaskA2.Width = 120;
            // 
            // spellfamilymaskB0
            // 
            this.spellfamilymaskB0.Text = "Spell Family Mask B 0";
            this.spellfamilymaskB0.Width = 120;
            // 
            // spellfamilymaskB1
            // 
            this.spellfamilymaskB1.Text = "Spell Family Mask B 1";
            this.spellfamilymaskB1.Width = 120;
            // 
            // spellfamilymaskB2
            // 
            this.spellfamilymaskB2.Text = "Spell Family Mask B 2";
            this.spellfamilymaskB2.Width = 120;
            // 
            // spellfamilymaskC0
            // 
            this.spellfamilymaskC0.Text = "Spell Family Mask C 0";
            this.spellfamilymaskC0.Width = 120;
            // 
            // spellfamilymaskC1
            // 
            this.spellfamilymaskC1.Text = "Spell Family Mask C 1";
            this.spellfamilymaskC1.Width = 120;
            // 
            // spellfamilymaskC2
            // 
            this.spellfamilymaskC2.Text = "Spell Family Mask C 2";
            this.spellfamilymaskC2.Width = 120;
            // 
            // procflag
            // 
            this.procflag.Text = "Proc Flags";
            this.procflag.Width = 80;
            // 
            // procEx
            // 
            this.procEx.Text = "Proc Ex";
            this.procEx.Width = 80;
            // 
            // ppmRate
            // 
            this.ppmRate.Text = "PPM Rate";
            this.ppmRate.Width = 67;
            // 
            // customchance
            // 
            this.customchance.Text = "Custom Chance";
            this.customchance.Width = 93;
            // 
            // cooldown
            // 
            this.cooldown.Text = "Colldown";
            // 
            // _rtbSqlLog
            // 
            this._rtbSqlLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._rtbSqlLog.Location = new System.Drawing.Point(0, 32);
            this._rtbSqlLog.Name = "_rtbSqlLog";
            this._rtbSqlLog.Size = new System.Drawing.Size(945, 281);
            this._rtbSqlLog.TabIndex = 3;
            this._rtbSqlLog.Text = "";
            // 
            // _bSqlToBase
            // 
            this._bSqlToBase.Location = new System.Drawing.Point(84, 3);
            this._bSqlToBase.Name = "_bSqlToBase";
            this._bSqlToBase.Size = new System.Drawing.Size(75, 23);
            this._bSqlToBase.TabIndex = 2;
            this._bSqlToBase.Text = "To DB";
            this._bSqlToBase.UseVisualStyleBackColor = true;
            this._bSqlToBase.Click += new System.EventHandler(this.SqlToBase_Click);
            // 
            // _bSqlSave
            // 
            this._bSqlSave.Location = new System.Drawing.Point(3, 3);
            this._bSqlSave.Name = "_bSqlSave";
            this._bSqlSave.Size = new System.Drawing.Size(75, 23);
            this._bSqlSave.TabIndex = 1;
            this._bSqlSave.Text = "Save";
            this._bSqlSave.UseVisualStyleBackColor = true;
            this._bSqlSave.Click += new System.EventHandler(this.SqlSave_Click);
            // 
            // _tpSpellDBC
            // 
            this._tpSpellDBC.Controls.Add(this.splitContainer9);
            this._tpSpellDBC.Location = new System.Drawing.Point(4, 22);
            this._tpSpellDBC.Name = "_tpSpellDBC";
            this._tpSpellDBC.Padding = new System.Windows.Forms.Padding(3);
            this._tpSpellDBC.Size = new System.Drawing.Size(951, 666);
            this._tpSpellDBC.TabIndex = 5;
            this._tpSpellDBC.Text = "SpellDBC";
            this._tpSpellDBC.UseVisualStyleBackColor = true;
            // 
            // splitContainer9
            // 
            this.splitContainer9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer9.Location = new System.Drawing.Point(3, 3);
            this.splitContainer9.Name = "splitContainer9";
            // 
            // splitContainer9.Panel1
            // 
            this.splitContainer9.Panel1.Controls.Add(this._scSpellDBC);
            // 
            // splitContainer9.Panel2
            // 
            this.splitContainer9.Panel2.Controls.Add(this.pg_Spell);
            this.splitContainer9.Panel2.Controls.Add(this.panel1);
            this.splitContainer9.Size = new System.Drawing.Size(945, 660);
            this.splitContainer9.SplitterDistance = 573;
            this.splitContainer9.TabIndex = 0;
            // 
            // _scSpellDBC
            // 
            this._scSpellDBC.Dock = System.Windows.Forms.DockStyle.Fill;
            this._scSpellDBC.Location = new System.Drawing.Point(0, 0);
            this._scSpellDBC.Name = "_scSpellDBC";
            this._scSpellDBC.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // _scSpellDBC.Panel1
            // 
            this._scSpellDBC.Panel1.Controls.Add(this._rbSpellInfo);
            // 
            // _scSpellDBC.Panel2
            // 
            this._scSpellDBC.Panel2.Controls.Add(this._rbDBCSQL);
            this._scSpellDBC.Size = new System.Drawing.Size(573, 660);
            this._scSpellDBC.SplitterDistance = 554;
            this._scSpellDBC.TabIndex = 1;
            // 
            // _rbSpellInfo
            // 
            this._rbSpellInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this._rbSpellInfo.Location = new System.Drawing.Point(0, 0);
            this._rbSpellInfo.Name = "_rbSpellInfo";
            this._rbSpellInfo.ReadOnly = true;
            this._rbSpellInfo.Size = new System.Drawing.Size(573, 554);
            this._rbSpellInfo.TabIndex = 1;
            this._rbSpellInfo.Text = "";
            // 
            // _rbDBCSQL
            // 
            this._rbDBCSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this._rbDBCSQL.Location = new System.Drawing.Point(0, 0);
            this._rbDBCSQL.Name = "_rbDBCSQL";
            this._rbDBCSQL.Size = new System.Drawing.Size(573, 102);
            this._rbDBCSQL.TabIndex = 0;
            this._rbDBCSQL.Text = "";
            // 
            // pg_Spell
            // 
            this.pg_Spell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pg_Spell.Location = new System.Drawing.Point(0, 100);
            this.pg_Spell.Name = "pg_Spell";
            this.pg_Spell.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            this.pg_Spell.Size = new System.Drawing.Size(368, 560);
            this.pg_Spell.TabIndex = 1;
            this.pg_Spell.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.pg_Spell_PropertyValueChanged);
            this.pg_Spell.SelectedObjectsChanged += new System.EventHandler(this.pg_Spell_SelectedObjectsChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._bCreatePatch);
            this.panel1.Controls.Add(this._bSearchSpell);
            this.panel1.Controls.Add(this._tbSpellID);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.cbDBfields);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 100);
            this.panel1.TabIndex = 0;
            // 
            // _bCreatePatch
            // 
            this._bCreatePatch.Location = new System.Drawing.Point(6, 52);
            this._bCreatePatch.Name = "_bCreatePatch";
            this._bCreatePatch.Size = new System.Drawing.Size(75, 23);
            this._bCreatePatch.TabIndex = 3;
            this._bCreatePatch.Text = "Create SQL";
            this._bCreatePatch.UseVisualStyleBackColor = true;
            this._bCreatePatch.Click += new System.EventHandler(this._bCreatePatch_Click);
            // 
            // _bSearchSpell
            // 
            this._bSearchSpell.Location = new System.Drawing.Point(196, 3);
            this._bSearchSpell.Name = "_bSearchSpell";
            this._bSearchSpell.Size = new System.Drawing.Size(103, 28);
            this._bSearchSpell.TabIndex = 2;
            this._bSearchSpell.Text = "Search";
            this._bSearchSpell.UseVisualStyleBackColor = true;
            this._bSearchSpell.Click += new System.EventHandler(this._bSearchSpell_Click);
            // 
            // _tbSpellID
            // 
            this._tbSpellID.Location = new System.Drawing.Point(27, 3);
            this._tbSpellID.Name = "_tbSpellID";
            this._tbSpellID.Size = new System.Drawing.Size(146, 20);
            this._tbSpellID.TabIndex = 1;
            this._tbSpellID.TextChanged += new System.EventHandler(this._tbSpellID_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "ID";
            // 
            // cbDBfields
            // 
            this.cbDBfields.AutoSize = true;
            this.cbDBfields.Location = new System.Drawing.Point(106, 56);
            this.cbDBfields.Name = "cbDBfields";
            this.cbDBfields.Size = new System.Drawing.Size(122, 17);
            this.cbDBfields.TabIndex = 4;
            this.cbDBfields.Text = "Only spell_dbc fields";
            this.cbDBfields.UseVisualStyleBackColor = true;
            this.cbDBfields.CheckedChanged += new System.EventHandler(this.cbDBfields_CheckedChanged);
            // 
            // _bWrite
            // 
            this._bWrite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._bWrite.Enabled = false;
            this._bWrite.Location = new System.Drawing.Point(815, 1);
            this._bWrite.Name = "_bWrite";
            this._bWrite.Size = new System.Drawing.Size(75, 23);
            this._bWrite.TabIndex = 3;
            this._bWrite.Text = "Write";
            this._bWrite.UseVisualStyleBackColor = true;
            this._bWrite.Visible = false;
            this._bWrite.Click += new System.EventHandler(this.Write_Click);
            // 
            // splitContainer7
            // 
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.Location = new System.Drawing.Point(0, 0);
            this.splitContainer7.Name = "splitContainer7";
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.splitContainer8);
            this.splitContainer7.Panel1.Controls.Add(this.richTextBox1);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.richTextBox2);
            this.splitContainer7.Size = new System.Drawing.Size(858, 429);
            this.splitContainer7.SplitterDistance = 424;
            this.splitContainer7.TabIndex = 0;
            // 
            // splitContainer8
            // 
            this.splitContainer8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer8.Location = new System.Drawing.Point(0, 0);
            this.splitContainer8.Name = "splitContainer8";
            // 
            // splitContainer8.Panel1
            // 
            this.splitContainer8.Panel1.Controls.Add(this.textBox2);
            this.splitContainer8.Size = new System.Drawing.Size(424, 429);
            this.splitContainer8.SplitterDistance = 209;
            this.splitContainer8.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(19, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(424, 429);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Location = new System.Drawing.Point(0, 0);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(430, 429);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 738);
            this.Controls.Add(this._bWrite);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(880, 585);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this._tpSpellInfo.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this._tpSpellProcInfo.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer10.Panel1.ResumeLayout(false);
            this.splitContainer10.Panel2.ResumeLayout(false);
            this.splitContainer10.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this._gSpellProcEvent.ResumeLayout(false);
            this._gSpellProcEvent.PerformLayout();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            this.splitContainer5.ResumeLayout(false);
            this._tpCompare.ResumeLayout(false);
            this._scCompareRoot.Panel1.ResumeLayout(false);
            this._scCompareRoot.Panel1.PerformLayout();
            this._scCompareRoot.Panel2.ResumeLayout(false);
            this._scCompareRoot.Panel2.PerformLayout();
            this._scCompareRoot.ResumeLayout(false);
            this._tpSqlData.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            this.splitContainer6.ResumeLayout(false);
            this._tpSpellDBC.ResumeLayout(false);
            this.splitContainer9.Panel1.ResumeLayout(false);
            this.splitContainer9.Panel2.ResumeLayout(false);
            this.splitContainer9.ResumeLayout(false);
            this._scSpellDBC.Panel1.ResumeLayout(false);
            this._scSpellDBC.Panel2.ResumeLayout(false);
            this._scSpellDBC.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel2.ResumeLayout(false);
            this.splitContainer7.ResumeLayout(false);
            this.splitContainer8.Panel1.ResumeLayout(false);
            this.splitContainer8.Panel1.PerformLayout();
            this.splitContainer8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage _tpSpellInfo;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox _rtSpellInfo;
        private System.Windows.Forms.TabPage _tpSpellProcInfo;
        private System.Windows.Forms.TabPage _tpSqlData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.ListView _lvProcAdditionalInfo;
        private System.Windows.Forms.TreeView _tvFamilyTree;
        private System.Windows.Forms.ComboBox _cbProcSpellFamilyTree;
        private System.Windows.Forms.RichTextBox _rtbProcSpellInfo;
        private System.Windows.Forms.ColumnHeader _chID;
        private System.Windows.Forms.ColumnHeader _chName;
        private System.Windows.Forms.ToolStripStatusLabel _status;
        private System.Windows.Forms.CheckedListBox _clbProcFlags;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.ListView _lvDataList;
        private System.Windows.Forms.ToolStripMenuItem _tsmFile;
        private System.Windows.Forms.ToolStripMenuItem _tsmExit;
        private System.Windows.Forms.ToolStripMenuItem _tsmHelp;
        private System.Windows.Forms.ToolStripMenuItem _tsmAbout;
        private System.Windows.Forms.ToolStripMenuItem _tsmSettings;
        private System.Windows.Forms.CheckedListBox _clbProcFlagEx;
        private System.Windows.Forms.CheckedListBox _clbSchools;
        private System.Windows.Forms.ComboBox _cbProcFitstSpellFamily;
        private System.Windows.Forms.ToolStripStatusLabel _ProcStatus;
        private System.Windows.Forms.TextBox _tbCooldown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _tbChance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _tbPPM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _bWrite;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox _gSpellProcEvent;
        private System.Windows.Forms.ColumnHeader entry;
        private System.Windows.Forms.ColumnHeader schoolmask;
        private System.Windows.Forms.ColumnHeader spellfamilyname;
        private System.Windows.Forms.ColumnHeader spellfamilymaskA0;
        private System.Windows.Forms.ColumnHeader spellfamilymaskA1;
        private System.Windows.Forms.ColumnHeader spellfamilymaskA2;
        private System.Windows.Forms.ColumnHeader procflag;
        private System.Windows.Forms.ColumnHeader procEx;
        private System.Windows.Forms.ColumnHeader ppmRate;
        private System.Windows.Forms.ColumnHeader customchance;
        private System.Windows.Forms.ColumnHeader cooldown;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ColumnHeader spellname;
        private System.Windows.Forms.Button _bSqlToBase;
        private System.Windows.Forms.Button _bSqlSave;
        private System.Windows.Forms.Button _bSelect;
        private System.Windows.Forms.ToolStripMenuItem _Connected;
        private System.Windows.Forms.ToolStripStatusLabel _dbConnect;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox _cbSqlSpellFamily;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button _bSqlProcEx;
        private System.Windows.Forms.Button _bSqlProc;
        private System.Windows.Forms.Button _bSqlSchool;
        private System.Windows.Forms.TextBox _tbSqlProcEx;
        private System.Windows.Forms.TextBox _tbSqlProc;
        private System.Windows.Forms.TextBox _tbSqlSchool;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox _tbSqlManual;
        private System.Windows.Forms.CheckBox _cbBinaryCompare;
        private System.Windows.Forms.TabPage _tpCompare;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.SplitContainer splitContainer8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.SplitContainer _scCompareRoot;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox _tbCompareFilterSpell1;
        private System.Windows.Forms.RichTextBox _rtbCompareSpell1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox _rtbCompareSpell2;
        private System.Windows.Forms.TextBox _tbCompareFilterSpell2;
        private System.Windows.Forms.Button _bCompareSearch1;
        private System.Windows.Forms.Button _bCompareSearch2;
        private System.Windows.Forms.RichTextBox _rtbSqlLog;
        private System.Windows.Forms.ImageList _ilPro;
        private System.Windows.Forms.ColumnHeader spellfamilymaskB0;
        private System.Windows.Forms.ColumnHeader spellfamilymaskB1;
        private System.Windows.Forms.ColumnHeader spellfamilymaskB2;
        private System.Windows.Forms.ColumnHeader spellfamilymaskC0;
        private System.Windows.Forms.ColumnHeader spellfamilymaskC1;
        private System.Windows.Forms.ColumnHeader spellfamilymaskC2;
        private System.Windows.Forms.TabPage _tpSpellDBC;
        private System.Windows.Forms.SplitContainer splitContainer9;
        private System.Windows.Forms.SplitContainer _scSpellDBC;
        private System.Windows.Forms.RichTextBox _rbSpellInfo;
        private System.Windows.Forms.RichTextBox _rbDBCSQL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox _tbSpellID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button _bSearchSpell;
        private System.Windows.Forms.PropertyGrid pg_Spell;
        private System.Windows.Forms.Button _bCreatePatch;
        private System.Windows.Forms.CheckBox cbDBfields;
        private Forms.SpellFilter SpellInfo_spellFilter;
        private Forms.SpellFilter SpellProc_spellFilter;
        private System.Windows.Forms.SplitContainer splitContainer10;
    }
}