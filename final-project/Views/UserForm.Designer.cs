namespace final_project
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.buttonBack = new Bunifu.Framework.UI.BunifuTileButton();
            this.buttonClose = new Bunifu.Framework.UI.BunifuTileButton();
            this.title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.labelLoggedUserName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.labelLoggedUserProfileName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonUsers = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panelTopBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panelTopBar.Controls.Add(this.buttonBack);
            this.panelTopBar.Controls.Add(this.buttonClose);
            this.panelTopBar.Controls.Add(this.title);
            this.panelTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(777, 35);
            this.panelTopBar.TabIndex = 0;
            this.panelTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTopBar_MouseMove);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.buttonBack.color = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.buttonBack.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(91)))), ((int)(((byte)(98)))));
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Image = global::final_project.Properties.Resources.back;
            this.buttonBack.ImagePosition = 8;
            this.buttonBack.ImageZoom = 55;
            this.buttonBack.LabelPosition = 0;
            this.buttonBack.LabelText = "";
            this.buttonBack.Location = new System.Drawing.Point(0, 0);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(6);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(35, 35);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.buttonClose.color = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.buttonClose.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Image = global::final_project.Properties.Resources.close;
            this.buttonClose.ImagePosition = 9;
            this.buttonClose.ImageZoom = 45;
            this.buttonClose.LabelPosition = 0;
            this.buttonClose.LabelText = "";
            this.buttonClose.Location = new System.Drawing.Point(742, 0);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(6);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(35, 35);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.title.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(345, 7);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(90, 20);
            this.title.TabIndex = 2;
            this.title.Text = "Dashboard";
            this.title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTopBar_MouseMove);
            // 
            // labelLoggedUserName
            // 
            this.labelLoggedUserName.AutoSize = true;
            this.labelLoggedUserName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoggedUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.labelLoggedUserName.Location = new System.Drawing.Point(17, 51);
            this.labelLoggedUserName.Name = "labelLoggedUserName";
            this.labelLoggedUserName.Size = new System.Drawing.Size(155, 20);
            this.labelLoggedUserName.TabIndex = 8;
            this.labelLoggedUserName.Text = "NOME DO USUÁRIO";
            // 
            // labelLoggedUserProfileName
            // 
            this.labelLoggedUserProfileName.AutoSize = true;
            this.labelLoggedUserProfileName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoggedUserProfileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.labelLoggedUserProfileName.Location = new System.Drawing.Point(18, 76);
            this.labelLoggedUserProfileName.Name = "labelLoggedUserProfileName";
            this.labelLoggedUserProfileName.Size = new System.Drawing.Size(46, 16);
            this.labelLoggedUserProfileName.TabIndex = 10;
            this.labelLoggedUserProfileName.Text = "PERFIL";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.labelLoggedUserName);
            this.panel1.Controls.Add(this.buttonUsers);
            this.panel1.Controls.Add(this.labelLoggedUserProfileName);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 530);
            this.panel1.TabIndex = 11;
            // 
            // buttonUsers
            // 
            this.buttonUsers.ActiveBorderThickness = 1;
            this.buttonUsers.ActiveCornerRadius = 1;
            this.buttonUsers.ActiveFillColor = System.Drawing.Color.White;
            this.buttonUsers.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonUsers.ActiveLineColor = System.Drawing.Color.White;
            this.buttonUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonUsers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUsers.BackgroundImage")));
            this.buttonUsers.ButtonText = "Usuários";
            this.buttonUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUsers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonUsers.IdleBorderThickness = 1;
            this.buttonUsers.IdleCornerRadius = 1;
            this.buttonUsers.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.buttonUsers.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonUsers.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.buttonUsers.Location = new System.Drawing.Point(-7, 107);
            this.buttonUsers.Margin = new System.Windows.Forms.Padding(5);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(266, 60);
            this.buttonUsers.TabIndex = 6;
            this.buttonUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonUsers.Click += new System.EventHandler(this.buttonUsers_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(777, 530);
            this.Controls.Add(this.panelTopBar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelTopBar.ResumeLayout(false);
            this.panelTopBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuTileButton buttonClose;
        private System.Windows.Forms.Panel panelTopBar;
        private Bunifu.Framework.UI.BunifuCustomLabel title;
        private Bunifu.Framework.UI.BunifuTileButton buttonBack;
        private Bunifu.Framework.UI.BunifuCustomLabel labelLoggedUserName;
        private Bunifu.Framework.UI.BunifuCustomLabel labelLoggedUserProfileName;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonUsers;
    }
}

