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

        #region Fomart text
        private void pBold_Click(object sender, EventArgs e)
        {
            if (rtEditConent.SelectionFont != null)
            {
                System.Drawing.Font currentFont = rtEditConent.SelectionFont;
                System.Drawing.FontStyle newFontStyle;

                if (rtEditConent.SelectionFont.Bold == true)
                {
                    newFontStyle = FontStyle.Regular;
                    pBold.Image = global::DiaryApp.Properties.Resources.bold_gray;
                }
                else
                {
                    newFontStyle = FontStyle.Bold;
                    pBold.Image = global::DiaryApp.Properties.Resources.bold;
                }

                rtEditConent.SelectionFont = new Font(
                   currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }

        private void pItalic_Click(object sender, EventArgs e)
        {
            if (rtEditConent.SelectionFont != null)
            {
                System.Drawing.Font currentFont = rtEditConent.SelectionFont;
                System.Drawing.FontStyle newFontStyle;

                if (rtEditConent.SelectionFont.Italic == true)
                {
                    newFontStyle = FontStyle.Regular;
                    pItalic.Image = global::DiaryApp.Properties.Resources.italics_gray;
                }
                else
                {
                    newFontStyle = FontStyle.Italic;
                    pItalic.Image = global::DiaryApp.Properties.Resources.italics;
                }

                rtEditConent.SelectionFont = new Font(
                   currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }

        private void pUnderline_Click(object sender, EventArgs e)
        {
            if (rtEditConent.SelectionFont != null)
            {
                System.Drawing.Font currentFont = rtEditConent.SelectionFont;
                System.Drawing.FontStyle newFontStyle;

                if (rtEditConent.SelectionFont.Underline == true)
                {
                    newFontStyle = FontStyle.Regular;
                    pUnderline.Image = global::DiaryApp.Properties.Resources.underline_gray;
                }
                else
                {
                    newFontStyle = FontStyle.Underline;
                    pUnderline.Image = global::DiaryApp.Properties.Resources.underline;
                }

                rtEditConent.SelectionFont = new Font(
                   currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(openFileDialog.FileName);
                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new Size(302, 302);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Image = image;
                fpnImg.Visible= true;
                fpnImg.Controls.Add(pictureBox);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                rtEditConent.SelectionColor = colorDialog.Color;
            }
        }

        #endregion Fomart text

        #endregion button click

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.Font = rtEditConent.SelectionFont;

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                rtEditConent.SelectionFont = fontDialog.Font;
            }
        }
    }
}
