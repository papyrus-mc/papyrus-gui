using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Reflection;

namespace papyrus_gui
{
    public partial class FormMain: Form
    {
        public delegate void ConsoleHandler(string stdOut);
        public ConsoleHandler updateConsole;

        public FormMain()
        {
            InitializeComponent();
            comboBoxVersion.SelectedIndex = 0;
            textBox1.Text = @":\Users\%username%\AppData\Local\Packages\Microsoft.MinecraftUWP_8wekyb3d8bbwe\LocalState\games\com.mojang\minecraftWorlds\";
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
                folderBrowserInput.SelectedPath = @"C:\Users\%username%\AppData\Local\Packages\Microsoft.MinecraftUWP_8wekyb3d8bbwe\LocalState\games\com.mojang\minecraftWorlds\";
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
            if (Directory.Exists(textBox1.Text.ToString()) && Directory.Exists(textBox2.Text.ToString()))
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
            richTextBoxConsoleOutput.Text += "\n" + stdOut;
        }

        private void renderCS()
        {
            var renderThread = new RenderThread(this, String.Format(@"-w {0} -o {1}", Path.GetFullPath(textBox1.Text.ToString()), Path.GetFullPath(textBox2.Text.ToString())));
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var formConfigure = new FormConfigure();
            formConfigure.Show();
        }

        private void AboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("papyrus.gui version {0} by clarkx86 & DeepBlue4200", Assembly.GetExecutingAssembly().GetName().Version), "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DiscordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://discordapp.com/invite/J2sBaXa");
        }
    }

    public class RenderThread
    {
        private FormMain mainForm;
        private Process process;

        public RenderThread(FormMain mainForm, string arguments)
        {
            this.mainForm = mainForm;

            process = new Process();
            process.StartInfo.FileName = FormConfigure.pathExeCS;
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
}
