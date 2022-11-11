using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreDevs_API;
using RBLXex.Helpers;
using System.Net;

namespace RBLXex
{
    public partial class Form1 : Form
    {
        private ExploitAPI api = new ExploitAPI();
        private WebClient webClient = new WebClient();

        private string robloxName = "RobloxPlayerBeta";

        private double version = 0.2;
        private string releaseType = "Alpha";
        
        private string monacoPath = Path.Combine(Application.StartupPath, @"Monaco");

        private string savedPath = Path.Combine(Application.StartupPath, @"Saved");
        private string savedExploitsPath = Path.Combine(Application.StartupPath, @"Saved\Exploits");
        private string settingsPath = Path.Combine(Application.StartupPath, @"Saved\settings.txt");

        private OpenFileDialog openDialog = new OpenFileDialog();
        private SaveFileDialog saveDialog = new SaveFileDialog { Filter = "Lua File (.lua)|*.lua|Text File (.txt)|*.txt|Any File|*" };
        
        private Point lastPoint;
        
        private bool busyAttaching = false;

        //Custom Functions
        private int SecMilli(double seconds)
        {
            return (int)Math.Round(seconds * 1000);
        }

        private int LerpInt(float from, float to, float speed)
        {
            return (int)Math.Round(from * (1 - speed) + to * speed);
        }

        private bool IsAppRunning(string appName)
        {
            if (Process.GetProcesses().Any((p) => p.ProcessName.Contains(appName))) { return true; }

            return false;
        }

        private string GetSetting(string setting)
        {
            foreach (string line in File.ReadAllLines(settingsPath))
            {
                string[] split = line.Split(new char[] { '=' });

                if (split.Length > 0)
                {
                    if (split[0] == setting)
                    {
                        return split[1];
                    }
                }
            }
            
            return "";
        }

        private void SetupIntellisense()
        {
            void RepetitiveAdding(string fileName, string kind)
            {
                foreach (string text in File.ReadLines(monacoPath + $"/{fileName}"))
                {
                    MonacoHelper.AddIntellisense(Editor, text, kind);
                }
            }

            RepetitiveAdding("globalf.txt", "Function");
            RepetitiveAdding("globalv.txt", "Variable");
            RepetitiveAdding("globalns.txt", "Class");
            RepetitiveAdding("classfunc.txt", "Method");
            RepetitiveAdding("base.txt", "Keyword");
        }

        private void ShowMessage(string msg) { 
            Task.Run(() => { MessageBox.Show(msg); }); 
        }

        private void PrepareForAttachment()
        {
            //Bypass API launch error by deleting 'finj.exe' (kinda hacky ik but it has to be done)
            //Error was "You are using an outdated version of the WeAreDevs_API"

            //Removing finj.exe fixes it somehow
            
            try { File.Delete(@".\finj.exe"); } catch { }
        }

        private void CloseProcess(string name)
        {
            //Closes any process that has the name specified

            try
            {
                Process[] processes = Process.GetProcessesByName(name);

                if (processes != null && processes.Length > 0)
                {
                    if (!processes[0].HasExited) { processes[0].Kill(); } //Get the main process and kill it

                    foreach (Process process in processes) { process.Dispose(); }
                }
            }
            catch { }
        }

        private void Attach()
        {
            ShowMessage("Attachment process has begun, this may take a while to startup");

            busyAttaching = true;
            
            PrepareForAttachment();
            api.LaunchExploit(); //Begin attaching

            while (!api.isAPIAttached()) { Thread.Sleep(25); }

            CloseProcess("finj"); //Close the annoying command prompt after attachment

            busyAttaching = false;

            ShowMessage("Attachment has finished");
        }

        //UI Events
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AttachButton_Click(object sender, EventArgs e)
        {
            if (busyAttaching) { ShowMessage("Busy attaching, please wait."); return; }
            if (!IsAppRunning(robloxName)) { ShowMessage("Cant attach without ROBLOX running."); return; }
            if (api.isAPIAttached()) { ShowMessage("Already attached to ROBLOX client."); return; }

            Task.Run(() => {
                Attach();
            });
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            void SendEditorValueToApi()
            {
                //I have to use this because it requires a switch back to the UI thread so API can run
                string script = MonacoHelper.GetCode(Editor);

                api.SendLuaScript(script);
            }

            if (busyAttaching) { ShowMessage("Busy attaching, please wait."); return; }
            if (!IsAppRunning(robloxName)) { ShowMessage("Cant attach or execute without ROBLOX running."); return; }

            Task.Run(() => {
                if (!api.isAPIAttached()) { Attach(); }

                UIHelper.SwitchToUI(this, new MethodInvoker(SendEditorValueToApi));
            });
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            MonacoHelper.SetCode(Editor, "");
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            openDialog.InitialDirectory = savedExploitsPath;

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                openDialog.Title = "Open";

                MonacoHelper.SetCode(Editor, File.ReadAllText(openDialog.FileName));
            }
        }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            saveDialog.InitialDirectory = savedExploitsPath;
            saveDialog.FileName = $"exploit_{Directory.GetFiles(savedExploitsPath, "*", SearchOption.TopDirectoryOnly).Length + 1}";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(saveDialog.FileName)) { File.Delete(saveDialog.FileName); }

                StreamWriter writer = new StreamWriter(File.Open(saveDialog.FileName, FileMode.CreateNew));
                
                writer.Write(MonacoHelper.GetCode(Editor));
                writer.Close();
            }
        }

        private void TopBar_MouseDown(object sender, MouseEventArgs mouse)
        {
            lastPoint = new Point(mouse.X, mouse.Y);
        }

        private void TopBar_MouseMove(object sender, MouseEventArgs mouse)
        {
            if (mouse.Button == MouseButtons.Left)
            {
                Top = LerpInt(Top, Top + (mouse.Y - lastPoint.Y), 0.2f);
                Left = LerpInt(Left, Left + (mouse.X - lastPoint.X), 0.2f);
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            //Create 'Saved' folder in the installation directory
            if (!Directory.Exists(savedPath)) { Directory.CreateDirectory(savedPath); }
            
            //Create 'Exploits' folder inside the 'Saved' directory
            if (!Directory.Exists(savedExploitsPath)) { Directory.CreateDirectory(savedExploitsPath); }
            
            //Create 'settings.txt' file to get app settings from
            if (!File.Exists(settingsPath)) {
                StreamWriter writer = new StreamWriter(File.Open(settingsPath, FileMode.CreateNew));

                writer.Write($"version={version}-{releaseType}");

                writer.Close();
            }

            webClient.Proxy = null;
            webClient.Headers.Add("User-Agent: Other"); //Add header to stop 403 error
            
            //Edit the registry to make sure the WebBrowser emulates a browser correctly so it renders in a modern way
            //I tried using WebView2 but it didnt work properly so I have to use stupid WebBrowser that is inneficient and uses alot more memory
            //also WebView2 was more difficult to get info out of so

            try
            {
                //Get the registry key
                RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Internet Explorer\\Main\\FeatureControl\\FEATURE_BROWSER_EMULATION", true);
                
                string friendlyName = AppDomain.CurrentDomain.FriendlyName;
                bool flag2 = key.GetValue(friendlyName) == null;

                if (flag2)
                {
                    key.SetValue(friendlyName, 11001, RegistryValueKind.DWord); //Set the registry
                }
            } catch {}
            
            Editor.Url = new Uri(string.Format(monacoPath + "/index.html", Directory.GetCurrentDirectory()));

            await Task.Delay(SecMilli(0.2)); //Wait 0.2 seconds so website can load up
            
            SetupIntellisense();
        }

        public Form1()
        {
            InitializeComponent();

            UIHelper.RoundEdges(this, this.CreateGraphics());
        }

        private void OpenFileButton_Paint(object sender, PaintEventArgs e) { UIHelper.RoundEdges(OpenFileButton, e.Graphics); }
        private void SaveFileButton_Paint(object sender, PaintEventArgs e) { UIHelper.RoundEdges(SaveFileButton, e.Graphics); }
        private void MinimizeButton_Paint(object sender, PaintEventArgs e) { UIHelper.RoundEdges(MinimizeButton, e.Graphics); }
        private void CloseButton_Paint(object sender, PaintEventArgs e) { UIHelper.RoundEdges(CloseButton, e.Graphics); }
    }
}