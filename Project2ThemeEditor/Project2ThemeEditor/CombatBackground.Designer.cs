namespace Project2ThemeEditor
{
    partial class CombatBackground
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
            this.combatBackground1 = new System.Windows.Forms.PictureBox();
            this.combatBackground2 = new System.Windows.Forms.PictureBox();
            this.combatBackground3 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.closeBtn = new System.Windows.Forms.Button();
            this.Description = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.combatBackground1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatBackground2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatBackground3)).BeginInit();
            this.SuspendLayout();
            // 
            // combatBackground1
            // 
            this.combatBackground1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.combatBackground1.Location = new System.Drawing.Point(12, 12);
            this.combatBackground1.Name = "combatBackground1";
            this.combatBackground1.Size = new System.Drawing.Size(772, 384);
            this.combatBackground1.TabIndex = 0;
            this.combatBackground1.TabStop = false;
            this.combatBackground1.Click += new System.EventHandler(this.combatBackground1_Click_1);
            // 
            // combatBackground2
            // 
            this.combatBackground2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.combatBackground2.Location = new System.Drawing.Point(790, 12);
            this.combatBackground2.Name = "combatBackground2";
            this.combatBackground2.Size = new System.Drawing.Size(772, 384);
            this.combatBackground2.TabIndex = 1;
            this.combatBackground2.TabStop = false;
            this.combatBackground2.Click += new System.EventHandler(this.combatBackground2_Click_1);
            // 
            // combatBackground3
            // 
            this.combatBackground3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.combatBackground3.Location = new System.Drawing.Point(12, 402);
            this.combatBackground3.Name = "combatBackground3";
            this.combatBackground3.Size = new System.Drawing.Size(772, 384);
            this.combatBackground3.TabIndex = 2;
            this.combatBackground3.TabStop = false;
            this.combatBackground3.Click += new System.EventHandler(this.combatBackground3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "PNG File (*.png) | *.PNG;";
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(912, 535);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 3;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(790, 402);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(197, 130);
            this.Description.TabIndex = 5;
            this.Description.Text = "Instructions on use:\r\n1. Click on a picture box\r\n2.Pick an image \r\n3.Repeat until" +
    " all picture boxes are filled \r\n4. Click the Close button\r\n(closing the window)\r" +
    "\n\r\nResolution and Format:\r\n772x384\r\nPNG";
            // 
            // CombatBackground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1575, 800);
            this.ControlBox = false;
            this.Controls.Add(this.Description);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.combatBackground3);
            this.Controls.Add(this.combatBackground2);
            this.Controls.Add(this.combatBackground1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CombatBackground";
            this.Text = "CombatBackground Editor";
            ((System.ComponentModel.ISupportInitialize)(this.combatBackground1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatBackground2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatBackground3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label Description;
        public System.Windows.Forms.PictureBox combatBackground1;
        public System.Windows.Forms.PictureBox combatBackground2;
        public System.Windows.Forms.PictureBox combatBackground3;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}