using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiaryApp.Source
{
    public partial class ViewDiary : Form
    {
        public ViewDiary()
        {
            InitializeComponent();
        }

        private void ViewDiary_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = DiaryItem.instance.NoiDung.Text;
        }
    }
}
