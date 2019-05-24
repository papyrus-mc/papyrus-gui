using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void DiscordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
