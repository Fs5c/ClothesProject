namespace Clothes.GUL
{
    partial class UserPro
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
            this.lblUser = new System.Windows.Forms.Label();
            this.btnPassword = new System.Windows.Forms.Label();
            this.btnPhone = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnloign = new System.Windows.Forms.Button();
            this.txtU = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(25, 82);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(56, 13);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "UserName";
            // 
            // btnPassword
            // 
            this.btnPassword.AutoSize = true;
            this.btnPassword.Location = new System.Drawing.Point(27, 109);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(53, 13);
            this.btnPassword.TabIndex = 3;
            this.btnPassword.Text = "Password";
            // 
            // btnPhone
            // 
            this.btnPhone.AutoSize = true;
            this.btnPhone.Location = new System.Drawing.Point(43, 138);
            this.btnPhone.Name = "btnPhone";
            this.btnPhone.Size = new System.Drawing.Size(37, 13);
            this.btnPhone.TabIndex = 4;
            this.btnPhone.Text = "Phone";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(87, 106);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(87, 138);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 7;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // btnloign
            // 
            this.btnloign.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnloign.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloign.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnloign.Location = new System.Drawing.Point(81, 177);
            this.btnloign.Name = "btnloign";
            this.btnloign.Size = new System.Drawing.Size(106, 38);
            this.btnloign.TabIndex = 8;
            this.btnloign.Text = "Loign";
            this.btnloign.UseVisualStyleBackColor = false;
            this.btnloign.Click += new System.EventHandler(this.btnloign_Click);
            // 
            // txtU
            // 
            this.txtU.Location = new System.Drawing.Point(87, 82);
            this.txtU.Name = "txtU";
            this.txtU.Size = new System.Drawing.Size(100, 20);
            this.txtU.TabIndex = 9;
            // 
            // UserPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Clothes.Properties.Resources.e0396ebef4a3f4eeba1d08728ddb7478;
            this.ClientSize = new System.Drawing.Size(262, 264);
            this.Controls.Add(this.txtU);
            this.Controls.Add(this.btnloign);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnPhone);
            this.Controls.Add(this.btnPassword);
            this.Controls.Add(this.lblUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserPro";
            this.Text = "UserPro";
            this.Load += new System.EventHandler(this.UserPro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label btnPassword;
        private System.Windows.Forms.Label btnPhone;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnloign;
        public System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtU;
    }
}