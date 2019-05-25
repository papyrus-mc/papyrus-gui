namespace papyrus_gui
{
    partial class form_configure
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxExeCS = new System.Windows.Forms.TextBox();
            this.buttonBrowse1 = new System.Windows.Forms.Button();
            this.labelStatusExeCS = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelStatusExeJS = new System.Windows.Forms.Label();
            this.buttonBrowse2 = new System.Windows.Forms.Button();
            this.textBoxExeJS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxArgumentsPreview = new System.Windows.Forms.TextBox();
            this.textBoxHTMLFileName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxHeightmap = new System.Windows.Forms.CheckBox();
            this.labelLimitY = new System.Windows.Forms.Label();
            this.textBoxLimitY = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.labelLimitZ = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelLimitX = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path to papyrus.cs executable:";
            // 
            // textBoxExeCS
            // 
            this.textBoxExeCS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxExeCS.Location = new System.Drawing.Point(165, 13);
            this.textBoxExeCS.Name = "textBoxExeCS";
            this.textBoxExeCS.Size = new System.Drawing.Size(94, 20);
            this.textBoxExeCS.TabIndex = 1;
            // 
            // buttonBrowse1
            // 
            this.buttonBrowse1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowse1.Location = new System.Drawing.Point(265, 13);
            this.buttonBrowse1.Name = "buttonBrowse1";
            this.buttonBrowse1.Size = new System.Drawing.Size(62, 20);
            this.buttonBrowse1.TabIndex = 3;
            this.buttonBrowse1.Text = "Browse";
            this.buttonBrowse1.UseVisualStyleBackColor = true;
            this.buttonBrowse1.Click += new System.EventHandler(this.ButtonBrowse1_Click);
            // 
            // labelStatusExeCS
            // 
            this.labelStatusExeCS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStatusExeCS.AutoSize = true;
            this.labelStatusExeCS.Location = new System.Drawing.Point(333, 16);
            this.labelStatusExeCS.Name = "labelStatusExeCS";
            this.labelStatusExeCS.Size = new System.Drawing.Size(54, 13);
            this.labelStatusExeCS.TabIndex = 4;
            this.labelStatusExeCS.Text = "Not found";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Please define the paths to the version of papyrus you are using.\r\nYou do not need" +
    " to define both. In most use cases, one version is enough.\r\n";
            // 
            // labelStatusExeJS
            // 
            this.labelStatusExeJS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStatusExeJS.AutoSize = true;
            this.labelStatusExeJS.Location = new System.Drawing.Point(333, 42);
            this.labelStatusExeJS.Name = "labelStatusExeJS";
            this.labelStatusExeJS.Size = new System.Drawing.Size(54, 13);
            this.labelStatusExeJS.TabIndex = 9;
            this.labelStatusExeJS.Text = "Not found";
            // 
            // buttonBrowse2
            // 
            this.buttonBrowse2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowse2.Location = new System.Drawing.Point(265, 39);
            this.buttonBrowse2.Name = "buttonBrowse2";
            this.buttonBrowse2.Size = new System.Drawing.Size(62, 20);
            this.buttonBrowse2.TabIndex = 8;
            this.buttonBrowse2.Text = "Browse";
            this.buttonBrowse2.UseVisualStyleBackColor = true;
            this.buttonBrowse2.Click += new System.EventHandler(this.ButtonBrowse2_Click);
            // 
            // textBoxExeJS
            // 
            this.textBoxExeJS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxExeJS.Location = new System.Drawing.Point(165, 39);
            this.textBoxExeJS.Name = "textBoxExeJS";
            this.textBoxExeJS.Size = new System.Drawing.Size(94, 20);
            this.textBoxExeJS.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Path to papyrus.js executable:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelStatusExeJS);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonBrowse2);
            this.groupBox1.Controls.Add(this.textBoxExeCS);
            this.groupBox1.Controls.Add(this.textBoxExeJS);
            this.groupBox1.Controls.Add(this.buttonBrowse1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.labelStatusExeCS);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 102);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "papyrus configuration";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxArgumentsPreview);
            this.groupBox2.Controls.Add(this.textBoxHTMLFileName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.checkBoxHeightmap);
            this.groupBox2.Controls.Add(this.labelLimitY);
            this.groupBox2.Controls.Add(this.textBoxLimitY);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.labelLimitZ);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.labelLimitX);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 160);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Additional arguments";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Arguments:";
            // 
            // textBoxArgumentsPreview
            // 
            this.textBoxArgumentsPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxArgumentsPreview.Location = new System.Drawing.Point(72, 134);
            this.textBoxArgumentsPreview.Name = "textBoxArgumentsPreview";
            this.textBoxArgumentsPreview.ReadOnly = true;
            this.textBoxArgumentsPreview.Size = new System.Drawing.Size(315, 20);
            this.textBoxArgumentsPreview.TabIndex = 11;
            // 
            // textBoxHTMLFileName
            // 
            this.textBoxHTMLFileName.Location = new System.Drawing.Point(123, 97);
            this.textBoxHTMLFileName.Name = "textBoxHTMLFileName";
            this.textBoxHTMLFileName.Size = new System.Drawing.Size(129, 20);
            this.textBoxHTMLFileName.TabIndex = 10;
            this.textBoxHTMLFileName.Text = "index.html";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "HTML file name:";
            // 
            // checkBoxHeightmap
            // 
            this.checkBoxHeightmap.AutoSize = true;
            this.checkBoxHeightmap.Location = new System.Drawing.Point(6, 69);
            this.checkBoxHeightmap.Name = "checkBoxHeightmap";
            this.checkBoxHeightmap.Size = new System.Drawing.Size(113, 17);
            this.checkBoxHeightmap.TabIndex = 8;
            this.checkBoxHeightmap.Text = "Enable Heightmap";
            this.checkBoxHeightmap.UseVisualStyleBackColor = true;
            // 
            // labelLimitY
            // 
            this.labelLimitY.AutoSize = true;
            this.labelLimitY.Location = new System.Drawing.Point(120, 46);
            this.labelLimitY.Name = "labelLimitY";
            this.labelLimitY.Size = new System.Drawing.Size(17, 13);
            this.labelLimitY.TabIndex = 7;
            this.labelLimitY.Text = "Y:";
            // 
            // textBoxLimitY
            // 
            this.textBoxLimitY.Location = new System.Drawing.Point(143, 43);
            this.textBoxLimitY.Name = "textBoxLimitY";
            this.textBoxLimitY.Size = new System.Drawing.Size(40, 20);
            this.textBoxLimitY.TabIndex = 6;
            this.textBoxLimitY.Text = "64";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 45);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(57, 17);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Limit Y";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // labelLimitZ
            // 
            this.labelLimitZ.AutoSize = true;
            this.labelLimitZ.Location = new System.Drawing.Point(189, 20);
            this.labelLimitZ.Name = "labelLimitZ";
            this.labelLimitZ.Size = new System.Drawing.Size(17, 13);
            this.labelLimitZ.TabIndex = 4;
            this.labelLimitZ.Text = "Z:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(212, 17);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(40, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "0";
            // 
            // labelLimitX
            // 
            this.labelLimitX.AutoSize = true;
            this.labelLimitX.Location = new System.Drawing.Point(120, 20);
            this.labelLimitX.Name = "labelLimitX";
            this.labelLimitX.Size = new System.Drawing.Size(17, 13);
            this.labelLimitX.TabIndex = 2;
            this.labelLimitX.Text = "X:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(40, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "0";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Limit range";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // form_configure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 292);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "form_configure";
            this.Text = "Configure";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxExeCS;
        private System.Windows.Forms.Button buttonBrowse1;
        private System.Windows.Forms.Label labelStatusExeCS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelStatusExeJS;
        private System.Windows.Forms.Button buttonBrowse2;
        private System.Windows.Forms.TextBox textBoxExeJS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxHeightmap;
        private System.Windows.Forms.Label labelLimitY;
        private System.Windows.Forms.TextBox textBoxLimitY;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label labelLimitZ;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelLimitX;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBoxHTMLFileName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxArgumentsPreview;
    }
}