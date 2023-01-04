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
            this.pClose = new System.Windows.Forms.PictureBox();
            this.lbDiaryApp = new System.Windows.Forms.Label();
            this.uiLine1 = new Sunny.UI.UILine();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.pUser = new System.Windows.Forms.PictureBox();
            this.uiLine2 = new Sunny.UI.UILine();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.pLock = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLock)).BeginInit();
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
            this.lbDiaryApp.Font = new System.Drawing.Font("Cascadia Mono", 28.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbDiaryApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(130)))), ((int)(((byte)(95)))));
            this.lbDiaryApp.Location = new System.Drawing.Point(432, 54);
            this.lbDiaryApp.Name = "lbDiaryApp";
            this.lbDiaryApp.Size = new System.Drawing.Size(561, 70);
            this.lbDiaryApp.TabIndex = 2;
            this.lbDiaryApp.Text = "DiaryApp";
            this.lbDiaryApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.uiLine1.Location = new System.Drawing.Point(589, 246);
            this.uiLine1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(306, 10);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.TabIndex = 3;
            this.uiLine1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.Control;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUserName.Location = new System.Drawing.Point(589, 215);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(306, 29);
            this.txtUserName.TabIndex = 4;
            // 
            // pUser
            // 
            this.pUser.BackColor = System.Drawing.Color.Transparent;
            this.pUser.Image = global::DiaryApp.Properties.Resources.user_green;
            this.pUser.Location = new System.Drawing.Point(529, 206);
            this.pUser.Name = "pUser";
            this.pUser.Size = new System.Drawing.Size(40, 40);
            this.pUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pUser.TabIndex = 5;
            this.pUser.TabStop = false;
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
            this.uiLine2.Location = new System.Drawing.Point(589, 338);
            this.uiLine2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine2.Name = "uiLine2";
            this.uiLine2.Size = new System.Drawing.Size(306, 10);
            this.uiLine2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine2.TabIndex = 3;
            this.uiLine2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.SystemColors.Control;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPass.Location = new System.Drawing.Point(589, 307);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(306, 29);
            this.txtPass.TabIndex = 4;
            // 
            // pLock
            // 
            this.pLock.BackColor = System.Drawing.Color.Transparent;
            this.pLock.Image = global::DiaryApp.Properties.Resources._lock;
            this.pLock.Location = new System.Drawing.Point(529, 298);
            this.pLock.Name = "pLock";
            this.pLock.Size = new System.Drawing.Size(40, 40);
            this.pLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pLock.TabIndex = 5;
            this.pLock.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 569);
            this.Controls.Add(this.pLock);
            this.Controls.Add(this.pUser);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.uiLine2);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.lbDiaryApp);
            this.Controls.Add(this.pClose);
            this.Controls.Add(this.pnImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}