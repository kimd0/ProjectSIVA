using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SIVA
{
    public partial class MainForm : Form
    {
        private readonly string inipath = Environment.CurrentDirectory + "\\settings.ini";
        private bool Active;
        private Thread Aimbot;
        private int[] aimPosVal;
        private int[] aimSpdVal;
        private int aimHumVal;
        private int AimX;
        private int AimY;
        private protected LowLevel MyLowLevel = new LowLevel();
        private int Resolution;
        private string[] search;
        private int[] searchVal;
        private int searchX;
        private int searchX1;
        private int searchX2;
        private int searchY;
        private int searchY1;
        private int searchY2;
        private Random RandomAim = new Random();


        public MainForm()
        {
            InitializeComponent();
            MyLowLevel.Setting();
        }

        [DllImport("crashhandler.dll")]
        private static extern IntPtr ImageSearch(int x, int y, int right, int bottom,
            [MarshalAs(UnmanagedType.LPStr)] string imagePath);

        [DllImport("kernel32.dll")]
        public static extern bool Beep(int n, int m);

        [DllImport("user32.dll")]
        private static extern int RegisterHotKey(int hwnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")]
        private static extern int UnregisterHotKey(int hwnd, int id);

        [DllImport("user32.dll")]
        private static extern bool GetAsyncKeyState(Keys vKey);

        [DllImport("kernel32.dll")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal,
            int size, string filePath);

        private void Form1_Load(object sender, EventArgs e)
        {
            RegisterHotKey((int) Handle, 0, 0x0, (int) Keys.F4);
            RegisterHotKey((int) Handle, 1, 0x0, (int) Keys.PageDown);
            RegisterHotKey((int) Handle, 2, 0x0, (int) Keys.PageUp);

            Resolution = Screen.PrimaryScreen.Bounds.Height;

            if (Resolution == 1080 || Resolution == 1440)
            {
                AimSpdX.Text = readSetting("AimSpeedX", inipath);
                AimSpdY.Text = readSetting("AimSpeedY", inipath);
                Left.Text = readSetting("Left", inipath);
                Right.Text = readSetting("Right", inipath);
                Top.Text = readSetting("Top", inipath);
                Bottom.Text = readSetting("Bottom", inipath);
                Force.Text = readSetting("Force", inipath);
                AimPosX.Text = readSetting("AimPositionX", inipath);
                AimPosY.Text = readSetting("AimPositionY", inipath);
                HumanStrength.Text = readSetting("HumanizerStrength", inipath);
                ResText.Text = Resolution + "P";
            }
            else
            {
                MessageBox.Show("Sorry. Currently supports FHD and QHD resolutions.", "Load Error");
                Application.Exit();
            }

            aimPosVal = new[] {int.Parse(AimPosX.Text), int.Parse(AimPosY.Text)};
            aimSpdVal = new[] {int.Parse(AimSpdX.Text), int.Parse(AimSpdY.Text)};
            aimHumVal = int.Parse(HumanStrength.Text);

            searchVal = new[]
            {
                int.Parse(Left.Text), int.Parse(Top.Text), int.Parse(Right.Text), int.Parse(Bottom.Text),
                int.Parse(Force.Text)
            };

            Active = false;
            searchX1 = searchVal[0];
            searchY1 = searchVal[1];
            searchX2 = searchVal[2];
            searchY2 = searchVal[3];

            Horizontal.Minimum = 0;
            Horizontal.Maximum = Screen.PrimaryScreen.Bounds.Width / 2;
            Horizontal.Value = (int.Parse(Right.Text) - int.Parse(Left.Text)) / 2;

            Vertical.Minimum = 0;
            Vertical.Maximum = Screen.PrimaryScreen.Bounds.Height / 2;
            Vertical.Value = Vertical.Maximum - int.Parse(Top.Text);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKey((int) Handle, 0);
            UnregisterHotKey((int) Handle, 1);
            writeSetting("AimPositionX", AimPosX.Text, inipath);
            writeSetting("AimPositionY", AimPosY.Text, inipath);
            writeSetting("AimSpeedX", AimSpdX.Text, inipath);
            writeSetting("AimSpeedY", AimSpdX.Text, inipath);
            writeSetting("Left", Left.Text, inipath);
            writeSetting("Right", Right.Text, inipath);
            writeSetting("Top", Top.Text, inipath);
            writeSetting("Bottom", Bottom.Text, inipath);
            writeSetting("Force", Force.Text, inipath);
            writeSetting("HumanizerStrength", HumanStrength.Text, inipath);
            MyLowLevel.unSetting();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x312)
            {
                if (m.WParam == (IntPtr) 0x0)
                {
                    if (!Active)
                    {
                        Beep(2000, 300);
                        Beep(2000, 300);

                        if (Resolution == 1080)
                            Aimbot = new Thread(Aiming) {IsBackground = true};
                        else if (Resolution == 1440)
                            Aimbot = new Thread(AimingQHD) {IsBackground = true};
                        Aimbot.Start();
                        Active = true;
                    }
                    else
                    {
                        Beep(2000, 300);
                        Aimbot.Abort();
                        Active = false;
                    }
                }

                if (m.WParam == (IntPtr) 0x1)
                {
                    //when pressing PgDn, Aiming Lower position
                    AimPosY.Text = (int.Parse(AimPosY.Text) + 1).ToString();
                    aimPosVal[1] = int.Parse(AimPosY.Text);
                }

                if (m.WParam == (IntPtr)0x2)
                {
                    //when pressing PgUp, Aiming Higher position
                    AimPosY.Text = (int.Parse(AimPosY.Text) - 1).ToString();
                    aimPosVal[1] = int.Parse(AimPosY.Text);
                }
            }
        }


        private void Aiming()
        {
            while (true)
                if (GetAsyncKeyState(Keys.RButton) || GetAsyncKeyState(Keys.LButton))
                {
                    search = MySearch(searchX1, searchY1, searchX2, searchY2, "*30 data\\1.dat");

                    if (search != null)
                    {
                        searchX = int.Parse(search[1]);
                        searchY = int.Parse(search[2]);

                        if (!CheckLevel(searchX, searchY))
                            continue;

                        AimX = (searchX + aimPosVal[0] - 960) * aimSpdVal[0] / 100;
                        AimY = ((Yaxis.Checked ? 0 : (searchY + aimPosVal[1] - 540)) 
                            + (HumanEnable.Checked ? 0 : RandomAim.Next(-aimHumVal, aimHumVal))) 
                            * aimSpdVal[1] / 100;

                        LowLevel.mouse_send(AimX, AimY);

                        searchX1 = searchX - searchVal[4];
                        searchY1 = searchY - searchVal[4];
                        searchX2 = searchX + searchVal[4];
                        searchY2 = searchY + searchVal[4];

                        searchY1 = searchY1 < searchVal[1] || searchY1 > searchVal[3] ? searchVal[1] : searchY1;
                        searchY2 = searchY2 < searchVal[1] || searchY2 > searchVal[3] ? searchVal[3] : searchY2;
                    }
                    else
                    {
                        searchX1 = searchVal[0];
                        searchY1 = searchVal[1];
                        searchX2 = searchVal[2];
                        searchY2 = searchVal[3];
                    }
                }
                else
                {
                    searchX1 = searchVal[0];
                    searchY1 = searchVal[1];
                    searchX2 = searchVal[2];
                    searchY2 = searchVal[3];
                    Thread.Sleep(1);
                }
        }


        private void AimingQHD()
        {
            while (true)
                if (GetAsyncKeyState(Keys.RButton) || GetAsyncKeyState(Keys.LButton))
                {
                    search = MySearch(searchX1, searchY1, searchX2, searchY2, "*30 data\\3.dat");

                    if (search != null)
                    {
                        searchX = int.Parse(search[1]);
                        searchY = int.Parse(search[2]);

                        if (!CheckLevelQHD(searchX, searchY))
                            continue;

                        AimX = (searchX + aimPosVal[0] - 1280) * aimSpdVal[0] / 100;
                        AimY = ((Yaxis.Checked ? 0 : (searchY + aimPosVal[1] - 720)) 
                            + (HumanEnable.Checked ? 0 : RandomAim.Next(-aimHumVal, aimHumVal))) 
                            * aimSpdVal[1] / 100;

                        LowLevel.mouse_send(AimX, AimY);

                        searchX1 = searchX - searchVal[4];
                        searchY1 = searchY - searchVal[4];
                        searchX2 = searchX + searchVal[4];
                        searchY2 = searchY + searchVal[4];

                        searchY1 = searchY1 < searchVal[1] || searchY1 > searchVal[3] ? searchVal[1] : searchY1;
                        searchY2 = searchY2 < searchVal[1] || searchY2 > searchVal[3] ? searchVal[3] : searchY2;
                    }
                    else
                    {
                        searchX1 = searchVal[0];
                        searchY1 = searchVal[1];
                        searchX2 = searchVal[2];
                        searchY2 = searchVal[3];
                        //locked = false;
                    }
                }
                else
                {
                    searchX1 = searchVal[0];
                    searchY1 = searchVal[1];
                    searchX2 = searchVal[2];
                    searchY2 = searchVal[3];
                    //locked = false;
                    Thread.Sleep(1);
                }
        }

        private static bool CheckLevel(int x, int y)
        {
            var levelSearch = MySearch(x - 30, y - 15, x - 10, y + 4, "*30 data\\0.dat");

            return levelSearch != null;
        }


        private static bool CheckLevelQHD(int x, int y)
        {
            var levelSearch = MySearch(x - 39, y - 20, x - 14, y + 6, "*30 data\\2.dat");

            return levelSearch != null;
        }

        public static string[] MySearch(int x1, int y1, int x2, int y2, string imgPath)
        {
            var result = ImageSearch(x1, y1, x2, y2, imgPath);
            var res = Marshal.PtrToStringAnsi(result);

            if (res[0] == '0') return null;

            var data = res.Split('|');

            return data;
        }

        private void AimApply_Click(object sender, EventArgs e)
        {
            aimPosVal = new[] { int.Parse(AimPosX.Text), int.Parse(AimPosY.Text) };
            aimSpdVal = new[] { int.Parse(AimSpdX.Text), int.Parse(AimSpdY.Text) };
            aimHumVal = int.Parse(HumanStrength.Text);
        }


        private void SearchApply_Click(object sender, EventArgs e)
        {
            searchVal = new[]
            {
                int.Parse(Left.Text), int.Parse(Top.Text), int.Parse(Right.Text), int.Parse(Bottom.Text),
                int.Parse(Force.Text)
            };
        }

        private void areashow_Click(object sender, EventArgs e)
        {
            var areashow = new SearchForm();
            areashow.Owner = this;
            areashow.StartPosition = FormStartPosition.Manual;
            areashow.Location = new Point(int.Parse(Left.Text), int.Parse(Top.Text));
            areashow.Size = new Size(int.Parse(Right.Text) - int.Parse(Left.Text),
                int.Parse(Bottom.Text) - int.Parse(Top.Text));
            areashow.ShowDialog();
        }

        private void Horizontal_ValueChanged(object sender, EventArgs e)
        {
            HorizontalValue.Text = Convert.ToString(Horizontal.Value) + "px";
            Left.Text = Convert.ToString(Screen.PrimaryScreen.Bounds.Width / 2 - Horizontal.Value);
            Right.Text = Convert.ToString(Screen.PrimaryScreen.Bounds.Width / 2 + Horizontal.Value);
        }

        private void Vertical_ValueChanged(object sender, EventArgs e)
        {
            VerticalValue.Text = Convert.ToString(Vertical.Value) + "px";
            Top.Text = Convert.ToString(Screen.PrimaryScreen.Bounds.Height / 2 - Vertical.Value);
            //Bottom.Text = Convert.ToString(Screen.PrimaryScreen.Bounds.Height / 2 + this.Vertical.Value);
        }

        private void writeSetting(string key, string value, string path)
        {
            WritePrivateProfileString("SETTINGS", key, value, path);
        }

        private string readSetting(string key, string path)
        {
            var sb = new StringBuilder(255);
            GetPrivateProfileString("SETTINGS", key, "", sb, sb.Capacity, path);
            return sb.ToString();
        }

        private void LoadSetting_Click(object sender, EventArgs e)
        {
            AimSpdX.Text = readSetting("AimSpeedX", inipath);
            AimSpdY.Text = readSetting("AimSpeedY", inipath);
            Left.Text = readSetting("Left", inipath);
            Right.Text = readSetting("Right", inipath);
            Top.Text = readSetting("Top", inipath);
            Bottom.Text = readSetting("Bottom", inipath);
            Force.Text = readSetting("Force", inipath);
            AimPosX.Text = readSetting("AimPositionX", inipath);
            AimPosY.Text = readSetting("AimPositionY", inipath);
            HumanStrength.Text = readSetting("HumanizerStrength", inipath);
        }

        private void SaveSetting_Click(object sender, EventArgs e)
        {
            writeSetting("AimPositionX", AimPosX.Text, inipath);
            writeSetting("AimPositionY", AimPosY.Text, inipath);
            writeSetting("AimSpeedX", AimSpdX.Text, inipath);
            writeSetting("AimSpeedY", AimSpdX.Text, inipath);
            writeSetting("Left", Left.Text, inipath);
            writeSetting("Right", Right.Text, inipath);
            writeSetting("Top", Top.Text, inipath);
            writeSetting("Bottom", Bottom.Text, inipath);
            writeSetting("Force", Force.Text, inipath);
            writeSetting("HumanizerStrength", HumanStrength.Text, inipath);
        }

        private void GoTray_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrayIcon.Visible = true;
        }

        private void TrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            TrayIcon.Visible = false;
        }
    }
}