using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ЛР1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        struct OSVERSIONINFOEX
        {
            public int dwOSVersionInfoSize;
            public int dwMajorVersion;
            public int dwMinorVersion;
            public int dwBuildNumber;
            public int dwPlatformId;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string szCSDVersion;
            public UInt16 wServicePackMajor;
            public UInt16 wServicePackMinor;
            public UInt16 wSuiteMask;
            public byte wProductType;
            public byte wReserved;
        }

        public enum SystemMetric
        {
            SM_CXSCREEN = 0,  // 0x00
            SM_CYSCREEN = 1,  // 0x01
            SM_CXVSCROLL = 2,  // 0x02
            SM_CYHSCROLL = 3,  // 0x03
            SM_CYCAPTION = 4,  // 0x04
            SM_CXBORDER = 5,  // 0x05
            SM_CYBORDER = 6,  // 0x06
            SM_CXDLGFRAME = 7,  // 0x07
            SM_CXFIXEDFRAME = 7,  // 0x07
            SM_CYDLGFRAME = 8,  // 0x08
            SM_CYFIXEDFRAME = 8,  // 0x08
            SM_CYVTHUMB = 9,  // 0x09
            SM_CXHTHUMB = 10, // 0x0A
            SM_CXICON = 11, // 0x0B
            SM_CYICON = 12, // 0x0C
            SM_CXCURSOR = 13, // 0x0D
            SM_CYCURSOR = 14, // 0x0E
            SM_CYMENU = 15, // 0x0F
            SM_CXFULLSCREEN = 16, // 0x10
            SM_CYFULLSCREEN = 17, // 0x11
            SM_CYKANJIWINDOW = 18, // 0x12
            SM_MOUSEPRESENT = 19, // 0x13
            SM_CYVSCROLL = 20, // 0x14
            SM_CXHSCROLL = 21, // 0x15
            SM_DEBUG = 22, // 0x16
            SM_SWAPBUTTON = 23, // 0x17
            SM_CXMIN = 28, // 0x1C
            SM_CYMIN = 29, // 0x1D
            SM_CXSIZE = 30, // 0x1E
            SM_CYSIZE = 31, // 0x1F
            SM_CXSIZEFRAME = 32, // 0x20
            SM_CXFRAME = 32, // 0x20
            SM_CYSIZEFRAME = 33, // 0x21
            SM_CYFRAME = 33, // 0x21
            SM_CXMINTRACK = 34, // 0x22
            SM_CYMINTRACK = 35, // 0x23
            SM_CXDOUBLECLK = 36, // 0x24
            SM_CYDOUBLECLK = 37, // 0x25
            SM_CXICONSPACING = 38, // 0x26
            SM_CYICONSPACING = 39, // 0x27
            SM_MENUDROPALIGNMENT = 40, // 0x28
            SM_PENWINDOWS = 41, // 0x29
            SM_DBCSENABLED = 42, // 0x2A
            SM_CMOUSEBUTTONS = 43, // 0x2B
            SM_SECURE = 44, // 0x2C
            SM_CXEDGE = 45, // 0x2D
            SM_CYEDGE = 46, // 0x2E
            SM_CXMINSPACING = 47, // 0x2F
            SM_CYMINSPACING = 48, // 0x30
            SM_CXSMICON = 49, // 0x31
            SM_CYSMICON = 50, // 0x32
            SM_CYSMCAPTION = 51, // 0x33
            SM_CXSMSIZE = 52, // 0x34
            SM_CYSMSIZE = 53, // 0x35
            SM_CXMENUSIZE = 54, // 0x36
            SM_CYMENUSIZE = 55, // 0x37
            SM_ARRANGE = 56, // 0x38
            SM_CXMINIMIZED = 57, // 0x39
            SM_CYMINIMIZED = 58, // 0x3A
            SM_CXMAXTRACK = 59, // 0x3B
            SM_CYMAXTRACK = 60, // 0x3C
            SM_CXMAXIMIZED = 61, // 0x3D
            SM_CYMAXIMIZED = 62, // 0x3E
            SM_NETWORK = 63, // 0x3F
            SM_CLEANBOOT = 67, // 0x43
            SM_CXDRAG = 68, // 0x44
            SM_CYDRAG = 69, // 0x45
            SM_SHOWSOUNDS = 70, // 0x46
            SM_CXMENUCHECK = 71, // 0x47
            SM_CYMENUCHECK = 72, // 0x48
            SM_SLOWMACHINE = 73, // 0x49
            SM_MIDEASTENABLED = 74, // 0x4A
            SM_MOUSEWHEELPRESENT = 75, // 0x4B
            SM_XVIRTUALSCREEN = 76, // 0x4C
            SM_YVIRTUALSCREEN = 77, // 0x4D
            SM_CXVIRTUALSCREEN = 78, // 0x4E
            SM_CYVIRTUALSCREEN = 79, // 0x4F
            SM_CMONITORS = 80, // 0x50
            SM_SAMEDISPLAYFORMAT = 81, // 0x51
            SM_IMMENABLED = 82, // 0x52
            SM_CXFOCUSBORDER = 83, // 0x53
            SM_CYFOCUSBORDER = 84, // 0x54
            SM_TABLETPC = 86, // 0x56
            SM_MEDIACENTER = 87, // 0x57
            SM_STARTER = 88, // 0x58
            SM_SERVERR2 = 89, // 0x59
            SM_MOUSEHORIZONTALWHEELPRESENT = 91, // 0x5B
            SM_CXPADDEDBORDER = 92, // 0x5C
            SM_DIGITIZER = 94, // 0x5E
            SM_MAXIMUMTOUCHES = 95, // 0x5F

            SM_REMOTESESSION = 0x1000, // 0x1000
            SM_SHUTTINGDOWN = 0x2000, // 0x2000
            SM_REMOTECONTROL = 0x2001, // 0x2001


            SM_CONVERTIBLESLATEMODE = 0x2003,
            SM_SYSTEMDOCKED = 0x2004,
        }

        [Flags]
        public enum SPIF
        {
            None = 0x00,
            /// <summary>Writes the new system-wide parameter setting to the user profile.</summary>
            SPIF_UPDATEINIFILE = 0x01,
            /// <summary>Broadcasts the WM_SETTINGCHANGE message after updating the user profile.</summary>
            SPIF_SENDCHANGE = 0x02,
            /// <summary>Same as SPIF_SENDCHANGE.</summary>
            SPIF_SENDWININICHANGE = 0x02
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SYSTEMTIME
        {
            [MarshalAs(UnmanagedType.U2)] public short Year;
            [MarshalAs(UnmanagedType.U2)] public short Month;
            [MarshalAs(UnmanagedType.U2)] public short DayOfWeek;
            [MarshalAs(UnmanagedType.U2)] public short Day;
            [MarshalAs(UnmanagedType.U2)] public short Hour;
            [MarshalAs(UnmanagedType.U2)] public short Minute;
            [MarshalAs(UnmanagedType.U2)] public short Second;
            [MarshalAs(UnmanagedType.U2)] public short Milliseconds;

            public SYSTEMTIME(DateTime dt)
            {
                dt = dt.ToUniversalTime();  // SetSystemTime expects the SYSTEMTIME in UTC
                Year = (short)dt.Year;
                Month = (short)dt.Month;
                DayOfWeek = (short)dt.DayOfWeek;
                Day = (short)dt.Day;
                Hour = (short)dt.Hour;
                Minute = (short)dt.Minute;
                Second = (short)dt.Second;
                Milliseconds = (short)dt.Millisecond;
            }
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct TIME_ZONE_INFORMATION
        {
            [MarshalAs(UnmanagedType.I4)]
            public Int32 Bias;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string StandardName;
            public SYSTEMTIME StandardDate;
            [MarshalAs(UnmanagedType.I4)]
            public Int32 StandardBias;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string DaylightName;
            public SYSTEMTIME DaylightDate;
            [MarshalAs(UnmanagedType.I4)]
            public Int32 DaylightBias;
        }





        [DllImport("Kernel32")]
        static extern unsafe bool GetComputerName(byte* lpBuffer, long* nSize);
        [DllImport("advapi32.dll", SetLastError = true)]
        static extern bool GetUserName(System.Text.StringBuilder sb, ref Int32 length);
        [DllImport("kernel32.dll")]
        static extern uint GetSystemDirectory([Out] StringBuilder lpBuffer, uint uSize);
        [DllImport("kernel32")]
        static extern bool GetVersionEx(ref OSVERSIONINFOEX osvi);
        [DllImport("user32.dll")]
        static extern int GetSystemMetrics(SystemMetric smIndex);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SystemParametersInfo(uint uiAction, uint uiParam, StringBuilder pvParam, SPIF fWinIni);
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SystemParametersInfo(uint uiAction, uint uiParam, ref uint pvParam, int fWinIni); // T = any type
        [DllImport("user32.dll")]
        static extern uint GetSysColor(int nIndex);
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern void GetSystemTime(out SYSTEMTIME lpSystemTime);
        [DllImport("user32.dll")]
        static extern bool SetSysColors(int cElements, int[] lpaElements, int[] lpaRgbValues);
        [DllImport("kernel32.dll")]
        static extern uint GetTimeZoneInformation(out TIME_ZONE_INFORMATION lpTimeZoneInformation);
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetCursorPos(out Point lpPoint);
        [DllImport("user32.dll", SetLastError = true)]
        static extern bool SetCaretPosition(int x, int y);
        [DllImport("user32.dll")]
        static extern bool CreateCaret(IntPtr hWnd, IntPtr hBitmap, int nWidth,
   int nHeight);
        [DllImport("user32.dll")]
        static extern bool ShowCaret(IntPtr hWnd);
        //HRESULT IVsTextView::SetCaretPos([in] long iLine,[in] ViewCol iColumn);

        private unsafe void button1_Click(object sender, EventArgs e)
        {
            //PC-name
            byte[] buffor = new byte[512];
            long sizeNameComputer = buffor.Length;
            long* pSize = &sizeNameComputer;
            fixed (byte* pBuffor = buffor)
            {
                GetComputerName(pBuffor, pSize);
            }
            System.Text.Encoding textEnc = new System.Text.ASCIIEncoding();
            label1.Text = "Имя ПК: " + textEnc.GetString(buffor);

            //username
            StringBuilder BufferUserName = new StringBuilder(512);
            int sizeUserName = 512;
            GetUserName(BufferUserName, ref sizeUserName);
            label2.Text = "Имя пользователя: " + BufferUserName;

            //system directory
            StringBuilder sbSystemDir = new StringBuilder(256);
            uint sizePathSystemDirectory = 256;
            GetSystemDirectory(sbSystemDir, sizePathSystemDirectory);
            label3.Text = "Системная директория: " + sbSystemDir;

            //version
            OSVERSIONINFOEX osVersionInfo = new OSVERSIONINFOEX();
            osVersionInfo.dwOSVersionInfoSize = (int)Marshal.SizeOf(osVersionInfo);
            GetVersionEx(ref osVersionInfo);
            label4.Text = "Версия ОС: " + osVersionInfo.dwBuildNumber;

            //system metrics
            switch (GetSystemMetrics(SystemMetric.SM_CLEANBOOT))
            {
                case 0:
                    label5.Text = "Тип загрузки: " + "Normal boot";
                    break;
                case 1:
                    label5.Text = "Тип загрузки: " + "Failed boot";
                    break;
                case 2:
                    label5.Text = "Тип загрузки: " + "Fail  safe boot with networking";
                    break;
            }
            label6.Text = "Разрешение монитора: " + GetSystemMetrics(SystemMetric.SM_CXSCREEN) + "x" + GetSystemMetrics(SystemMetric.SM_CYSCREEN);
            label15.Text = "Наличие мышки: " + GetSystemMetrics(SystemMetric.SM_MOUSEPRESENT);

            //system settings
            StringBuilder pathWallpaper = new StringBuilder(1024);
            const uint SPI_GETDESKWALLPAPER = 0x0073;
            SystemParametersInfo(SPI_GETDESKWALLPAPER, 1024, pathWallpaper, 0);
            label7.Text = "Путь к картинке рабчего стола: " + pathWallpaper;

            const uint SPI_GETFONTSMOOTHINGCONTRAST = 0x200C;
            uint contrast = 0;
            SystemParametersInfo(SPI_GETFONTSMOOTHINGCONTRAST, 0, ref contrast, 0);
            label8.Text = "Контрастность: " + contrast;

            const uint SPI_GETCLIENTAREAANIMATION = 0x1042;
            uint animation = 0;
            SystemParametersInfo(SPI_GETCLIENTAREAANIMATION, 0, ref animation, 0);
            label16.Text = "Наличие анимации: " + animation;
            

            //system color
            //COLOR_BTNFACE, COLOR_GRAYTEXT, COLOR_DESKTOP
            const int COLOR_BACKGROUND = 1;
            int color1 = Convert.ToInt32(GetSysColor(COLOR_BACKGROUND));
            Color color_1 = Color.FromArgb(color1 & 0xFF, (color1 & 0xFF00) >> 8, (color1 & 0xFF0000) >> 16);
            label9.Text = "Цвет Рабочего стола: " + "[R = " + color_1.R + ", G = " + color_1.G + ", B = " + color_1.B + "]";

            const int COLOR_GRAYTEXT = 17;
            int color2 = Convert.ToInt32(GetSysColor(COLOR_GRAYTEXT));
            Color color_2 = Color.FromArgb(color2 & 0xFF, (color2 & 0xFF00) >> 8, (color2 & 0xFF0000) >> 16);
            label17.Text = "Цвет серого (отключенного) текста: " + "[R = " + color_2.R + ", G = " + color_2.G + ", B = " + color_2.B + "]";

            const int COLOR_BTNFACE = 15;
            int color3 = Convert.ToInt32(GetSysColor(COLOR_BTNFACE));
            Color color_3 = Color.FromArgb(color3 & 0xFF, (color3 & 0xFF00) >> 8, (color3 & 0xFF0000) >> 16);
            label18.Text = "Цвет лица для элементов трехмерного дисплея и фонов диалогового окна: " + "[R = " + color_3.R + ", G = " + color_3.G + ", B = " + color_3.B + "]";

            //system time
            SYSTEMTIME myTime;
            TIME_ZONE_INFORMATION myZone;
            GetTimeZoneInformation(out myZone);
            GetSystemTime(out myTime);
            label10.Text = "Дата: " + myTime.Day+"/"+myTime.Month+"/"+myTime.Year;
            label12.Text = "Время: " + (myTime.Hour + (((int)myZone.Bias) / (-60))) + "." + myTime.Minute + "." + myTime.Second;

            label13.Text = "Часовой пояс: " + ((int)myZone.Bias) / (-60);
            //API
            //GetCursorPos, GetNumberFormat, SetCaretPos
            Point myPoint = Cursor.Position;
            if (GetCursorPos(out myPoint))
            {
                label14.Text = "Позиция курсора: X = " + Convert.ToString(myPoint.X) + ", Y = " + Convert.ToString(myPoint.Y);
            }

            CreateCaret(textBox2.Handle, IntPtr.Zero, 15, textBox2.Height);
            //SetCaretPosition(0, 1);
            //ShowCaret(textBox1.Handle);

            if (ShowCaret(textBox2.Handle) == true)
            {
                label21.Text = "Caret pos: true";
            } else
            {
                label21.Text = "Caret pos: false";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //change color of worktable
            const int COLOR_DESKTOP = 1;
            Color inColor = Color.FromArgb(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
            int[] elements = { COLOR_DESKTOP };
            int[] colors = { System.Drawing.ColorTranslator.ToWin32(inColor) };
            SetSysColors(elements.Length, elements, colors);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //change color
            const int COLOR_GRAYTEXT = 17;
            Color inColor = Color.FromArgb(Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
            int[] elements = { COLOR_GRAYTEXT };
            int[] colors = { System.Drawing.ColorTranslator.ToWin32(inColor) };
            SetSysColors(elements.Length, elements, colors);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //change color
            const int COLOR_BTNFACE = 15;
            Color inColor = Color.FromArgb(Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox9.Text));
            int[] elements = { COLOR_BTNFACE };
            int[] colors = { System.Drawing.ColorTranslator.ToWin32(inColor) };
            SetSysColors(elements.Length, elements, colors);
        }


    }
}