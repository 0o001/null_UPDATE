namespace null_UPDATE
{
    partial class frm_guncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_guncelle));
            this.pcr_logo = new System.Windows.Forms.PictureBox();
            this.pbr_indir = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pcr_logo
            // 
            this.pcr_logo.BackColor = System.Drawing.SystemColors.Control;
            this.pcr_logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcr_logo.Image = global::null_UPDATE.Properties.Resources.o_6bf0452764eceb42_2;
            this.pcr_logo.Location = new System.Drawing.Point(0, 0);
            this.pcr_logo.Name = "pcr_logo";
            this.pcr_logo.Size = new System.Drawing.Size(48, 48);
            this.pcr_logo.TabIndex = 0;
            this.pcr_logo.TabStop = false;
            // 
            // pbr_indir
            // 
            this.pbr_indir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pbr_indir.Location = new System.Drawing.Point(59, 12);
            this.pbr_indir.Name = "pbr_indir";
            this.pbr_indir.Size = new System.Drawing.Size(226, 23);
            this.pbr_indir.TabIndex = 1;
            // 
            // frm_guncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 48);
            this.Controls.Add(this.pbr_indir);
            this.Controls.Add(this.pcr_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_guncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Güncelle - SQL Yardımcısı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_guncelle_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pcr_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcr_logo;
        private System.Windows.Forms.ProgressBar pbr_indir;
    }
}

