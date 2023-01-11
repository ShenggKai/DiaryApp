﻿namespace DiaryApp
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
            this.tabpageCalendar = new System.Windows.Forms.TabPage();
            this.tabpageUser = new System.Windows.Forms.TabPage();
            this.pnMenu.SuspendLayout();
            this.pageMain.SuspendLayout();
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
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::DiaryApp.Properties.Resources.home_full;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 86);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(272, 71);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = " Trang chủ";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
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
            this.btnLogout.BackColor = System.Drawing.Color.ForestGreen;
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
            this.tabpageHome.Location = new System.Drawing.Point(4, 4);
            this.tabpageHome.Name = "tabpageHome";
            this.tabpageHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageHome.Size = new System.Drawing.Size(1622, 1000);
            this.tabpageHome.TabIndex = 0;
            this.tabpageHome.Text = "TrangChu";
            this.tabpageHome.UseVisualStyleBackColor = true;
            // 
            // tabpageCalendar
            // 
            this.tabpageCalendar.Location = new System.Drawing.Point(4, 4);
            this.tabpageCalendar.Name = "tabpageCalendar";
            this.tabpageCalendar.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageCalendar.Size = new System.Drawing.Size(1622, 1000);
            this.tabpageCalendar.TabIndex = 1;
            this.tabpageCalendar.Text = "Lich";
            this.tabpageCalendar.UseVisualStyleBackColor = true;
            // 
            // tabpageUser
            // 
            this.tabpageUser.Location = new System.Drawing.Point(4, 4);
            this.tabpageUser.Name = "tabpageUser";
            this.tabpageUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageUser.Size = new System.Drawing.Size(1622, 1000);
            this.tabpageUser.TabIndex = 2;
            this.tabpageUser.Text = "TaiKhoan";
            this.tabpageUser.UseVisualStyleBackColor = true;
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
            this.pnMenu.ResumeLayout(false);
            this.pageMain.ResumeLayout(false);
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
    }
}