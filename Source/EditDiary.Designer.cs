namespace DiaryApp.Source
{
    partial class EditDiary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDiary));
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtEditConent = new System.Windows.Forms.RichTextBox();
            this.pAddImage = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnPost = new Sunny.UI.UIButton();
            this.btnCancel = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.pAddImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTitle.Location = new System.Drawing.Point(12, 12);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PlaceholderText = "Nhập tiêu đề";
            this.txtTitle.Size = new System.Drawing.Size(1072, 34);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(130)))), ((int)(((byte)(95)))));
            this.panel1.Location = new System.Drawing.Point(12, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 2);
            this.panel1.TabIndex = 1;
            // 
            // rtEditConent
            // 
            this.rtEditConent.BackColor = System.Drawing.Color.Gainsboro;
            this.rtEditConent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtEditConent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtEditConent.Location = new System.Drawing.Point(12, 136);
            this.rtEditConent.Name = "rtEditConent";
            this.rtEditConent.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtEditConent.Size = new System.Drawing.Size(1072, 302);
            this.rtEditConent.TabIndex = 2;
            this.rtEditConent.Text = "";
            // 
            // pAddImage
            // 
            this.pAddImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pAddImage.Image = global::DiaryApp.Properties.Resources.addphoto;
            this.pAddImage.Location = new System.Drawing.Point(506, 84);
            this.pAddImage.Name = "pAddImage";
            this.pAddImage.Size = new System.Drawing.Size(35, 35);
            this.pAddImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pAddImage.TabIndex = 3;
            this.pAddImage.TabStop = false;
            this.pAddImage.Click += new System.EventHandler(this.pAddImage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::DiaryApp.Properties.Resources.heading1;
            this.pictureBox1.Location = new System.Drawing.Point(603, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::DiaryApp.Properties.Resources.heading2;
            this.pictureBox2.Location = new System.Drawing.Point(688, 84);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::DiaryApp.Properties.Resources.heading3;
            this.pictureBox3.Location = new System.Drawing.Point(774, 84);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // btnPost
            // 
            this.btnPost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPost.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(130)))), ((int)(((byte)(95)))));
            this.btnPost.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(130)))), ((int)(((byte)(95)))));
            this.btnPost.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(160)))), ((int)(((byte)(103)))));
            this.btnPost.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(130)))), ((int)(((byte)(95)))));
            this.btnPost.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPost.Location = new System.Drawing.Point(910, 465);
            this.btnPost.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnPost.Name = "btnPost";
            this.btnPost.Radius = 30;
            this.btnPost.Size = new System.Drawing.Size(145, 55);
            this.btnPost.Style = Sunny.UI.UIStyle.Custom;
            this.btnPost.TabIndex = 4;
            this.btnPost.Text = "Đăng";
            this.btnPost.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FillColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.FillColor2 = System.Drawing.Color.Gainsboro;
            this.btnCancel.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(160)))), ((int)(((byte)(103)))));
            this.btnCancel.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(130)))), ((int)(((byte)(95)))));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.DimGray;
            this.btnCancel.Location = new System.Drawing.Point(688, 465);
            this.btnCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Radius = 30;
            this.btnCancel.RectColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.RectDisableColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.RectHoverColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.RectPressColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.RectSelectedColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.Size = new System.Drawing.Size(145, 55);
            this.btnCancel.Style = Sunny.UI.UIStyle.Custom;
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // EditDiary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 532);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pAddImage);
            this.Controls.Add(this.rtEditConent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditDiary";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nội dung nhật ký";
            ((System.ComponentModel.ISupportInitialize)(this.pAddImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtTitle;
        private Panel panel1;
        private RichTextBox rtEditConent;
        private PictureBox pAddImage;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Sunny.UI.UIButton btnPost;
        private Sunny.UI.UIButton btnCancel;
    }
}