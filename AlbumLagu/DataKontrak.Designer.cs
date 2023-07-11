namespace AlbumLagu
{
    partial class DataKontrak
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
            this.dttm = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtidkontrak = new System.Windows.Forms.TextBox();
            this.txtnilaikontrak = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.dtm = new System.Windows.Forms.DateTimePicker();
            this.dttb = new System.Windows.Forms.DateTimePicker();
            this.btnopen = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.cbxidartis = new System.Windows.Forms.ComboBox();
            this.cbxidproduser = new System.Windows.Forms.ComboBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(218, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(404, 189);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Linen;
            this.label1.Location = new System.Drawing.Point(213, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Kontrak";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Linen;
            this.label2.Location = new System.Drawing.Point(213, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID Artis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Linen;
            this.label3.Location = new System.Drawing.Point(213, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID Produser";
            // 
            // dttm
            // 
            this.dttm.AutoSize = true;
            this.dttm.BackColor = System.Drawing.Color.Linen;
            this.dttm.Location = new System.Drawing.Point(213, 332);
            this.dttm.Name = "dttm";
            this.dttm.Size = new System.Drawing.Size(107, 20);
            this.dttm.TabIndex = 4;
            this.dttm.Text = "Tanggal Mulai";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Linen;
            this.label5.Location = new System.Drawing.Point(213, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tanggal Berakhir";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Linen;
            this.label6.Location = new System.Drawing.Point(213, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nilai Kontrak";
            // 
            // txtidkontrak
            // 
            this.txtidkontrak.Location = new System.Drawing.Point(348, 238);
            this.txtidkontrak.Name = "txtidkontrak";
            this.txtidkontrak.Size = new System.Drawing.Size(272, 26);
            this.txtidkontrak.TabIndex = 7;
            // 
            // txtnilaikontrak
            // 
            this.txtnilaikontrak.Location = new System.Drawing.Point(348, 395);
            this.txtnilaikontrak.Name = "txtnilaikontrak";
            this.txtnilaikontrak.Size = new System.Drawing.Size(272, 26);
            this.txtnilaikontrak.TabIndex = 12;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.LightSalmon;
            this.btnadd.Location = new System.Drawing.Point(218, 454);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 29);
            this.btnadd.TabIndex = 13;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.LightSalmon;
            this.btnsave.Location = new System.Drawing.Point(380, 454);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 29);
            this.btnsave.TabIndex = 14;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.LightSalmon;
            this.btnclear.Location = new System.Drawing.Point(546, 454);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 29);
            this.btnclear.TabIndex = 15;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // dtm
            // 
            this.dtm.Location = new System.Drawing.Point(348, 332);
            this.dtm.Name = "dtm";
            this.dtm.Size = new System.Drawing.Size(272, 26);
            this.dtm.TabIndex = 16;
            // 
            // dttb
            // 
            this.dttb.Location = new System.Drawing.Point(348, 365);
            this.dttb.Name = "dttb";
            this.dttb.Size = new System.Drawing.Size(272, 26);
            this.dttb.TabIndex = 17;
            // 
            // btnopen
            // 
            this.btnopen.BackColor = System.Drawing.Color.LightSalmon;
            this.btnopen.Location = new System.Drawing.Point(646, 25);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(75, 35);
            this.btnopen.TabIndex = 18;
            this.btnopen.Text = "Open";
            this.btnopen.UseVisualStyleBackColor = false;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.LightSalmon;
            this.btnback.Location = new System.Drawing.Point(122, 25);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 35);
            this.btnback.TabIndex = 19;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // cbxidartis
            // 
            this.cbxidartis.FormattingEnabled = true;
            this.cbxidartis.Location = new System.Drawing.Point(348, 269);
            this.cbxidartis.Name = "cbxidartis";
            this.cbxidartis.Size = new System.Drawing.Size(273, 28);
            this.cbxidartis.TabIndex = 20;
            // 
            // cbxidproduser
            // 
            this.cbxidproduser.FormattingEnabled = true;
            this.cbxidproduser.Location = new System.Drawing.Point(348, 298);
            this.cbxidproduser.Name = "cbxidproduser";
            this.cbxidproduser.Size = new System.Drawing.Size(272, 28);
            this.cbxidproduser.TabIndex = 21;
            this.cbxidproduser.SelectedIndexChanged += new System.EventHandler(this.cbxproduser_SelectedIndexChanged);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.LightSalmon;
            this.btnupdate.Location = new System.Drawing.Point(646, 89);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 33);
            this.btnupdate.TabIndex = 22;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.LightSalmon;
            this.btndelete.Location = new System.Drawing.Point(646, 155);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 31);
            this.btndelete.TabIndex = 23;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // DataKontrak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(864, 529);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.cbxidproduser);
            this.Controls.Add(this.cbxidartis);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.dttb);
            this.Controls.Add(this.dtm);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtnilaikontrak);
            this.Controls.Add(this.txtidkontrak);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dttm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DataKontrak";
            this.Text = "Data Kontrak";
            this.Load += new System.EventHandler(this.DataKontrak_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dttm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtidkontrak;
        private System.Windows.Forms.TextBox txtnilaikontrak;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.DateTimePicker dtm;
        private System.Windows.Forms.DateTimePicker dttb;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.ComboBox cbxidartis;
        private System.Windows.Forms.ComboBox cbxidproduser;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
    }
}