using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiaryApp.Source
{
    public partial class EditDiary : Form
    {
        public EditDiary()
        {
            InitializeComponent();
        }

        #region button click
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            DiaryItem diaryItem = new DiaryItem();
            diaryItem.Title = txtTitle.Text;
            diaryItem.Content = rtEditConent.Text;
            diaryItem.Pic = pInsertimage.Image;

            MainForm.instance.pnItem.Controls.Add(diaryItem);
            this.Close();
        }

        private void pAddImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Images|*.png;*.bmp;*.jpg" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Image img = Image.FromFile(ofd.FileName);
                    Clipboard.SetImage(img);
                    rtEditConent.Paste();
                }
            }
        }

        private void pInsertimage_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog to select a new image
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Set the Image property of the PictureBox to the selected image
                pInsertimage.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void pBold_Click(object sender, EventArgs e)
        {
            if (rtEditConent.SelectionFont != null)
            {
                System.Drawing.Font currentFont = rtEditConent.SelectionFont;
                System.Drawing.FontStyle newFontStyle;

                if (rtEditConent.SelectionFont.Bold == true)
                {
                    newFontStyle = FontStyle.Regular;
                }
                else
                {
                    newFontStyle = FontStyle.Bold;
                }

                rtEditConent.SelectionFont = new Font(
                   currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }

        private void pItalic_Click(object sender, EventArgs e)
        {

        }

        private void pUnderline_Click(object sender, EventArgs e)
        {

        }

        #endregion button click
    }
}
