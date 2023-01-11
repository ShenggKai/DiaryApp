namespace DiaryApp.Source
{
    partial class changeEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(changeEmail));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uiLine3 = new Sunny.UI.UILine();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnChangeEmail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DiaryApp.Properties.Resources.envelope;
            this.pictureBox1.Location = new System.Drawing.Point(26, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // uiLine3
            // 
            this.uiLine3.FillColor = System.Drawing.Color.Transparent;
            this.uiLine3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLine3.LineCapSize = 10;
            this.uiLine3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(130)))), ((int)(((byte)(95)))));
            this.uiLine3.LineColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(130)))), ((int)(((byte)(95)))));
            this.uiLine3.LineDashStyle = Sunny.UI.UILineDashStyle.Solid;
            this.uiLine3.LineSize = 2;
            this.uiLine3.Location = new System.Drawing.Point(81, 71);
            this.uiLine3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine3.Name = "uiLine3";
            this.uiLine3.Size = new System.Drawing.Size(350, 10);
            this.uiLine3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine3.TabIndex = 23;
            this.uiLine3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Control;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.txtEmail.Location = new System.Drawing.Point(81, 40);
            this.txtEmail.MaxLength = 40;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.Size = new System.Drawing.Size(350, 29);
            this.txtEmail.TabIndex = 21;
            // 
            // btnChangeEmail
            // 
            this.btnChangeEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(130)))), ((int)(((byte)(95)))));
            this.btnChangeEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeEmail.FlatAppearance.BorderSize = 0;
            this.btnChangeEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChangeEmail.ForeColor = System.Drawing.Color.White;
            this.btnChangeEmail.Location = new System.Drawing.Point(142, 113);
            this.btnChangeEmail.Name = "btnChangeEmail";
            this.btnChangeEmail.Size = new System.Drawing.Size(180, 57);
            this.btnChangeEmail.TabIndex = 24;
            this.btnChangeEmail.Text = "Đổi email";
            this.btnChangeEmail.UseVisualStyleBackColor = false;
            // 
            // changeEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 203);
            this.Controls.Add(this.btnChangeEmail);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uiLine3);
            this.Controls.Add(this.txtEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "changeEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thay đổi email";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Sunny.UI.UILine uiLine3;
        private TextBox txtEmail;
        private Button btnChangeEmail;
    }
}