using System;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoClicker {
    public struct MouseMessage {
        public uint MouseDownMsg;
        public uint MouseUpMsg;
        public uint ModifierKey;
    }

    public struct MouseFlag {
        public uint MouseDownFlag;
        public uint MouseUpFlag;
    }

    public partial class MainForm : Form {
        public static Keys DEFAULT_HOTKEY = Keys.F6;
        public static int HOTKEY_ID = 0x1;

        private Random random = new Random();

        public static MouseMessage[] MOUSE_MESSAGES = {
            new MouseMessage { MouseDownMsg = Win32.WM_LBUTTONDOWN, MouseUpMsg = Win32.WM_LBUTTONUP, ModifierKey = Win32.MK_LBUTTON },
            new MouseMessage { MouseDownMsg = Win32.WM_RBUTTONDOWN, MouseUpMsg = Win32.WM_RBUTTONUP, ModifierKey = Win32.MK_RBUTTON },
            new MouseMessage { MouseDownMsg = Win32.WM_MBUTTONDOWN, MouseUpMsg = Win32.WM_MBUTTONUP, ModifierKey = Win32.MK_MBUTTON }
        };
        public static MouseFlag[] MOUSE_FLAGS = {
            new MouseFlag { MouseDownFlag = Win32.MOUSEEVENTF_LEFTDOWN, MouseUpFlag = Win32.MOUSEEVENTF_LEFTUP },
            new MouseFlag { MouseDownFlag = Win32.MOUSEEVENTF_RIGHTDOWN, MouseUpFlag = Win32.MOUSEEVENTF_RIGHTUP },
            new MouseFlag { MouseDownFlag = Win32.MOUSEEVENTF_MIDDLEDOWN, MouseUpFlag = Win32.MOUSEEVENTF_MIDDLEUP }
        };

        private Keys hotkey;

        private bool autoClickerRunning = false;
        private bool windowSelecting = false;
        private bool positionSelecting = false;

        private bool[] mouseButton = { true, false, false };
        private IntPtr selectedHandle = IntPtr.Zero;
        private uint clickCount = 0;

        public MainForm() {
            InitializeComponent();

            clickTypeCombo.SelectedIndex = 0;
            Hotkey = DEFAULT_HOTKEY;

            RegisterHotkey();
            CheckTime();
        }

        private void CheckTime()
        {
            DateTime currentTime = DateTime.Now;
            DateTime specifiedTime = new DateTime(2024, 12, 31, 0, 0, 0);

            if (DateTime.Compare(currentTime, specifiedTime) < 0)
            {
                
            }
            else
            {
                this.Close();
            }
        }

        public Keys Hotkey {
            get { return hotkey; }
            set {
                hotkey = value;
                startBtn.Text = "Start (" + hotkey + ")";
                stopBtn.Text = "Stop (" + hotkey + ")";
            }
        }

        protected override void WndProc(ref Message m) {
            if (m.Msg == Win32.WM_HOTKEY) {
                if (((uint)m.LParam & 0xFFFF) == GetFsModifers()
                    && (Keys)(((uint)m.LParam >> 16) & 0xFFFF) == (Hotkey & Keys.KeyCode)) {
                    ToggleAutoClicker();
                }
            }

            base.WndProc(ref m);
        }

        #region Helper Functions 
        private uint GetFsModifers() {
            uint fsModifiers = 0;

            if ((Hotkey & Keys.Alt) == Keys.Alt) {
                fsModifiers |= Win32.MOD_ALT;
            }
            if ((Hotkey & Keys.Control) == Keys.Control) {
                fsModifiers |= Win32.MOD_CONTROL;
            }
            if ((Hotkey & Keys.Shift) == Keys.Shift) {
                fsModifiers |= Win32.MOD_SHIFT;
            }

            return fsModifiers;
        }

        private void RegisterHotkey() {
            if (!Win32.RegisterHotKey(Handle, HOTKEY_ID, GetFsModifers() | Win32.MOD_NOREPEAT,
                Hotkey & Keys.KeyCode)) {
                MessageBox.Show("Failed to register hotkey. Please modify the hotkey setting.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UnregisterHotkey() {
            Win32.UnregisterHotKey(Handle, HOTKEY_ID);
        }

        private bool IsSelfSelectedHandle(IntPtr handle) {
            if (handle == IntPtr.Zero) {
                return false;
            }
            if (handle == Handle) {
                return true;
            }

            uint processId = 0;
            Win32.GetWindowThreadProcessId(handle, ref processId);

            return processId == Process.GetCurrentProcess().Id;
        }

        private string GetWindowTitle(IntPtr handle) {
            if (handle == IntPtr.Zero) {
                return string.Empty;
            }

            int length = Win32.GetWindowTextLength(handle);
            if (length == 0) {
                return string.Empty;
            }
            StringBuilder title = new StringBuilder(length + 1);
            Win32.GetWindowText(handle, title, title.Capacity);

            return title.ToString();
        }

        private int GetIntervalMs() {
            int randomTime = random.Next(10, (int)randomNumeric.Value); // 生成1000到10000毫秒之间的随机数
            int time = ((int)(hrNumeric.Value * 3600000
                + minNumeric.Value * 60000
                + secNumeric.Value * 1000
                + msNumeric.Value) + randomTime);
            Console.WriteLine(time);
            return time;
        }

        private Point GetCursorPos() {
            // add by liubin 
            int randomX = random.Next(0, (int)xRandomNumeric.Value);
            int randomY = random.Next(0, (int)yRandomNumeric.Value);
            // add by liubin 
            if (currPosRadio.Checked)
            {
                // add by liubin 
                return new Point(Cursor.Position.X + randomX, Cursor.Position.Y + randomY);
                //return Cursor.Position;
                // add by liubin 
            }
            else {
                return new Point((int)xNumeric.Value + randomX, (int)yNumeric.Value + randomY);
            }
        }

        private void PostMouseDownMessage(Point curPos) {
            IntPtr lParam = (IntPtr)(curPos.Y << 16 | curPos.X);
            for (int i = 0; i < mouseButton.Length; i++) {
                if (mouseButton[i]) {
                    Win32.PostMessage(selectedHandle, MOUSE_MESSAGES[i].MouseDownMsg,
                        (IntPtr)MOUSE_MESSAGES[i].ModifierKey, lParam);
                }
            }
        }

        private void PostMouseUpMessage(Point curPos) {
            IntPtr lParam = (IntPtr)(curPos.Y << 16 | curPos.X);
            for (int i = 0; i < mouseButton.Length; i++) {
                if (mouseButton[i]) {
                    Win32.PostMessage(selectedHandle, MOUSE_MESSAGES[i].MouseUpMsg,
                        (IntPtr)MOUSE_MESSAGES[i].ModifierKey, lParam);
                }
            }
        }

        private uint GetMouseDownFlag() {
            uint flag = 0;
            for (int i = 0; i < mouseButton.Length; i++) {
                if (mouseButton[i]) {
                    flag |= MOUSE_FLAGS[i].MouseDownFlag;
                }
            }

            return flag;
        }

        private uint GetMouseUpFlag() {
            uint flag = 0;
            for (int i = 0; i < mouseButton.Length; i++) {
                if (mouseButton[i]) {
                    flag |= MOUSE_FLAGS[i].MouseUpFlag;
                }
            }

            return flag;
        }

        private void HandleClick(bool mouseDown, bool mouseUp) {
            Point curPos = GetCursorPos();

            if (windowModeRadio.Checked && selectedHandle != IntPtr.Zero) {
                Win32.ScreenToClient(selectedHandle, ref curPos);
                if (mouseDown) {
                    PostMouseDownMessage(curPos);
                }
                if (mouseUp) {
                    PostMouseUpMessage(curPos);
                }
            } else if (pointerModeRadio.Checked) {
                if (customPosRadio.Checked) {
                    Win32.SetCursorPos(curPos.X, curPos.Y);
                }
                uint flag = 0;
                if (mouseDown) {
                    flag |= GetMouseDownFlag();
                }
                if (mouseUp) {
                    flag |= GetMouseUpFlag();
                }
                Win32.mouse_event(flag, curPos.X, curPos.Y, 0, IntPtr.Zero);
            }
        }

        private void ToggleAutoClicker() {
            autoClickerRunning = !autoClickerRunning;

            startBtn.Enabled = !autoClickerRunning;
            stopBtn.Enabled = autoClickerRunning;

            bool holdMode = clickTypeCombo.SelectedItem.Equals("Hold");
            if (autoClickerRunning) {
                if (holdMode) {
                    HandleClick(true, false);
                } else {
                    clickCount = 0;
                    clickTimer.Interval = GetIntervalMs();
                    clickTimer.Start();
                }
            } else {
                if (holdMode) {
                    HandleClick(false, true);
                } else {
                    clickTimer.Stop();
                }
            }
        }
        #endregion

        #region Event Handlers
        private void clickTimer_Tick(object sender, EventArgs e) {
            // add by liubin
            clickTimer.Stop(); // 停止计时器
            clickTimer.Interval = GetIntervalMs();
            clickTimer.Start(); // 重新开始计时器
            // end add


            HandleClick(true, true);
            if (clickTypeCombo.SelectedItem.Equals("Double")) {
                HandleClick(true, true);
            }

            clickCount++;
            if (repeatLimitRadio.Checked && clickCount >= repeatCountNumeric.Value) {
                ToggleAutoClicker();
            }
        }

        private void hotkeySettingMenu_Click(object sender, EventArgs e) {
            HotkeyForm hotkeyForm = new HotkeyForm(this, TopMost);

            UnregisterHotkey();
            hotkeyForm.ShowDialog();
            RegisterHotkey();
        }

        private void alwaysOnTopMenu_Click(object sender, EventArgs e) {
            alwaysOnTopMenu.Checked = !alwaysOnTopMenu.Checked;
            TopMost = alwaysOnTopMenu.Checked;
        }

        private void aboutMenu_Click(object sender, EventArgs e) {
            AboutForm aboutForm = new AboutForm(TopMost);

            UnregisterHotkey();
            aboutForm.ShowDialog();
            RegisterHotkey();
        }

        private void pickWindowBtn_MouseDown(object sender, MouseEventArgs e) {
            windowSelecting = true;
            pickWindowBtn.Cursor = Cursors.Cross;

            Win32.SetCapture(pickWindowBtn.Handle);
        }

        private void pickWindowBtn_MouseUp(object sender, MouseEventArgs e) {
            windowSelecting = false;
            pickWindowBtn.Cursor = Cursors.Default;

            Win32.ReleaseCapture();
        }

        private void pickWindowBtn_MouseMove(object sender, MouseEventArgs e) {
            if (!windowSelecting) {
                return;
            }

            IntPtr currHandle = Win32.WindowFromPoint(Cursor.Position);
            if (currHandle == IntPtr.Zero || IsSelfSelectedHandle(currHandle)) {
                selectedHandle = IntPtr.Zero;
                handleText.Text = string.Empty;
                titleText.Text = string.Empty;
            } else {
                selectedHandle = currHandle;
                handleText.Text = currHandle.ToString("X8");
                titleText.Text = GetWindowTitle(currHandle);
            }
        }

        private void leftButtonCheck_CheckedChanged(object sender, EventArgs e) {
            mouseButton[0] = leftButtonCheck.Checked;
        }

        private void rightButtonCheck_CheckedChanged(object sender, EventArgs e) {
            mouseButton[1] = rightButtonCheck.Checked;
        }

        private void middleButtonCheck_CheckedChanged(object sender, EventArgs e) {
            mouseButton[2] = middleButtonCheck.Checked;
        }

        private void pickPosBtn_MouseDown(object sender, MouseEventArgs e) {
            positionSelecting = true;
            pickPosBtn.Cursor = Cursors.Cross;

            Win32.SetCapture(pickPosBtn.Handle);
        }

        private void pickPosBtn_MouseUp(object sender, MouseEventArgs e) {
            positionSelecting = false;
            pickPosBtn.Cursor = Cursors.Default;

            Win32.ReleaseCapture();
        }

        private void pickPosBtn_MouseMove(object sender, MouseEventArgs e) {
            if (!positionSelecting) {
                return;
            }

            xNumeric.Value = Cursor.Position.X;
            yNumeric.Value = Cursor.Position.Y;
        }

        private void startBtn_Click(object sender, EventArgs e) {
            ToggleAutoClicker();
        }

        private void stopBtn_Click(object sender, EventArgs e) {
            ToggleAutoClicker();
        }
        #endregion
    }
}
