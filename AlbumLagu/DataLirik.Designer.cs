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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(187, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(415, 169);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Lirik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Judul";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID Pencipta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nama Pencipta";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(187, 405);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 33);
            this.btnadd.TabIndex = 9;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(358, 405);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 33);
            this.btnsave.TabIndex = 10;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(527, 405);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 33);
            this.btnclear.TabIndex = 11;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(626, 36);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(75, 31);
            this.btnopen.TabIndex = 12;
            this.btnopen.Text = "Open";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(87, 36);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 31);
            this.btnback.TabIndex = 13;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // cbxjudul
            // 
            this.cbxjudul.FormattingEnabled = true;
            this.cbxjudul.Location = new System.Drawing.Point(338, 276);
            this.cbxjudul.Name = "cbxjudul";
            this.cbxjudul.Size = new System.Drawing.Size(264, 28);
            this.cbxjudul.TabIndex = 15;
            this.cbxjudul.SelectedIndexChanged += new System.EventHandler(this.cbxjudul_SelectedIndexChanged);
            // 
            // cbxidpencipta
            // 
            this.cbxidpencipta.FormattingEnabled = true;
            this.cbxidpencipta.Location = new System.Drawing.Point(338, 318);
            this.cbxidpencipta.Name = "cbxidpencipta";
            this.cbxidpencipta.Size = new System.Drawing.Size(264, 28);
            this.cbxidpencipta.TabIndex = 16;
            // 
            // cbxnamapencipta
            // 
            this.cbxnamapencipta.FormattingEnabled = true;
            this.cbxnamapencipta.Location = new System.Drawing.Point(338, 353);
            this.cbxnamapencipta.Name = "cbxnamapencipta";
            this.cbxnamapencipta.Size = new System.Drawing.Size(264, 28);
            this.cbxnamapencipta.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 18;
            // 
            // txtidlirik
            // 
            this.txtidlirik.Location = new System.Drawing.Point(340, 234);
            this.txtidlirik.Name = "txtidlirik";
            this.txtidlirik.Size = new System.Drawing.Size(262, 26);
            this.txtidlirik.TabIndex = 19;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(626, 84);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 34);
            this.btnupdate.TabIndex = 20;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndlt
            // 
            this.btndlt.Location = new System.Drawing.Point(626, 143);
            this.btndlt.Name = "btndlt";
            this.btndlt.Size = new System.Drawing.Size(75, 37);
            this.btndlt.TabIndex = 21;
            this.btndlt.Text = "Delete";
            this.btndlt.UseVisualStyleBackColor = true;
            this.btndlt.Click += new System.EventHandler(this.btndlt_Click);
            // 
            // DataLirik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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