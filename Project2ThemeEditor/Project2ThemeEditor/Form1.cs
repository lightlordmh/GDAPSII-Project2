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
    public partial class Form1 : Form
    {
        string folderLoc;
        Sprites sprites;
        Icon icon;
        MainBackground mainBackground;
        CombatBackground combatBackground;
        public Form1()
        {
            InitializeComponent();
            sprites = new Sprites();
            icon = new Icon();
            mainBackground = new MainBackground();
            combatBackground = new CombatBackground();
            

        }

        private void toBackgroundForm_Click(object sender, EventArgs e)
        {
            if (mainBackground.Visible == true)
            {
                mainBackground.Hide();
            }
            else
            {
                mainBackground.Show();
            }
        }

        private void toCombatBackgroundForm_Click(object sender, EventArgs e)
        {
            if (combatBackground.Visible == true)
            {
                combatBackground.Hide();
            }
            else
            {
                combatBackground.Show();
            }
        }

        private void toSpriteForm_Click(object sender, EventArgs e)
        {
            if (sprites.Visible == true)
            {
                sprites.Hide();
            }
            else
            {
                sprites.Show();
            }
        }

        private void toIconForm_Click(object sender, EventArgs e)
        {
            if (icon.Visible == true)
            {
                icon.Hide();
            }
            else
            {
                icon.Show();
            }
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folderLoc = folderBrowserDialog1.SelectedPath;
            }
            if (folderLoc != null)
            {
                toBackgroundForm.Enabled = true;
                toCombatBackgroundForm.Enabled = true;
                //toIconForm.Enabled = true;
                toSpriteForm.Enabled = true;
            }
        }

        private void saveAsStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
