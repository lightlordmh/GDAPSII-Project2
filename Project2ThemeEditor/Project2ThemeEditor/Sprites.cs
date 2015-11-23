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
    public partial class Sprites : Form
    {
        public bool Ready { get; set; }
        public Sprites()
        {
            InitializeComponent();
            Ready = false;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            ImageCheck();
            this.Hide();
        }

        private void npcPic1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                npcPic1.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void npcPic2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                npcPic2.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void npcPic3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                npcPic3.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void monsterPic3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                monsterPic3.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void monsterPic2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                monsterPic2.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void monsterPic1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                monsterPic1.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void monsterPic5_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                monsterPic5.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void monsterPic4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                monsterPic4.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void playerPic_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                playerPic.ImageLocation = openFileDialog1.FileName;
            }
        }
        public void ImageCheck()
        {
            if (npcPic1.ImageLocation != null && npcPic2.ImageLocation != null && npcPic3.ImageLocation != null &&
                monsterPic1.ImageLocation != null && monsterPic2.ImageLocation != null && monsterPic3.ImageLocation != null &&
                monsterPic4.ImageLocation != null && monsterPic5.ImageLocation != null && playerPic.ImageLocation != null)
            {
                Ready = true;
            }
        }
    }
}
