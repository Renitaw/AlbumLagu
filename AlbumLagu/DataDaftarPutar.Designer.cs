namespace AlbumLagu
{
    partial class DataDaftarPutar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtiddaftarputar = new System.Windows.Forms.TextBox();
            this.txtnamadaftar = new System.Windows.Forms.TextBox();
            this.txtidpengguna = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnopen = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.cbxidlagu = new System.Windows.Forms.ComboBox();
            this.btnupdt = new System.Windows.Forms.Button();
            this.btndlt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(271, 38);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(511, 244);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Linen;
            this.label1.Location = new System.Drawing.Point(265, 311);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Daftar putar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Linen;
            this.label2.Location = new System.Drawing.Point(265, 356);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama Daftar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Linen;
            this.label3.Location = new System.Drawing.Point(265, 401);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID Pengguna";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Linen;
            this.label4.Location = new System.Drawing.Point(265, 442);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "ID Lagu";
            // 
            // txtiddaftarputar
            // 
            this.txtiddaftarputar.Location = new System.Drawing.Point(428, 311);
            this.txtiddaftarputar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtiddaftarputar.Name = "txtiddaftarputar";
            this.txtiddaftarputar.Size = new System.Drawing.Size(352, 30);
            this.txtiddaftarputar.TabIndex = 5;
            // 
            // txtnamadaftar
            // 
            this.txtnamadaftar.Location = new System.Drawing.Point(428, 352);
            this.txtnamadaftar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnamadaftar.Name = "txtnamadaftar";
            this.txtnamadaftar.Size = new System.Drawing.Size(352, 30);
            this.txtnamadaftar.TabIndex = 6;
            // 
            // txtidpengguna
            // 
            this.txtidpengguna.Location = new System.Drawing.Point(428, 394);
            this.txtidpengguna.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtidpengguna.Name = "txtidpengguna";
            this.txtidpengguna.Size = new System.Drawing.Size(352, 30);
            this.txtidpengguna.TabIndex = 7;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Linen;
            this.btnadd.Location = new System.Drawing.Point(271, 508);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(100, 40);
            this.btnadd.TabIndex = 9;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Linen;
            this.btnsave.Location = new System.Drawing.Point(476, 508);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(100, 40);
            this.btnsave.TabIndex = 10;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Linen;
            this.btnclear.Location = new System.Drawing.Point(680, 508);
            this.btnclear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(100, 40);
            this.btnclear.TabIndex = 11;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnopen
            // 
            this.btnopen.BackColor = System.Drawing.Color.Linen;
            this.btnopen.Location = new System.Drawing.Point(805, 38);
            this.btnopen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(100, 34);
            this.btnopen.TabIndex = 12;
            this.btnopen.Text = "Open";
            this.btnopen.UseVisualStyleBackColor = false;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Linen;
            this.btnback.Location = new System.Drawing.Point(144, 38);
            this.btnback.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(100, 34);
            this.btnback.TabIndex = 13;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // cbxidlagu
            // 
            this.cbxidlagu.FormattingEnabled = true;
            this.cbxidlagu.Location = new System.Drawing.Point(428, 442);
            this.cbxidlagu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxidlagu.Name = "cbxidlagu";
            this.cbxidlagu.Size = new System.Drawing.Size(352, 33);
            this.cbxidlagu.TabIndex = 14;
            this.cbxidlagu.SelectedIndexChanged += new System.EventHandler(this.cbxidlagu_SelectedIndexChanged);
            // 
            // btnupdt
            // 
            this.btnupdt.BackColor = System.Drawing.Color.Linen;
            this.btnupdt.Location = new System.Drawing.Point(805, 98);
            this.btnupdt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnupdt.Name = "btnupdt";
            this.btnupdt.Size = new System.Drawing.Size(100, 41);
            this.btnupdt.TabIndex = 15;
            this.btnupdt.Text = "Update";
            this.btnupdt.UseVisualStyleBackColor = false;
            this.btnupdt.Click += new System.EventHandler(this.btnupdt_Click);
            // 
            // btndlt
            // 
            this.btndlt.BackColor = System.Drawing.Color.Linen;
            this.btndlt.Location = new System.Drawing.Point(805, 159);
            this.btndlt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btndlt.Name = "btndlt";
            this.btndlt.Size = new System.Drawing.Size(100, 39);
            this.btndlt.TabIndex = 16;
            this.btndlt.Text = "Delete";
            this.btndlt.UseVisualStyleBackColor = false;
            this.btndlt.Click += new System.EventHandler(this.btndlt_Click);
            // 
            // DataDaftarPutar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.btndlt);
            this.Controls.Add(this.btnupdt);
            this.Controls.Add(this.cbxidlagu);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtidpengguna);
            this.Controls.Add(this.txtnamadaftar);
            this.Controls.Add(this.txtiddaftarputar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DataDaftarPutar";
            this.Text = "Data Daftar Putar";
            this.Load += new System.EventHandler(this.DataDaftarPutar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtiddaftarputar;
        private System.Windows.Forms.TextBox txtnamadaftar;
        private System.Windows.Forms.TextBox txtidpengguna;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.ComboBox cbxidlagu;
        private System.Windows.Forms.Button btnupdt;
        private System.Windows.Forms.Button btndlt;
    }
}