using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SIVA
{
    internal class LowLevel
    {
        public enum VK : ushort
        {
            BACK = 8,
            TAB = 9,
            RETURN = 13, // 0x000D
            SHIFT = 16, // 0x0010
            CONTROL = 17, // 0x0011
            MENU = 18, // 0x0012
            ESCAPE = 27, // 0x001B
            PRIOR = 33, // 0x0021
            NEXT = 34, // 0x0022
            END = 35, // 0x0023
            HOME = 36, // 0x0024
            LEFT = 37, // 0x0025
            UP = 38, // 0x0026
            RIGHT = 39, // 0x0027
            DOWN = 40, // 0x0028
            SELECT = 41, // 0x0029
            PRINT = 42, // 0x002A
            EXECUTE = 43, // 0x002B
            SNAPSHOT = 44, // 0x002C
            INSERT = 45, // 0x002D
            DELETE = 46, // 0x002E
            HELP = 47, // 0x002F
            LWIN = 91, // 0x005B
            RWIN = 92, // 0x005C
            NUMPAD0 = 96, // 0x0060
            NUMPAD1 = 97, // 0x0061
            NUMPAD2 = 98, // 0x0062
            NUMPAD3 = 99, // 0x0063
            NUMPAD4 = 100, // 0x0064
            NUMPAD5 = 101, // 0x0065
            NUMPAD6 = 102, // 0x0066
            NUMPAD7 = 103, // 0x0067
            NUMPAD8 = 104, // 0x0068
            NUMPAD9 = 105, // 0x0069
            MULTIPLY = 106, // 0x006A
            ADD = 107, // 0x006B
            SEPARATOR = 108, // 0x006C
            SUBTRACT = 109, // 0x006D
            DECIMAL = 110, // 0x006E
            DIVIDE = 111, // 0x006F
            F1 = 112, // 0x0070
            F2 = 113, // 0x0071
            F3 = 114, // 0x0072
            F4 = 115, // 0x0073
            F5 = 116, // 0x0074
            F6 = 117, // 0x0075
            F7 = 118, // 0x0076
            F8 = 119, // 0x0077
            F9 = 120, // 0x0078
            F10 = 121, // 0x0079
            F11 = 122, // 0x007A
            F12 = 123, // 0x007B
            MEDIA_NEXT_TRACK = 176, // 0x00B0
            MEDIA_PREV_TRACK = 177, // 0x00B1
            MEDIA_STOP = 178, // 0x00B2
            MEDIA_PLAY_PAUSE = 179, // 0x00B3
            OEM_1 = 186, // 0x00BA
            OEM_PLUS = 187, // 0x00BB
            OEM_COMMA = 188, // 0x00BC
            OEM_MINUS = 189, // 0x00BD
            OEM_PERIOD = 190, // 0x00BE
            OEM_2 = 191, // 0x00BF
            OEM_3 = 192 // 0x00C0
        }

        private const int INPUT_MOUSE = 0;
        private const int INPUT_KEYBOARD = 1;
        private const int INPUT_HARDWARE = 2;
        private const uint KEYEVENTF_EXTENDEDKEY = 1;
        private const uint KEYEVENTF_KEYUP = 2;
        private const uint KEYEVENTF_UNICODE = 4;
        private const uint KEYEVENTF_SCANCODE = 8;
        private const uint XBUTTON1 = 1;
        private const uint XBUTTON2 = 2;
        private const uint MOUSEEVENTF_MOVE = 1;
        private const uint MOUSEEVENTF_LEFTDOWN = 2;
        private const uint MOUSEEVENTF_LEFTUP = 4;
        private const uint MOUSEEVENTF_RIGHTDOWN = 8;
        private const uint MOUSEEVENTF_RIGHTUP = 16;
        private const uint MOUSEEVENTF_MIDDLEDOWN = 32;
        private const uint MOUSEEVENTF_MIDDLEUP = 64;
        private const uint MOUSEEVENTF_XDOWN = 128;
        private const uint MOUSEEVENTF_XUP = 256;
        private const uint MOUSEEVENTF_WHEEL = 2048;
        private const uint MOUSEEVENTF_VIRTUALDESK = 16384;
        private const uint MOUSEEVENTF_ABSOLUTE = 32768;
        private const uint WM_MOUSEMOVE = 512;
        private const int WH_MOUSE_LL = 14;
        private static readonly LowLevelMouseProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;
        private readonly ContainerMessageFilter containerMessageFilter;

        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint SendInput(uint nInputs, Input[] pInputs, int cbSize);

        public static void mouse_send(int x, int y)
        {
            var pInputs = new Input[2];
            pInputs[0] = new Input();
            pInputs[0].Type = 0;
            pInputs[0].MouseInput.X = x;
            pInputs[0].MouseInput.Y = y;
            pInputs[0].MouseInput.Flags = 1U;
            var num = (int) SendInput(1U, pInputs, Marshal.SizeOf((object) pInputs[0]));
        }

        public void Setting()
        {
            _hookID = SetHook(_proc);
            Application.AddMessageFilter(containerMessageFilter);
        }

        public void unSetting()
        {
            UnhookWindowsHookEx(_hookID);
        }

        private static IntPtr SetHook(LowLevelMouseProc proc)
        {
            using (var currentProcess = Process.GetCurrentProcess())
            {
                using (var mainModule = currentProcess.MainModule)
                {
                    return SetWindowsHookEx(14, proc, GetModuleHandle(mainModule.ModuleName), 0U);
                }
            }
        }

        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {
                if (513 == (int) wParam)
                {
                    var structure1 = (MSLLHOOKSTRUCT) Marshal.PtrToStructure(lParam, typeof(MSLLHOOKSTRUCT));
                }
                else if (512 == (int) wParam)
                {
                    var structure2 = (MSLLHOOKSTRUCT) Marshal.PtrToStructure(lParam, typeof(MSLLHOOKSTRUCT));
                }
            }

            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelMouseProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        private struct MOUSEINPUT
        {
            public int dx;
            public int dy;
            public uint mouseData;
            public uint dwFlags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        private struct KEYBDINPUT
        {
            public ushort wVk;
            public ushort wScan;
            public uint dwFlags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        private struct HARDWAREINPUT
        {
            public uint uMsg;
            public ushort wParamL;
            public ushort wParamH;
        }

        internal struct MouseInput
        {
            public int X;
            public int Y;
            public uint MouseData;
            public uint Flags;
            public uint Time;
            public IntPtr ExtraInfo;
        }

        internal struct Input
        {
            public int Type;
            public MouseInput MouseInput;
        }

        private delegate IntPtr LowLevelMouseProc(int nCode, IntPtr wParam, IntPtr lParam);

        private enum MouseMessages
        {
            WM_MOUSEMOVE = 512, // 0x00000200
            WM_LBUTTONDOWN = 513, // 0x00000201
            WM_LBUTTONUP = 514, // 0x00000202
            WM_RBUTTONDOWN = 516, // 0x00000204
            WM_RBUTTONUP = 517, // 0x00000205
            WM_MOUSEWHEEL = 522 // 0x0000020A
        }

        private struct POINT
        {
            public int x;
            public int y;
        }

        private struct MSLLHOOKSTRUCT
        {
            public POINT pt;
            public uint mouseData;
            public uint flags;
            public uint time;
            public IntPtr dwExtraInfo;
        }
    }
}