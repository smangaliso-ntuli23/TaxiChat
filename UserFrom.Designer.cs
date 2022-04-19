namespace UserManagement.TaxiUserForms
{
    partial class UserFrom
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
            this.lblWelcomeMSG = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGetLoca = new System.Windows.Forms.Label();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.txtlongi = new System.Windows.Forms.TextBox();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLat = new System.Windows.Forms.Label();
            this.txtStringLocation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMan = new System.Windows.Forms.Button();
            this.btnBegin = new System.Windows.Forms.Label();
            this.pnlInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcomeMSG
            // 
            this.lblWelcomeMSG.AutoSize = true;
            this.lblWelcomeMSG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeMSG.Location = new System.Drawing.Point(12, 7);
            this.lblWelcomeMSG.Name = "lblWelcomeMSG";
            this.lblWelcomeMSG.Size = new System.Drawing.Size(126, 16);
            this.lblWelcomeMSG.TabIndex = 1;
            this.lblWelcomeMSG.Text = "Welcome Message";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Before we proceed, please state your location.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Users privacy and rights will not be neglected.";
            // 
            // lblGetLoca
            // 
            this.lblGetLoca.AutoSize = true;
            this.lblGetLoca.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblGetLoca.Location = new System.Drawing.Point(53, 70);
            this.lblGetLoca.Name = "lblGetLoca";
            this.lblGetLoca.Size = new System.Drawing.Size(133, 13);
            this.lblGetLoca.TabIndex = 4;
            this.lblGetLoca.Text = "Use Your Current Locaton!";
            this.lblGetLoca.Click += new System.EventHandler(this.label3_Click);
            // 
            // pnlInput
            // 
            this.pnlInput.Controls.Add(this.txtlongi);
            this.pnlInput.Controls.Add(this.txtLat);
            this.pnlInput.Controls.Add(this.label6);
            this.pnlInput.Controls.Add(this.lblLat);
            this.pnlInput.Controls.Add(this.txtStringLocation);
            this.pnlInput.Controls.Add(this.label4);
            this.pnlInput.Location = new System.Drawing.Point(56, 94);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(228, 100);
            this.pnlInput.TabIndex = 6;
            // 
            // txtlongi
            // 
            this.txtlongi.Location = new System.Drawing.Point(103, 68);
            this.txtlongi.Name = "txtlongi";
            this.txtlongi.Size = new System.Drawing.Size(100, 20);
            this.txtlongi.TabIndex = 13;
            // 
            // txtLat
            // 
            this.txtLat.Location = new System.Drawing.Point(103, 36);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(100, 20);
            this.txtLat.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Longitude";
            // 
            // lblLat
            // 
            this.lblLat.AutoSize = true;
            this.lblLat.Location = new System.Drawing.Point(14, 39);
            this.lblLat.Name = "lblLat";
            this.lblLat.Size = new System.Drawing.Size(45, 13);
            this.lblLat.TabIndex = 10;
            this.lblLat.Text = "Latitude";
            // 
            // txtStringLocation
            // 
            this.txtStringLocation.Location = new System.Drawing.Point(103, 7);
            this.txtStringLocation.Name = "txtStringLocation";
            this.txtStringLocation.Size = new System.Drawing.Size(100, 20);
            this.txtStringLocation.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Location String";
            // 
            // btnMan
            // 
            this.btnMan.Location = new System.Drawing.Point(192, 65);
            this.btnMan.Name = "btnMan";
            this.btnMan.Size = new System.Drawing.Size(112, 23);
            this.btnMan.TabIndex = 7;
            this.btnMan.Text = "Manual input?";
            this.btnMan.UseVisualStyleBackColor = true;
            this.btnMan.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBegin
            // 
            this.btnBegin.AutoSize = true;
            this.btnBegin.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBegin.ForeColor = System.Drawing.Color.White;
            this.btnBegin.Location = new System.Drawing.Point(329, 178);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(35, 16);
            this.btnBegin.TabIndex = 8;
            this.btnBegin.Text = "&Next";
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // UserFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 238);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.btnMan);
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.lblGetLoca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWelcomeMSG);
            this.Name = "UserFrom";
            this.Text = "TaxiFinder";
            this.Load += new System.EventHandler(this.UserFrom_Load);
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeMSG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGetLoca;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Button btnMan;
        private System.Windows.Forms.TextBox txtlongi;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblLat;
        private System.Windows.Forms.TextBox txtStringLocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label btnBegin;
    }
}