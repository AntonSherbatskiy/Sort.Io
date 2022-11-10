namespace Sort.Io
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.fibonacciButton = new System.Windows.Forms.RadioButton();
            this.tokudaButton = new System.Windows.Forms.RadioButton();
            this.sedgwickButton = new System.Windows.Forms.RadioButton();
            this.shellButton = new System.Windows.Forms.RadioButton();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.sizeBox = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.informationPanel = new System.Windows.Forms.GroupBox();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.complexityBox = new System.Windows.Forms.TextBox();
            this.swapsBox = new System.Windows.Forms.TextBox();
            this.comparisonsBox = new System.Windows.Forms.TextBox();
            this.comparisonsLabel = new System.Windows.Forms.Label();
            this.swapsLabel = new System.Windows.Forms.Label();
            this.complexityLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.sortChoose = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reverseCheckBox = new System.Windows.Forms.CheckBox();
            this.delayLabel = new System.Windows.Forms.Label();
            this.delayUpDown = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loggerToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizationModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizationModeComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.arrayAutosaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrayAutoSaveComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.arrayPanel = new System.Windows.Forms.PictureBox();
            this.informationPanel.SuspendLayout();
            this.sortChoose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayUpDown)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arrayPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // fibonacciButton
            // 
            this.fibonacciButton.AutoSize = true;
            this.fibonacciButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fibonacciButton.ForeColor = System.Drawing.Color.Black;
            this.fibonacciButton.Location = new System.Drawing.Point(11, 268);
            this.fibonacciButton.Name = "fibonacciButton";
            this.fibonacciButton.Size = new System.Drawing.Size(159, 24);
            this.fibonacciButton.TabIndex = 8;
            this.fibonacciButton.Text = "Fibonacci sequence";
            this.fibonacciButton.UseVisualStyleBackColor = true;
            // 
            // tokudaButton
            // 
            this.tokudaButton.AutoSize = true;
            this.tokudaButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tokudaButton.ForeColor = System.Drawing.Color.Black;
            this.tokudaButton.Location = new System.Drawing.Point(11, 184);
            this.tokudaButton.Name = "tokudaButton";
            this.tokudaButton.Size = new System.Drawing.Size(144, 24);
            this.tokudaButton.TabIndex = 6;
            this.tokudaButton.Text = "Tokuda sequence";
            this.tokudaButton.UseVisualStyleBackColor = true;
            // 
            // sedgwickButton
            // 
            this.sedgwickButton.AutoSize = true;
            this.sedgwickButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sedgwickButton.ForeColor = System.Drawing.Color.Black;
            this.sedgwickButton.Location = new System.Drawing.Point(11, 226);
            this.sedgwickButton.Name = "sedgwickButton";
            this.sedgwickButton.Size = new System.Drawing.Size(159, 24);
            this.sedgwickButton.TabIndex = 7;
            this.sedgwickButton.Text = "Sedgwick sequence";
            this.sedgwickButton.UseVisualStyleBackColor = true;
            // 
            // shellButton
            // 
            this.shellButton.AutoSize = true;
            this.shellButton.Checked = true;
            this.shellButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shellButton.ForeColor = System.Drawing.Color.Black;
            this.shellButton.Location = new System.Drawing.Point(11, 142);
            this.shellButton.Name = "shellButton";
            this.shellButton.Size = new System.Drawing.Size(128, 24);
            this.shellButton.TabIndex = 5;
            this.shellButton.TabStop = true;
            this.shellButton.Text = "Shell sequence";
            this.shellButton.UseVisualStyleBackColor = true;
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sizeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sizeLabel.Location = new System.Drawing.Point(11, 31);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(39, 20);
            this.sizeLabel.TabIndex = 0;
            this.sizeLabel.Text = "Size:";
            // 
            // sizeBox
            // 
            this.sizeBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sizeBox.Location = new System.Drawing.Point(170, 28);
            this.sizeBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.ShortcutsEnabled = false;
            this.sizeBox.Size = new System.Drawing.Size(97, 27);
            this.sizeBox.TabIndex = 1;
            this.sizeBox.TextChanged += new System.EventHandler(this.sizeBox_TextChanged);
            this.sizeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sizeBox_KeyPress);
            // 
            // generateButton
            // 
            this.generateButton.BackColor = System.Drawing.Color.White;
            this.generateButton.Enabled = false;
            this.generateButton.FlatAppearance.BorderSize = 0;
            this.generateButton.ForeColor = System.Drawing.Color.Black;
            this.generateButton.Location = new System.Drawing.Point(0, 591);
            this.generateButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(285, 30);
            this.generateButton.TabIndex = 2;
            this.generateButton.Text = "Create";
            this.generateButton.UseVisualStyleBackColor = false;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.White;
            this.resetButton.Enabled = false;
            this.resetButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.resetButton.Location = new System.Drawing.Point(137, 624);
            this.resetButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(148, 30);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.White;
            this.startButton.Enabled = false;
            this.startButton.ForeColor = System.Drawing.Color.Black;
            this.startButton.Location = new System.Drawing.Point(0, 624);
            this.startButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(135, 30);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // informationPanel
            // 
            this.informationPanel.AutoSize = true;
            this.informationPanel.BackColor = System.Drawing.Color.White;
            this.informationPanel.Controls.Add(this.timeBox);
            this.informationPanel.Controls.Add(this.complexityBox);
            this.informationPanel.Controls.Add(this.swapsBox);
            this.informationPanel.Controls.Add(this.comparisonsBox);
            this.informationPanel.Controls.Add(this.comparisonsLabel);
            this.informationPanel.Controls.Add(this.swapsLabel);
            this.informationPanel.Controls.Add(this.complexityLabel);
            this.informationPanel.Controls.Add(this.timeLabel);
            this.informationPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.informationPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.informationPanel.Location = new System.Drawing.Point(0, 338);
            this.informationPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.informationPanel.Name = "informationPanel";
            this.informationPanel.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.informationPanel.Size = new System.Drawing.Size(285, 245);
            this.informationPanel.TabIndex = 18;
            this.informationPanel.TabStop = false;
            this.informationPanel.Text = "Information Panel";
            // 
            // timeBox
            // 
            this.timeBox.BackColor = System.Drawing.SystemColors.Window;
            this.timeBox.Enabled = false;
            this.timeBox.Location = new System.Drawing.Point(25, 190);
            this.timeBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(242, 27);
            this.timeBox.TabIndex = 19;
            // 
            // complexityBox
            // 
            this.complexityBox.BackColor = System.Drawing.SystemColors.Window;
            this.complexityBox.Enabled = false;
            this.complexityBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.complexityBox.Location = new System.Drawing.Point(137, 124);
            this.complexityBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.complexityBox.Name = "complexityBox";
            this.complexityBox.Size = new System.Drawing.Size(130, 27);
            this.complexityBox.TabIndex = 20;
            // 
            // swapsBox
            // 
            this.swapsBox.BackColor = System.Drawing.SystemColors.Window;
            this.swapsBox.Enabled = false;
            this.swapsBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.swapsBox.Location = new System.Drawing.Point(137, 83);
            this.swapsBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.swapsBox.Name = "swapsBox";
            this.swapsBox.Size = new System.Drawing.Size(130, 27);
            this.swapsBox.TabIndex = 19;
            // 
            // comparisonsBox
            // 
            this.comparisonsBox.BackColor = System.Drawing.SystemColors.Window;
            this.comparisonsBox.Enabled = false;
            this.comparisonsBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comparisonsBox.Location = new System.Drawing.Point(137, 40);
            this.comparisonsBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comparisonsBox.Name = "comparisonsBox";
            this.comparisonsBox.Size = new System.Drawing.Size(130, 27);
            this.comparisonsBox.TabIndex = 19;
            // 
            // comparisonsLabel
            // 
            this.comparisonsLabel.AutoSize = true;
            this.comparisonsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comparisonsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comparisonsLabel.Location = new System.Drawing.Point(6, 43);
            this.comparisonsLabel.Name = "comparisonsLabel";
            this.comparisonsLabel.Size = new System.Drawing.Size(102, 20);
            this.comparisonsLabel.TabIndex = 16;
            this.comparisonsLabel.Text = "Comparisons: ";
            // 
            // swapsLabel
            // 
            this.swapsLabel.AutoSize = true;
            this.swapsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.swapsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.swapsLabel.Location = new System.Drawing.Point(6, 86);
            this.swapsLabel.Name = "swapsLabel";
            this.swapsLabel.Size = new System.Drawing.Size(58, 20);
            this.swapsLabel.TabIndex = 17;
            this.swapsLabel.Text = "Swaps: ";
            // 
            // complexityLabel
            // 
            this.complexityLabel.AutoSize = true;
            this.complexityLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.complexityLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.complexityLabel.Location = new System.Drawing.Point(7, 127);
            this.complexityLabel.Name = "complexityLabel";
            this.complexityLabel.Size = new System.Drawing.Size(129, 20);
            this.complexityLabel.TabIndex = 12;
            this.complexityLabel.Text = "Space complexity:";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeLabel.Location = new System.Drawing.Point(87, 166);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(95, 20);
            this.timeLabel.TabIndex = 13;
            this.timeLabel.Text = "Elapsed time";
            // 
            // sortChoose
            // 
            this.sortChoose.BackColor = System.Drawing.Color.White;
            this.sortChoose.Controls.Add(this.label1);
            this.sortChoose.Controls.Add(this.reverseCheckBox);
            this.sortChoose.Controls.Add(this.fibonacciButton);
            this.sortChoose.Controls.Add(this.shellButton);
            this.sortChoose.Controls.Add(this.delayLabel);
            this.sortChoose.Controls.Add(this.sedgwickButton);
            this.sortChoose.Controls.Add(this.delayUpDown);
            this.sortChoose.Controls.Add(this.tokudaButton);
            this.sortChoose.Controls.Add(this.sizeLabel);
            this.sortChoose.Controls.Add(this.sizeBox);
            this.sortChoose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sortChoose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sortChoose.Location = new System.Drawing.Point(-2, 28);
            this.sortChoose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sortChoose.Name = "sortChoose";
            this.sortChoose.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sortChoose.Size = new System.Drawing.Size(287, 324);
            this.sortChoose.TabIndex = 11;
            this.sortChoose.TabStop = false;
            this.sortChoose.Text = "Control panel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Reverse sort:";
            // 
            // reverseCheckBox
            // 
            this.reverseCheckBox.AutoSize = true;
            this.reverseCheckBox.Location = new System.Drawing.Point(170, 107);
            this.reverseCheckBox.Name = "reverseCheckBox";
            this.reverseCheckBox.Size = new System.Drawing.Size(18, 17);
            this.reverseCheckBox.TabIndex = 16;
            this.reverseCheckBox.UseVisualStyleBackColor = true;
            // 
            // delayLabel
            // 
            this.delayLabel.AutoSize = true;
            this.delayLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delayLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.delayLabel.Location = new System.Drawing.Point(11, 71);
            this.delayLabel.Name = "delayLabel";
            this.delayLabel.Size = new System.Drawing.Size(79, 20);
            this.delayLabel.TabIndex = 15;
            this.delayLabel.Text = "Delay(ms):";
            // 
            // delayUpDown
            // 
            this.delayUpDown.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delayUpDown.Location = new System.Drawing.Point(169, 69);
            this.delayUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.delayUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.delayUpDown.Name = "delayUpDown";
            this.delayUpDown.Size = new System.Drawing.Size(97, 27);
            this.delayUpDown.TabIndex = 14;
            this.delayUpDown.Leave += new System.EventHandler(this.delayUpDown_Leave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1369, 28);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loggerToolStripMenuItem2,
            this.visualizationModeToolStripMenuItem,
            this.arrayAutosaveToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // loggerToolStripMenuItem2
            // 
            this.loggerToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem1,
            this.clearToolStripMenuItem1});
            this.loggerToolStripMenuItem2.Name = "loggerToolStripMenuItem2";
            this.loggerToolStripMenuItem2.Size = new System.Drawing.Size(219, 26);
            this.loggerToolStripMenuItem2.Text = "Logger";
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem1.Text = "Open";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem1_Click);
            // 
            // clearToolStripMenuItem1
            // 
            this.clearToolStripMenuItem1.Name = "clearToolStripMenuItem1";
            this.clearToolStripMenuItem1.Size = new System.Drawing.Size(128, 26);
            this.clearToolStripMenuItem1.Text = "Clear";
            this.clearToolStripMenuItem1.Click += new System.EventHandler(this.clearToolStripMenuItem1_Click);
            // 
            // visualizationModeToolStripMenuItem
            // 
            this.visualizationModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizationModeComboBox});
            this.visualizationModeToolStripMenuItem.Name = "visualizationModeToolStripMenuItem";
            this.visualizationModeToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.visualizationModeToolStripMenuItem.Text = "Visualization mode";
            // 
            // visualizationModeComboBox
            // 
            this.visualizationModeComboBox.CausesValidation = false;
            this.visualizationModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.visualizationModeComboBox.Items.AddRange(new object[] {
            "Standard",
            "Pyramid"});
            this.visualizationModeComboBox.Name = "visualizationModeComboBox";
            this.visualizationModeComboBox.Size = new System.Drawing.Size(121, 28);
            this.visualizationModeComboBox.SelectedIndexChanged += new System.EventHandler(this.visualizationModeComboBox_SelectedIndexChanged);
            // 
            // arrayAutosaveToolStripMenuItem
            // 
            this.arrayAutosaveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arrayAutoSaveComboBox});
            this.arrayAutosaveToolStripMenuItem.Name = "arrayAutosaveToolStripMenuItem";
            this.arrayAutosaveToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.arrayAutosaveToolStripMenuItem.Text = "Array autosave";
            // 
            // arrayAutoSaveComboBox
            // 
            this.arrayAutoSaveComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.arrayAutoSaveComboBox.Items.AddRange(new object[] {
            "Off",
            "On"});
            this.arrayAutoSaveComboBox.Name = "arrayAutoSaveComboBox";
            this.arrayAutoSaveComboBox.Size = new System.Drawing.Size(121, 28);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.writeToFileToolStripMenuItem,
            this.readToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // writeToFileToolStripMenuItem
            // 
            this.writeToFileToolStripMenuItem.Name = "writeToFileToolStripMenuItem";
            this.writeToFileToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.writeToFileToolStripMenuItem.Text = "Write";
            this.writeToFileToolStripMenuItem.Click += new System.EventHandler(this.writeToFileToolStripMenuItem_Click);
            // 
            // readToolStripMenuItem
            // 
            this.readToolStripMenuItem.Name = "readToolStripMenuItem";
            this.readToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.readToolStripMenuItem.Text = "Read";
            this.readToolStripMenuItem.Click += new System.EventHandler(this.readToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutProgramToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.aboutProgramToolStripMenuItem.Text = "About program";
            this.aboutProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutProgramToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // arrayPanel
            // 
            this.arrayPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("arrayPanel.BackgroundImage")));
            this.arrayPanel.Location = new System.Drawing.Point(285, 0);
            this.arrayPanel.Name = "arrayPanel";
            this.arrayPanel.Size = new System.Drawing.Size(1084, 665);
            this.arrayPanel.TabIndex = 20;
            this.arrayPanel.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1369, 664);
            this.Controls.Add(this.informationPanel);
            this.Controls.Add(this.arrayPanel);
            this.Controls.Add(this.sortChoose);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sort.Io";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.informationPanel.ResumeLayout(false);
            this.informationPanel.PerformLayout();
            this.sortChoose.ResumeLayout(false);
            this.sortChoose.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayUpDown)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arrayPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RadioButton fibonacciButton;
        private RadioButton tokudaButton;
        private RadioButton sedgwickButton;
        private RadioButton shellButton;
        private Label sizeLabel;
        private TextBox sizeBox;
        private Button generateButton;
        private Button resetButton;
        private Button startButton;
        private Label delayLabel;
        private GroupBox informationPanel;
        private Label comparisonsLabel;
        private Label swapsLabel;
        private Label complexityLabel;
        private Label timeLabel;
        private TextBox timeBox;
        private TextBox complexityBox;
        private TextBox swapsBox;
        private TextBox comparisonsBox;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ToolStripMenuItem loggerToolStripMenuItem2;
        private ToolStripMenuItem openToolStripMenuItem1;
        private ToolStripMenuItem clearToolStripMenuItem1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem writeToFileToolStripMenuItem;
        private ToolStripMenuItem readToolStripMenuItem;
        private ToolStripMenuItem aboutProgramToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem visualizationModeToolStripMenuItem;
        internal NumericUpDown delayUpDown;
        internal ToolStripComboBox visualizationModeComboBox;
        internal CheckBox reverseCheckBox;
        private ToolStripMenuItem openToolStripMenuItem;
        internal GroupBox sortChoose;
        private ToolStripMenuItem arrayAutosaveToolStripMenuItem;
        private ToolStripComboBox arrayAutoSaveComboBox;
        internal PictureBox arrayPanel;
    }
}