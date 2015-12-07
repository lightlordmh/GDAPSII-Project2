namespace Project2ThemeEditor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toBackgroundForm = new System.Windows.Forms.Button();
            this.backgroundLabel = new System.Windows.Forms.Label();
            this.toSpriteForm = new System.Windows.Forms.Button();
            this.toIconForm = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spritesLabel = new System.Windows.Forms.Label();
            this.iconLabel = new System.Windows.Forms.Label();
            this.toCombatBackgroundForm = new System.Windows.Forms.Button();
            this.combatBackgroundLabel = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toBackgroundForm
            // 
            this.toBackgroundForm.Enabled = false;
            this.toBackgroundForm.Location = new System.Drawing.Point(59, 52);
            this.toBackgroundForm.Name = "toBackgroundForm";
            this.toBackgroundForm.Size = new System.Drawing.Size(109, 23);
            this.toBackgroundForm.TabIndex = 0;
            this.toBackgroundForm.Text = "MainBackground";
            this.toBackgroundForm.UseVisualStyleBackColor = true;
            this.toBackgroundForm.Click += new System.EventHandler(this.toBackgroundForm_Click);
            // 
            // backgroundLabel
            // 
            this.backgroundLabel.AutoSize = true;
            this.backgroundLabel.Location = new System.Drawing.Point(38, 36);
            this.backgroundLabel.Name = "backgroundLabel";
            this.backgroundLabel.Size = new System.Drawing.Size(167, 13);
            this.backgroundLabel.TabIndex = 1;
            this.backgroundLabel.Text = "Edit the Main Backgrounds Image";
            // 
            // toSpriteForm
            // 
            this.toSpriteForm.Enabled = false;
            this.toSpriteForm.Location = new System.Drawing.Point(59, 163);
            this.toSpriteForm.Name = "toSpriteForm";
            this.toSpriteForm.Size = new System.Drawing.Size(109, 23);
            this.toSpriteForm.TabIndex = 2;
            this.toSpriteForm.Text = "Sprites";
            this.toSpriteForm.UseVisualStyleBackColor = true;
            this.toSpriteForm.Click += new System.EventHandler(this.toSpriteForm_Click);
            // 
            // toIconForm
            // 
            this.toIconForm.Enabled = false;
            this.toIconForm.Location = new System.Drawing.Point(59, 214);
            this.toIconForm.Name = "toIconForm";
            this.toIconForm.Size = new System.Drawing.Size(109, 23);
            this.toIconForm.TabIndex = 3;
            this.toIconForm.Text = "Icons";
            this.toIconForm.UseVisualStyleBackColor = true;
            this.toIconForm.Click += new System.EventHandler(this.toIconForm_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(630, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem1,
            this.saveAsStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.openToolStripMenuItem1.Text = "Open Folder";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem1_Click);
            // 
            // saveAsStripMenuItem
            // 
            this.saveAsStripMenuItem.Name = "saveAsStripMenuItem";
            this.saveAsStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.saveAsStripMenuItem.Text = "Save All";
            this.saveAsStripMenuItem.Click += new System.EventHandler(this.saveAsStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // spritesLabel
            // 
            this.spritesLabel.AutoSize = true;
            this.spritesLabel.Location = new System.Drawing.Point(71, 147);
            this.spritesLabel.Name = "spritesLabel";
            this.spritesLabel.Size = new System.Drawing.Size(92, 13);
            this.spritesLabel.TabIndex = 5;
            this.spritesLabel.Text = "Edit Sprite Images";
            // 
            // iconLabel
            // 
            this.iconLabel.AutoSize = true;
            this.iconLabel.Location = new System.Drawing.Point(71, 198);
            this.iconLabel.Name = "iconLabel";
            this.iconLabel.Size = new System.Drawing.Size(175, 13);
            this.iconLabel.TabIndex = 6;
            this.iconLabel.Text = "Edit Icon Images (Not Implemented)";
            // 
            // toCombatBackgroundForm
            // 
            this.toCombatBackgroundForm.Enabled = false;
            this.toCombatBackgroundForm.Location = new System.Drawing.Point(59, 105);
            this.toCombatBackgroundForm.Name = "toCombatBackgroundForm";
            this.toCombatBackgroundForm.Size = new System.Drawing.Size(109, 23);
            this.toCombatBackgroundForm.TabIndex = 7;
            this.toCombatBackgroundForm.Text = "CombatBackground";
            this.toCombatBackgroundForm.UseVisualStyleBackColor = true;
            this.toCombatBackgroundForm.Click += new System.EventHandler(this.toCombatBackgroundForm_Click);
            // 
            // combatBackgroundLabel
            // 
            this.combatBackgroundLabel.AutoSize = true;
            this.combatBackgroundLabel.Location = new System.Drawing.Point(12, 89);
            this.combatBackgroundLabel.Name = "combatBackgroundLabel";
            this.combatBackgroundLabel.Size = new System.Drawing.Size(224, 13);
            this.combatBackgroundLabel.TabIndex = 8;
            this.combatBackgroundLabel.Text = "Edit the Combat Windows Backgound Images";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 117);
            this.label1.TabIndex = 9;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 247);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combatBackgroundLabel);
            this.Controls.Add(this.toCombatBackgroundForm);
            this.Controls.Add(this.iconLabel);
            this.Controls.Add(this.spritesLabel);
            this.Controls.Add(this.toIconForm);
            this.Controls.Add(this.toSpriteForm);
            this.Controls.Add(this.backgroundLabel);
            this.Controls.Add(this.toBackgroundForm);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Theme Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button toBackgroundForm;
        private System.Windows.Forms.Label backgroundLabel;
        private System.Windows.Forms.Button toSpriteForm;
        private System.Windows.Forms.Button toIconForm;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label spritesLabel;
        private System.Windows.Forms.Label iconLabel;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveAsStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Button toCombatBackgroundForm;
        private System.Windows.Forms.Label combatBackgroundLabel;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
    }
}