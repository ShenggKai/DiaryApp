namespace DiaryApp.Source
{
    partial class Share
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Share));
            this.pFacebook = new System.Windows.Forms.PictureBox();
            this.pGmail = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pFacebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGmail)).BeginInit();
            this.SuspendLayout();
            // 
            // pFacebook
            // 
            this.pFacebook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pFacebook.Image = global::DiaryApp.Properties.Resources.facebook;
            this.pFacebook.Location = new System.Drawing.Point(44, 27);
            this.pFacebook.Name = "pFacebook";
            this.pFacebook.Size = new System.Drawing.Size(85, 85);
            this.pFacebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pFacebook.TabIndex = 0;
            this.pFacebook.TabStop = false;
            // 
            // pGmail
            // 
            this.pGmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pGmail.Image = global::DiaryApp.Properties.Resources.gmail;
            this.pGmail.Location = new System.Drawing.Point(216, 27);
            this.pGmail.Name = "pGmail";
            this.pGmail.Size = new System.Drawing.Size(85, 85);
            this.pGmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pGmail.TabIndex = 0;
            this.pGmail.TabStop = false;
            this.pGmail.Click += new System.EventHandler(this.pGmail_Click);
            // 
            // Share
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 139);
            this.Controls.Add(this.pGmail);
            this.Controls.Add(this.pFacebook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Share";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chia sẻ nhật ký";
            ((System.ComponentModel.ISupportInitialize)(this.pFacebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGmail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pFacebook;
        private PictureBox pGmail;
    }
}