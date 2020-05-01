namespace papyrus_gui
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.discordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxVersion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxWorld = new System.Windows.Forms.TextBox();
            this.buttonSelect1 = new System.Windows.Forms.Button();
            this.buttonSelect2 = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.checkBoxEnableConsoleOutput = new System.Windows.Forms.CheckBox();
            this.richTextBoxConsoleOutput = new System.Windows.Forms.RichTextBox();
            this.buttonRender = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabelTag = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.discordToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // discordToolStripMenuItem
            // 
            this.discordToolStripMenuItem.Name = "discordToolStripMenuItem";
            this.discordToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.discordToolStripMenuItem.Text = "Discord";
            this.discordToolStripMenuItem.Click += new System.EventHandler(this.DiscordToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(111, 6);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.AboutToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "papyrus version:";
            // 
            // comboBoxVersion
            // 
            this.comboBoxVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxVersion.FormattingEnabled = true;
            this.comboBoxVersion.Items.AddRange(new object[] {
            "PapyrusCS"});
            this.comboBoxVersion.Location = new System.Drawing.Point(102, 27);
            this.comboBoxVersion.Name = "comboBoxVersion";
            this.comboBoxVersion.Size = new System.Drawing.Size(590, 21);
            this.comboBoxVersion.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "World Folder:";
            // 
            // textBoxWorld
            // 
            this.textBoxWorld.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWorld.Location = new System.Drawing.Point(102, 54);
            this.textBoxWorld.Name = "textBoxWorld";
            this.textBoxWorld.Size = new System.Drawing.Size(590, 20);
            this.textBoxWorld.TabIndex = 4;
            // 
            // buttonSelect1
            // 
            this.buttonSelect1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelect1.Location = new System.Drawing.Point(698, 54);
            this.buttonSelect1.Name = "buttonSelect1";
            this.buttonSelect1.Size = new System.Drawing.Size(75, 20);
            this.buttonSelect1.TabIndex = 5;
            this.buttonSelect1.Text = "Select";
            this.buttonSelect1.UseVisualStyleBackColor = true;
            this.buttonSelect1.Click += new System.EventHandler(this.ButtonSelect1_Click);
            // 
            // buttonSelect2
            // 
            this.buttonSelect2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelect2.Location = new System.Drawing.Point(698, 83);
            this.buttonSelect2.Name = "buttonSelect2";
            this.buttonSelect2.Size = new System.Drawing.Size(75, 20);
            this.buttonSelect2.TabIndex = 8;
            this.buttonSelect2.Text = "Select";
            this.buttonSelect2.UseVisualStyleBackColor = true;
            this.buttonSelect2.Click += new System.EventHandler(this.ButtonSelect2_Click);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutput.Location = new System.Drawing.Point(102, 83);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(590, 20);
            this.textBoxOutput.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Output Folder:";
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.Controls.Add(this.checkBoxEnableConsoleOutput);
            this.groupBox.Controls.Add(this.richTextBoxConsoleOutput);
            this.groupBox.Location = new System.Drawing.Point(12, 148);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(760, 388);
            this.groupBox.TabIndex = 9;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Console Output";
            // 
            // checkBoxEnableConsoleOutput
            // 
            this.checkBoxEnableConsoleOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxEnableConsoleOutput.AutoSize = true;
            this.checkBoxEnableConsoleOutput.Checked = true;
            this.checkBoxEnableConsoleOutput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEnableConsoleOutput.Location = new System.Drawing.Point(6, 365);
            this.checkBoxEnableConsoleOutput.Name = "checkBoxEnableConsoleOutput";
            this.checkBoxEnableConsoleOutput.Size = new System.Drawing.Size(132, 17);
            this.checkBoxEnableConsoleOutput.TabIndex = 1;
            this.checkBoxEnableConsoleOutput.Text = "Enable console output";
            this.checkBoxEnableConsoleOutput.UseVisualStyleBackColor = true;
            this.checkBoxEnableConsoleOutput.CheckedChanged += new System.EventHandler(this.checkBoxEnableConsoleOutput_CheckedChanged);
            // 
            // richTextBoxConsoleOutput
            // 
            this.richTextBoxConsoleOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxConsoleOutput.BackColor = System.Drawing.Color.White;
            this.richTextBoxConsoleOutput.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxConsoleOutput.Location = new System.Drawing.Point(6, 20);
            this.richTextBoxConsoleOutput.Name = "richTextBoxConsoleOutput";
            this.richTextBoxConsoleOutput.ReadOnly = true;
            this.richTextBoxConsoleOutput.Size = new System.Drawing.Size(748, 339);
            this.richTextBoxConsoleOutput.TabIndex = 0;
            this.richTextBoxConsoleOutput.Text = "";
            // 
            // buttonRender
            // 
            this.buttonRender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRender.Location = new System.Drawing.Point(12, 110);
            this.buttonRender.Name = "buttonRender";
            this.buttonRender.Size = new System.Drawing.Size(760, 32);
            this.buttonRender.TabIndex = 10;
            this.buttonRender.Text = "Start rendering!";
            this.buttonRender.UseVisualStyleBackColor = true;
            this.buttonRender.Click += new System.EventHandler(this.ButtonRender_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(698, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 11;
            this.button1.Text = "Configure";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabelTag,
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabelTag
            // 
            this.statusLabelTag.Name = "statusLabelTag";
            this.statusLabelTag.Size = new System.Drawing.Size(42, 17);
            this.statusLabelTag.Text = "Status:";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(48, 17);
            this.statusLabel.Text = "Waiting";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonRender);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.buttonSelect2);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonSelect1);
            this.Controls.Add(this.textBoxWorld);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxVersion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "papyrus.gui";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxVersion;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBoxWorld;
        private System.Windows.Forms.Button buttonSelect1;
        private System.Windows.Forms.Button buttonSelect2;
        public System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RichTextBox richTextBoxConsoleOutput;
        private System.Windows.Forms.Button buttonRender;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem discordToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxEnableConsoleOutput;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelTag;
    }
}

