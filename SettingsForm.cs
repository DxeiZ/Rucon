using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Rucon
{
    public partial class SettingsForm : Form
    {
        #region WinAPI Functions
        [DllImport("dwmapi.dll", EntryPoint = "DwmSetWindowAttribute")]
        public static extern void DwmSetWindowAttribute(IntPtr hwnd,
            DWMWINDOWATTRIBUTE attribute,
            DWM_WINDOW_CORNER_PREFERENCE pvAttribute,
            uint cbAttribute);

        public enum DWMWINDOWATTRIBUTE
        {
            DWMWA_WINDOW_CORNER_PREFERENCE = 33
        }

        public enum DWM_WINDOW_CORNER_PREFERENCE
        {
            DWMWCP_DEFAULT = 0,
            DWMWCP_DONOTROUND = 1,
            DWMWCP_ROUND = 2,
            DWMWCP_ROUNDSMALL = 3
        }
        #endregion
        #region Form Settings
        public SettingsForm()
        {
            InitializeComponent();
            LoadCyber();
            LoadDev();
            LoadUsr();
        }
        #endregion
        #region Context Menu
        private bool isMenuVisible = false;

        private void ToggleMenuVisibility()
        {
            Hide();
            if (!isMenuVisible)
            {
                new MenuForm().Show();
                isMenuVisible = true;
            }
        }

        private void siticoneGradientButton1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            ToggleMenuVisibility();
        }
        private void stgsStripMenuItem_Click(object sender, EventArgs e) => Show();
        private void clseStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();
        private void siticoneGradientButton2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            checkedListBox1.Items.Clear();
            checkedListBox2.Items.Clear();
            checkedListBox3.Items.Clear();
            siticonePictureBox1.Visible = siticonePictureBox2.Visible = siticonePictureBox3.Visible = true;
            checkedListBox1.Enabled = checkedListBox2.Enabled = checkedListBox3.Enabled = false;
        }

        #endregion
        #region Cyber Interface
        private List<string> cyberNames = new List<string>();
        private List<bool> cyberChecks = new List<bool>();
        private void LoadCyber()
        {
            cyberNames.Clear();
            cyberChecks.Clear();
            if (Properties.Settings.Default.cyberAppList != null && Properties.Settings.Default.cyberAppCheck != null)
            {
                for (int i = 0; i < Properties.Settings.Default.cyberAppList.Count; i++)
                {
                    string appPath = Properties.Settings.Default.cyberAppList[i];
                    string appName = Path.GetFileNameWithoutExtension(appPath);

                    bool isChecked = false;
                    if (Properties.Settings.Default.cyberAppCheck.Count > i && Properties.Settings.Default.cyberAppCheck[i] != null)
                    {
                        bool.TryParse(Properties.Settings.Default.cyberAppCheck[i], out isChecked);
                    }

                    cyberNames.Add(appName);
                    cyberChecks.Add(isChecked);

                    checkedListBox1.Items.Add(appName, isChecked);

                    siticonePictureBox1.Visible = false;
                    checkedListBox1.Enabled = true;
                }
            }
        }
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index >= 0 && e.Index < cyberChecks.Count)
            {
                cyberChecks[e.Index] = e.NewValue == CheckState.Checked;

                Properties.Settings.Default.cyberAppCheck[e.Index] = cyberChecks[e.Index].ToString();
            }
        }
        private void cyberAppBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog.Filter = "Uygulama Dosyaları (*.exe)|*.exe";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName);

                if (Properties.Settings.Default.cyberAppList == null)
                {
                    Properties.Settings.Default.cyberAppList = new System.Collections.Specialized.StringCollection();
                }

                if (Properties.Settings.Default.cyberAppCheck == null)
                {
                    Properties.Settings.Default.cyberAppCheck = new System.Collections.Specialized.StringCollection();
                }

                if (!cyberNames.Contains(fileName))
                {
                    cyberNames.Add(fileName);
                    cyberChecks.Add(true);

                    Properties.Settings.Default.cyberAppList.Add(openFileDialog.FileName);
                    Properties.Settings.Default.cyberAppCheck.Add("True");

                    checkedListBox1.Items.Add(fileName, true);

                    siticonePictureBox1.Visible = false;
                    checkedListBox1.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Bu uygulama zaten listede var!");
                }
            }
        }
        #endregion
        #region Developer Interface
        private List<string> devNames = new List<string>();
        private List<bool> devChecks = new List<bool>();
        private void LoadDev()
        {
            devNames.Clear();
            devChecks.Clear();
            if (Properties.Settings.Default.devAppList != null && Properties.Settings.Default.devAppCheck != null)
            {
                for (int i = 0; i < Properties.Settings.Default.devAppList.Count; i++)
                {
                    string appPath = Properties.Settings.Default.devAppList[i];
                    string appName = Path.GetFileNameWithoutExtension(appPath);

                    bool isChecked = false;
                    if (Properties.Settings.Default.devAppCheck.Count > i && Properties.Settings.Default.devAppCheck[i] != null)
                    {
                        bool.TryParse(Properties.Settings.Default.devAppCheck[i], out isChecked);
                    }

                    devNames.Add(appName);
                    devChecks.Add(isChecked);

                    checkedListBox2.Items.Add(appName, isChecked);

                    siticonePictureBox2.Visible = false;
                    checkedListBox2.Enabled = true;
                }
            }
        }
        private void checkedListBox2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index >= 0 && e.Index < devChecks.Count)
            {
                devChecks[e.Index] = e.NewValue == CheckState.Checked;

                Properties.Settings.Default.devAppCheck[e.Index] = devChecks[e.Index].ToString();
            }
        }
        private void devAppBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog.Filter = "Uygulama Dosyaları (*.exe)|*.exe";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName);

                if (Properties.Settings.Default.devAppList == null)
                {
                    Properties.Settings.Default.devAppList = new System.Collections.Specialized.StringCollection();
                }

                if (Properties.Settings.Default.devAppCheck == null)
                {
                    Properties.Settings.Default.devAppCheck = new System.Collections.Specialized.StringCollection();
                }

                if (!devNames.Contains(fileName))
                {
                    devNames.Add(fileName);
                    devChecks.Add(true);

                    Properties.Settings.Default.devAppList.Add(openFileDialog.FileName);
                    Properties.Settings.Default.devAppCheck.Add("True");

                    checkedListBox2.Items.Add(fileName, true);

                    siticonePictureBox2.Visible = false;
                    checkedListBox2.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Bu uygulama zaten listede var!");
                }
            }
        }
        #endregion
        #region User Interface
        private List<string> usrNames = new List<string>();
        private List<bool> usrChecks = new List<bool>();

        private void LoadUsr()
        {
            usrNames.Clear();
            usrChecks.Clear();

            var usrAppList = Properties.Settings.Default.usrAppList;
            var usrAppCheck = Properties.Settings.Default.usrAppCheck;

            if (usrAppList != null && usrAppCheck != null)
            {
                for (int i = 0; i < usrAppList.Count; i++)
                {
                    string appPath = usrAppList[i];
                    string appName = Path.GetFileNameWithoutExtension(appPath);

                    bool isChecked = false;
                    if (i < usrAppCheck.Count && bool.TryParse(usrAppCheck[i], out isChecked))
                    {
                        usrNames.Add(appName);
                        usrChecks.Add(isChecked);
                        checkedListBox3.Items.Add(appName, isChecked);
                    }

                    siticonePictureBox3.Visible = false;
                    checkedListBox3.Enabled = true;
                }
            }
        }

        private void checkedListBox3_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index >= 0 && e.Index < usrChecks.Count)
            {
                usrChecks[e.Index] = e.NewValue == CheckState.Checked;
                Properties.Settings.Default.usrAppCheck[e.Index] = usrChecks[e.Index].ToString();
            }
        }

        private void usrAppBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog.Filter = "Uygulama Dosyaları (*.exe)|*.exe";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName);

                if (!usrNames.Contains(fileName))
                {
                    usrNames.Add(fileName);
                    usrChecks.Add(true);

                    Properties.Settings.Default.usrAppList.Add(openFileDialog.FileName);
                    Properties.Settings.Default.usrAppCheck.Add("True");

                    checkedListBox3.Items.Add(fileName, true);
                }
                else
                {
                    MessageBox.Show("Bu uygulama zaten listede var!");
                }
            }

            siticonePictureBox3.Visible = false;
            checkedListBox3.Enabled = true;
        }
        #endregion
    }
}
