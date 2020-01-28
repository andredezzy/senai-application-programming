namespace final_project
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.buttonClose = new Bunifu.Framework.UI.BunifuTileButton();
            this.textEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.labelEmail = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.labelPassword = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.textPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.buttonBack = new Bunifu.Framework.UI.BunifuThinButton2();
            this.buttonSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.labelName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.textName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.labelUser = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.textUser = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuSeparator4 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panelTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panelTopBar.Controls.Add(this.buttonClose);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(471, 35);
            this.panelTopBar.TabIndex = 0;
            this.panelTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTopBar_MouseMove);
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
            this.buttonClose.Location = new System.Drawing.Point(436, 0);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(6);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(35, 35);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textEmail
            // 
            this.textEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textEmail.HintForeColor = System.Drawing.Color.Empty;
            this.textEmail.HintText = "";
            this.textEmail.isPassword = false;
            this.textEmail.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(91)))), ((int)(((byte)(98)))));
            this.textEmail.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(114)))), ((int)(((byte)(123)))));
            this.textEmail.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(91)))), ((int)(((byte)(98)))));
            this.textEmail.LineThickness = 3;
            this.textEmail.Location = new System.Drawing.Point(48, 166);
            this.textEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(370, 44);
            this.textEmail.TabIndex = 1;
            this.textEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(91)))), ((int)(((byte)(98)))));
            this.labelEmail.Location = new System.Drawing.Point(44, 154);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(54, 18);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "E-mail";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(91)))), ((int)(((byte)(98)))));
            this.labelPassword.Location = new System.Drawing.Point(43, 310);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(54, 18);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Senha";
            // 
            // textPassword
            // 
            this.textPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textPassword.HintForeColor = System.Drawing.Color.Empty;
            this.textPassword.HintText = "";
            this.textPassword.isPassword = true;
            this.textPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(91)))), ((int)(((byte)(98)))));
            this.textPassword.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(114)))), ((int)(((byte)(123)))));
            this.textPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(91)))), ((int)(((byte)(98)))));
            this.textPassword.LineThickness = 3;
            this.textPassword.Location = new System.Drawing.Point(47, 322);
            this.textPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(370, 44);
            this.textPassword.TabIndex = 3;
            this.textPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // buttonBack
            // 
            this.buttonBack.ActiveBorderThickness = 1;
            this.buttonBack.ActiveCornerRadius = 1;
            this.buttonBack.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.buttonBack.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonBack.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.buttonBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBack.BackgroundImage")));
            this.buttonBack.ButtonText = "Voltar";
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonBack.IdleBorderThickness = 1;
            this.buttonBack.IdleCornerRadius = 1;
            this.buttonBack.IdleFillColor = System.Drawing.Color.White;
            this.buttonBack.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonBack.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonBack.Location = new System.Drawing.Point(46, 408);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(5);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(175, 60);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.ActiveBorderThickness = 1;
            this.buttonSave.ActiveCornerRadius = 1;
            this.buttonSave.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.buttonSave.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonSave.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.buttonSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSave.BackgroundImage")));
            this.buttonSave.ButtonText = "Salvar";
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonSave.IdleBorderThickness = 1;
            this.buttonSave.IdleCornerRadius = 1;
            this.buttonSave.IdleFillColor = System.Drawing.Color.White;
            this.buttonSave.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonSave.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonSave.Location = new System.Drawing.Point(243, 408);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(175, 60);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(104, 146);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(313, 35);
            this.bunifuSeparator1.TabIndex = 7;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(103, 303);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(314, 35);
            this.bunifuSeparator2.TabIndex = 8;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.title.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(192, 6);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(82, 20);
            this.title.TabIndex = 2;
            this.title.Text = "Cadastrar";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(91)))), ((int)(((byte)(98)))));
            this.labelName.Location = new System.Drawing.Point(44, 77);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(53, 18);
            this.labelName.TabIndex = 10;
            this.labelName.Text = "Nome";
            // 
            // textName
            // 
            this.textName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textName.HintForeColor = System.Drawing.Color.Empty;
            this.textName.HintText = "";
            this.textName.isPassword = false;
            this.textName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(91)))), ((int)(((byte)(98)))));
            this.textName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(114)))), ((int)(((byte)(123)))));
            this.textName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(91)))), ((int)(((byte)(98)))));
            this.textName.LineThickness = 3;
            this.textName.Location = new System.Drawing.Point(48, 89);
            this.textName.Margin = new System.Windows.Forms.Padding(4);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(370, 44);
            this.textName.TabIndex = 9;
            this.textName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(104, 69);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(313, 35);
            this.bunifuSeparator3.TabIndex = 11;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(91)))), ((int)(((byte)(98)))));
            this.labelUser.Location = new System.Drawing.Point(44, 232);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(62, 18);
            this.labelUser.TabIndex = 13;
            this.labelUser.Text = "Usuário";
            // 
            // textUser
            // 
            this.textUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textUser.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textUser.HintForeColor = System.Drawing.Color.Empty;
            this.textUser.HintText = "";
            this.textUser.isPassword = false;
            this.textUser.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(91)))), ((int)(((byte)(98)))));
            this.textUser.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(114)))), ((int)(((byte)(123)))));
            this.textUser.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(91)))), ((int)(((byte)(98)))));
            this.textUser.LineThickness = 3;
            this.textUser.Location = new System.Drawing.Point(48, 244);
            this.textUser.Margin = new System.Windows.Forms.Padding(4);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(370, 44);
            this.textUser.TabIndex = 12;
            this.textUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.bunifuSeparator4.LineThickness = 1;
            this.bunifuSeparator4.Location = new System.Drawing.Point(112, 224);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.Size = new System.Drawing.Size(305, 35);
            this.bunifuSeparator4.TabIndex = 14;
            this.bunifuSeparator4.Transparency = 255;
            this.bunifuSeparator4.Vertical = false;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(471, 502);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.bunifuSeparator4);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.bunifuSeparator3);
            this.Controls.Add(this.title);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.panelTopBar);
            this.Controls.Add(this.bunifuSeparator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelTopBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuTileButton buttonClose;
        private System.Windows.Forms.Panel panelTopBar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textEmail;
        private Bunifu.Framework.UI.BunifuCustomLabel labelEmail;
        private Bunifu.Framework.UI.BunifuCustomLabel labelPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textPassword;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonBack;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonSave;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuCustomLabel title;
        private Bunifu.Framework.UI.BunifuCustomLabel labelName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textName;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private Bunifu.Framework.UI.BunifuCustomLabel labelUser;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textUser;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator4;
    }
}

