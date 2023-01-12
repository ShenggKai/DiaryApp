namespace DiaryApp.Source
{
    partial class DiaryItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnNote = new System.Windows.Forms.Panel();
            this.rtxtContent = new System.Windows.Forms.RichTextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.pDel = new System.Windows.Forms.PictureBox();
            this.pShare = new System.Windows.Forms.PictureBox();
            this.pEit = new System.Windows.Forms.PictureBox();
            this.pnNote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pShare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEit)).BeginInit();
            this.SuspendLayout();
            // 
            // pnNote
            // 
            this.pnNote.BackColor = System.Drawing.Color.White;
            this.pnNote.Controls.Add(this.rtxtContent);
            this.pnNote.Controls.Add(this.lbTitle);
            this.pnNote.Location = new System.Drawing.Point(367, 0);
            this.pnNote.Margin = new System.Windows.Forms.Padding(0);
            this.pnNote.Name = "pnNote";
            this.pnNote.Size = new System.Drawing.Size(926, 126);
            this.pnNote.TabIndex = 0;
            // 
            // rtxtContent
            // 
            this.rtxtContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtContent.Location = new System.Drawing.Point(55, 72);
            this.rtxtContent.Name = "rtxtContent";
            this.rtxtContent.Size = new System.Drawing.Size(419, 39);
            this.rtxtContent.TabIndex = 1;
            this.rtxtContent.Text = "";
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(3, 20);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(920, 45);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Tiêu đề nhật ký";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDate
            // 
            this.lbDate.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDate.ForeColor = System.Drawing.Color.White;
            this.lbDate.Location = new System.Drawing.Point(3, 20);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(361, 35);
            this.lbDate.TabIndex = 1;
            this.lbDate.Text = "Thứ năm, 11 tháng 1 2023";
            this.lbDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTime.ForeColor = System.Drawing.Color.White;
            this.lbTime.Location = new System.Drawing.Point(140, 72);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(77, 35);
            this.lbTime.TabIndex = 1;
            this.lbTime.Text = "08:22";
            // 
            // pDel
            // 
            this.pDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pDel.Image = global::DiaryApp.Properties.Resources.trash_white;
            this.pDel.Location = new System.Drawing.Point(1327, 44);
            this.pDel.Name = "pDel";
            this.pDel.Size = new System.Drawing.Size(40, 40);
            this.pDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pDel.TabIndex = 2;
            this.pDel.TabStop = false;
            this.pDel.Click += new System.EventHandler(this.pDel_Click);
            // 
            // pShare
            // 
            this.pShare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pShare.Image = global::DiaryApp.Properties.Resources.share;
            this.pShare.Location = new System.Drawing.Point(1427, 44);
            this.pShare.Name = "pShare";
            this.pShare.Size = new System.Drawing.Size(40, 40);
            this.pShare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pShare.TabIndex = 2;
            this.pShare.TabStop = false;
            this.pShare.Click += new System.EventHandler(this.pShare_Click);
            // 
            // pEit
            // 
            this.pEit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pEit.Image = global::DiaryApp.Properties.Resources.edit_white;
            this.pEit.Location = new System.Drawing.Point(1527, 44);
            this.pEit.Name = "pEit";
            this.pEit.Size = new System.Drawing.Size(40, 40);
            this.pEit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pEit.TabIndex = 2;
            this.pEit.TabStop = false;
            this.pEit.Click += new System.EventHandler(this.pEit_Click);
            // 
            // DiaryItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(160)))), ((int)(((byte)(103)))));
            this.Controls.Add(this.pEit);
            this.Controls.Add(this.pShare);
            this.Controls.Add(this.pDel);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.pnNote);
            this.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.Name = "DiaryItem";
            this.Size = new System.Drawing.Size(1612, 126);
            this.Load += new System.EventHandler(this.DiaryItem_Load);
            this.pnNote.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pShare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnNote;
        private Label lbDate;
        private Label lbTime;
        private Label lbTitle;
        private PictureBox pDel;
        private PictureBox pShare;
        private PictureBox pEit;
        private RichTextBox rtxtContent;
    }
}
