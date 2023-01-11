namespace DiaryApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnMenu = new System.Windows.Forms.Panel();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lbLogo = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pageMain = new System.Windows.Forms.TabControl();
            this.tabpageHome = new System.Windows.Forms.TabPage();
            this.pBanner = new System.Windows.Forms.PictureBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbHi = new System.Windows.Forms.Label();
            this.tabpageCalendar = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tabpageUser = new System.Windows.Forms.TabPage();
            this.lb1 = new System.Windows.Forms.Label();
            this.pUser = new System.Windows.Forms.PictureBox();
            this.lb2 = new System.Windows.Forms.Label();
            this.lbUsername1 = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pEditEmail = new System.Windows.Forms.PictureBox();
            this.pEditPass = new System.Windows.Forms.PictureBox();
            this.pEditUser = new System.Windows.Forms.PictureBox();
            this.pnMenu.SuspendLayout();
            this.pageMain.SuspendLayout();
            this.tabpageHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBanner)).BeginInit();
            this.tabpageCalendar.SuspendLayout();
            this.tabpageUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEditEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEditPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEditUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(130)))), ((int)(((byte)(95)))));
            this.pnMenu.Controls.Add(this.btnUser);
            this.pnMenu.Controls.Add(this.btnCalendar);
            this.pnMenu.Controls.Add(this.btnHome);
            this.pnMenu.Controls.Add(this.lbLogo);
            this.pnMenu.Controls.Add(this.btnLogout);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Margin = new System.Windows.Forms.Padding(0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(272, 1033);
            this.pnMenu.TabIndex = 0;
            // 
            // btnUser
            // 
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Image = global::DiaryApp.Properties.Resources.user;
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(0, 228);
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnUser.Size = new System.Drawing.Size(272, 71);
            this.btnUser.TabIndex = 5;
            this.btnUser.Text = " Tài khoản";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnCalendar
            // 
            this.btnCalendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalendar.FlatAppearance.BorderSize = 0;
            this.btnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendar.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalendar.ForeColor = System.Drawing.Color.White;
            this.btnCalendar.Image = global::DiaryApp.Properties.Resources.calendar;
            this.btnCalendar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendar.Location = new System.Drawing.Point(0, 157);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnCalendar.Size = new System.Drawing.Size(272, 71);
            this.btnCalendar.TabIndex = 4;
            this.btnCalendar.Text = " Lịch";
            this.btnCalendar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalendar.UseVisualStyleBackColor = true;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Gainsboro;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(130)))), ((int)(((byte)(95)))));
            this.btnHome.Image = global::DiaryApp.Properties.Resources.home_green;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 86);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(272, 71);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = " Trang chủ";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lbLogo
            // 
            this.lbLogo.BackColor = System.Drawing.Color.White;
            this.lbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbLogo.Font = new System.Drawing.Font("Cascadia Mono", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(130)))), ((int)(((byte)(95)))));
            this.lbLogo.Location = new System.Drawing.Point(0, 0);
            this.lbLogo.Name = "lbLogo";
            this.lbLogo.Size = new System.Drawing.Size(272, 86);
            this.lbLogo.TabIndex = 3;
            this.lbLogo.Text = "DiaryApp";
            this.lbLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(130)))), ((int)(((byte)(95)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::DiaryApp.Properties.Resources.logout;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(34, 934);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(183, 65);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = " Đăng xuất";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pageMain
            // 
            this.pageMain.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.pageMain.Controls.Add(this.tabpageHome);
            this.pageMain.Controls.Add(this.tabpageCalendar);
            this.pageMain.Controls.Add(this.tabpageUser);
            this.pageMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageMain.Location = new System.Drawing.Point(272, 0);
            this.pageMain.Name = "pageMain";
            this.pageMain.SelectedIndex = 0;
            this.pageMain.Size = new System.Drawing.Size(1630, 1033);
            this.pageMain.TabIndex = 1;
            // 
            // tabpageHome
            // 
            this.tabpageHome.BackColor = System.Drawing.Color.Gainsboro;
            this.tabpageHome.Controls.Add(this.pBanner);
            this.tabpageHome.Controls.Add(this.lbUsername);
            this.tabpageHome.Controls.Add(this.lbDate);
            this.tabpageHome.Controls.Add(this.label1);
            this.tabpageHome.Controls.Add(this.lbHi);
            this.tabpageHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(130)))), ((int)(((byte)(95)))));
            this.tabpageHome.Location = new System.Drawing.Point(4, 4);
            this.tabpageHome.Margin = new System.Windows.Forms.Padding(0);
            this.tabpageHome.Name = "tabpageHome";
            this.tabpageHome.Size = new System.Drawing.Size(1622, 1000);
            this.tabpageHome.TabIndex = 0;
            this.tabpageHome.Text = "TrangChu";
            // 
            // pBanner
            // 
            this.pBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBanner.Image = global::DiaryApp.Properties.Resources.banner;
            this.pBanner.Location = new System.Drawing.Point(0, 0);
            this.pBanner.Name = "pBanner";
            this.pBanner.Size = new System.Drawing.Size(1622, 255);
            this.pBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBanner.TabIndex = 1;
            this.pBanner.TabStop = false;
            // 
            // lbUsername
            // 
            this.lbUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(130)))), ((int)(((byte)(95)))));
            this.lbUsername.Location = new System.Drawing.Point(166, 273);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(277, 46);
            this.lbUsername.TabIndex = 0;
            this.lbUsername.Text = "user1";
            this.lbUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(130)))), ((int)(((byte)(95)))));
            this.lbDate.Location = new System.Drawing.Point(655, 274);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(450, 46);
            this.lbDate.TabIndex = 0;
            this.lbDate.Text = "thứ 5, ngày 12 tháng 1, 2023";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(130)))), ((int)(((byte)(95)))));
            this.label1.Location = new System.Drawing.Point(505, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hôm nay";
            // 
            // lbHi
            // 
            this.lbHi.AutoSize = true;
            this.lbHi.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbHi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(130)))), ((int)(((byte)(95)))));
            this.lbHi.Location = new System.Drawing.Point(20, 273);
            this.lbHi.Name = "lbHi";
            this.lbHi.Size = new System.Drawing.Size(161, 46);
            this.lbHi.TabIndex = 0;
            this.lbHi.Text = "Xin chào,";
            // 
            // tabpageCalendar
            // 
            this.tabpageCalendar.BackColor = System.Drawing.Color.Gainsboro;
            this.tabpageCalendar.Controls.Add(this.label2);
            this.tabpageCalendar.Location = new System.Drawing.Point(4, 4);
            this.tabpageCalendar.Name = "tabpageCalendar";
            this.tabpageCalendar.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageCalendar.Size = new System.Drawing.Size(1622, 1000);
            this.tabpageCalendar.TabIndex = 1;
            this.tabpageCalendar.Text = "Lich";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(217, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lich";
            // 
            // tabpageUser
            // 
            this.tabpageUser.BackColor = System.Drawing.Color.Gainsboro;
            this.tabpageUser.Controls.Add(this.pEditPass);
            this.tabpageUser.Controls.Add(this.pEditUser);
            this.tabpageUser.Controls.Add(this.pEditEmail);
            this.tabpageUser.Controls.Add(this.label6);
            this.tabpageUser.Controls.Add(this.lb2);
            this.tabpageUser.Controls.Add(this.pUser);
            this.tabpageUser.Controls.Add(this.label5);
            this.tabpageUser.Controls.Add(this.lbEmail);
            this.tabpageUser.Controls.Add(this.lbUsername1);
            this.tabpageUser.Controls.Add(this.lb1);
            this.tabpageUser.Location = new System.Drawing.Point(4, 4);
            this.tabpageUser.Name = "tabpageUser";
            this.tabpageUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageUser.Size = new System.Drawing.Size(1622, 1000);
            this.tabpageUser.TabIndex = 2;
            this.tabpageUser.Text = "TaiKhoan";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb1.Location = new System.Drawing.Point(370, 48);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(148, 38);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "Username:";
            this.lb1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pUser
            // 
            this.pUser.Image = global::DiaryApp.Properties.Resources.avt;
            this.pUser.Location = new System.Drawing.Point(120, 48);
            this.pUser.Name = "pUser";
            this.pUser.Size = new System.Drawing.Size(200, 200);
            this.pUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pUser.TabIndex = 2;
            this.pUser.TabStop = false;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb2.Location = new System.Drawing.Point(370, 127);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(229, 38);
            this.lb2.TabIndex = 3;
            this.lb2.Text = "Email đăng nhập:";
            this.lb2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbUsername1
            // 
            this.lbUsername1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbUsername1.Location = new System.Drawing.Point(628, 44);
            this.lbUsername1.Name = "lbUsername1";
            this.lbUsername1.Size = new System.Drawing.Size(484, 38);
            this.lbUsername1.TabIndex = 1;
            this.lbUsername1.Text = "Username";
            this.lbUsername1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbEmail
            // 
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEmail.Location = new System.Drawing.Point(628, 127);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(484, 38);
            this.lbEmail.TabIndex = 1;
            this.lbEmail.Text = "a@gmail.com";
            this.lbEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(628, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 38);
            this.label5.TabIndex = 1;
            this.label5.Text = "••••••••••••";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(370, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 38);
            this.label6.TabIndex = 3;
            this.label6.Text = "Mật khẩu";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pEditEmail
            // 
            this.pEditEmail.Image = global::DiaryApp.Properties.Resources.edit;
            this.pEditEmail.Location = new System.Drawing.Point(1118, 125);
            this.pEditEmail.Name = "pEditEmail";
            this.pEditEmail.Size = new System.Drawing.Size(40, 40);
            this.pEditEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pEditEmail.TabIndex = 4;
            this.pEditEmail.TabStop = false;
            // 
            // pEditPass
            // 
            this.pEditPass.Image = global::DiaryApp.Properties.Resources.edit;
            this.pEditPass.Location = new System.Drawing.Point(1118, 200);
            this.pEditPass.Name = "pEditPass";
            this.pEditPass.Size = new System.Drawing.Size(40, 40);
            this.pEditPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pEditPass.TabIndex = 4;
            this.pEditPass.TabStop = false;
            // 
            // pEditUser
            // 
            this.pEditUser.Image = global::DiaryApp.Properties.Resources.edit;
            this.pEditUser.Location = new System.Drawing.Point(1118, 48);
            this.pEditUser.Name = "pEditUser";
            this.pEditUser.Size = new System.Drawing.Size(40, 40);
            this.pEditUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pEditUser.TabIndex = 4;
            this.pEditUser.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.pageMain);
            this.Controls.Add(this.pnMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "DiaryApp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnMenu.ResumeLayout(false);
            this.pageMain.ResumeLayout(false);
            this.tabpageHome.ResumeLayout(false);
            this.tabpageHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBanner)).EndInit();
            this.tabpageCalendar.ResumeLayout(false);
            this.tabpageCalendar.PerformLayout();
            this.tabpageUser.ResumeLayout(false);
            this.tabpageUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEditEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEditPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEditUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnMenu;
        private Button btnLogout;
        private Button btnHome;
        private Label lbLogo;
        private Button btnUser;
        private Button btnCalendar;
        private TabControl pageMain;
        private TabPage tabpageHome;
        private TabPage tabpageCalendar;
        private TabPage tabpageUser;
        private Label lbHi;
        private Label label2;
        private Label lb1;
        private Label lbUsername;
        private PictureBox pBanner;
        private Label lbDate;
        private Label label1;
        private PictureBox pUser;
        private Label label6;
        private Label lb2;
        private Label label5;
        private Label lbEmail;
        private Label lbUsername1;
        private PictureBox pEditEmail;
        private PictureBox pEditPass;
        private PictureBox pEditUser;
    }
}