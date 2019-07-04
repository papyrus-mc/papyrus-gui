using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Reflection;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace papyrus_gui
{
    public partial class FormMain: Form
    {
        public delegate void ConsoleHandler(string stdOut);
        public ConsoleHandler updateConsole;
        public FormConfigure formConfigure;
        public static Settings settings;
        public static string AppVersion = String.Format("{0}.{1}.{2}", Assembly.GetExecutingAssembly().GetName().Version.Major, Assembly.GetExecutingAssembly().GetName().Version.Minor, Assembly.GetExecutingAssembly().GetName().Version.Build);

        public FormMain()
        {
            InitializeComponent();
            this.Text = this.Text + " v" + AppVersion;
            comboBoxVersion.SelectedIndex = 0;
            textBoxWorld.Text = @":\Users\%username%\AppData\Local\Packages\Microsoft.MinecraftUWP_8wekyb3d8bbwe\LocalState\games\com.mojang\minecraftWorlds\";
            Application.ApplicationExit += new EventHandler(CloseApplication);

            // Load settings
            var configProfile = @".\configuration.json";
            if (File.Exists(configProfile))
            {
                settings = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(configProfile));
                comboBoxVersion.SelectedIndex = (int)settings.config["variant"];
                textBoxWorld.Text = settings.config["world"];
                textBoxOutput.Text = settings.config["output"];
            } else
            {
                settings = new Settings();
            }
            formConfigure = new FormConfigure();
        }

        private void CloseApplication(object sender, EventArgs e)
        {
            settings.config["variant"] = comboBoxVersion.SelectedIndex;
            using (StreamWriter streamWriter = new StreamWriter(@".\configuration.json", false))
            {
                streamWriter.Write(JsonConvert.SerializeObject(settings));
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            formConfigure.Show();
        }
        private void ButtonSelect1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserInput = new FolderBrowserDialog();

            if ( folderBrowserInput.ShowDialog() == DialogResult.OK )
            {
                textBoxWorld.Text = folderBrowserInput.SelectedPath;
                //settings.config["world"] = textBoxWorld.Text;
            }
        }
        private void ButtonSelect2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserOutput = new FolderBrowserDialog();

            if (folderBrowserOutput.ShowDialog() == DialogResult.OK)
            {
                textBoxOutput.Text = folderBrowserOutput.SelectedPath;
                //settings.config["output"] = textBoxOutput.Text;
            }
        }
        private void ButtonRender_Click(object sender, EventArgs e)
        {
            settings.config["world"] = textBoxWorld.Text;
            settings.config["output"] = textBoxOutput.Text;

            if (Directory.Exists(textBoxWorld.Text.ToString()) && Directory.Exists(textBoxOutput.Text.ToString()))
            {
                switch (comboBoxVersion.SelectedIndex)
                {
                    // .cs
                    case 0:
                        updateConsole = new ConsoleHandler(UpdateConsole);

                        var threadRender = new Thread(new ThreadStart(renderCS));
                        threadRender.Start();
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
        public void UpdateConsole(string stdOut)
        {
            richTextBoxConsoleOutput.Text += stdOut + "\n";
            richTextBoxConsoleOutput.SelectionStart = richTextBoxConsoleOutput.Text.Length;
            richTextBoxConsoleOutput.ScrollToCaret();
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DiscordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://discordapp.com/invite/J2sBaXa");
        }
        private void AboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("papyrus.gui version {0} by clarkx86 & DeepBlue4200", AppVersion, "About", MessageBoxButtons.OK, MessageBoxIcon.Information));
        }
        private void renderCS()
        {
            //var renderThread = new RenderThread(this, String.Format(@"-w {0} -o {1}", Path.GetFullPath(textBoxWorld.Text.ToString()), Path.GetFullPath(textBoxOutput.Text.ToString())));
            string argumentProfile = "";

            if (settings.config_cs["profile"].ToLower() != "default")
            {
                argumentProfile = String.Format("--profile {0}", settings.config_cs["profile"].ToLower());
            }

            string arguments = String.Format(@"-w {0} -o {1} --dim {2} -f {3} {4} --brillouin_j {5} --brillouin_divider {6} --brillouin_offset {7} --forceoverwrite {8} --use_leaflet_legacy {9} --htmlfile {10} {11}", Path.GetFullPath(textBoxWorld.Text.ToString()), Path.GetFullPath(textBoxOutput.Text.ToString()), settings.config_cs["dimension"], settings.config_cs["image_format"].ToString().ToLower(), settings.config_cs["image_quality"], settings.config_cs["heightmap_j"], settings.config_cs["heightmap_divider"], settings.config_cs["heightmap_offset"], settings.config_cs["force_overwrite"], settings.config_cs["leaflet"], settings.config_cs["html_filename"], argumentProfile);
            var renderThread = new RenderThread(this, arguments);
            //MessageBox.Show(FormMain.settings.config_cs["executable"] + " " + arguments);
        }

    }

    internal class RenderThread
    {
        private FormMain mainForm;
        private Process process;

        public RenderThread(FormMain mainForm, string arguments)
        {
            this.mainForm = mainForm;

            process = new Process();
            process.StartInfo.FileName = FormMain.settings.config_cs["executable"];
            process.StartInfo.Arguments = arguments;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.Start();

            process.BeginOutputReadLine();

            process.OutputDataReceived += InvokeUpdate;

        }

        private void InvokeUpdate(object sender, DataReceivedEventArgs e)
        {
            mainForm.Invoke(mainForm.updateConsole, e.Data);
        }
    }

    public class Settings
    {
        public Dictionary<string, dynamic> config = new Dictionary<string, dynamic>();
        public Dictionary<string, dynamic> config_cs = new Dictionary<string, dynamic>();

        public Settings()
        {
            this.config["variant"] = 0;
            this.config["world"] = @"C:/Users/%username%/AppData/Local/Packages/Microsoft.MinecraftUWP_8wekyb3d8bbwe/LocalState/games/com.mojang/minecraftWorlds/";
            this.config["output"] = "";
            //
            this.config_cs["executable"] = "";
            this.config_cs["limitXZ_enable"] = false;
            this.config_cs["limitXZ_X1"] = 0;
            this.config_cs["limitXZ_X2"] = 0;
            this.config_cs["limitXZ_Z1"] = 0;
            this.config_cs["limitXZ_Z2"] = 0;
            this.config_cs["limitY_enable"] = false;
            this.config_cs["limitY"] = 64;
            this.config_cs["heightmap_enable"] = true;
            this.config_cs["heightmap_j"] = 10000;
            this.config_cs["heightmap_divider"] = 20;
            this.config_cs["heightmap_offset"] = 64;
            this.config_cs["dimension"] = 0;
            this.config_cs["profile"] = "Default";
            this.config_cs["html_filename"] = "index.html";
            this.config_cs["image_format"] = "PNG";
            this.config_cs["image_quality"] = 100;
            this.config_cs["force_overwrite"] = false;
            this.config_cs["leaflet"] = false;
        }
    }
}
