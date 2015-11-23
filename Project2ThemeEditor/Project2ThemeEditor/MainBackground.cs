using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2ThemeEditor
{
    public partial class MainBackground : Form
    {
        public bool Ready { get; set; }
        public MainBackground()
        {
            InitializeComponent();
            Ready = false;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            ImageCheck();
            this.Hide();
        }

        private void mainBackgroundPic_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                mainBackgroundPic.ImageLocation = openFileDialog1.FileName;
            }
        }
        public void ImageCheck()
        {
            if (mainBackgroundPic.ImageLocation != null)
            {
                Ready = true;
            } 
        }
    }
}
