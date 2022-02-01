
namespace LoginScreen
{
    partial class ScheduleFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleFrm));
            this.uxBackBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uxBackBtn
            // 
            this.uxBackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.uxBackBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.uxBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxBackBtn.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBackBtn.Location = new System.Drawing.Point(10, 379);
            this.uxBackBtn.Name = "uxBackBtn";
            this.uxBackBtn.Size = new System.Drawing.Size(416, 36);
            this.uxBackBtn.TabIndex = 0;
            this.uxBackBtn.Text = "Back";
            this.uxBackBtn.UseVisualStyleBackColor = false;
            this.uxBackBtn.Click += new System.EventHandler(this.uxBackBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-5, -25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(449, 536);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ScheduleFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(106)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(435, 426);
            this.Controls.Add(this.uxBackBtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ScheduleFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uxBackBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}