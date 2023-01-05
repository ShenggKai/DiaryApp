namespace DiaryApp.Source
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pnImage = new System.Windows.Forms.Panel();
            this.pLock = new System.Windows.Forms.PictureBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.uiLine2 = new Sunny.UI.UILine();
            this.pUser = new System.Windows.Forms.PictureBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.uiLine1 = new Sunny.UI.UILine();
            this.pClose = new System.Windows.Forms.PictureBox();
            this.lbDiaryApp = new System.Windows.Forms.Label();
            this.pageLogAndReg = new Sunny.UI.UITabControl();
            this.tabpageLog = new System.Windows.Forms.TabPage();
            this.lbForget = new Sunny.UI.UISymbolLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tabpageRes = new System.Windows.Forms.TabPage();
            this.lbQues = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pClose)).BeginInit();
            this.pageLogAndReg.SuspendLayout();
            this.tabpageLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnImage
            // 
            this.pnImage.BackgroundImage = global::DiaryApp.Properties.Resources.astronaut;
            this.pnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnImage.Location = new System.Drawing.Point(0, 0);
            this.pnImage.Name = "pnImage";
            this.pnImage.Size = new System.Drawing.Size(426, 569);
            this.pnImage.TabIndex = 0;
            // 
            // pLock
            // 
            this.pLock.BackColor = System.Drawing.Color.Transparent;
            this.pLock.Image = global::DiaryApp.Properties.Resources._lock;
            this.pLock.Location = new System.Drawing.Point(83, 209);
            this.pLock.Name = "pLock";
            this.pLock.Size = new System.Drawing.Size(40, 40);
            this.pLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pLock.TabIndex = 5;
            this.pLock.TabStop = false;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.Control;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.txtUserName.Location = new System.Drawing.Point(138, 128);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PlaceholderText = "Username hoặc email";
            this.txtUserName.Size = new System.Drawing.Size(350, 29);
            this.txtUserName.TabIndex = 4;
            // 
            // uiLine2
            // 
            this.uiLine2.FillColor = System.Drawing.Color.Transparent;
            this.uiLine2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLine2.LineCapSize = 10;
            this.uiLine2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(130)))), ((int)(((byte)(95)))));
            this.uiLine2.LineColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(130)))), ((int)(((byte)(95)))));
            this.uiLine2.LineDashStyle = Sunny.UI.UILineDashStyle.Solid;
            this.uiLine2.LineSize = 2;
            this.uiLine2.Location = new System.Drawing.Point(138, 249);
            this.uiLine2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine2.Name = "uiLine2";
            this.uiLine2.Size = new System.Drawing.Size(350, 10);
            this.uiLine2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine2.TabIndex = 3;
            this.uiLine2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // pUser
            // 
            this.pUser.BackColor = System.Drawing.Color.Transparent;
            this.pUser.Image = global::DiaryApp.Properties.Resources.user_green;
            this.pUser.Location = new System.Drawing.Point(83, 119);
            this.pUser.Name = "pUser";
            this.pUser.Size = new System.Drawing.Size(40, 40);
            this.pUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pUser.TabIndex = 5;
            this.pUser.TabStop = false;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.SystemColors.Control;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.txtPass.Location = new System.Drawing.Point(138, 218);
            this.txtPass.Name = "txtPass";
            this.txtPass.PlaceholderText = "Mật khẩu";
            this.txtPass.Size = new System.Drawing.Size(350, 29);
            this.txtPass.TabIndex = 4;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // uiLine1
            // 
            this.uiLine1.FillColor = System.Drawing.Color.Transparent;
            this.uiLine1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLine1.LineCapSize = 10;
            this.uiLine1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(130)))), ((int)(((byte)(95)))));
            this.uiLine1.LineColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(130)))), ((int)(((byte)(95)))));
            this.uiLine1.LineDashStyle = Sunny.UI.UILineDashStyle.Solid;
            this.uiLine1.LineSize = 2;
            this.uiLine1.Location = new System.Drawing.Point(138, 163);
            this.uiLine1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(350, 10);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.TabIndex = 3;
            this.uiLine1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // pClose
            // 
            this.pClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pClose.Image = global::DiaryApp.Properties.Resources.close_green;
            this.pClose.Location = new System.Drawing.Point(963, 15);
            this.pClose.Name = "pClose";
            this.pClose.Size = new System.Drawing.Size(20, 20);
            this.pClose.TabIndex = 1;
            this.pClose.TabStop = false;
            this.pClose.Click += new System.EventHandler(this.pClose_Click);
            // 
            // lbDiaryApp
            // 
            this.lbDiaryApp.BackColor = System.Drawing.Color.Transparent;
            this.lbDiaryApp.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbDiaryApp.Font = new System.Drawing.Font("Cascadia Mono", 28.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbDiaryApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(130)))), ((int)(((byte)(95)))));
            this.lbDiaryApp.Location = new System.Drawing.Point(0, 0);
            this.lbDiaryApp.Name = "lbDiaryApp";
            this.lbDiaryApp.Size = new System.Drawing.Size(572, 65);
            this.lbDiaryApp.TabIndex = 2;
            this.lbDiaryApp.Text = "DiaryApp";
            this.lbDiaryApp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pageLogAndReg
            // 
            this.pageLogAndReg.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.pageLogAndReg.Controls.Add(this.tabpageLog);
            this.pageLogAndReg.Controls.Add(this.tabpageRes);
            this.pageLogAndReg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pageLogAndReg.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.pageLogAndReg.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pageLogAndReg.Frame = null;
            this.pageLogAndReg.ItemSize = new System.Drawing.Size(150, 40);
            this.pageLogAndReg.Location = new System.Drawing.Point(426, 41);
            this.pageLogAndReg.MainPage = "";
            this.pageLogAndReg.Name = "pageLogAndReg";
            this.pageLogAndReg.SelectedIndex = 0;
            this.pageLogAndReg.Size = new System.Drawing.Size(572, 528);
            this.pageLogAndReg.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.pageLogAndReg.TabIndex = 3;
            this.pageLogAndReg.TabUnSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pageLogAndReg.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // tabpageLog
            // 
            this.tabpageLog.BackColor = System.Drawing.SystemColors.Control;
            this.tabpageLog.Controls.Add(this.lbQues);
            this.tabpageLog.Controls.Add(this.lbForget);
            this.tabpageLog.Controls.Add(this.btnLogin);
            this.tabpageLog.Controls.Add(this.pLock);
            this.tabpageLog.Controls.Add(this.lbDiaryApp);
            this.tabpageLog.Controls.Add(this.txtUserName);
            this.tabpageLog.Controls.Add(this.uiLine2);
            this.tabpageLog.Controls.Add(this.uiLine1);
            this.tabpageLog.Controls.Add(this.pUser);
            this.tabpageLog.Controls.Add(this.txtPass);
            this.tabpageLog.Location = new System.Drawing.Point(0, 0);
            this.tabpageLog.Name = "tabpageLog";
            this.tabpageLog.Size = new System.Drawing.Size(572, 488);
            this.tabpageLog.TabIndex = 0;
            this.tabpageLog.Text = "DangNhap";
            // 
            // lbForget
            // 
            this.lbForget.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbForget.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbForget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(130)))), ((int)(((byte)(95)))));
            this.lbForget.ImageInterval = 0;
            this.lbForget.Location = new System.Drawing.Point(312, 265);
            this.lbForget.MinimumSize = new System.Drawing.Size(1, 1);
            this.lbForget.Name = "lbForget";
            this.lbForget.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.lbForget.Size = new System.Drawing.Size(176, 35);
            this.lbForget.Style = Sunny.UI.UIStyle.Custom;
            this.lbForget.Symbol = 117;
            this.lbForget.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(130)))), ((int)(((byte)(95)))));
            this.lbForget.SymbolOffset = new System.Drawing.Point(155, 0);
            this.lbForget.SymbolSize = 26;
            this.lbForget.TabIndex = 7;
            this.lbForget.Text = "Quên mật khẩu";
            this.lbForget.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbForget.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(130)))), ((int)(((byte)(95)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(196, 334);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(180, 57);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // tabpageRes
            // 
            this.tabpageRes.Location = new System.Drawing.Point(0, 0);
            this.tabpageRes.Name = "tabpageRes";
            this.tabpageRes.Size = new System.Drawing.Size(200, 60);
            this.tabpageRes.TabIndex = 1;
            this.tabpageRes.Text = "DangKy";
            this.tabpageRes.UseVisualStyleBackColor = true;
            // 
            // lbQues
            // 
            this.lbQues.AutoSize = true;
            this.lbQues.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbQues.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(130)))), ((int)(((byte)(95)))));
            this.lbQues.Location = new System.Drawing.Point(101, 439);
            this.lbQues.Name = "lbQues";
            this.lbQues.Size = new System.Drawing.Size(251, 25);
            this.lbQues.TabIndex = 8;
            this.lbQues.Text = "Chưa có tài khoản? Đăng ký";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 569);
            this.Controls.Add(this.pageLogAndReg);
            this.Controls.Add(this.pClose);
            this.Controls.Add(this.pnImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pClose)).EndInit();
            this.pageLogAndReg.ResumeLayout(false);
            this.tabpageLog.ResumeLayout(false);
            this.tabpageLog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnImage;
        private PictureBox pClose;
        private Label lbDiaryApp;
        private Sunny.UI.UILine uiLine1;
        private TextBox txtUserName;
        private PictureBox pUser;
        private Sunny.UI.UILine uiLine2;
        private TextBox txtPass;
        private PictureBox pLock;
        private Sunny.UI.UITabControl pageLogAndReg;
        private TabPage tabpageLog;
        private TabPage tabpageRes;
        private Button btnLogin;
        private Sunny.UI.UISymbolLabel lbForget;
        private Label lbQues;
    }
}