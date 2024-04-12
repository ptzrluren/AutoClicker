namespace AutoClicker {
    partial class AboutForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.aboutGroup = new System.Windows.Forms.GroupBox();
            this.iconPicture = new System.Windows.Forms.PictureBox();
            this.descriptionText = new System.Windows.Forms.TextBox();
            this.companyLabel = new System.Windows.Forms.Label();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.aboutGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // aboutGroup
            // 
            this.aboutGroup.Controls.Add(this.iconPicture);
            this.aboutGroup.Controls.Add(this.descriptionText);
            this.aboutGroup.Controls.Add(this.companyLabel);
            this.aboutGroup.Controls.Add(this.copyrightLabel);
            this.aboutGroup.Controls.Add(this.versionLabel);
            this.aboutGroup.Controls.Add(this.titleLabel);
            this.aboutGroup.Location = new System.Drawing.Point(13, 13);
            this.aboutGroup.Name = "aboutGroup";
            this.aboutGroup.Size = new System.Drawing.Size(199, 158);
            this.aboutGroup.TabIndex = 0;
            this.aboutGroup.TabStop = false;
            // 
            // iconPicture
            // 
            this.iconPicture.Location = new System.Drawing.Point(143, 19);
            this.iconPicture.Name = "iconPicture";
            this.iconPicture.Size = new System.Drawing.Size(50, 50);
            this.iconPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPicture.TabIndex = 5;
            this.iconPicture.TabStop = false;
            // 
            // descriptionText
            // 
            this.descriptionText.Location = new System.Drawing.Point(6, 102);
            this.descriptionText.Multiline = true;
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.ReadOnly = true;
            this.descriptionText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.descriptionText.Size = new System.Drawing.Size(187, 50);
            this.descriptionText.TabIndex = 4;
            this.descriptionText.TabStop = false;
            this.descriptionText.Text = "Description";
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Location = new System.Drawing.Point(6, 83);
            this.companyLabel.Margin = new System.Windows.Forms.Padding(3);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(51, 13);
            this.companyLabel.TabIndex = 3;
            this.companyLabel.Text = "Company";
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.Location = new System.Drawing.Point(6, 64);
            this.copyrightLabel.Margin = new System.Windows.Forms.Padding(3);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(51, 13);
            this.copyrightLabel.TabIndex = 2;
            this.copyrightLabel.Text = "Copyright";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(6, 45);
            this.versionLabel.Margin = new System.Windows.Forms.Padding(3);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(42, 13);
            this.versionLabel.TabIndex = 1;
            this.versionLabel.Text = "Version";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(6, 19);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(3);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(38, 20);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(137, 177);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 1;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 212);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.aboutGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.aboutGroup.ResumeLayout(false);
            this.aboutGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox aboutGroup;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox descriptionText;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.PictureBox iconPicture;
    }
}