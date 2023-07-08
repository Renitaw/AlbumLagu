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
            this.txtidlirik = new System.Windows.Forms.TextBox();
            this.txtjudul = new System.Windows.Forms.TextBox();
            this.txtidpencipta = new System.Windows.Forms.TextBox();
            this.txtnamapencipta = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnopen = new System.Windows.Forms.Button();
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
            this.label4.Location = new System.Drawing.Point(183, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nama Pencipta";
            // 
            // txtidlirik
            // 
            this.txtidlirik.Location = new System.Drawing.Point(325, 234);
            this.txtidlirik.Name = "txtidlirik";
            this.txtidlirik.Size = new System.Drawing.Size(277, 26);
            this.txtidlirik.TabIndex = 5;
            // 
            // txtjudul
            // 
            this.txtjudul.Location = new System.Drawing.Point(325, 273);
            this.txtjudul.Name = "txtjudul";
            this.txtjudul.Size = new System.Drawing.Size(277, 26);
            this.txtjudul.TabIndex = 6;
            // 
            // txtidpencipta
            // 
            this.txtidpencipta.Location = new System.Drawing.Point(325, 314);
            this.txtidpencipta.Name = "txtidpencipta";
            this.txtidpencipta.Size = new System.Drawing.Size(277, 26);
            this.txtidpencipta.TabIndex = 7;
            // 
            // txtnamapencipta
            // 
            this.txtnamapencipta.Location = new System.Drawing.Point(325, 353);
            this.txtnamapencipta.Name = "txtnamapencipta";
            this.txtnamapencipta.Size = new System.Drawing.Size(277, 26);
            this.txtnamapencipta.TabIndex = 8;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(187, 405);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 33);
            this.btnadd.TabIndex = 9;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(358, 405);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 33);
            this.btnsave.TabIndex = 10;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(527, 405);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 33);
            this.btnclear.TabIndex = 11;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(626, 36);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(75, 31);
            this.btnopen.TabIndex = 12;
            this.btnopen.Text = "Open";
            this.btnopen.UseVisualStyleBackColor = true;
            // 
            // DataLirik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtnamapencipta);
            this.Controls.Add(this.txtidpencipta);
            this.Controls.Add(this.txtjudul);
            this.Controls.Add(this.txtidlirik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DataLirik";
            this.Text = "Data Lirik";
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
        private System.Windows.Forms.TextBox txtidlirik;
        private System.Windows.Forms.TextBox txtjudul;
        private System.Windows.Forms.TextBox txtidpencipta;
        private System.Windows.Forms.TextBox txtnamapencipta;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnopen;
    }
}