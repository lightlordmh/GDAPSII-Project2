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
        public Form1()
        {
            InitializeComponent();
        }

        private void HealerPortrait_Click(object sender, EventArgs e)
        {
            // Call the ShowDialog method to show the dialog box.
            DialogResult userClickedOK = openFileDialog1.ShowDialog();

            // Process input if the user clicked OK.
            if (userClickedOK == DialogResult.OK)
            {
                HealerPortrait.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void MagePortrait_Click(object sender, EventArgs e)
        {
            // Call the ShowDialog method to show the dialog box.
            DialogResult userClickedOK = openFileDialog1.ShowDialog();

            // Process input if the user clicked OK.
            if (userClickedOK == DialogResult.OK)
            {
                MagePortrait.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void TankPortrait_Click(object sender, EventArgs e)
        {
            // Call the ShowDialog method to show the dialog box.
            DialogResult userClickedOK = openFileDialog1.ShowDialog();

            // Process input if the user clicked OK.
            if (userClickedOK == DialogResult.OK)
            {
                TankPortrait.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void WarriorPortrait_Click(object sender, EventArgs e)
        {
            // Call the ShowDialog method to show the dialog box.
            DialogResult userClickedOK = openFileDialog1.ShowDialog();

            // Process input if the user clicked OK.
            if (userClickedOK == DialogResult.OK)
            {
                WarriorPortrait.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void Boss1Icon_Click(object sender, EventArgs e)
        {
            // Call the ShowDialog method to show the dialog box.
            DialogResult userClickedOK = openFileDialog1.ShowDialog();

            // Process input if the user clicked OK.
            if (userClickedOK == DialogResult.OK)
            {
                Boss1Icon.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void Boss2Icon_Click(object sender, EventArgs e)
        {
            // Call the ShowDialog method to show the dialog box.
            DialogResult userClickedOK = openFileDialog1.ShowDialog();

            // Process input if the user clicked OK.
            if (userClickedOK == DialogResult.OK)
            {
                Boss2Icon.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void Boss3Icon_Click(object sender, EventArgs e)
        {
            // Call the ShowDialog method to show the dialog box.
            DialogResult userClickedOK = openFileDialog1.ShowDialog();

            // Process input if the user clicked OK.
            if (userClickedOK == DialogResult.OK)
            {
                Boss3Icon.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void Boss4Icon_Click(object sender, EventArgs e)
        {
            // Call the ShowDialog method to show the dialog box.
            DialogResult userClickedOK = openFileDialog1.ShowDialog();

            // Process input if the user clicked OK.
            if (userClickedOK == DialogResult.OK)
            {
                Boss4Icon.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void Boss5Icon_Click(object sender, EventArgs e)
        {
            // Call the ShowDialog method to show the dialog box.
            DialogResult userClickedOK = openFileDialog1.ShowDialog();

            // Process input if the user clicked OK.
            if (userClickedOK == DialogResult.OK)
            {
                Boss5Icon.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void NPC1Portrait_Click(object sender, EventArgs e)
        {
            // Call the ShowDialog method to show the dialog box.
            DialogResult userClickedOK = openFileDialog1.ShowDialog();

            // Process input if the user clicked OK.
            if (userClickedOK == DialogResult.OK)
            {
                NPC1Portrait.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void NPC2Portrait_Click(object sender, EventArgs e)
        {
            // Call the ShowDialog method to show the dialog box.
            DialogResult userClickedOK = openFileDialog1.ShowDialog();

            // Process input if the user clicked OK.
            if (userClickedOK == DialogResult.OK)
            {
                NPC2Portrait.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void NPC3Portrait_Click(object sender, EventArgs e)
        {
            // Call the ShowDialog method to show the dialog box.
            DialogResult userClickedOK = openFileDialog1.ShowDialog();

            // Process input if the user clicked OK.
            if (userClickedOK == DialogResult.OK)
            {
                NPC3Portrait.ImageLocation = openFileDialog1.FileName;
            }
        }
        private void Boss1Portrait_Click(object sender, EventArgs e)
        {
            // Call the ShowDialog method to show the dialog box.
            DialogResult userClickedOK = openFileDialog1.ShowDialog();

            // Process input if the user clicked OK.
            if (userClickedOK == DialogResult.OK)
            {
                Boss1Portrait.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void Boss3Portrait_Click(object sender, EventArgs e)
        {
            // Call the ShowDialog method to show the dialog box.
            DialogResult userClickedOK = openFileDialog1.ShowDialog();

            // Process input if the user clicked OK.
            if (userClickedOK == DialogResult.OK)
            {
                Boss3Portrait.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void Spell1Icon_Click(object sender, EventArgs e)
        {
            // Call the ShowDialog method to show the dialog box.
            DialogResult userClickedOK = openFileDialog1.ShowDialog();

            // Process input if the user clicked OK.
            if (userClickedOK == DialogResult.OK)
            {
                Spell1Icon.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void Boss2Portrait_Click(object sender, EventArgs e)
        {
            // Call the ShowDialog method to show the dialog box.
            DialogResult userClickedOK = openFileDialog1.ShowDialog();

            // Process input if the user clicked OK.
            if (userClickedOK == DialogResult.OK)
            {
                Boss2Portrait.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void MainBackground_Click(object sender, EventArgs e)
        {
            // Call the ShowDialog method to show the dialog box.
            DialogResult userClickedOK = openFileDialog1.ShowDialog();

            // Process input if the user clicked OK.
            if (userClickedOK == DialogResult.OK)
            {
                MainBackground.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void ActionWindowBackground_Click(object sender, EventArgs e)
        {
            // Call the ShowDialog method to show the dialog box.
            DialogResult userClickedOK = openFileDialog1.ShowDialog();

            // Process input if the user clicked OK.
            if (userClickedOK == DialogResult.OK)
            {
                ActionWindowBackground.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (HealerPortrait.ImageLocation == null | MagePortrait.ImageLocation == null | TankPortrait.ImageLocation == null | WarriorPortrait.ImageLocation == null |
                Boss1Icon.ImageLocation == null | Boss2Icon.ImageLocation == null | Boss3Icon.ImageLocation == null | Boss4Icon.ImageLocation == null | Boss5Icon.ImageLocation == null |
                Spell1Icon.ImageLocation == null | NPC1Portrait.ImageLocation == null | NPC2Portrait.ImageLocation == null | NPC3Portrait.ImageLocation == null |
                Boss1Portrait.ImageLocation == null | Boss2Portrait.ImageLocation == null | Boss3Portrait.ImageLocation == null | MainBackground.ImageLocation == null | ActionWindowBackground.ImageLocation == null)
            {
                MessageBox.Show("A picture box has not been filled unable to save");
            }
            else
            {

            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Function Has Not Been Implemented Yet");
        }
    }
}
