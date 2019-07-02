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
    public partial class FormConfigure : Form
    {
        public static string pathExeCS, pathExeJS;
        int    limitX, limitY, limitZ;

        public FormConfigure()
        {
            InitializeComponent();
            textBoxExeJS.Enabled = false;
            buttonBrowse2.Enabled = false;

            checkBoxHeightmap.Checked = true;
        }

        private string BrowseExecutable(OpenFileDialog OFD, TextBox tBox, Label label)
        {
            if (OFD.ShowDialog() == DialogResult.OK && System.IO.File.Exists(OFD.FileName))
            {
                label.ForeColor = Color.Green;
                label.Text = "OK!";
                tBox.Text = OFD.FileName;
                return OFD.FileName.ToString();
            }
            else
            {
                label.ForeColor = Color.Red;
                label.Text = "Invalid";
                return null;
            }
        }
        private void ButtonBrowse1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "papyrus.cs executable|papyruscs.exe";
            pathExeCS = BrowseExecutable(openFile, textBoxExeCS, labelStatusExeCS);
        }

        private void ButtonBrowse2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "papyrus.js executable|papyrusjs.exe";
            pathExeJS = BrowseExecutable(openFile, textBoxExeJS, labelStatusExeJS);
        }
    }
}
