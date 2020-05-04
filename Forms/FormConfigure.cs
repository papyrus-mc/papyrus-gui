using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace papyrus_gui
{
    public partial class FormConfigure : Form
    {
        public static string pathExeCS, pathExeJS;
        private FormMain FormMain;


        public FormConfigure(FormMain formMain)
        {
            InitializeComponent();

            FormMain = formMain;
            this.FormClosing += FormConfigure_FormClosing;

            #region DEFAULT VALUES
            buttonBrowse2.Enabled = false;
            checkBoxHeightmap.Checked = true;
            comboBoxDimension.SelectedIndex = 0;
            comboBoxProfile.SelectedIndex = 0;
            comboBoxImgFormat.SelectedIndex = 0;

            numericUpDownHeightmapJ.Maximum = Int32.MaxValue;
            numericUpDownHeightmapJ.Value = 10000;
            #endregion

            #region Load settings
            pathExeCS = FormMain.Settings.config_cs["executable"];
            if (File.Exists(pathExeCS))
            {
                labelStatusExeCS.ForeColor = Color.Green;
                labelStatusExeCS.Text = "OK!";
            } else
            {
                labelStatusExeCS.ForeColor = Color.Red;
                labelStatusExeCS.Text = "Invalid";
            }
            checkBoxLimitXZ.Checked = (bool)FormMain.Settings.config_cs["limitXZ_enable"];
            numericUpDownXzX1.Value = FormMain.Settings.config_cs["limitXZ_X1"];
            numericUpDownXzX2.Value = FormMain.Settings.config_cs["limitXZ_X2"];
            numericUpDownXzZ1.Value = FormMain.Settings.config_cs["limitXZ_Z1"];
            numericUpDownXzZ2.Value = FormMain.Settings.config_cs["limitXZ_Z2"];
            checkBoxLimitY.Checked = Convert.ToBoolean(FormMain.Settings.config_cs["limitY_enable"]);
            numericUpDownLimitY.Value = FormMain.Settings.config_cs["limitY"];
            checkBoxHeightmap.Checked = Convert.ToBoolean(FormMain.Settings.config_cs["heightmap_enable"]);
            numericUpDownHeightmapJ.Value = FormMain.Settings.config_cs["heightmap_j"];
            numericUpDownHeightmapDivider.Value = FormMain.Settings.config_cs["heightmap_divider"];
            numericUpDownHeightmapOffset.Value = FormMain.Settings.config_cs["heightmap_offset"];
            comboBoxDimension.SelectedIndex = (int)FormMain.Settings.config_cs["dimension"];
            comboBoxProfile.SelectedItem = FormMain.Settings.config_cs["profile"];
            textBoxHtmlFilename.Text = FormMain.Settings.config_cs["html_filename"];
            comboBoxImgFormat.SelectedItem = FormMain.Settings.config_cs["image_format"];
            numericUpDownImgQuality.Value = FormMain.Settings.config_cs["image_quality"];
            checkBoxForceOverwrite.Checked = Convert.ToBoolean(FormMain.Settings.config_cs["force_overwrite"]);
            checkBoxLeaflet.Checked = Convert.ToBoolean(FormMain.Settings.config_cs["leaflet"]);
            #endregion
        }

        public void FormConfigure_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;

                SaveSettings();

                this.Hide();
            }
        }

        private string BrowseExecutable(OpenFileDialog OFD, Label label)
        {
            if (OFD.ShowDialog() == DialogResult.OK && File.Exists(OFD.FileName))
            {
                label.ForeColor = Color.Green;
                label.Text = "OK!";
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
            pathExeCS = BrowseExecutable(openFile, labelStatusExeCS);

        }

        private void ButtonBrowse2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "papyrus.js executable|papyrusjs.exe";
            pathExeJS = BrowseExecutable(openFile, labelStatusExeJS);

            // FormMain.settings.config_js["executable"]
        }

        private void buttonCopyArgumentsCs_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to copy the command line arguments to your clipboard?", "Are you sure about that?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SaveSettings();
                Clipboard.SetText(FormMain.Settings.GetArguments(PapyrusVariant.PAPYRUSCS, true, Path.GetFullPath(this.FormMain.textBoxWorld.Text), Path.GetFullPath(this.FormMain.textBoxOutput.Text)));
            }
        }

        public void SaveSettings()
        {
            #region Save Settings
            #region .cs
            FormMain.Settings.config_cs["executable"] = pathExeCS;
            FormMain.Settings.config_cs["limitXZ_enable"] = checkBoxLimitXZ.Checked;
            FormMain.Settings.config_cs["limitXZ_X1"] = numericUpDownXzX1.Value;
            FormMain.Settings.config_cs["limitXZ_X2"] = numericUpDownXzX2.Value;
            FormMain.Settings.config_cs["limitXZ_Z1"] = numericUpDownXzZ1.Value;
            FormMain.Settings.config_cs["limitXZ_Z2"] = numericUpDownXzZ2.Value;
            FormMain.Settings.config_cs["limitY_enable"] = checkBoxLimitY.Checked;
            FormMain.Settings.config_cs["limitY"] = numericUpDownLimitY.Value;
            FormMain.Settings.config_cs["heightmap_enable"] = checkBoxHeightmap.Checked;
            FormMain.Settings.config_cs["heightmap_j"] = numericUpDownHeightmapJ.Value;
            FormMain.Settings.config_cs["heightmap_divider"] = numericUpDownHeightmapDivider.Value;
            FormMain.Settings.config_cs["heightmap_offset"] = numericUpDownHeightmapOffset.Value;
            FormMain.Settings.config_cs["dimension"] = comboBoxDimension.SelectedIndex;
            FormMain.Settings.config_cs["profile"] = comboBoxProfile.SelectedItem.ToString();
            FormMain.Settings.config_cs["html_filename"] = textBoxHtmlFilename.Text;
            FormMain.Settings.config_cs["image_format"] = comboBoxImgFormat.SelectedItem.ToString();
            FormMain.Settings.config_cs["image_quality"] = numericUpDownImgQuality.Value;
            FormMain.Settings.config_cs["force_overwrite"] = checkBoxForceOverwrite.Checked;
            FormMain.Settings.config_cs["leaflet"] = checkBoxLeaflet.Checked;
            #endregion
            //
            #region .js
            #endregion
            #endregion
        }

        public String GetArguments(PapyrusVariant variant)
        {
            string arguments = "";
            switch (variant)
            {
                case PapyrusVariant.PAPYRUSCS:
                    arguments = "";
                    break;

                case PapyrusVariant.PAPYRUSJS:
                    // Not available
                    break;
            }

            return arguments;
        }
    }
}
