namespace papyrus_gui
{
    partial class FormConfigure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfigure));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBrowse1 = new System.Windows.Forms.Button();
            this.labelStatusExeCS = new System.Windows.Forms.Label();
            this.labelStatusExeJS = new System.Windows.Forms.Label();
            this.buttonBrowse2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonCopyArgumentsCs = new System.Windows.Forms.Button();
            this.checkBoxLeaflet = new System.Windows.Forms.CheckBox();
            this.textBoxHeightmapOffset = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxHeightmapDivider = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxHeightmapJ = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBoxForceOverwrite = new System.Windows.Forms.CheckBox();
            this.comboBoxProfile = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxImgQuality = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxImgFormat = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxDimension = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxLimitXZX2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLimitXZZ2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxLimitXZ = new System.Windows.Forms.CheckBox();
            this.textBoxLimitXZX1 = new System.Windows.Forms.TextBox();
            this.labelLimitX = new System.Windows.Forms.Label();
            this.textBoxHTMLFilename = new System.Windows.Forms.TextBox();
            this.textBoxLimitXZZ1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelLimitZ = new System.Windows.Forms.Label();
            this.checkBoxHeightmap = new System.Windows.Forms.CheckBox();
            this.checkBoxLimitY = new System.Windows.Forms.CheckBox();
            this.labelLimitY = new System.Windows.Forms.Label();
            this.textBoxLimitY = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PapyrusCS executable:";
            // 
            // buttonBrowse1
            // 
            this.buttonBrowse1.Location = new System.Drawing.Point(122, 19);
            this.buttonBrowse1.Name = "buttonBrowse1";
            this.buttonBrowse1.Size = new System.Drawing.Size(135, 20);
            this.buttonBrowse1.TabIndex = 3;
            this.buttonBrowse1.Text = "Browse";
            this.buttonBrowse1.UseVisualStyleBackColor = true;
            this.buttonBrowse1.Click += new System.EventHandler(this.ButtonBrowse1_Click);
            // 
            // labelStatusExeCS
            // 
            this.labelStatusExeCS.AutoSize = true;
            this.labelStatusExeCS.Location = new System.Drawing.Point(263, 22);
            this.labelStatusExeCS.Name = "labelStatusExeCS";
            this.labelStatusExeCS.Size = new System.Drawing.Size(54, 13);
            this.labelStatusExeCS.TabIndex = 4;
            this.labelStatusExeCS.Text = "Not found";
            // 
            // labelStatusExeJS
            // 
            this.labelStatusExeJS.AutoSize = true;
            this.labelStatusExeJS.Location = new System.Drawing.Point(263, 46);
            this.labelStatusExeJS.Name = "labelStatusExeJS";
            this.labelStatusExeJS.Size = new System.Drawing.Size(54, 13);
            this.labelStatusExeJS.TabIndex = 9;
            this.labelStatusExeJS.Text = "Not found";
            // 
            // buttonBrowse2
            // 
            this.buttonBrowse2.Location = new System.Drawing.Point(122, 43);
            this.buttonBrowse2.Name = "buttonBrowse2";
            this.buttonBrowse2.Size = new System.Drawing.Size(135, 20);
            this.buttonBrowse2.TabIndex = 8;
            this.buttonBrowse2.Text = "Browse";
            this.buttonBrowse2.UseVisualStyleBackColor = true;
            this.buttonBrowse2.Click += new System.EventHandler(this.ButtonBrowse2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "papyrus.js executable:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.labelStatusExeJS);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonBrowse2);
            this.groupBox1.Controls.Add(this.buttonBrowse1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.labelStatusExeCS);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 76);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "papyrus path configuration";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Location = new System.Drawing.Point(10, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 346);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Additional arguments";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(5, 18);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(309, 323);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonCopyArgumentsCs);
            this.tabPage1.Controls.Add(this.checkBoxLeaflet);
            this.tabPage1.Controls.Add(this.textBoxHeightmapOffset);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.textBoxHeightmapDivider);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.textBoxHeightmapJ);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.checkBoxForceOverwrite);
            this.tabPage1.Controls.Add(this.comboBoxProfile);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.textBoxImgQuality);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.comboBoxImgFormat);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.comboBoxDimension);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.textBoxLimitXZX2);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textBoxLimitXZZ2);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.checkBoxLimitXZ);
            this.tabPage1.Controls.Add(this.textBoxLimitXZX1);
            this.tabPage1.Controls.Add(this.labelLimitX);
            this.tabPage1.Controls.Add(this.textBoxHTMLFilename);
            this.tabPage1.Controls.Add(this.textBoxLimitXZZ1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.labelLimitZ);
            this.tabPage1.Controls.Add(this.checkBoxHeightmap);
            this.tabPage1.Controls.Add(this.checkBoxLimitY);
            this.tabPage1.Controls.Add(this.labelLimitY);
            this.tabPage1.Controls.Add(this.textBoxLimitY);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(301, 297);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PapyrusCS";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonCopyArgumentsCs
            // 
            this.buttonCopyArgumentsCs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCopyArgumentsCs.Location = new System.Drawing.Point(5, 269);
            this.buttonCopyArgumentsCs.Name = "buttonCopyArgumentsCs";
            this.buttonCopyArgumentsCs.Size = new System.Drawing.Size(291, 23);
            this.buttonCopyArgumentsCs.TabIndex = 32;
            this.buttonCopyArgumentsCs.Text = "Copy command line arguments to clipboard";
            this.buttonCopyArgumentsCs.UseVisualStyleBackColor = true;
            this.buttonCopyArgumentsCs.Click += new System.EventHandler(this.buttonCopyArgumentsCs_Click);
            // 
            // checkBoxLeaflet
            // 
            this.checkBoxLeaflet.AutoSize = true;
            this.checkBoxLeaflet.Location = new System.Drawing.Point(109, 246);
            this.checkBoxLeaflet.Name = "checkBoxLeaflet";
            this.checkBoxLeaflet.Size = new System.Drawing.Size(189, 17);
            this.checkBoxLeaflet.TabIndex = 31;
            this.checkBoxLeaflet.Text = "Use Leaflet instead of OpenLayers";
            this.checkBoxLeaflet.UseVisualStyleBackColor = true;
            // 
            // textBoxHeightmapOffset
            // 
            this.textBoxHeightmapOffset.Location = new System.Drawing.Point(226, 125);
            this.textBoxHeightmapOffset.Name = "textBoxHeightmapOffset";
            this.textBoxHeightmapOffset.Size = new System.Drawing.Size(71, 20);
            this.textBoxHeightmapOffset.TabIndex = 30;
            this.textBoxHeightmapOffset.Text = "64";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(120, 128);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Offset:";
            // 
            // textBoxHeightmapDivider
            // 
            this.textBoxHeightmapDivider.Location = new System.Drawing.Point(226, 101);
            this.textBoxHeightmapDivider.Name = "textBoxHeightmapDivider";
            this.textBoxHeightmapDivider.Size = new System.Drawing.Size(71, 20);
            this.textBoxHeightmapDivider.TabIndex = 28;
            this.textBoxHeightmapDivider.Text = "20";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(120, 103);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Divider:";
            // 
            // textBoxHeightmapJ
            // 
            this.textBoxHeightmapJ.Location = new System.Drawing.Point(226, 76);
            this.textBoxHeightmapJ.Name = "textBoxHeightmapJ";
            this.textBoxHeightmapJ.Size = new System.Drawing.Size(71, 20);
            this.textBoxHeightmapJ.TabIndex = 26;
            this.textBoxHeightmapJ.Text = "10000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(120, 79);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Brilloun J:";
            // 
            // checkBoxForceOverwrite
            // 
            this.checkBoxForceOverwrite.AutoSize = true;
            this.checkBoxForceOverwrite.Location = new System.Drawing.Point(8, 246);
            this.checkBoxForceOverwrite.Name = "checkBoxForceOverwrite";
            this.checkBoxForceOverwrite.Size = new System.Drawing.Size(99, 17);
            this.checkBoxForceOverwrite.TabIndex = 24;
            this.checkBoxForceOverwrite.Text = "Force overwrite";
            this.checkBoxForceOverwrite.UseVisualStyleBackColor = true;
            // 
            // comboBoxProfile
            // 
            this.comboBoxProfile.FormattingEnabled = true;
            this.comboBoxProfile.Items.AddRange(new object[] {
            "Default",
            "Underground",
            "Aquatic",
            "Ore",
            "Stronghold"});
            this.comboBoxProfile.Location = new System.Drawing.Point(94, 173);
            this.comboBoxProfile.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxProfile.Name = "comboBoxProfile";
            this.comboBoxProfile.Size = new System.Drawing.Size(203, 21);
            this.comboBoxProfile.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 176);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Profile:";
            // 
            // textBoxImgQuality
            // 
            this.textBoxImgQuality.Location = new System.Drawing.Point(224, 197);
            this.textBoxImgQuality.Name = "textBoxImgQuality";
            this.textBoxImgQuality.Size = new System.Drawing.Size(74, 20);
            this.textBoxImgQuality.TabIndex = 21;
            this.textBoxImgQuality.Text = "100";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(176, 200);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Quality:";
            // 
            // comboBoxImgFormat
            // 
            this.comboBoxImgFormat.FormattingEnabled = true;
            this.comboBoxImgFormat.Items.AddRange(new object[] {
            "PNG",
            "WebP",
            "JPG"});
            this.comboBoxImgFormat.Location = new System.Drawing.Point(94, 197);
            this.comboBoxImgFormat.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxImgFormat.Name = "comboBoxImgFormat";
            this.comboBoxImgFormat.Size = new System.Drawing.Size(78, 21);
            this.comboBoxImgFormat.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 200);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Image format:";
            // 
            // comboBoxDimension
            // 
            this.comboBoxDimension.FormattingEnabled = true;
            this.comboBoxDimension.Items.AddRange(new object[] {
            "Overworld",
            "Nether",
            "The End"});
            this.comboBoxDimension.Location = new System.Drawing.Point(94, 149);
            this.comboBoxDimension.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxDimension.Name = "comboBoxDimension";
            this.comboBoxDimension.Size = new System.Drawing.Size(203, 21);
            this.comboBoxDimension.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 151);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Dimension:";
            // 
            // textBoxLimitXZX2
            // 
            this.textBoxLimitXZX2.Location = new System.Drawing.Point(151, 28);
            this.textBoxLimitXZX2.Name = "textBoxLimitXZX2";
            this.textBoxLimitXZX2.Size = new System.Drawing.Size(40, 20);
            this.textBoxLimitXZX2.TabIndex = 11;
            this.textBoxLimitXZX2.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "X 2:";
            // 
            // textBoxLimitXZZ2
            // 
            this.textBoxLimitXZZ2.Location = new System.Drawing.Point(257, 28);
            this.textBoxLimitXZZ2.Name = "textBoxLimitXZZ2";
            this.textBoxLimitXZZ2.Size = new System.Drawing.Size(40, 20);
            this.textBoxLimitXZZ2.TabIndex = 13;
            this.textBoxLimitXZZ2.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Z 2:";
            // 
            // checkBoxLimitXZ
            // 
            this.checkBoxLimitXZ.AutoSize = true;
            this.checkBoxLimitXZ.Location = new System.Drawing.Point(5, 6);
            this.checkBoxLimitXZ.Name = "checkBoxLimitXZ";
            this.checkBoxLimitXZ.Size = new System.Drawing.Size(88, 17);
            this.checkBoxLimitXZ.TabIndex = 0;
            this.checkBoxLimitXZ.Text = "Limit X and Z";
            this.checkBoxLimitXZ.UseVisualStyleBackColor = true;
            // 
            // textBoxLimitXZX1
            // 
            this.textBoxLimitXZX1.Location = new System.Drawing.Point(151, 4);
            this.textBoxLimitXZX1.Name = "textBoxLimitXZX1";
            this.textBoxLimitXZX1.Size = new System.Drawing.Size(40, 20);
            this.textBoxLimitXZX1.TabIndex = 1;
            this.textBoxLimitXZX1.Text = "0";
            // 
            // labelLimitX
            // 
            this.labelLimitX.AutoSize = true;
            this.labelLimitX.Location = new System.Drawing.Point(120, 6);
            this.labelLimitX.Name = "labelLimitX";
            this.labelLimitX.Size = new System.Drawing.Size(26, 13);
            this.labelLimitX.TabIndex = 2;
            this.labelLimitX.Text = "X 1:";
            // 
            // textBoxHTMLFilename
            // 
            this.textBoxHTMLFilename.Location = new System.Drawing.Point(94, 222);
            this.textBoxHTMLFilename.Name = "textBoxHTMLFilename";
            this.textBoxHTMLFilename.Size = new System.Drawing.Size(203, 20);
            this.textBoxHTMLFilename.TabIndex = 10;
            this.textBoxHTMLFilename.Text = "index.html";
            // 
            // textBoxLimitXZZ1
            // 
            this.textBoxLimitXZZ1.Location = new System.Drawing.Point(257, 3);
            this.textBoxLimitXZZ1.Name = "textBoxLimitXZZ1";
            this.textBoxLimitXZZ1.Size = new System.Drawing.Size(40, 20);
            this.textBoxLimitXZZ1.TabIndex = 3;
            this.textBoxLimitXZZ1.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "HTML file name:";
            // 
            // labelLimitZ
            // 
            this.labelLimitZ.AutoSize = true;
            this.labelLimitZ.Location = new System.Drawing.Point(226, 6);
            this.labelLimitZ.Name = "labelLimitZ";
            this.labelLimitZ.Size = new System.Drawing.Size(26, 13);
            this.labelLimitZ.TabIndex = 4;
            this.labelLimitZ.Text = "Z 1:";
            // 
            // checkBoxHeightmap
            // 
            this.checkBoxHeightmap.AutoSize = true;
            this.checkBoxHeightmap.Location = new System.Drawing.Point(5, 78);
            this.checkBoxHeightmap.Name = "checkBoxHeightmap";
            this.checkBoxHeightmap.Size = new System.Drawing.Size(113, 17);
            this.checkBoxHeightmap.TabIndex = 8;
            this.checkBoxHeightmap.Text = "Enable Heightmap";
            this.checkBoxHeightmap.UseVisualStyleBackColor = true;
            // 
            // checkBoxLimitY
            // 
            this.checkBoxLimitY.AutoSize = true;
            this.checkBoxLimitY.Location = new System.Drawing.Point(5, 54);
            this.checkBoxLimitY.Name = "checkBoxLimitY";
            this.checkBoxLimitY.Size = new System.Drawing.Size(57, 17);
            this.checkBoxLimitY.TabIndex = 5;
            this.checkBoxLimitY.Text = "Limit Y";
            this.checkBoxLimitY.UseVisualStyleBackColor = true;
            // 
            // labelLimitY
            // 
            this.labelLimitY.AutoSize = true;
            this.labelLimitY.Location = new System.Drawing.Point(120, 55);
            this.labelLimitY.Name = "labelLimitY";
            this.labelLimitY.Size = new System.Drawing.Size(17, 13);
            this.labelLimitY.TabIndex = 7;
            this.labelLimitY.Text = "Y:";
            // 
            // textBoxLimitY
            // 
            this.textBoxLimitY.Location = new System.Drawing.Point(151, 53);
            this.textBoxLimitY.Name = "textBoxLimitY";
            this.textBoxLimitY.Size = new System.Drawing.Size(40, 20);
            this.textBoxLimitY.TabIndex = 6;
            this.textBoxLimitY.Text = "64";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Enabled = false;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(301, 297);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "papyrus.js";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Not available...";
            // 
            // FormConfigure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 456);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(356, 495);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(356, 495);
            this.Name = "FormConfigure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configure";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBrowse1;
        private System.Windows.Forms.Label labelStatusExeCS;
        private System.Windows.Forms.Label labelStatusExeJS;
        private System.Windows.Forms.Button buttonBrowse2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxHeightmap;
        private System.Windows.Forms.Label labelLimitY;
        private System.Windows.Forms.TextBox textBoxLimitY;
        private System.Windows.Forms.CheckBox checkBoxLimitY;
        private System.Windows.Forms.Label labelLimitZ;
        private System.Windows.Forms.TextBox textBoxLimitXZZ1;
        private System.Windows.Forms.Label labelLimitX;
        private System.Windows.Forms.TextBox textBoxLimitXZX1;
        private System.Windows.Forms.CheckBox checkBoxLimitXZ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxHTMLFilename;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLimitXZX2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLimitXZZ2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxDimension;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxImgQuality;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxImgFormat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxHeightmapOffset;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxHeightmapDivider;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxHeightmapJ;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBoxForceOverwrite;
        private System.Windows.Forms.ComboBox comboBoxProfile;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBoxLeaflet;
        private System.Windows.Forms.Button buttonCopyArgumentsCs;
    }
}