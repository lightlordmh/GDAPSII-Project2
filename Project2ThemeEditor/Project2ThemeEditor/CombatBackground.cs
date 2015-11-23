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
    public partial class CombatBackground : Form
    {
        public CombatBackground()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void combatBackground3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                combatBackground3.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void combatBackground1_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                combatBackground1.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void combatBackground2_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                combatBackground2.ImageLocation = openFileDialog1.FileName;
            }
        }
    }
}
