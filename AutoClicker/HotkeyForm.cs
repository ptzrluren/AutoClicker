using System.Windows.Forms;

namespace AutoClicker {
    public partial class HotkeyForm : Form {
        MainForm mainForm;

        private Keys hotkey;
        private bool hotkeyChanging = false;

        public HotkeyForm(MainForm mainForm, bool topMost) {
            InitializeComponent();

            this.mainForm = mainForm;
            UpdateHotkey(mainForm.Hotkey);
            TopMost = topMost;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            if (hotkeyChanging
                && (keyData & Keys.KeyCode) != Keys.None
                && (keyData & Keys.KeyCode) != Keys.ControlKey
                && (keyData & Keys.KeyCode) != Keys.ShiftKey
                && (keyData & Keys.KeyCode) != Keys.Menu
                && (keyData & Keys.KeyCode) != Keys.LWin
                && (keyData & Keys.KeyCode) != Keys.RWin) {
                hotkeyChanging = false;
                UpdateHotkey(keyData);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        #region Helper Functions
        private void UpdateHotkey(Keys hotkey) {
            this.hotkey = hotkey;
            hotkeyText.Text = hotkey.ToString();
            changeHotkeyBtn.Enabled = true;
        }
        #endregion

        #region Event Handlers
        private void changeHotkeyBtn_Click(object sender, System.EventArgs e) {
            hotkeyChanging = true;
            hotkeyText.Text = "Press a key...";
            changeHotkeyBtn.Enabled = false;
        }

        private void resetHotkeyBtn_Click(object sender, System.EventArgs e) {
            hotkeyChanging = false;
            UpdateHotkey(MainForm.DEFAULT_HOTKEY);
        }

        private void okBtn_Click(object sender, System.EventArgs e) {
            mainForm.Hotkey = hotkey;
            Close();
        }

        private void cancelBtn_Click(object sender, System.EventArgs e) {
            Close();
        }
        #endregion
    }
}
