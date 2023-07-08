namespace AlbumLagu
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.datapencipta = new System.Windows.Forms.ToolStripMenuItem();
            this.datalagu = new System.Windows.Forms.ToolStripMenuItem();
            this.dataalbum = new System.Windows.Forms.ToolStripMenuItem();
            this.dataartis = new System.Windows.Forms.ToolStripMenuItem();
            this.dataproduser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.dataLirikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataDaftarPutarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataKontrakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 34);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datapencipta,
            this.datalagu,
            this.dataalbum,
            this.dataartis,
            this.dataproduser});
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(124, 29);
            this.toolStripDropDownButton1.Text = "Data Utama";
            // 
            // datapencipta
            // 
            this.datapencipta.Name = "datapencipta";
            this.datapencipta.Size = new System.Drawing.Size(270, 34);
            this.datapencipta.Text = "Data Pencipta";
            this.datapencipta.Click += new System.EventHandler(this.dataUtamaToolStripMenuItem_Click);
            // 
            // datalagu
            // 
            this.datalagu.Name = "datalagu";
            this.datalagu.Size = new System.Drawing.Size(270, 34);
            this.datalagu.Text = "Data Lagu";
            this.datalagu.Click += new System.EventHandler(this.dataPenciptaToolStripMenuItem_Click);
            // 
            // dataalbum
            // 
            this.dataalbum.Name = "dataalbum";
            this.dataalbum.Size = new System.Drawing.Size(270, 34);
            this.dataalbum.Text = "Data Album";
            this.dataalbum.Click += new System.EventHandler(this.dataLaguToolStripMenuItem_Click);
            // 
            // dataartis
            // 
            this.dataartis.Name = "dataartis";
            this.dataartis.Size = new System.Drawing.Size(270, 34);
            this.dataartis.Text = "Data Artis";
            this.dataartis.Click += new System.EventHandler(this.dataArtisToolStripMenuItem_Click);
            // 
            // dataproduser
            // 
            this.dataproduser.Name = "dataproduser";
            this.dataproduser.Size = new System.Drawing.Size(270, 34);
            this.dataproduser.Text = "Data Produser";
            this.dataproduser.Click += new System.EventHandler(this.dataProduserToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataLirikToolStripMenuItem,
            this.dataDaftarPutarToolStripMenuItem,
            this.dataKontrakToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(107, 29);
            this.toolStripDropDownButton2.Text = "Data Baru";
            // 
            // dataLirikToolStripMenuItem
            // 
            this.dataLirikToolStripMenuItem.Name = "dataLirikToolStripMenuItem";
            this.dataLirikToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.dataLirikToolStripMenuItem.Text = "Data Lirik ";
            this.dataLirikToolStripMenuItem.Click += new System.EventHandler(this.dataLirikToolStripMenuItem_Click);
            // 
            // dataDaftarPutarToolStripMenuItem
            // 
            this.dataDaftarPutarToolStripMenuItem.Name = "dataDaftarPutarToolStripMenuItem";
            this.dataDaftarPutarToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.dataDaftarPutarToolStripMenuItem.Text = "Data Daftar Putar";
            this.dataDaftarPutarToolStripMenuItem.Click += new System.EventHandler(this.dataDaftarPutarToolStripMenuItem_Click);
            // 
            // dataKontrakToolStripMenuItem
            // 
            this.dataKontrakToolStripMenuItem.Name = "dataKontrakToolStripMenuItem";
            this.dataKontrakToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.dataKontrakToolStripMenuItem.Text = "Data Kontrak";
            this.dataKontrakToolStripMenuItem.Click += new System.EventHandler(this.dataKontrakToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "DATA MASTER";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem datapencipta;
        private System.Windows.Forms.ToolStripMenuItem datalagu;
        private System.Windows.Forms.ToolStripMenuItem dataalbum;
        private System.Windows.Forms.ToolStripMenuItem dataartis;
        private System.Windows.Forms.ToolStripMenuItem dataproduser;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem dataLirikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataDaftarPutarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataKontrakToolStripMenuItem;
    }
}

