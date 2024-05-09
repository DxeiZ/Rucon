using IWshRuntimeLibrary;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static Rucon.EffectBlur;

namespace Rucon
{
    public partial class MenuForm : Form
    {
        #region WinAPI Functions
        [DllImport("user32.dll")]
        internal static extern int SetWindowCompositionAttribute(IntPtr hwnd, ref WindowCompositionAttributeData data);

        private uint _blurOpacity;
        public double BlurOpacity
        {
            get { return _blurOpacity; }
            set { _blurOpacity = (uint)value; EnableBlur(); }
        }

        private uint _blurBackgroundColor = 0x990000;

        internal void EnableBlur()
        {
            var accent = new AccentPolicy();
            accent.AccentState = AccentState.ACCENT_ENABLE_ACRYLICBLURBEHIND;
            accent.GradientColor = (_blurOpacity << 24) | (_blurBackgroundColor & 0xFFFFFF);
            var accentStructSize = Marshal.SizeOf(accent);
            var accentPtr = Marshal.AllocHGlobal(accentStructSize);
            Marshal.StructureToPtr(accent, accentPtr, false);
            var data = new WindowCompositionAttributeData();
            data.Attribute = WindowCompositionAttribute.WCA_ACCENT_POLICY;
            data.SizeOfData = accentStructSize;
            data.Data = accentPtr;
            SetWindowCompositionAttribute(this.Handle, ref data);
            Marshal.FreeHGlobal(accentPtr);
        }

        [DllImport("dwmapi.dll")]
        internal static extern void DwmSetWindowAttribute(IntPtr hwnd,
            DWMWINDOWATTRIBUTE attribute,
            ref int pvAttribute,
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

        [DllImport("shell32.dll")]
        static extern int SHGetFolderPath(IntPtr hwndOwner, int nFolder, IntPtr hToken, uint dwFlags, [Out] StringBuilder pszPath);

        const int CSIDL_DESKTOPDIRECTORY = 0x0000;

        [DllImport("shell32.dll", CharSet = CharSet.Auto)]
        static extern int SHChangeNotify(int wEventId, int uFlags, IntPtr dwItem1, IntPtr dwItem2);

        const int SHCNE_ASSOCCHANGED = 0x08000000;
        const int SHCNF_FLUSH = 0x1000;
        #endregion
        #region Form Menu
        public MenuForm()
        {
            InitializeComponent();
            MoveFormToBottomRight();
            EnableBlur();
            int cornerPreference = (int)DWM_WINDOW_CORNER_PREFERENCE.DWMWCP_ROUNDSMALL;
            DwmSetWindowAttribute(Handle, DWMWINDOWATTRIBUTE.DWMWA_WINDOW_CORNER_PREFERENCE, ref cornerPreference, sizeof(int));
        }

        private void MoveFormToBottomRight()
        {
            Screen screen = Screen.FromControl(this);
            Rectangle workingArea = screen.WorkingArea;

            int formWidth = Width;
            int formHeight = Height;

            int newX = workingArea.Right - formWidth;
            int newY = workingArea.Bottom - formHeight;
            Location = new Point(newX - 10, newY - 10);
        }
        #endregion
        #region Main Functions
        private void CreateShortcuts(System.Collections.Specialized.StringCollection appList, System.Collections.Specialized.StringCollection checkList)
        {
            if (appList != null && checkList != null)
            {
                string desktopPaths = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                string[] files = Directory.GetFiles(desktopPaths);

                foreach (string file in files)
                {
                    if (file.EndsWith(".lnk", StringComparison.OrdinalIgnoreCase))
                    {
                        System.IO.File.Delete(file);
                    }
                }

                SHChangeNotify(SHCNE_ASSOCCHANGED, SHCNF_FLUSH, IntPtr.Zero, IntPtr.Zero);
                
                while (Directory.GetFiles(desktopPaths).Any(file => file.EndsWith(".lnk", StringComparison.OrdinalIgnoreCase))) { Thread.Sleep(100); }

                for (int i = 0; i < appList.Count; i++)
                {
                    string appFileName = appList[i];
                    bool checkStatus = bool.Parse(checkList[i]);

                    if (checkStatus)
                    {
                        string fileName = Path.GetFileNameWithoutExtension(appFileName);
                        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        string shortcutPath = Path.Combine(desktopPath, $"{fileName}.lnk");

                        if (!System.IO.File.Exists(shortcutPath))
                        {
                            WshShell shell = new WshShell();
                            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutPath);
                            shortcut.TargetPath = appFileName;
                            shortcut.Save();
                        }
                    }
                }
            }
        }

        private void siticonePictureBox1_Click(object sender, EventArgs e)
        {
            CreateShortcuts(Properties.Settings.Default.cyberAppList, Properties.Settings.Default.cyberAppCheck);
        }

        private void siticonePictureBox2_Click(object sender, EventArgs e)
        {
            CreateShortcuts(Properties.Settings.Default.devAppList, Properties.Settings.Default.devAppCheck);
        }

        private void siticonePictureBox3_Click(object sender, EventArgs e)
        {
            CreateShortcuts(Properties.Settings.Default.usrAppList, Properties.Settings.Default.usrAppCheck);
        }
        #endregion
    }
}
