namespace AutoClicker {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.optionsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.hotkeySettingMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.alwaysOnTopMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.clickIntervalGroup = new System.Windows.Forms.GroupBox();
            this.msLabel = new System.Windows.Forms.Label();
            this.msNumeric = new System.Windows.Forms.NumericUpDown();
            this.secLabel = new System.Windows.Forms.Label();
            this.secNumeric = new System.Windows.Forms.NumericUpDown();
            this.minLabel = new System.Windows.Forms.Label();
            this.minNumeric = new System.Windows.Forms.NumericUpDown();
            this.hrLabel = new System.Windows.Forms.Label();
            this.hrNumeric = new System.Windows.Forms.NumericUpDown();
            this.clickModesGroup = new System.Windows.Forms.GroupBox();
            this.pickWindowBtn = new System.Windows.Forms.Button();
            this.titleText = new System.Windows.Forms.TextBox();
            this.handleText = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.handleLabel = new System.Windows.Forms.Label();
            this.windowModeRadio = new System.Windows.Forms.RadioButton();
            this.pointerModeRadio = new System.Windows.Forms.RadioButton();
            this.clickOptionsGroup = new System.Windows.Forms.GroupBox();
            this.middleButtonCheck = new System.Windows.Forms.CheckBox();
            this.rightButtonCheck = new System.Windows.Forms.CheckBox();
            this.leftButtonCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clickTypeCombo = new System.Windows.Forms.ComboBox();
            this.clickTypeLabel = new System.Windows.Forms.Label();
            this.clickRepeatGroup = new System.Windows.Forms.GroupBox();
            this.repeatInfRadio = new System.Windows.Forms.RadioButton();
            this.timesLabel = new System.Windows.Forms.Label();
            this.repeatCountNumeric = new System.Windows.Forms.NumericUpDown();
            this.repeatLimitRadio = new System.Windows.Forms.RadioButton();
            this.clickPosGroup = new System.Windows.Forms.GroupBox();
            this.yRandomNumeric = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.xRandomNumeric = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.yNumeric = new System.Windows.Forms.NumericUpDown();
            this.xNumeric = new System.Windows.Forms.NumericUpDown();
            this.yLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.pickPosBtn = new System.Windows.Forms.Button();
            this.customPosRadio = new System.Windows.Forms.RadioButton();
            this.currPosRadio = new System.Windows.Forms.RadioButton();
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.clickTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.randomNumeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.mainMenu.SuspendLayout();
            this.clickIntervalGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrNumeric)).BeginInit();
            this.clickModesGroup.SuspendLayout();
            this.clickOptionsGroup.SuspendLayout();
            this.clickRepeatGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repeatCountNumeric)).BeginInit();
            this.clickPosGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yRandomNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xRandomNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsMenu,
            this.helpMenu});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(778, 32);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "mainMenu";
            // 
            // optionsMenu
            // 
            this.optionsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hotkeySettingMenu,
            this.alwaysOnTopMenu});
            this.optionsMenu.Name = "optionsMenu";
            this.optionsMenu.Size = new System.Drawing.Size(95, 28);
            this.optionsMenu.Text = "Options";
            // 
            // hotkeySettingMenu
            // 
            this.hotkeySettingMenu.Name = "hotkeySettingMenu";
            this.hotkeySettingMenu.Size = new System.Drawing.Size(237, 34);
            this.hotkeySettingMenu.Text = "Hotkey setting";
            this.hotkeySettingMenu.Click += new System.EventHandler(this.hotkeySettingMenu_Click);
            // 
            // alwaysOnTopMenu
            // 
            this.alwaysOnTopMenu.Checked = true;
            this.alwaysOnTopMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.alwaysOnTopMenu.Name = "alwaysOnTopMenu";
            this.alwaysOnTopMenu.Size = new System.Drawing.Size(237, 34);
            this.alwaysOnTopMenu.Text = "Always on top";
            this.alwaysOnTopMenu.Click += new System.EventHandler(this.alwaysOnTopMenu_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenu});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(67, 28);
            this.helpMenu.Text = "Help";
            // 
            // aboutMenu
            // 
            this.aboutMenu.Name = "aboutMenu";
            this.aboutMenu.Size = new System.Drawing.Size(164, 34);
            this.aboutMenu.Text = "About";
            this.aboutMenu.Click += new System.EventHandler(this.aboutMenu_Click);
            // 
            // clickIntervalGroup
            // 
            this.clickIntervalGroup.Controls.Add(this.msLabel);
            this.clickIntervalGroup.Controls.Add(this.msNumeric);
            this.clickIntervalGroup.Controls.Add(this.secLabel);
            this.clickIntervalGroup.Controls.Add(this.secNumeric);
            this.clickIntervalGroup.Controls.Add(this.minLabel);
            this.clickIntervalGroup.Controls.Add(this.minNumeric);
            this.clickIntervalGroup.Controls.Add(this.hrLabel);
            this.clickIntervalGroup.Controls.Add(this.hrNumeric);
            this.clickIntervalGroup.Location = new System.Drawing.Point(18, 37);
            this.clickIntervalGroup.Margin = new System.Windows.Forms.Padding(4);
            this.clickIntervalGroup.Name = "clickIntervalGroup";
            this.clickIntervalGroup.Padding = new System.Windows.Forms.Padding(4);
            this.clickIntervalGroup.Size = new System.Drawing.Size(749, 62);
            this.clickIntervalGroup.TabIndex = 1;
            this.clickIntervalGroup.TabStop = false;
            this.clickIntervalGroup.Text = "Click interval";
            // 
            // msLabel
            // 
            this.msLabel.AutoSize = true;
            this.msLabel.Location = new System.Drawing.Point(490, 29);
            this.msLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.msLabel.Name = "msLabel";
            this.msLabel.Size = new System.Drawing.Size(26, 18);
            this.msLabel.TabIndex = 7;
            this.msLabel.Text = "ms";
            // 
            // msNumeric
            // 
            this.msNumeric.Location = new System.Drawing.Point(400, 26);
            this.msNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.msNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.msNumeric.Name = "msNumeric";
            this.msNumeric.Size = new System.Drawing.Size(81, 28);
            this.msNumeric.TabIndex = 6;
            this.msNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.msNumeric.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // secLabel
            // 
            this.secLabel.AutoSize = true;
            this.secLabel.Location = new System.Drawing.Point(356, 29);
            this.secLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.secLabel.Name = "secLabel";
            this.secLabel.Size = new System.Drawing.Size(35, 18);
            this.secLabel.TabIndex = 5;
            this.secLabel.Text = "sec";
            // 
            // secNumeric
            // 
            this.secNumeric.Location = new System.Drawing.Point(266, 26);
            this.secNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.secNumeric.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.secNumeric.Name = "secNumeric";
            this.secNumeric.Size = new System.Drawing.Size(81, 28);
            this.secNumeric.TabIndex = 4;
            this.secNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(222, 29);
            this.minLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(35, 18);
            this.minLabel.TabIndex = 3;
            this.minLabel.Text = "min";
            // 
            // minNumeric
            // 
            this.minNumeric.Location = new System.Drawing.Point(132, 26);
            this.minNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.minNumeric.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.minNumeric.Name = "minNumeric";
            this.minNumeric.Size = new System.Drawing.Size(81, 28);
            this.minNumeric.TabIndex = 2;
            this.minNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // hrLabel
            // 
            this.hrLabel.AutoSize = true;
            this.hrLabel.Location = new System.Drawing.Point(99, 29);
            this.hrLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hrLabel.Name = "hrLabel";
            this.hrLabel.Size = new System.Drawing.Size(26, 18);
            this.hrLabel.TabIndex = 1;
            this.hrLabel.Text = "hr";
            // 
            // hrNumeric
            // 
            this.hrNumeric.Location = new System.Drawing.Point(9, 26);
            this.hrNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.hrNumeric.Name = "hrNumeric";
            this.hrNumeric.Size = new System.Drawing.Size(81, 28);
            this.hrNumeric.TabIndex = 0;
            this.hrNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // clickModesGroup
            // 
            this.clickModesGroup.Controls.Add(this.pickWindowBtn);
            this.clickModesGroup.Controls.Add(this.titleText);
            this.clickModesGroup.Controls.Add(this.handleText);
            this.clickModesGroup.Controls.Add(this.titleLabel);
            this.clickModesGroup.Controls.Add(this.handleLabel);
            this.clickModesGroup.Controls.Add(this.windowModeRadio);
            this.clickModesGroup.Controls.Add(this.pointerModeRadio);
            this.clickModesGroup.Location = new System.Drawing.Point(18, 108);
            this.clickModesGroup.Margin = new System.Windows.Forms.Padding(4);
            this.clickModesGroup.Name = "clickModesGroup";
            this.clickModesGroup.Padding = new System.Windows.Forms.Padding(4);
            this.clickModesGroup.Size = new System.Drawing.Size(540, 138);
            this.clickModesGroup.TabIndex = 2;
            this.clickModesGroup.TabStop = false;
            this.clickModesGroup.Text = "Click modes";
            // 
            // pickWindowBtn
            // 
            this.pickWindowBtn.Location = new System.Drawing.Point(302, 98);
            this.pickWindowBtn.Margin = new System.Windows.Forms.Padding(4);
            this.pickWindowBtn.Name = "pickWindowBtn";
            this.pickWindowBtn.Size = new System.Drawing.Size(230, 32);
            this.pickWindowBtn.TabIndex = 6;
            this.pickWindowBtn.Text = "Drag && pick window";
            this.pickWindowBtn.UseVisualStyleBackColor = true;
            this.pickWindowBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pickWindowBtn_MouseDown);
            this.pickWindowBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pickWindowBtn_MouseMove);
            this.pickWindowBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pickWindowBtn_MouseUp);
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(372, 62);
            this.titleText.Margin = new System.Windows.Forms.Padding(4);
            this.titleText.Name = "titleText";
            this.titleText.ReadOnly = true;
            this.titleText.Size = new System.Drawing.Size(157, 28);
            this.titleText.TabIndex = 5;
            // 
            // handleText
            // 
            this.handleText.Location = new System.Drawing.Point(372, 26);
            this.handleText.Margin = new System.Windows.Forms.Padding(4);
            this.handleText.Name = "handleText";
            this.handleText.ReadOnly = true;
            this.handleText.Size = new System.Drawing.Size(157, 28);
            this.handleText.TabIndex = 4;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(297, 66);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(62, 18);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Title:";
            // 
            // handleLabel
            // 
            this.handleLabel.AutoSize = true;
            this.handleLabel.Location = new System.Drawing.Point(297, 30);
            this.handleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.handleLabel.Name = "handleLabel";
            this.handleLabel.Size = new System.Drawing.Size(71, 18);
            this.handleLabel.TabIndex = 2;
            this.handleLabel.Text = "Handle:";
            // 
            // windowModeRadio
            // 
            this.windowModeRadio.AutoSize = true;
            this.windowModeRadio.Checked = true;
            this.windowModeRadio.Location = new System.Drawing.Point(148, 66);
            this.windowModeRadio.Margin = new System.Windows.Forms.Padding(4);
            this.windowModeRadio.Name = "windowModeRadio";
            this.windowModeRadio.Size = new System.Drawing.Size(132, 22);
            this.windowModeRadio.TabIndex = 1;
            this.windowModeRadio.TabStop = true;
            this.windowModeRadio.Text = "Window mode";
            this.windowModeRadio.UseVisualStyleBackColor = true;
            // 
            // pointerModeRadio
            // 
            this.pointerModeRadio.AutoSize = true;
            this.pointerModeRadio.Location = new System.Drawing.Point(9, 66);
            this.pointerModeRadio.Margin = new System.Windows.Forms.Padding(4);
            this.pointerModeRadio.Name = "pointerModeRadio";
            this.pointerModeRadio.Size = new System.Drawing.Size(141, 22);
            this.pointerModeRadio.TabIndex = 0;
            this.pointerModeRadio.Text = "Pointer mode";
            this.pointerModeRadio.UseVisualStyleBackColor = true;
            // 
            // clickOptionsGroup
            // 
            this.clickOptionsGroup.Controls.Add(this.middleButtonCheck);
            this.clickOptionsGroup.Controls.Add(this.rightButtonCheck);
            this.clickOptionsGroup.Controls.Add(this.leftButtonCheck);
            this.clickOptionsGroup.Controls.Add(this.label1);
            this.clickOptionsGroup.Controls.Add(this.clickTypeCombo);
            this.clickOptionsGroup.Controls.Add(this.clickTypeLabel);
            this.clickOptionsGroup.Location = new System.Drawing.Point(18, 255);
            this.clickOptionsGroup.Margin = new System.Windows.Forms.Padding(4);
            this.clickOptionsGroup.Name = "clickOptionsGroup";
            this.clickOptionsGroup.Padding = new System.Windows.Forms.Padding(4);
            this.clickOptionsGroup.Size = new System.Drawing.Size(266, 159);
            this.clickOptionsGroup.TabIndex = 3;
            this.clickOptionsGroup.TabStop = false;
            this.clickOptionsGroup.Text = "Click options";
            // 
            // middleButtonCheck
            // 
            this.middleButtonCheck.AutoSize = true;
            this.middleButtonCheck.Location = new System.Drawing.Point(130, 90);
            this.middleButtonCheck.Margin = new System.Windows.Forms.Padding(4);
            this.middleButtonCheck.Name = "middleButtonCheck";
            this.middleButtonCheck.Size = new System.Drawing.Size(88, 22);
            this.middleButtonCheck.TabIndex = 5;
            this.middleButtonCheck.Text = "Middle";
            this.middleButtonCheck.UseVisualStyleBackColor = true;
            this.middleButtonCheck.CheckedChanged += new System.EventHandler(this.middleButtonCheck_CheckedChanged);
            // 
            // rightButtonCheck
            // 
            this.rightButtonCheck.AutoSize = true;
            this.rightButtonCheck.Location = new System.Drawing.Point(130, 58);
            this.rightButtonCheck.Margin = new System.Windows.Forms.Padding(4);
            this.rightButtonCheck.Name = "rightButtonCheck";
            this.rightButtonCheck.Size = new System.Drawing.Size(79, 22);
            this.rightButtonCheck.TabIndex = 4;
            this.rightButtonCheck.Text = "Right";
            this.rightButtonCheck.UseVisualStyleBackColor = true;
            this.rightButtonCheck.CheckedChanged += new System.EventHandler(this.rightButtonCheck_CheckedChanged);
            // 
            // leftButtonCheck
            // 
            this.leftButtonCheck.AutoSize = true;
            this.leftButtonCheck.Checked = true;
            this.leftButtonCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.leftButtonCheck.Location = new System.Drawing.Point(130, 26);
            this.leftButtonCheck.Margin = new System.Windows.Forms.Padding(4);
            this.leftButtonCheck.Name = "leftButtonCheck";
            this.leftButtonCheck.Size = new System.Drawing.Size(70, 22);
            this.leftButtonCheck.TabIndex = 3;
            this.leftButtonCheck.Text = "Left";
            this.leftButtonCheck.UseVisualStyleBackColor = true;
            this.leftButtonCheck.CheckedChanged += new System.EventHandler(this.leftButtonCheck_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mouse button:";
            // 
            // clickTypeCombo
            // 
            this.clickTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clickTypeCombo.FormattingEnabled = true;
            this.clickTypeCombo.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Hold"});
            this.clickTypeCombo.Location = new System.Drawing.Point(130, 122);
            this.clickTypeCombo.Margin = new System.Windows.Forms.Padding(4);
            this.clickTypeCombo.Name = "clickTypeCombo";
            this.clickTypeCombo.Size = new System.Drawing.Size(124, 26);
            this.clickTypeCombo.TabIndex = 1;
            // 
            // clickTypeLabel
            // 
            this.clickTypeLabel.AutoSize = true;
            this.clickTypeLabel.Location = new System.Drawing.Point(9, 126);
            this.clickTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clickTypeLabel.Name = "clickTypeLabel";
            this.clickTypeLabel.Size = new System.Drawing.Size(107, 18);
            this.clickTypeLabel.TabIndex = 0;
            this.clickTypeLabel.Text = "Click type:";
            // 
            // clickRepeatGroup
            // 
            this.clickRepeatGroup.Controls.Add(this.repeatInfRadio);
            this.clickRepeatGroup.Controls.Add(this.timesLabel);
            this.clickRepeatGroup.Controls.Add(this.repeatCountNumeric);
            this.clickRepeatGroup.Controls.Add(this.repeatLimitRadio);
            this.clickRepeatGroup.Location = new System.Drawing.Point(292, 255);
            this.clickRepeatGroup.Margin = new System.Windows.Forms.Padding(4);
            this.clickRepeatGroup.Name = "clickRepeatGroup";
            this.clickRepeatGroup.Padding = new System.Windows.Forms.Padding(4);
            this.clickRepeatGroup.Size = new System.Drawing.Size(266, 159);
            this.clickRepeatGroup.TabIndex = 4;
            this.clickRepeatGroup.TabStop = false;
            this.clickRepeatGroup.Text = "Click repeat";
            // 
            // repeatInfRadio
            // 
            this.repeatInfRadio.AutoSize = true;
            this.repeatInfRadio.Checked = true;
            this.repeatInfRadio.Location = new System.Drawing.Point(9, 93);
            this.repeatInfRadio.Margin = new System.Windows.Forms.Padding(4);
            this.repeatInfRadio.Name = "repeatInfRadio";
            this.repeatInfRadio.Size = new System.Drawing.Size(213, 22);
            this.repeatInfRadio.TabIndex = 3;
            this.repeatInfRadio.TabStop = true;
            this.repeatInfRadio.Text = "Repeat until stopped";
            this.repeatInfRadio.UseVisualStyleBackColor = true;
            // 
            // timesLabel
            // 
            this.timesLabel.AutoSize = true;
            this.timesLabel.Location = new System.Drawing.Point(198, 61);
            this.timesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timesLabel.Name = "timesLabel";
            this.timesLabel.Size = new System.Drawing.Size(53, 18);
            this.timesLabel.TabIndex = 2;
            this.timesLabel.Text = "times";
            // 
            // repeatCountNumeric
            // 
            this.repeatCountNumeric.Location = new System.Drawing.Point(108, 57);
            this.repeatCountNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.repeatCountNumeric.Maximum = new decimal(new int[] {
            32768,
            0,
            0,
            0});
            this.repeatCountNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repeatCountNumeric.Name = "repeatCountNumeric";
            this.repeatCountNumeric.Size = new System.Drawing.Size(81, 28);
            this.repeatCountNumeric.TabIndex = 1;
            this.repeatCountNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // repeatLimitRadio
            // 
            this.repeatLimitRadio.AutoSize = true;
            this.repeatLimitRadio.Location = new System.Drawing.Point(9, 58);
            this.repeatLimitRadio.Margin = new System.Windows.Forms.Padding(4);
            this.repeatLimitRadio.Name = "repeatLimitRadio";
            this.repeatLimitRadio.Size = new System.Drawing.Size(87, 22);
            this.repeatLimitRadio.TabIndex = 0;
            this.repeatLimitRadio.Text = "Repeat";
            this.repeatLimitRadio.UseVisualStyleBackColor = true;
            // 
            // clickPosGroup
            // 
            this.clickPosGroup.Controls.Add(this.yRandomNumeric);
            this.clickPosGroup.Controls.Add(this.label6);
            this.clickPosGroup.Controls.Add(this.label4);
            this.clickPosGroup.Controls.Add(this.xRandomNumeric);
            this.clickPosGroup.Controls.Add(this.label5);
            this.clickPosGroup.Controls.Add(this.yNumeric);
            this.clickPosGroup.Controls.Add(this.xNumeric);
            this.clickPosGroup.Controls.Add(this.yLabel);
            this.clickPosGroup.Controls.Add(this.xLabel);
            this.clickPosGroup.Controls.Add(this.pickPosBtn);
            this.clickPosGroup.Controls.Add(this.customPosRadio);
            this.clickPosGroup.Controls.Add(this.currPosRadio);
            this.clickPosGroup.Location = new System.Drawing.Point(18, 422);
            this.clickPosGroup.Margin = new System.Windows.Forms.Padding(4);
            this.clickPosGroup.Name = "clickPosGroup";
            this.clickPosGroup.Padding = new System.Windows.Forms.Padding(4);
            this.clickPosGroup.Size = new System.Drawing.Size(749, 98);
            this.clickPosGroup.TabIndex = 5;
            this.clickPosGroup.TabStop = false;
            this.clickPosGroup.Text = "Click position";
            // 
            // yRandomNumeric
            // 
            this.yRandomNumeric.Location = new System.Drawing.Point(660, 62);
            this.yRandomNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.yRandomNumeric.Maximum = new decimal(new int[] {
            32768,
            0,
            0,
            0});
            this.yRandomNumeric.Minimum = new decimal(new int[] {
            32768,
            0,
            0,
            -2147483648});
            this.yRandomNumeric.Name = "yRandomNumeric";
            this.yRandomNumeric.Size = new System.Drawing.Size(81, 28);
            this.yRandomNumeric.TabIndex = 11;
            this.yRandomNumeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(634, 65);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Y:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(548, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 42);
            this.label4.TabIndex = 9;
            this.label4.Text = "Random position:";
            // 
            // xRandomNumeric
            // 
            this.xRandomNumeric.Location = new System.Drawing.Point(660, 26);
            this.xRandomNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.xRandomNumeric.Maximum = new decimal(new int[] {
            32768,
            0,
            0,
            0});
            this.xRandomNumeric.Minimum = new decimal(new int[] {
            32768,
            0,
            0,
            -2147483648});
            this.xRandomNumeric.Name = "xRandomNumeric";
            this.xRandomNumeric.Size = new System.Drawing.Size(81, 28);
            this.xRandomNumeric.TabIndex = 8;
            this.xRandomNumeric.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(634, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "X:";
            // 
            // yNumeric
            // 
            this.yNumeric.Location = new System.Drawing.Point(450, 62);
            this.yNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.yNumeric.Maximum = new decimal(new int[] {
            32768,
            0,
            0,
            0});
            this.yNumeric.Minimum = new decimal(new int[] {
            32768,
            0,
            0,
            -2147483648});
            this.yNumeric.Name = "yNumeric";
            this.yNumeric.Size = new System.Drawing.Size(81, 28);
            this.yNumeric.TabIndex = 6;
            // 
            // xNumeric
            // 
            this.xNumeric.Location = new System.Drawing.Point(450, 26);
            this.xNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.xNumeric.Maximum = new decimal(new int[] {
            32768,
            0,
            0,
            0});
            this.xNumeric.Minimum = new decimal(new int[] {
            32768,
            0,
            0,
            -2147483648});
            this.xNumeric.Name = "xNumeric";
            this.xNumeric.Size = new System.Drawing.Size(81, 28);
            this.xNumeric.TabIndex = 5;
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(416, 65);
            this.yLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(26, 18);
            this.yLabel.TabIndex = 4;
            this.yLabel.Text = "Y:";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(416, 29);
            this.xLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(26, 18);
            this.xLabel.TabIndex = 3;
            this.xLabel.Text = "X:";
            // 
            // pickPosBtn
            // 
            this.pickPosBtn.Font = new System.Drawing.Font("宋体", 7F);
            this.pickPosBtn.Location = new System.Drawing.Point(218, 36);
            this.pickPosBtn.Margin = new System.Windows.Forms.Padding(4);
            this.pickPosBtn.Name = "pickPosBtn";
            this.pickPosBtn.Size = new System.Drawing.Size(196, 44);
            this.pickPosBtn.TabIndex = 2;
            this.pickPosBtn.Text = "Drag && pick position";
            this.pickPosBtn.UseVisualStyleBackColor = true;
            this.pickPosBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pickPosBtn_MouseDown);
            this.pickPosBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pickPosBtn_MouseMove);
            this.pickPosBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pickPosBtn_MouseUp);
            // 
            // customPosRadio
            // 
            this.customPosRadio.AutoSize = true;
            this.customPosRadio.Checked = true;
            this.customPosRadio.Location = new System.Drawing.Point(190, 50);
            this.customPosRadio.Margin = new System.Windows.Forms.Padding(4);
            this.customPosRadio.Name = "customPosRadio";
            this.customPosRadio.Size = new System.Drawing.Size(21, 20);
            this.customPosRadio.TabIndex = 1;
            this.customPosRadio.TabStop = true;
            this.customPosRadio.UseVisualStyleBackColor = true;
            // 
            // currPosRadio
            // 
            this.currPosRadio.AutoSize = true;
            this.currPosRadio.Location = new System.Drawing.Point(9, 47);
            this.currPosRadio.Margin = new System.Windows.Forms.Padding(4);
            this.currPosRadio.Name = "currPosRadio";
            this.currPosRadio.Size = new System.Drawing.Size(177, 22);
            this.currPosRadio.TabIndex = 0;
            this.currPosRadio.Text = "Current position";
            this.currPosRadio.UseVisualStyleBackColor = true;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(18, 529);
            this.startBtn.Margin = new System.Windows.Forms.Padding(4);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(266, 64);
            this.startBtn.TabIndex = 6;
            this.startBtn.Text = "Start (F6)";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Enabled = false;
            this.stopBtn.Location = new System.Drawing.Point(292, 529);
            this.stopBtn.Margin = new System.Windows.Forms.Padding(4);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(266, 64);
            this.stopBtn.TabIndex = 7;
            this.stopBtn.Text = "Stop (F6)";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // clickTimer
            // 
            this.clickTimer.Tick += new System.EventHandler(this.clickTimer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(553, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Random:";
            // 
            // randomNumeric
            // 
            this.randomNumeric.Location = new System.Drawing.Point(632, 63);
            this.randomNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.randomNumeric.Maximum = new decimal(new int[] {
            32768,
            0,
            0,
            0});
            this.randomNumeric.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.randomNumeric.Name = "randomNumeric";
            this.randomNumeric.Size = new System.Drawing.Size(81, 28);
            this.randomNumeric.TabIndex = 7;
            this.randomNumeric.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(721, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "ms";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 609);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.randomNumeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.clickPosGroup);
            this.Controls.Add(this.clickRepeatGroup);
            this.Controls.Add(this.clickOptionsGroup);
            this.Controls.Add(this.clickModesGroup);
            this.Controls.Add(this.clickIntervalGroup);
            this.Controls.Add(this.mainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "电击";
            this.TopMost = true;
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.clickIntervalGroup.ResumeLayout(false);
            this.clickIntervalGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrNumeric)).EndInit();
            this.clickModesGroup.ResumeLayout(false);
            this.clickModesGroup.PerformLayout();
            this.clickOptionsGroup.ResumeLayout(false);
            this.clickOptionsGroup.PerformLayout();
            this.clickRepeatGroup.ResumeLayout(false);
            this.clickRepeatGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repeatCountNumeric)).EndInit();
            this.clickPosGroup.ResumeLayout(false);
            this.clickPosGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yRandomNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xRandomNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem optionsMenu;
        private System.Windows.Forms.ToolStripMenuItem hotkeySettingMenu;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutMenu;
        private System.Windows.Forms.GroupBox clickIntervalGroup;
        private System.Windows.Forms.Label msLabel;
        private System.Windows.Forms.NumericUpDown msNumeric;
        private System.Windows.Forms.Label secLabel;
        private System.Windows.Forms.NumericUpDown secNumeric;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.NumericUpDown minNumeric;
        private System.Windows.Forms.Label hrLabel;
        private System.Windows.Forms.NumericUpDown hrNumeric;
        private System.Windows.Forms.GroupBox clickModesGroup;
        private System.Windows.Forms.RadioButton windowModeRadio;
        private System.Windows.Forms.RadioButton pointerModeRadio;
        private System.Windows.Forms.Button pickWindowBtn;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.TextBox handleText;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label handleLabel;
        private System.Windows.Forms.GroupBox clickOptionsGroup;
        private System.Windows.Forms.GroupBox clickRepeatGroup;
        private System.Windows.Forms.ComboBox clickTypeCombo;
        private System.Windows.Forms.Label clickTypeLabel;
        private System.Windows.Forms.CheckBox middleButtonCheck;
        private System.Windows.Forms.CheckBox rightButtonCheck;
        private System.Windows.Forms.CheckBox leftButtonCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton repeatInfRadio;
        private System.Windows.Forms.Label timesLabel;
        private System.Windows.Forms.NumericUpDown repeatCountNumeric;
        private System.Windows.Forms.RadioButton repeatLimitRadio;
        private System.Windows.Forms.GroupBox clickPosGroup;
        private System.Windows.Forms.NumericUpDown xNumeric;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Button pickPosBtn;
        private System.Windows.Forms.RadioButton customPosRadio;
        private System.Windows.Forms.RadioButton currPosRadio;
        private System.Windows.Forms.NumericUpDown yNumeric;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Timer clickTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown randomNumeric;
        private System.Windows.Forms.NumericUpDown xRandomNumeric;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown yRandomNumeric;
        private System.Windows.Forms.Label label6;
    }
}

