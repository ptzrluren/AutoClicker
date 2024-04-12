using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace AutoClicker {
    public class Win32 {
        public static uint MK_LBUTTON = 0x0001;
        public static uint MK_RBUTTON = 0x0002;
        public static uint MK_MBUTTON = 0x0010;

        public static uint MOD_ALT = 0x0001;
        public static uint MOD_CONTROL = 0x0002;
        public static uint MOD_SHIFT = 0x0004;
        public static uint MOD_WIN = 0x0008;
        public static uint MOD_NOREPEAT = 0x4000;

        public static uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        public static uint MOUSEEVENTF_LEFTUP = 0x0004;
        public static uint MOUSEEVENTF_RIGHTDOWN = 0x0008;
        public static uint MOUSEEVENTF_RIGHTUP = 0x0010;
        public static uint MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        public static uint MOUSEEVENTF_MIDDLEUP = 0x0040;

        public static uint WM_HOTKEY = 0x0312;
        public static uint WM_LBUTTONDOWN = 0x0201;
        public static uint WM_LBUTTONUP = 0x0202;
        public static uint WM_RBUTTONDOWN = 0x0204;
        public static uint WM_RBUTTONUP = 0x0205;
        public static uint WM_MBUTTONDOWN = 0x0207;
        public static uint WM_MBUTTONUP = 0x0208;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);
        [DllImport("user32.dll")]
        public static extern int GetWindowTextLength(IntPtr hWnd);
        [DllImport("user32.dll")]
        public static extern uint GetWindowThreadProcessId(IntPtr hWnd, ref uint processId);
        [DllImport("user32.dll")]
        public static extern bool PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, Keys vk);
        [DllImport("user32.dll")]
        public static extern bool ScreenToClient(IntPtr hWnd, ref Point lpPoint);
        [DllImport("user32.dll")]
        public static extern IntPtr SetCapture(IntPtr hWnd);
        [DllImport("user32.dll")]
        public static extern bool SetCursorPos(int X, int Y);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        [DllImport("user32.dll")]
        public static extern IntPtr WindowFromPoint(Point p);
        [DllImport("user32.dll")]
        public static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, IntPtr dwExtraInfo);
    }
}
