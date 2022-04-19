namespace UserManagement
{
    partial class frmLogin
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtbxUsername = new System.Windows.Forms.TextBox();
            this.lblPas = new System.Windows.Forms.Label();
            this.txtbxPassword = new System.Windows.Forms.TextBox();
            this.btnLog = new System.Windows.Forms.Button();
            this.lblForgot = new System.Windows.Forms.Label();
            this.lblRegister = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(92, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(108, 25);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(4, 12);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(61, 13);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username: ";
            // 
            // txtbxUsername
            // 
            this.txtbxUsername.Location = new System.Drawing.Point(112, 62);
            this.txtbxUsername.Name = "txtbxUsername";
            this.txtbxUsername.Size = new System.Drawing.Size(100, 20);
            this.txtbxUsername.TabIndex = 2;
            // 
            // lblPas
            // 
            this.lblPas.AutoSize = true;
            this.lblPas.Location = new System.Drawing.Point(4, 55);
            this.lblPas.Name = "lblPas";
            this.lblPas.Size = new System.Drawing.Size(59, 13);
            this.lblPas.TabIndex = 3;
            this.lblPas.Text = "Password: ";
            // 
            // txtbxPassword
            // 
            this.txtbxPassword.Location = new System.Drawing.Point(86, 52);
            this.txtbxPassword.Name = "txtbxPassword";
            this.txtbxPassword.PasswordChar = '*';
            this.txtbxPassword.Size = new System.Drawing.Size(100, 20);
            this.txtbxPassword.TabIndex = 4;
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(70, 159);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(130, 23);
            this.btnLog.TabIndex = 5;
            this.btnLog.Text = "Validate && Login";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // lblForgot
            // 
            this.lblForgot.AutoSize = true;
            this.lblForgot.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblForgot.Location = new System.Drawing.Point(130, 79);
            this.lblForgot.Name = "lblForgot";
            this.lblForgot.Size = new System.Drawing.Size(92, 13);
            this.lblForgot.TabIndex = 6;
            this.lblForgot.Text = "Forgot Password?";
            this.lblForgot.Click += new System.EventHandler(this.lblForgot_Click);
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Location = new System.Drawing.Point(79, 190);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(121, 13);
            this.lblRegister.TabIndex = 7;
            this.lblRegister.Text = "Register account here!!!";
            this.lblRegister.Click += new System.EventHandler(this.lblRegister_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblForgot);
            this.panel1.Controls.Add(this.txtbxPassword);
            this.panel1.Controls.Add(this.lblPas);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Location = new System.Drawing.Point(26, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 100);
            this.panel1.TabIndex = 8;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 212);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.txtbxUsername);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.panel1);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtbxUsername;
        private System.Windows.Forms.Label lblPas;
        private System.Windows.Forms.TextBox txtbxPassword;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Label lblForgot;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Panel panel1;
    }
}

