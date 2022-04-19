namespace UserManagement.TaxiUserForms
{
    partial class Finder
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gMapCntrl = new GMap.NET.WindowsForms.GMapControl();
            this.lblUserString = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gMapCntrl);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.SplitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblUserString);
            this.splitContainer1.Size = new System.Drawing.Size(849, 330);
            this.splitContainer1.SplitterDistance = 534;
            this.splitContainer1.TabIndex = 0;
            // 
            // gMapCntrl
            // 
            this.gMapCntrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMapCntrl.Bearing = 0F;
            this.gMapCntrl.CanDragMap = true;
            this.gMapCntrl.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapCntrl.GrayScaleMode = false;
            this.gMapCntrl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapCntrl.LevelsKeepInMemmory = 5;
            this.gMapCntrl.Location = new System.Drawing.Point(27, 37);
            this.gMapCntrl.MarkersEnabled = true;
            this.gMapCntrl.MaxZoom = 2;
            this.gMapCntrl.MinZoom = 2;
            this.gMapCntrl.MouseWheelZoomEnabled = true;
            this.gMapCntrl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapCntrl.Name = "gMapCntrl";
            this.gMapCntrl.NegativeMode = false;
            this.gMapCntrl.PolygonsEnabled = true;
            this.gMapCntrl.RetryLoadTile = 0;
            this.gMapCntrl.RoutesEnabled = true;
            this.gMapCntrl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapCntrl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapCntrl.ShowTileGridLines = false;
            this.gMapCntrl.Size = new System.Drawing.Size(461, 256);
            this.gMapCntrl.TabIndex = 0;
            this.gMapCntrl.Zoom = 0D;
            this.gMapCntrl.Load += new System.EventHandler(this.GMapControl1_Load);
            // 
            // lblUserString
            // 
            this.lblUserString.AutoSize = true;
            this.lblUserString.Location = new System.Drawing.Point(4, 13);
            this.lblUserString.Name = "lblUserString";
            this.lblUserString.Size = new System.Drawing.Size(60, 13);
            this.lblUserString.TabIndex = 0;
            this.lblUserString.Text = "UserName:";
            this.lblUserString.Click += new System.EventHandler(this.LblUserString_Click);
            // 
            // Finder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 330);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Finder";
            this.Text = "Finder";
            this.Load += new System.EventHandler(this.Finder_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private GMap.NET.WindowsForms.GMapControl gMapCntrl;
        private System.Windows.Forms.Label lblUserString;
    }
}