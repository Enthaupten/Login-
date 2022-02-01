
namespace LoginScreen
{
    partial class TicketsFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketsFrm));
            this.uxBackBtn = new System.Windows.Forms.Button();
            this.uxFootballPicbox = new System.Windows.Forms.PictureBox();
            this.uxVolleyballPicbox = new System.Windows.Forms.PictureBox();
            this.uxBballPicbox = new System.Windows.Forms.PictureBox();
            this.uxSoccerPicbox = new System.Windows.Forms.PictureBox();
            this.uxFootballLabel = new System.Windows.Forms.Label();
            this.uxVolleyballLabel = new System.Windows.Forms.Label();
            this.uxBballLabel = new System.Windows.Forms.Label();
            this.uxSoccerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uxFootballPicbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxVolleyballPicbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxBballPicbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxSoccerPicbox)).BeginInit();
            this.SuspendLayout();
            // 
            // uxBackBtn
            // 
            this.uxBackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.uxBackBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.uxBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxBackBtn.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBackBtn.Location = new System.Drawing.Point(8, 357);
            this.uxBackBtn.Name = "uxBackBtn";
            this.uxBackBtn.Size = new System.Drawing.Size(420, 57);
            this.uxBackBtn.TabIndex = 1;
            this.uxBackBtn.Text = "Back";
            this.uxBackBtn.UseVisualStyleBackColor = false;
            this.uxBackBtn.Click += new System.EventHandler(this.uxBackBtn_Click);
            // 
            // uxFootballPicbox
            // 
            this.uxFootballPicbox.Image = ((System.Drawing.Image)(resources.GetObject("uxFootballPicbox.Image")));
            this.uxFootballPicbox.Location = new System.Drawing.Point(8, 41);
            this.uxFootballPicbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxFootballPicbox.Name = "uxFootballPicbox";
            this.uxFootballPicbox.Size = new System.Drawing.Size(208, 127);
            this.uxFootballPicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.uxFootballPicbox.TabIndex = 2;
            this.uxFootballPicbox.TabStop = false;
            // 
            // uxVolleyballPicbox
            // 
            this.uxVolleyballPicbox.Image = ((System.Drawing.Image)(resources.GetObject("uxVolleyballPicbox.Image")));
            this.uxVolleyballPicbox.Location = new System.Drawing.Point(220, 41);
            this.uxVolleyballPicbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxVolleyballPicbox.Name = "uxVolleyballPicbox";
            this.uxVolleyballPicbox.Size = new System.Drawing.Size(208, 127);
            this.uxVolleyballPicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.uxVolleyballPicbox.TabIndex = 3;
            this.uxVolleyballPicbox.TabStop = false;
            // 
            // uxBballPicbox
            // 
            this.uxBballPicbox.Image = ((System.Drawing.Image)(resources.GetObject("uxBballPicbox.Image")));
            this.uxBballPicbox.Location = new System.Drawing.Point(8, 195);
            this.uxBballPicbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxBballPicbox.Name = "uxBballPicbox";
            this.uxBballPicbox.Size = new System.Drawing.Size(208, 127);
            this.uxBballPicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.uxBballPicbox.TabIndex = 4;
            this.uxBballPicbox.TabStop = false;
            // 
            // uxSoccerPicbox
            // 
            this.uxSoccerPicbox.Image = ((System.Drawing.Image)(resources.GetObject("uxSoccerPicbox.Image")));
            this.uxSoccerPicbox.Location = new System.Drawing.Point(220, 195);
            this.uxSoccerPicbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxSoccerPicbox.Name = "uxSoccerPicbox";
            this.uxSoccerPicbox.Size = new System.Drawing.Size(208, 127);
            this.uxSoccerPicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.uxSoccerPicbox.TabIndex = 5;
            this.uxSoccerPicbox.TabStop = false;
            // 
            // uxFootballLabel
            // 
            this.uxFootballLabel.AutoSize = true;
            this.uxFootballLabel.BackColor = System.Drawing.Color.Transparent;
            this.uxFootballLabel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxFootballLabel.Location = new System.Drawing.Point(50, 41);
            this.uxFootballLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxFootballLabel.Name = "uxFootballLabel";
            this.uxFootballLabel.Size = new System.Drawing.Size(133, 29);
            this.uxFootballLabel.TabIndex = 6;
            this.uxFootballLabel.Text = "Football Tickets";
            // 
            // uxVolleyballLabel
            // 
            this.uxVolleyballLabel.AutoSize = true;
            this.uxVolleyballLabel.BackColor = System.Drawing.Color.Transparent;
            this.uxVolleyballLabel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxVolleyballLabel.Location = new System.Drawing.Point(255, 41);
            this.uxVolleyballLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxVolleyballLabel.Name = "uxVolleyballLabel";
            this.uxVolleyballLabel.Size = new System.Drawing.Size(148, 29);
            this.uxVolleyballLabel.TabIndex = 7;
            this.uxVolleyballLabel.Text = "Volleyball Tickets";
            // 
            // uxBballLabel
            // 
            this.uxBballLabel.AutoSize = true;
            this.uxBballLabel.BackColor = System.Drawing.Color.Transparent;
            this.uxBballLabel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBballLabel.Location = new System.Drawing.Point(41, 195);
            this.uxBballLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxBballLabel.Name = "uxBballLabel";
            this.uxBballLabel.Size = new System.Drawing.Size(149, 29);
            this.uxBballLabel.TabIndex = 8;
            this.uxBballLabel.Text = "Basketball Tickets";
            // 
            // uxSoccerLabel
            // 
            this.uxSoccerLabel.AutoSize = true;
            this.uxSoccerLabel.BackColor = System.Drawing.Color.Transparent;
            this.uxSoccerLabel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSoccerLabel.Location = new System.Drawing.Point(267, 195);
            this.uxSoccerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxSoccerLabel.Name = "uxSoccerLabel";
            this.uxSoccerLabel.Size = new System.Drawing.Size(120, 29);
            this.uxSoccerLabel.TabIndex = 9;
            this.uxSoccerLabel.Text = "Soccer Tickets";
            // 
            // TicketsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(106)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(435, 426);
            this.Controls.Add(this.uxSoccerLabel);
            this.Controls.Add(this.uxBballLabel);
            this.Controls.Add(this.uxVolleyballLabel);
            this.Controls.Add(this.uxFootballLabel);
            this.Controls.Add(this.uxSoccerPicbox);
            this.Controls.Add(this.uxBballPicbox);
            this.Controls.Add(this.uxVolleyballPicbox);
            this.Controls.Add(this.uxBackBtn);
            this.Controls.Add(this.uxFootballPicbox);
            this.Name = "TicketsFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tickets";
            ((System.ComponentModel.ISupportInitialize)(this.uxFootballPicbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxVolleyballPicbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxBballPicbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxSoccerPicbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxBackBtn;
        private System.Windows.Forms.PictureBox uxFootballPicbox;
        private System.Windows.Forms.PictureBox uxVolleyballPicbox;
        private System.Windows.Forms.PictureBox uxBballPicbox;
        private System.Windows.Forms.PictureBox uxSoccerPicbox;
        private System.Windows.Forms.Label uxFootballLabel;
        private System.Windows.Forms.Label uxVolleyballLabel;
        private System.Windows.Forms.Label uxBballLabel;
        private System.Windows.Forms.Label uxSoccerLabel;
    }
}