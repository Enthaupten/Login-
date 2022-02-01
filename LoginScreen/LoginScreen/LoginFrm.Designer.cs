
namespace LoginScreen
{
    partial class LoginFrm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uxSubmitBtn = new System.Windows.Forms.Button();
            this.uxExitBtn = new System.Windows.Forms.Button();
            this.uxLoginLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(88, 40);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(128, 28);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.TextChanged += new System.EventHandler(this.uxUsernameTextbox_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.ContextMenuStrip = this.contextMenuStrip1;
            this.txtPassword.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(88, 76);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ShortcutsEnabled = false;
            this.txtPassword.Size = new System.Drawing.Size(128, 28);
            this.txtPassword.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // uxSubmitBtn
            // 
            this.uxSubmitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.uxSubmitBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.uxSubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxSubmitBtn.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSubmitBtn.Location = new System.Drawing.Point(25, 115);
            this.uxSubmitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.uxSubmitBtn.Name = "uxSubmitBtn";
            this.uxSubmitBtn.Size = new System.Drawing.Size(88, 58);
            this.uxSubmitBtn.TabIndex = 4;
            this.uxSubmitBtn.Text = "Submit";
            this.uxSubmitBtn.UseVisualStyleBackColor = false;
            this.uxSubmitBtn.Click += new System.EventHandler(this.uxSubmitBtn_Click);
            // 
            // uxExitBtn
            // 
            this.uxExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.uxExitBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.uxExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxExitBtn.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxExitBtn.Location = new System.Drawing.Point(128, 115);
            this.uxExitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.uxExitBtn.Name = "uxExitBtn";
            this.uxExitBtn.Size = new System.Drawing.Size(88, 58);
            this.uxExitBtn.TabIndex = 5;
            this.uxExitBtn.Text = "Exit";
            this.uxExitBtn.UseVisualStyleBackColor = false;
            this.uxExitBtn.Click += new System.EventHandler(this.uxExitBtn_Click);
            // 
            // uxLoginLabel
            // 
            this.uxLoginLabel.AutoSize = true;
            this.uxLoginLabel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLoginLabel.Location = new System.Drawing.Point(37, 9);
            this.uxLoginLabel.Name = "uxLoginLabel";
            this.uxLoginLabel.Size = new System.Drawing.Size(167, 29);
            this.uxLoginLabel.TabIndex = 6;
            this.uxLoginLabel.Text = "K-State Sports Login";
            // 
            // LoginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(106)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(241, 201);
            this.Controls.Add(this.uxLoginLabel);
            this.Controls.Add(this.uxExitBtn);
            this.Controls.Add(this.uxSubmitBtn);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "K-State Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button uxSubmitBtn;
        private System.Windows.Forms.Button uxExitBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label uxLoginLabel;
    }
}