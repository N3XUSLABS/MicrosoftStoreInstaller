namespace NexusLabs.MicrosoftStoreInstaller
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new MetroFramework.Controls.MetroPanel();
            this.tbPID = new MetroFramework.Controls.MetroTextBox();
            this.lbInstallApp = new MetroFramework.Controls.MetroLabel();
            this.btnInstall = new MetroFramework.Controls.MetroButton();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.tbPID);
            this.panel.Controls.Add(this.lbInstallApp);
            this.panel.Controls.Add(this.btnInstall);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(20, 60);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(139, 84);
            this.panel.TabIndex = 0;
            // 
            // tbPID
            // 
            // 
            // 
            // 
            this.tbPID.CustomButton.Image = null;
            this.tbPID.CustomButton.Location = new System.Drawing.Point(109, 1);
            this.tbPID.CustomButton.Name = "";
            this.tbPID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPID.CustomButton.TabIndex = 1;
            this.tbPID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPID.CustomButton.UseSelectable = true;
            this.tbPID.CustomButton.Visible = false;
            this.tbPID.Lines = new string[0];
            this.tbPID.Location = new System.Drawing.Point(4, 26);
            this.tbPID.MaxLength = 32767;
            this.tbPID.Name = "tbPID";
            this.tbPID.PasswordChar = '\0';
            this.tbPID.PromptText = "9NBLGGGZM6WM";
            this.tbPID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPID.SelectedText = "";
            this.tbPID.SelectionLength = 0;
            this.tbPID.SelectionStart = 0;
            this.tbPID.ShortcutsEnabled = true;
            this.tbPID.Size = new System.Drawing.Size(131, 23);
            this.tbPID.TabIndex = 2;
            this.tbPID.UseSelectable = true;
            this.tbPID.WaterMark = "9NBLGGGZM6WM";
            this.tbPID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbInstallApp
            // 
            this.lbInstallApp.AutoSize = true;
            this.lbInstallApp.Location = new System.Drawing.Point(4, 4);
            this.lbInstallApp.Name = "lbInstallApp";
            this.lbInstallApp.Size = new System.Drawing.Size(89, 19);
            this.lbInstallApp.TabIndex = 1;
            this.lbInstallApp.Text = "Install an app:";
            // 
            // btnInstall
            // 
            this.btnInstall.Location = new System.Drawing.Point(4, 55);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(130, 23);
            this.btnInstall.TabIndex = 0;
            this.btnInstall.Text = "Install";
            this.btnInstall.UseSelectable = true;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 164);
            this.Controls.Add(this.panel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Text = "App Installer";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panel;
        private MetroFramework.Controls.MetroButton btnInstall;
        private MetroFramework.Controls.MetroTextBox tbPID;
        private MetroFramework.Controls.MetroLabel lbInstallApp;
    }
}

