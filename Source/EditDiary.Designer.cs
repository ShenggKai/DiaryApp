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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDiary));
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtEditConent = new System.Windows.Forms.RichTextBox();
            this.pAddImg = new System.Windows.Forms.PictureBox();
            this.pForeColor = new System.Windows.Forms.PictureBox();
            this.pFont = new System.Windows.Forms.PictureBox();
            this.btnPost = new Sunny.UI.UIButton();
            this.btnCancel = new Sunny.UI.UIButton();
            this.pInsertimage = new System.Windows.Forms.PictureBox();
            this.pBold = new System.Windows.Forms.PictureBox();
            this.pItalic = new System.Windows.Forms.PictureBox();
            this.pUnderline = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.fpnImg = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pAddImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pForeColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pFont)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pInsertimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pItalic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUnderline)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTitle.Location = new System.Drawing.Point(12, 12);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PlaceholderText = "Nhập tiêu đề";
            this.txtTitle.Size = new System.Drawing.Size(1072, 34);
            this.txtTitle.TabIndex = 3;
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(130)))), ((int)(((byte)(95)))));
            this.panel1.Location = new System.Drawing.Point(12, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 2);
            this.panel1.TabIndex = 0;
            // 
            // rtEditConent
            // 
            this.rtEditConent.BackColor = System.Drawing.Color.Gainsboro;
            this.rtEditConent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtEditConent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtEditConent.Location = new System.Drawing.Point(324, 136);
            this.rtEditConent.Name = "rtEditConent";
            this.rtEditConent.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtEditConent.Size = new System.Drawing.Size(760, 323);
            this.rtEditConent.TabIndex = 2;
            this.rtEditConent.Text = "";
            // 
            // pAddImg
            // 
            this.pAddImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pAddImg.Image = global::DiaryApp.Properties.Resources.addphoto;
            this.pAddImg.Location = new System.Drawing.Point(622, 84);
            this.pAddImg.Name = "pAddImg";
            this.pAddImg.Size = new System.Drawing.Size(35, 35);
            this.pAddImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pAddImg.TabIndex = 3;
            this.pAddImg.TabStop = false;
            this.toolTip1.SetToolTip(this.pAddImg, "nhấp để thêm hình ảnh");
            this.pAddImg.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pForeColor
            // 
            this.pForeColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pForeColor.Image = global::DiaryApp.Properties.Resources.fontcolor;
            this.pForeColor.Location = new System.Drawing.Point(704, 84);
            this.pForeColor.Name = "pForeColor";
            this.pForeColor.Size = new System.Drawing.Size(35, 35);
            this.pForeColor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pForeColor.TabIndex = 3;
            this.pForeColor.TabStop = false;
            this.toolTip1.SetToolTip(this.pForeColor, "nhấp để thay đổi màu chữ");
            this.pForeColor.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pFont
            // 
            this.pFont.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pFont.Image = global::DiaryApp.Properties.Resources.typography;
            this.pFont.Location = new System.Drawing.Point(783, 84);
            this.pFont.Name = "pFont";
            this.pFont.Size = new System.Drawing.Size(35, 35);
            this.pFont.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pFont.TabIndex = 3;
            this.pFont.TabStop = false;
            this.toolTip1.SetToolTip(this.pFont, "nhấp để thay đổi kiểu chữ");
            this.pFont.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btnPost
            // 
            this.btnPost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPost.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(130)))), ((int)(((byte)(95)))));
            this.btnPost.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(130)))), ((int)(((byte)(95)))));
            this.btnPost.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(160)))), ((int)(((byte)(103)))));
            this.btnPost.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(130)))), ((int)(((byte)(95)))));
            this.btnPost.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPost.Location = new System.Drawing.Point(910, 469);
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
            this.btnCancel.Location = new System.Drawing.Point(688, 469);
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
            // pInsertimage
            // 
            this.pInsertimage.Image = global::DiaryApp.Properties.Resources.insertimage;
            this.pInsertimage.Location = new System.Drawing.Point(12, 136);
            this.pInsertimage.Name = "pInsertimage";
            this.pInsertimage.Size = new System.Drawing.Size(300, 300);
            this.pInsertimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pInsertimage.TabIndex = 5;
            this.pInsertimage.TabStop = false;
            // 
            // pBold
            // 
            this.pBold.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBold.Image = global::DiaryApp.Properties.Resources.bold_gray;
            this.pBold.Location = new System.Drawing.Point(858, 84);
            this.pBold.Name = "pBold";
            this.pBold.Size = new System.Drawing.Size(35, 35);
            this.pBold.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBold.TabIndex = 3;
            this.pBold.TabStop = false;
            this.toolTip1.SetToolTip(this.pBold, "in đậm");
            this.pBold.Click += new System.EventHandler(this.pBold_Click);
            // 
            // pItalic
            // 
            this.pItalic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pItalic.Image = global::DiaryApp.Properties.Resources.italics_gray;
            this.pItalic.Location = new System.Drawing.Point(935, 84);
            this.pItalic.Name = "pItalic";
            this.pItalic.Size = new System.Drawing.Size(35, 35);
            this.pItalic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pItalic.TabIndex = 3;
            this.pItalic.TabStop = false;
            this.toolTip1.SetToolTip(this.pItalic, "in nghiêng");
            this.pItalic.Click += new System.EventHandler(this.pItalic_Click);
            // 
            // pUnderline
            // 
            this.pUnderline.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pUnderline.Image = global::DiaryApp.Properties.Resources.underline_gray;
            this.pUnderline.Location = new System.Drawing.Point(1010, 84);
            this.pUnderline.Name = "pUnderline";
            this.pUnderline.Size = new System.Drawing.Size(35, 35);
            this.pUnderline.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pUnderline.TabIndex = 3;
            this.pUnderline.TabStop = false;
            this.toolTip1.SetToolTip(this.pUnderline, "gạch chân");
            this.pUnderline.Click += new System.EventHandler(this.pUnderline_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Thay đổi font";
            // 
            // fpnImg
            // 
            this.fpnImg.AllowDrop = true;
            this.fpnImg.AutoScroll = true;
            this.fpnImg.Location = new System.Drawing.Point(2, 84);
            this.fpnImg.Name = "fpnImg";
            this.fpnImg.Size = new System.Drawing.Size(316, 440);
            this.fpnImg.TabIndex = 0;
            this.fpnImg.Visible = false;
            // 
            // EditDiary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 536);
            this.Controls.Add(this.fpnImg);
            this.Controls.Add(this.pInsertimage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.pUnderline);
            this.Controls.Add(this.pItalic);
            this.Controls.Add(this.pBold);
            this.Controls.Add(this.pFont);
            this.Controls.Add(this.pForeColor);
            this.Controls.Add(this.pAddImg);
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
            ((System.ComponentModel.ISupportInitialize)(this.pAddImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pForeColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pFont)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pInsertimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pItalic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUnderline)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtTitle;
        private Panel panel1;
        private RichTextBox rtEditConent;
        private PictureBox pAddImg;
        private PictureBox pForeColor;
        private PictureBox pFont;
        private Sunny.UI.UIButton btnPost;
        private Sunny.UI.UIButton btnCancel;
        private PictureBox pInsertimage;
        private PictureBox pBold;
        private PictureBox pItalic;
        private PictureBox pUnderline;
        private ToolTip toolTip1;
        private FlowLayoutPanel fpnImg;
    }
}