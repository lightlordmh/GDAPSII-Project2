namespace Project2ThemeEditor
{
    partial class MainBackground
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
            this.mainBackgroundPic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.mainBackgroundPic)).BeginInit();
            this.SuspendLayout();
            // 
            // mainBackgroundPic
            // 
            this.mainBackgroundPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainBackgroundPic.Location = new System.Drawing.Point(12, 12);
            this.mainBackgroundPic.Name = "mainBackgroundPic";
            this.mainBackgroundPic.Size = new System.Drawing.Size(1024, 768);
            this.mainBackgroundPic.TabIndex = 0;
            this.mainBackgroundPic.TabStop = false;
            this.mainBackgroundPic.Click += new System.EventHandler(this.mainBackgroundPic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1042, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 117);
            this.label1.TabIndex = 1;
            this.label1.Text = "Instructions on use:\r\n1.Click the Pcture box\r\n2. Pick an image\r\n3. Click the Clos" +
    "e Button \r\n(closing the window)\r\n\r\nResolution and Format\r\n1024x768\r\nPNG";
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(1069, 143);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "PNG File (*.png) | *.PNG; ";
            // 
            // MainBackground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 792);
            this.ControlBox = false;
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainBackgroundPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainBackground";
            this.Text = "MainBackground Editor";
            ((System.ComponentModel.ISupportInitialize)(this.mainBackgroundPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeBtn;
        public System.Windows.Forms.PictureBox mainBackgroundPic;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}