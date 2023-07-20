namespace AlbumLagu
{
    partial class DataLirik
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
            this.btnadd = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnopen = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.cbxjudul = new System.Windows.Forms.ComboBox();
            this.cbxidpencipta = new System.Windows.Forms.ComboBox();
            this.cbxnamapencipta = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtidlirik = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndlt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(322, 107);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(553, 211);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Linen;
            this.label1.Location = new System.Drawing.Point(317, 354);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Lirik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Linen;
            this.label2.Location = new System.Drawing.Point(317, 407);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Judul";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Linen;
            this.label3.Location = new System.Drawing.Point(317, 454);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID Pencipta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Linen;
            this.label4.Location = new System.Drawing.Point(317, 513);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nama Pencipta";
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.PeachPuff;
            this.btnadd.Location = new System.Drawing.Point(322, 568);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(100, 41);
            this.btnadd.TabIndex = 9;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.PeachPuff;
            this.btnsave.Location = new System.Drawing.Point(550, 568);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(100, 41);
            this.btnsave.TabIndex = 10;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.PeachPuff;
            this.btnclear.Location = new System.Drawing.Point(776, 568);
            this.btnclear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(100, 41);
            this.btnclear.TabIndex = 11;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnopen
            // 
            this.btnopen.BackColor = System.Drawing.Color.PeachPuff;
            this.btnopen.Location = new System.Drawing.Point(908, 107);
            this.btnopen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(100, 39);
            this.btnopen.TabIndex = 12;
            this.btnopen.Text = "Open";
            this.btnopen.UseVisualStyleBackColor = false;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.PeachPuff;
            this.btnback.Location = new System.Drawing.Point(189, 107);
            this.btnback.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(100, 39);
            this.btnback.TabIndex = 13;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // cbxjudul
            // 
            this.cbxjudul.FormattingEnabled = true;
            this.cbxjudul.Location = new System.Drawing.Point(524, 407);
            this.cbxjudul.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxjudul.Name = "cbxjudul";
            this.cbxjudul.Size = new System.Drawing.Size(351, 33);
            this.cbxjudul.TabIndex = 15;
            this.cbxjudul.SelectedIndexChanged += new System.EventHandler(this.cbxjudul_SelectedIndexChanged);
            // 
            // cbxidpencipta
            // 
            this.cbxidpencipta.FormattingEnabled = true;
            this.cbxidpencipta.Location = new System.Drawing.Point(524, 460);
            this.cbxidpencipta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxidpencipta.Name = "cbxidpencipta";
            this.cbxidpencipta.Size = new System.Drawing.Size(351, 33);
            this.cbxidpencipta.TabIndex = 16;
            // 
            // cbxnamapencipta
            // 
            this.cbxnamapencipta.FormattingEnabled = true;
            this.cbxnamapencipta.Location = new System.Drawing.Point(524, 503);
            this.cbxnamapencipta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxnamapencipta.Name = "cbxnamapencipta";
            this.cbxnamapencipta.Size = new System.Drawing.Size(351, 33);
            this.cbxnamapencipta.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(518, 354);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 25);
            this.label5.TabIndex = 18;
            // 
            // txtidlirik
            // 
            this.txtidlirik.Location = new System.Drawing.Point(526, 354);
            this.txtidlirik.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtidlirik.Name = "txtidlirik";
            this.txtidlirik.Size = new System.Drawing.Size(348, 30);
            this.txtidlirik.TabIndex = 19;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.PeachPuff;
            this.btnupdate.Location = new System.Drawing.Point(908, 167);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(100, 42);
            this.btnupdate.TabIndex = 20;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndlt
            // 
            this.btndlt.BackColor = System.Drawing.Color.PeachPuff;
            this.btndlt.Location = new System.Drawing.Point(908, 241);
            this.btndlt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btndlt.Name = "btndlt";
            this.btndlt.Size = new System.Drawing.Size(100, 46);
            this.btndlt.TabIndex = 21;
            this.btndlt.Text = "Delete";
            this.btndlt.UseVisualStyleBackColor = false;
            this.btndlt.Click += new System.EventHandler(this.btndlt_Click);
            // 
            // DataLirik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.btndlt);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.txtidlirik);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxnamapencipta);
            this.Controls.Add(this.cbxidpencipta);
            this.Controls.Add(this.cbxjudul);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DataLirik";
            this.Text = "Data Lirik";
            this.Load += new System.EventHandler(this.DataLirik_Load);
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
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.ComboBox cbxjudul;
        private System.Windows.Forms.ComboBox cbxidpencipta;
        private System.Windows.Forms.ComboBox cbxnamapencipta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtidlirik;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndlt;
    }
}