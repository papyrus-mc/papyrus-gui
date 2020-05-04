using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Reflection;
using Newtonsoft.Json;
using System.Timers;
using System.Net;
using System.Text.RegularExpressions;

namespace papyrus_gui
{
    public enum ProcessingStatus
    {
        IDLE,
        RENDERING,
        CANCELED,
        FINISHED
    }

    public enum PapyrusVariant
    {
        PAPYRUSCS,
        PAPYRUSJS
    }

    public partial class FormMain : Form
    {
        public delegate void UpdateHandler(string stdOut);
        public delegate void ProcessExitedHandler(int exitCode);
        public UpdateHandler UHandler;
        public ProcessExitedHandler ProcessExitHandler;
        public FormConfigure formConfigure;
        public static AppSettings Settings;
        public static string AppVersion = String.Format("{0}.{1}.{2}", Assembly.GetExecutingAssembly().GetName().Version.Major, Assembly.GetExecutingAssembly().GetName().Version.Minor, Assembly.GetExecutingAssembly().GetName().Version.Revision);
        private LogContent _logContent;
        private ProcessingStatus _status = ProcessingStatus.IDLE;
        public Process _renderProcess;
        private uint _uiRefreshTickingRate = 500;

        public FormMain()
        {
            InitializeComponent();

            this.Text = String.Format("{0} v{1}", this.Text, AppVersion);
            _logContent = new LogContent(32);

            comboBoxVersion.SelectedIndex = 0;
            textBoxWorld.Text = @"C:\Users\%username%\AppData\Local\Packages\Microsoft.MinecraftUWP_8wekyb3d8bbwe\LocalState\games\com.mojang\minecraftWorlds";
            // Application.ApplicationExit += CloseApplication;
            this.FormClosing += CloseApplication;

            System.Timers.Timer checkForUpdateTimer = new System.Timers.Timer(1000);
            checkForUpdateTimer.AutoReset = false;

            // Load settings
            string configProfile = @".\configuration.json";
            if (File.Exists(configProfile))
            {
                using (StreamReader streamReader = new StreamReader(new FileStream(configProfile, FileMode.Open, FileAccess.Read)))
                {
                    Settings = JsonConvert.DeserializeObject<AppSettings>(streamReader.ReadToEnd());
                }

                comboBoxVersion.SelectedIndex = (int)Settings.config["variant"];
                textBoxWorld.Text = Settings.config["world"];
                textBoxOutput.Text = Settings.config["output"];
            } else
            {
                Settings = new AppSettings();

                checkForUpdateTimer.Elapsed += (object sender, ElapsedEventArgs e) => { Settings.config["checkForUpdatesOnStartup"] = (MessageBox.Show("Do you want to automatically check for updates when this application starts?", "Check for updates on startup?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes ? true : false); };
            }


            checkForUpdateTimer.Elapsed += (object sender, ElapsedEventArgs e) => {
                if ((bool)Settings.config["checkForUpdatesOnStartup"])
                {
                    UpdateCheck(false);
                }
            };

            System.Timers.Timer statusCheckTimer = new System.Timers.Timer(_uiRefreshTickingRate);
            statusCheckTimer.AutoReset = true;
            statusCheckTimer.Elapsed += (object sender, ElapsedEventArgs e) =>
            {
                buttonRender.Text = "Start rendering!";
                switch (_status)
                {
                    case ProcessingStatus.IDLE:
                        statusLabel.Text = "Waiting";
                        break;

                    case ProcessingStatus.RENDERING:
                        statusLabel.Text = "Rendering";
                        buttonRender.Text = "STOP RENDERING!";
                        break;

                    case ProcessingStatus.FINISHED:
                        statusLabel.Text = "Finished";
                        break;

                    case ProcessingStatus.CANCELED:
                        statusLabel.Text = "Canceled";
                        break;
                }
            };
            statusCheckTimer.Start();
            checkForUpdateTimer.Start();

            formConfigure = new FormConfigure(this);
        }

        public void UpdateCheck(bool notifyLatest)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"https://api.github.com/repos/clarkx86/papyrus-gui/releases/latest");
            request.UserAgent = "papyrus-gui";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                dynamic jsonResponse;
                using (StreamReader streamReader = new StreamReader(response.GetResponseStream()))
                {
                    jsonResponse = JsonConvert.DeserializeObject(streamReader.ReadToEnd());
                }

                Match remoteTag = Regex.Match((string)jsonResponse["tag_name"], @"^v?(\d+).(\d+).(\d+)");
                //MessageBox.Show((string)json["tag_name"] + "\nCaptures: " + remoteTag[0].Groups.Count);
                // MessageBox.Show(Convert.ToString(remoteTag[0].Groups.Count));

                if (remoteTag.Groups.Count > 3)
                {
                    Version assemblyVersion = Assembly.GetExecutingAssembly().GetName().Version;
                    Version localVersion = new Version(assemblyVersion.Major, assemblyVersion.Minor, 0, assemblyVersion.Revision);
                    Version remoteVersion = new Version(Convert.ToInt32(remoteTag.Groups[1].Value), Convert.ToInt32(remoteTag.Groups[2].Value), 0, Convert.ToInt32(remoteTag.Groups[3].Value));
                    // MessageBox.Show(remoteVersion.ToString());


                    if (remoteVersion > localVersion)
                    {
                        if (MessageBox.Show(String.Format("A new update is available!\n\nLocal version: {0}\nRemote version: {1}\n\nDo you want to download the update? This will open a link in your browser.", FormatVersion(localVersion), FormatVersion(remoteVersion)), "Update available", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            Process.Start(@"https://github.com/clarkx86/papyrus-gui/releases/latest");
                        }
                    } else if (notifyLatest)
                    {
                        MessageBox.Show("You already have the latest version!", "No new updates", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                } else
                {
                    MessageBox.Show("Could not check for updates: Invalid remote version.");
                }
            } else
            {
                MessageBox.Show(String.Format("Failed to check for updates.\nResponse code: {0}", ((HttpWebResponse)response).StatusCode));
            }

            response.Close();
        }

        private string FormatVersion(Version version)
        {
            return String.Format("{0}.{1}.{2}", version.Major, version.Minor, version.Revision);
        }

        private void CloseApplication(object sender, FormClosingEventArgs e)
        {
            if (_status == ProcessingStatus.RENDERING)
            {
                e.Cancel = !PromptCancelConfirmation();
            } else
            {
                Settings.config["variant"] = comboBoxVersion.SelectedIndex;
                using (StreamWriter streamWriter = new StreamWriter(@".\configuration.json", false))
                {
                    streamWriter.Write(JsonConvert.SerializeObject(Settings, Formatting.Indented));
                }
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
            switch (_status)
            {
                case ProcessingStatus.RENDERING:
                    PromptCancelConfirmation();
                    break;
                default:
                    Settings.config["world"] = textBoxWorld.Text;
                    Settings.config["output"] = textBoxOutput.Text;

                    if (Directory.Exists(textBoxWorld.Text.ToString()) && Directory.Exists(textBoxOutput.Text.ToString()))
                    {
                        switch (comboBoxVersion.SelectedIndex)
                        {
                            // .cs
                            case 0:
                                UHandler = UpdateConsole;
                                ProcessExitHandler = ProcessExited;

                                Thread renderThread = new Thread(new ThreadStart(() =>
                                {
                                    _renderProcess = new Process();
                                    _renderProcess.StartInfo.FileName = FormMain.Settings.config_cs["executable"];
                                    _renderProcess.StartInfo.Arguments = FormMain.Settings.GetArguments(PapyrusVariant.PAPYRUSCS, false, Path.GetFullPath(textBoxWorld.Text.ToString()), Path.GetFullPath(textBoxOutput.Text.ToString()));
                                    _renderProcess.StartInfo.UseShellExecute = false;
                                    _renderProcess.StartInfo.RedirectStandardOutput = true;
                                    _renderProcess.StartInfo.CreateNoWindow = true;
                                    _renderProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                                    _renderProcess.Start();

                                    _renderProcess.BeginOutputReadLine();

                                    // _renderProcess.Exited += (object threadSender, EventArgs eArgs) => { this.ProcessExitHandler?.Invoke(_renderProcess.ExitCode); };
                                    _renderProcess.OutputDataReceived += (object threadSender, DataReceivedEventArgs eArgs) => { this.UHandler?.Invoke(eArgs.Data); };

                                    _renderProcess.WaitForExit();
                                    ProcessExitHandler?.Invoke(_renderProcess.ExitCode);
                                    _renderProcess.Close();
                                }));

                                _logContent.Clear();
                                renderThread.Start();
                                _status = ProcessingStatus.RENDERING;
                                break;

                            // .js
                            case 1:
                                // Not available
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("World and/ or output directory is invalid or does not exist.", "Invalid directory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
            }
        }

        private bool PromptCancelConfirmation()
        {
            bool result = false;
            if (MessageBox.Show("A rendering process is still running. Do you really want to cancel?", "Are you sure about that?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    _renderProcess.Kill();
                    _logContent.Append("\nRendering process canceled by user.");
                    _status = ProcessingStatus.CANCELED;

                    result = true;
                }
                catch
                {
                    MessageBox.Show("Could not cancel rendering process.");
                }
            }

            return result;
        }

        public void UpdateConsole(string stdOut)
        {

            if (checkBoxEnableConsoleOutput.Checked)
            {
                _logContent.Append(stdOut);
                richTextBoxConsoleOutput.Lines = _logContent.Lines;
                richTextBoxConsoleOutput.SelectionStart = richTextBoxConsoleOutput.TextLength;
                richTextBoxConsoleOutput.ScrollToCaret();
            }
        }

        public void ProcessExited(int exitCode)
        {
            if (exitCode == 0)
            {
                _status = ProcessingStatus.FINISHED;
            }
            else
            {
                _status = ProcessingStatus.CANCELED;
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
        private void DiscordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PromptOpenLink(@"https://discordapp.com/invite/J2sBaXa");
        }
        private void AboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("papyrus.gui version {0} build {1} by clarkx86 & DeepBlue", AppVersion, Assembly.GetExecutingAssembly().GetName().Version.Build), "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBoxEnableConsoleOutput_CheckedChanged(object sender, EventArgs e)
        {
            richTextBoxConsoleOutput.Enabled = checkBoxEnableConsoleOutput.Checked;

            switch (checkBoxEnableConsoleOutput.Checked)
            {
                case false:
                    richTextBoxConsoleOutput.Enabled = false;
                    richTextBoxConsoleOutput.Text = "Console output disabled";
                    break;

                case true:
                    richTextBoxConsoleOutput.Enabled = true;
                    richTextBoxConsoleOutput.Lines = _logContent.Lines;
                    break;
            }
        }

        private void papyrusCSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PromptOpenLink(@"https://github.com/mjungnickel18/papyruscs/releases/latest");
        }

        private void papyrusjsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PromptOpenLink(@"https://github.com/clarkx86/papyrusjs/releases/latest");
        }

        public static bool PromptOpenLink(string url)
        {
            bool result = false;

            if (MessageBox.Show(String.Format("This will open the following link in your browser:\n\n{0}\n\nDo you want to proceed?", url), "Are you sure about that?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Process.Start(url);
                result = true;
            }

            return result;
        }

        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateCheck(true);
        }
    }
}
