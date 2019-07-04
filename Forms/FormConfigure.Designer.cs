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
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "papyrus.cs executable:";
            // 
            // buttonBrowse1
            // 
            this.buttonBrowse1.Location = new System.Drawing.Point(163, 23);
            this.buttonBrowse1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBrowse1.Name = "buttonBrowse1";
            this.buttonBrowse1.Size = new System.Drawing.Size(180, 24);
            this.buttonBrowse1.TabIndex = 3;
            this.buttonBrowse1.Text = "Browse";
            this.buttonBrowse1.UseVisualStyleBackColor = true;
            this.buttonBrowse1.Click += new System.EventHandler(this.ButtonBrowse1_Click);
            // 
            // labelStatusExeCS
            // 
            this.labelStatusExeCS.AutoSize = true;
            this.labelStatusExeCS.Location = new System.Drawing.Point(351, 27);
            this.labelStatusExeCS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatusExeCS.Name = "labelStatusExeCS";
            this.labelStatusExeCS.Size = new System.Drawing.Size(70, 17);
            this.labelStatusExeCS.TabIndex = 4;
            this.labelStatusExeCS.Text = "Not found";
            // 
            // labelStatusExeJS
            // 
            this.labelStatusExeJS.AutoSize = true;
            this.labelStatusExeJS.Location = new System.Drawing.Point(351, 57);
            this.labelStatusExeJS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatusExeJS.Name = "labelStatusExeJS";
            this.labelStatusExeJS.Size = new System.Drawing.Size(70, 17);
            this.labelStatusExeJS.TabIndex = 9;
            this.labelStatusExeJS.Text = "Not found";
            // 
            // buttonBrowse2
            // 
            this.buttonBrowse2.Location = new System.Drawing.Point(163, 53);
            this.buttonBrowse2.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBrowse2.Name = "buttonBrowse2";
            this.buttonBrowse2.Size = new System.Drawing.Size(180, 24);
            this.buttonBrowse2.TabIndex = 8;
            this.buttonBrowse2.Text = "Browse";
            this.buttonBrowse2.UseVisualStyleBackColor = true;
            this.buttonBrowse2.Click += new System.EventHandler(this.ButtonBrowse2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 17);
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
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(426, 93);
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
            this.groupBox2.Location = new System.Drawing.Point(13, 114);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(426, 392);
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
            this.tabControl1.Location = new System.Drawing.Point(7, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(412, 363);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
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
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(404, 334);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "papyrus.cs";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkBoxLeaflet
            // 
            this.checkBoxLeaflet.AutoSize = true;
            this.checkBoxLeaflet.Location = new System.Drawing.Point(145, 303);
            this.checkBoxLeaflet.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxLeaflet.Name = "checkBoxLeaflet";
            this.checkBoxLeaflet.Size = new System.Drawing.Size(250, 21);
            this.checkBoxLeaflet.TabIndex = 31;
            this.checkBoxLeaflet.Text = "Use Leaflet instead of OpenLayers";
            this.checkBoxLeaflet.UseVisualStyleBackColor = true;
            // 
            // textBoxHeightmapOffset
            // 
            this.textBoxHeightmapOffset.Location = new System.Drawing.Point(302, 154);
            this.textBoxHeightmapOffset.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxHeightmapOffset.Name = "textBoxHeightmapOffset";
            this.textBoxHeightmapOffset.Size = new System.Drawing.Size(93, 22);
            this.textBoxHeightmapOffset.TabIndex = 30;
            this.textBoxHeightmapOffset.Text = "64";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(160, 157);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 17);
            this.label14.TabIndex = 29;
            this.label14.Text = "Offset:";
            // 
            // textBoxHeightmapDivider
            // 
            this.textBoxHeightmapDivider.Location = new System.Drawing.Point(302, 124);
            this.textBoxHeightmapDivider.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxHeightmapDivider.Name = "textBoxHeightmapDivider";
            this.textBoxHeightmapDivider.Size = new System.Drawing.Size(93, 22);
            this.textBoxHeightmapDivider.TabIndex = 28;
            this.textBoxHeightmapDivider.Text = "20";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(160, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 17);
            this.label13.TabIndex = 27;
            this.label13.Text = "Divider:";
            // 
            // textBoxHeightmapJ
            // 
            this.textBoxHeightmapJ.Location = new System.Drawing.Point(302, 94);
            this.textBoxHeightmapJ.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxHeightmapJ.Name = "textBoxHeightmapJ";
            this.textBoxHeightmapJ.Size = new System.Drawing.Size(93, 22);
            this.textBoxHeightmapJ.TabIndex = 26;
            this.textBoxHeightmapJ.Text = "10000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(160, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 17);
            this.label12.TabIndex = 25;
            this.label12.Text = "Brilloun J:";
            // 
            // checkBoxForceOverwrite
            // 
            this.checkBoxForceOverwrite.AutoSize = true;
            this.checkBoxForceOverwrite.Location = new System.Drawing.Point(10, 303);
            this.checkBoxForceOverwrite.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxForceOverwrite.Name = "checkBoxForceOverwrite";
            this.checkBoxForceOverwrite.Size = new System.Drawing.Size(127, 21);
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
            this.comboBoxProfile.Location = new System.Drawing.Point(126, 213);
            this.comboBoxProfile.Name = "comboBoxProfile";
            this.comboBoxProfile.Size = new System.Drawing.Size(269, 24);
            this.comboBoxProfile.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Profile:";
            // 
            // textBoxImgQuality
            // 
            this.textBoxImgQuality.Location = new System.Drawing.Point(298, 243);
            this.textBoxImgQuality.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxImgQuality.Name = "textBoxImgQuality";
            this.textBoxImgQuality.Size = new System.Drawing.Size(97, 22);
            this.textBoxImgQuality.TabIndex = 21;
            this.textBoxImgQuality.Text = "100";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(235, 246);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 17);
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
            this.comboBoxImgFormat.Location = new System.Drawing.Point(126, 243);
            this.comboBoxImgFormat.Name = "comboBoxImgFormat";
            this.comboBoxImgFormat.Size = new System.Drawing.Size(103, 24);
            this.comboBoxImgFormat.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 17);
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
            this.comboBoxDimension.Location = new System.Drawing.Point(126, 183);
            this.comboBoxDimension.Name = "comboBoxDimension";
            this.comboBoxDimension.Size = new System.Drawing.Size(269, 24);
            this.comboBoxDimension.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Dimension:";
            // 
            // textBoxLimitXZX2
            // 
            this.textBoxLimitXZX2.Location = new System.Drawing.Point(201, 35);
            this.textBoxLimitXZX2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLimitXZX2.Name = "textBoxLimitXZX2";
            this.textBoxLimitXZX2.Size = new System.Drawing.Size(52, 22);
            this.textBoxLimitXZX2.TabIndex = 11;
            this.textBoxLimitXZX2.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "X 2:";
            // 
            // textBoxLimitXZZ2
            // 
            this.textBoxLimitXZZ2.Location = new System.Drawing.Point(343, 34);
            this.textBoxLimitXZZ2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLimitXZZ2.Name = "textBoxLimitXZZ2";
            this.textBoxLimitXZZ2.Size = new System.Drawing.Size(52, 22);
            this.textBoxLimitXZZ2.TabIndex = 13;
            this.textBoxLimitXZZ2.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(302, 37);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Z 2:";
            // 
            // checkBoxLimitXZ
            // 
            this.checkBoxLimitXZ.AutoSize = true;
            this.checkBoxLimitXZ.Location = new System.Drawing.Point(7, 7);
            this.checkBoxLimitXZ.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxLimitXZ.Name = "checkBoxLimitXZ";
            this.checkBoxLimitXZ.Size = new System.Drawing.Size(113, 21);
            this.checkBoxLimitXZ.TabIndex = 0;
            this.checkBoxLimitXZ.Text = "Limit X and Z";
            this.checkBoxLimitXZ.UseVisualStyleBackColor = true;
            // 
            // textBoxLimitXZX1
            // 
            this.textBoxLimitXZX1.Location = new System.Drawing.Point(201, 5);
            this.textBoxLimitXZX1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLimitXZX1.Name = "textBoxLimitXZX1";
            this.textBoxLimitXZX1.Size = new System.Drawing.Size(52, 22);
            this.textBoxLimitXZX1.TabIndex = 1;
            this.textBoxLimitXZX1.Text = "0";
            // 
            // labelLimitX
            // 
            this.labelLimitX.AutoSize = true;
            this.labelLimitX.Location = new System.Drawing.Point(160, 8);
            this.labelLimitX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLimitX.Name = "labelLimitX";
            this.labelLimitX.Size = new System.Drawing.Size(33, 17);
            this.labelLimitX.TabIndex = 2;
            this.labelLimitX.Text = "X 1:";
            // 
            // textBoxHTMLFilename
            // 
            this.textBoxHTMLFilename.Location = new System.Drawing.Point(126, 273);
            this.textBoxHTMLFilename.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxHTMLFilename.Name = "textBoxHTMLFilename";
            this.textBoxHTMLFilename.Size = new System.Drawing.Size(269, 22);
            this.textBoxHTMLFilename.TabIndex = 10;
            this.textBoxHTMLFilename.Text = "index.html";
            // 
            // textBoxLimitXZZ1
            // 
            this.textBoxLimitXZZ1.Location = new System.Drawing.Point(343, 4);
            this.textBoxLimitXZZ1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLimitXZZ1.Name = "textBoxLimitXZZ1";
            this.textBoxLimitXZZ1.Size = new System.Drawing.Size(52, 22);
            this.textBoxLimitXZZ1.TabIndex = 3;
            this.textBoxLimitXZZ1.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 276);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "HTML file name:";
            // 
            // labelLimitZ
            // 
            this.labelLimitZ.AutoSize = true;
            this.labelLimitZ.Location = new System.Drawing.Point(302, 7);
            this.labelLimitZ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLimitZ.Name = "labelLimitZ";
            this.labelLimitZ.Size = new System.Drawing.Size(33, 17);
            this.labelLimitZ.TabIndex = 4;
            this.labelLimitZ.Text = "Z 1:";
            // 
            // checkBoxHeightmap
            // 
            this.checkBoxHeightmap.AutoSize = true;
            this.checkBoxHeightmap.Location = new System.Drawing.Point(7, 96);
            this.checkBoxHeightmap.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxHeightmap.Name = "checkBoxHeightmap";
            this.checkBoxHeightmap.Size = new System.Drawing.Size(146, 21);
            this.checkBoxHeightmap.TabIndex = 8;
            this.checkBoxHeightmap.Text = "Enable Heightmap";
            this.checkBoxHeightmap.UseVisualStyleBackColor = true;
            // 
            // checkBoxLimitY
            // 
            this.checkBoxLimitY.AutoSize = true;
            this.checkBoxLimitY.Location = new System.Drawing.Point(7, 67);
            this.checkBoxLimitY.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxLimitY.Name = "checkBoxLimitY";
            this.checkBoxLimitY.Size = new System.Drawing.Size(72, 21);
            this.checkBoxLimitY.TabIndex = 5;
            this.checkBoxLimitY.Text = "Limit Y";
            this.checkBoxLimitY.UseVisualStyleBackColor = true;
            // 
            // labelLimitY
            // 
            this.labelLimitY.AutoSize = true;
            this.labelLimitY.Location = new System.Drawing.Point(160, 68);
            this.labelLimitY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLimitY.Name = "labelLimitY";
            this.labelLimitY.Size = new System.Drawing.Size(21, 17);
            this.labelLimitY.TabIndex = 7;
            this.labelLimitY.Text = "Y:";
            // 
            // textBoxLimitY
            // 
            this.textBoxLimitY.Location = new System.Drawing.Point(201, 65);
            this.textBoxLimitY.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLimitY.Name = "textBoxLimitY";
            this.textBoxLimitY.Size = new System.Drawing.Size(52, 22);
            this.textBoxLimitY.TabIndex = 6;
            this.textBoxLimitY.Text = "64";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Enabled = false;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(403, 341);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "papyrus.js";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Not available...";
            // 
            // FormConfigure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 519);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(470, 566);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(470, 566);
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
    }
}