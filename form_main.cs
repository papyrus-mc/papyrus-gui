using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;

namespace papyrus_gui
{
    public partial class form_main : Form
    {
        public form_main()
        {
            InitializeComponent();
            comboBoxVersion.SelectedIndex = 0;
            textBox1.Text = "";
        }

        private void ButtonSelect1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserInput = new FolderBrowserDialog();

            if (textBox1.Text != "")
            {
                folderBrowserInput.SelectedPath = textBox1.Text;
            }
            else
            {
                folderBrowserInput.SelectedPath = @"%LocalAppData%\Packages\Microsoft.MinecraftUWP_8wekyb3d8bbwe\LocalState\games\com.mojang\minecraftWorlds\";
            }

            if ( folderBrowserInput.ShowDialog() == DialogResult.OK )
            {
                textBox1.Text = folderBrowserInput.SelectedPath;
            }
        }

        private void ButtonSelect2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserOutput = new FolderBrowserDialog();

            if (textBox2.Text != "")
            {
                folderBrowserOutput.SelectedPath = textBox2.Text;
            } else {
                folderBrowserOutput.SelectedPath = "";
            }

            if (folderBrowserOutput.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = folderBrowserOutput.SelectedPath;
            }
        }

        private void ButtonRender_Click(object sender, EventArgs e)
        {
            if (System.IO.Directory.Exists(textBox1.Text.ToString()) && System.IO.Directory.Exists(textBox2.Text.ToString()))
            {
                switch (comboBoxVersion.SelectedIndex)
                {
                    // .cs
                    case 0:
                        Process process = new Process();
                        process.StartInfo.FileName = form_configure.pathExeCS;
                        process.StartInfo.Arguments = String.Format(@"-w "+"{0}"+@" -o"+"{1} --htmlfile {2}", textBox1.Text, textBox2.Text);
                        process.StartInfo.UseShellExecute = false;
                        process.StartInfo.RedirectStandardOutput = true;
                        process.Start();

                        richTextBoxConsoleOutput.Text = process.StandardOutput.ReadToEnd();
                        process.WaitForExit();
                        break;

                    // .js
                    case 1:
                        break;
                }
            } else
            {
                MessageBox.Show("World and/ or output directory is invalid or does not exist.", "Invalid directory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DiscordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var formConfigure = new form_configure();
            formConfigure.Show();
        }

        private void AboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("papyrus.gui version {0} by clarkx86", "1.0"), "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
