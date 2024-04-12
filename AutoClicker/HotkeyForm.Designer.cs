namespace AutoClicker {
    partial class HotkeyForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotkeyForm));
            this.resetHotkeyBtn = new System.Windows.Forms.Button();
            this.changeHotkeyBtn = new System.Windows.Forms.Button();
            this.hotkeyText = new System.Windows.Forms.TextBox();
            this.startStopLabel = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.hotkeySettingGroup = new System.Windows.Forms.GroupBox();
            this.hotkeySettingGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // resetHotkeyBtn
            // 
            this.resetHotkeyBtn.Location = new System.Drawing.Point(220, 19);
            this.resetHotkeyBtn.Name = "resetHotkeyBtn";
            this.resetHotkeyBtn.Size = new System.Drawing.Size(60, 23);
            this.resetHotkeyBtn.TabIndex = 3;
            this.resetHotkeyBtn.Text = "Reset";
            this.resetHotkeyBtn.UseVisualStyleBackColor = true;
            this.resetHotkeyBtn.Click += new System.EventHandler(this.resetHotkeyBtn_Click);
            // 
            // changeHotkeyBtn
            // 
            this.changeHotkeyBtn.Location = new System.Drawing.Point(154, 19);
            this.changeHotkeyBtn.Name = "changeHotkeyBtn";
            this.changeHotkeyBtn.Size = new System.Drawing.Size(60, 23);
            this.changeHotkeyBtn.TabIndex = 2;
            this.changeHotkeyBtn.Text = "Change";
            this.changeHotkeyBtn.UseVisualStyleBackColor = true;
            this.changeHotkeyBtn.Click += new System.EventHandler(this.changeHotkeyBtn_Click);
            // 
            // hotkeyText
            // 
            this.hotkeyText.Location = new System.Drawing.Point(78, 21);
            this.hotkeyText.Name = "hotkeyText";
            this.hotkeyText.ReadOnly = true;
            this.hotkeyText.Size = new System.Drawing.Size(70, 20);
            this.hotkeyText.TabIndex = 1;
            this.hotkeyText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // startStopLabel
            // 
            this.startStopLabel.AutoSize = true;
            this.startStopLabel.Location = new System.Drawing.Point(9, 24);
            this.startStopLabel.Name = "startStopLabel";
            this.startStopLabel.Size = new System.Drawing.Size(59, 13);
            this.startStopLabel.TabIndex = 0;
            this.startStopLabel.Text = "Start/Stop:";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(223, 66);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(142, 66);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 2;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // hotkeySettingGroup
            // 
            this.hotkeySettingGroup.Controls.Add(this.resetHotkeyBtn);
            this.hotkeySettingGroup.Controls.Add(this.startStopLabel);
            this.hotkeySettingGroup.Controls.Add(this.hotkeyText);
            this.hotkeySettingGroup.Controls.Add(this.changeHotkeyBtn);
            this.hotkeySettingGroup.Location = new System.Drawing.Point(12, 12);
            this.hotkeySettingGroup.Name = "hotkeySettingGroup";
            this.hotkeySettingGroup.Size = new System.Drawing.Size(286, 48);
            this.hotkeySettingGroup.TabIndex = 4;
            this.hotkeySettingGroup.TabStop = false;
            this.hotkeySettingGroup.Text = "Hotkey setting";
            // 
            // HotkeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 101);
            this.Controls.Add(this.hotkeySettingGroup);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.cancelBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HotkeyForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hotkey setting";
            this.hotkeySettingGroup.ResumeLayout(false);
            this.hotkeySettingGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button resetHotkeyBtn;
        private System.Windows.Forms.Button changeHotkeyBtn;
        private System.Windows.Forms.TextBox hotkeyText;
        private System.Windows.Forms.Label startStopLabel;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.GroupBox hotkeySettingGroup;
    }
}