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
        public delegate void UpdateHandler(string stdOut);
        public UpdateHandler UHandler;
        public FormConfigure formConfigure;
        public static AppSettings Settings;
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
                Settings = JsonConvert.DeserializeObject<AppSettings>(File.ReadAllText(configProfile));
                comboBoxVersion.SelectedIndex = (int)Settings.config["variant"];
                textBoxWorld.Text = Settings.config["world"];
                textBoxOutput.Text = Settings.config["output"];
            } else
            {
                Settings = new AppSettings();
            }

            formConfigure = new FormConfigure();
        }

        private void CloseApplication(object sender, EventArgs e)
        {
            Settings.config["variant"] = comboBoxVersion.SelectedIndex;
            using (StreamWriter streamWriter = new StreamWriter(@".\configuration.json", false))
            {
                streamWriter.Write(JsonConvert.SerializeObject(Settings));
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            formConfigure.Show();
        }
        private void ButtonSelect1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserInput = new FolderBrowserDialog();

            if (folderBrowserInput.ShowDialog() == DialogResult.OK)
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
            Settings.config["world"] = textBoxWorld.Text;
            Settings.config["output"] = textBoxOutput.Text;

            if (Directory.Exists(textBoxWorld.Text.ToString()) && Directory.Exists(textBoxOutput.Text.ToString()))
            {
                switch (comboBoxVersion.SelectedIndex)
                {
                    // .cs
                    case 0:
                        UHandler = UpdateConsole;

                        //var renderThread = new RenderThread(this, String.Format(@"-w {0} -o {1}", Path.GetFullPath(textBoxWorld.Text.ToString()), Path.GetFullPath(textBoxOutput.Text.ToString())));
                        String[] additionalArgs = new String[2];

                        if (Settings.config_cs["profile"].ToLower() != "default")
                        {
                            additionalArgs[0] = String.Format("--profile {0}", Settings.config_cs["profile"].ToLower());
                        }

                        if (Settings.config_cs["limitXZ_enable"])
                        {
                            additionalArgs[1] = String.Format("--limitx {0},{1} --limitz {2},{3}", Settings.config_cs["limitXZ_X1"], Settings.config_cs["limitXZ_X2"], Settings.config_cs["limitXZ_Z1"], Settings.config_cs["limitXZ_Z2"]);
                        }

                        string arguments = String.Format("-w \"{0}\" -o \"{1}\" --dim {2} -f {3} {4} --brillouin_j {5} --brillouin_divider {6} --brillouin_offset {7} --forceoverwrite {8} --use_leaflet_legacy {9} --htmlfile {10} {11} {12}", Path.GetFullPath(textBoxWorld.Text.ToString()), Path.GetFullPath(textBoxOutput.Text.ToString()), Settings.config_cs["dimension"], Settings.config_cs["image_format"].ToString().ToLower(), Settings.config_cs["image_quality"], Settings.config_cs["heightmap_j"], Settings.config_cs["heightmap_divider"], Settings.config_cs["heightmap_offset"], Settings.config_cs["force_overwrite"], Settings.config_cs["leaflet"], Settings.config_cs["html_filename"], additionalArgs[0], additionalArgs[1]);

                        Thread renderThread = new Thread(new ThreadStart(() =>
                        {
                            Process process = new Process();
                            process.StartInfo.FileName = FormMain.Settings.config_cs["executable"];
                            process.StartInfo.Arguments = arguments;
                            process.StartInfo.UseShellExecute = false;
                            process.StartInfo.RedirectStandardOutput = true;
                            process.StartInfo.CreateNoWindow = true;
                            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                            process.Start();

                            process.BeginOutputReadLine();

                            process.OutputDataReceived += (object threadSender, DataReceivedEventArgs eArgs) => { this.UHandler?.Invoke(eArgs.Data); };
                        }));
                        renderThread.Start();

                        // MessageBox.Show(FormMain.Settings.config_cs["executable"] + " " + arguments);

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
    }

    internal class RenderThread
    {
        public RenderThread(FormMain handle, string arguments)
        {
            

        }
    }

    public class AppSettings
    {
        public Dictionary<string, dynamic> config = new Dictionary<string, dynamic>();
        public Dictionary<string, dynamic> config_cs = new Dictionary<string, dynamic>();

        public AppSettings()
        {
            // Global config
            this.config["variant"] = 0;
            this.config["world"] = @"C:/Users/%username%/AppData/Local/Packages/Microsoft.MinecraftUWP_8wekyb3d8bbwe/LocalState/games/com.mojang/minecraftWorlds/";
            this.config["output"] = "";
            
            // papyrus.cs config
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
