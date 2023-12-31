﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbumLagu
{
    public partial class DataKontrak : Form
    {
        private string stringConnection = "data source=RENITAWIDIASTUT\\RENITAWDST;database=ALBUMLAGUUAS;User ID=sa; Password=Rere2607";
        private SqlConnection koneksi;
        public DataKontrak()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }
        private void datagridview1()
        {
            koneksi.Open();
            string str = "select * from dbo.kontrak";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }
        private void DataKontrak_Load(object sender, EventArgs e)
        {
            FillComboBox();
        }

        private void FillComboBox()
        {
            koneksi.Open();
            string queryArtis = "SELECT id_artis FROM dbo.artis";
            SqlDataAdapter adapterArtis = new SqlDataAdapter(queryArtis, koneksi);
            DataSet datasetArtis = new DataSet();
            adapterArtis.Fill(datasetArtis, "Artis");
            cbxidartis.DisplayMember = "id_artis";
            cbxidartis.ValueMember = "id_artis";
            cbxidartis.DataSource = datasetArtis.Tables["Artis"];
            koneksi.Close();

            koneksi.Open();
            string queryProduser = "SELECT id_produser FROM dbo.produser";
            SqlDataAdapter adapterProduser = new SqlDataAdapter(queryProduser, koneksi);
            DataSet datasetProduser = new DataSet();
            adapterProduser.Fill(datasetProduser, "Produser");
            cbxidproduser.DisplayMember = "id_produser";
            cbxidproduser.ValueMember = "id_produser";
            cbxidproduser.DataSource = datasetProduser.Tables["Produser"];
            koneksi.Close();
        }
        private void refreshform()
        {
            txtidkontrak.Enabled = false;
            cbxidartis.Enabled = false;
            cbxidproduser.Enabled = false;
            dtm.Enabled = false;
            dttb.Enabled = false;
            txtnilaikontrak.Enabled = false;
            btnsave.Enabled = false;
            btnclear.Enabled = false;
            btnadd.Enabled = true;
        }
        private void clearBinding()
        {
            this.cbxidartis.DataBindings.Clear();
            this.txtidkontrak.DataBindings.Clear();
            this.cbxidproduser.DataBindings.Clear();
            this.dtm.DataBindings.Clear();
            this.dttb.DataBindings.Clear();
            this.txtnilaikontrak.DataBindings.Clear();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            datagridview1();
            btnopen.Enabled = false;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            txtidkontrak.Enabled = true;
            cbxidartis.Enabled = true;
            cbxidproduser.Enabled = true;
            dtm.Enabled = true;
            dttb.Enabled = true;
            txtnilaikontrak.Enabled = true;
            btnsave.Enabled = true;
            btnclear.Enabled = true;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string idkontrak = txtidkontrak.Text;
            string idartis = cbxidartis.SelectedValue.ToString();
            string idproduser = cbxidproduser.SelectedValue.ToString();
            DateTime tanggalmulai = dtm.Value;
            DateTime tanggalberakhir = dttb.Value;
            string nilaikontrak = txtnilaikontrak.Text;

            if (idkontrak == "")
            {
                MessageBox.Show("Masukkan id_kontrak", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (idartis == "")
            {
                MessageBox.Show("Masukkan id_artis", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (idproduser == "")
            {
                MessageBox.Show("Masukkan id_produser", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(tanggalmulai.ToString()))
            {
                MessageBox.Show("Masukkan tanggal_mulai", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(tanggalberakhir.ToString()))
            {
                MessageBox.Show("Masukkan tanggal_berakhir", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nilaikontrak == "")
            {
                MessageBox.Show("Masukkan nilai_kontrak", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "INSERT INTO kontrak (id_kontrak, id_artis, id_produser, tanggal_mulai, tanggal_berakhir, nilai_kontrak) VALUES (@ID_kontrak, @ID_artis, @ID_produser, @tanggal_mulai, @tanggal_berakhir, @nilai_kontrak)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@ID_kontrak", idkontrak));
                cmd.Parameters.Add(new SqlParameter("@ID_artis", idartis));
                cmd.Parameters.Add(new SqlParameter("@ID_produser", idproduser));
                cmd.Parameters.Add(new SqlParameter("@tanggal_mulai", tanggalmulai));
                cmd.Parameters.Add(new SqlParameter("@tanggal_berakhir", tanggalberakhir));
                cmd.Parameters.Add(new SqlParameter("@nilai_kontrak", nilaikontrak)); 
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                datagridview1();
                refreshform();
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void cbxproduser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih baris data yang akan diperbarui", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idkontrak = txtidkontrak.Text;
            string idartis = cbxidartis.SelectedValue.ToString();
            string idproduser = cbxidproduser.SelectedValue.ToString();
            DateTime tanggalmulai = dtm.Value;
            DateTime tanggalberakhir = dttb.Value;
            string nilaikontrak = txtnilaikontrak.Text;

            if (string.IsNullOrEmpty(idkontrak) || string.IsNullOrEmpty(idartis) || string.IsNullOrEmpty(idproduser) || string.IsNullOrEmpty(nilaikontrak))
            {
                MessageBox.Show("Harap lengkapi semua field", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = "UPDATE kontrak SET id_artis = @id_artis, id_produser = @id_produser, tanggal_mulai = @tanggal_mulai, tanggal_berakhir = @tanggal_berakhir, nilai_kontrak = @nilai_kontrak WHERE id_kontrak = @id_kontrak";
            using (SqlCommand command = new SqlCommand(sql, koneksi))
            {
                command.Parameters.AddWithValue("@id_kontrak", idkontrak);
                command.Parameters.AddWithValue("@id_artis", idartis);
                command.Parameters.AddWithValue("@id_produser", idproduser);
                command.Parameters.AddWithValue("@tanggal_mulai", tanggalmulai);
                command.Parameters.AddWithValue("@tanggal_berakhir", tanggalberakhir);
                command.Parameters.AddWithValue("@nilai_kontrak", nilaikontrak);

                try
                {
                    koneksi.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data berhasil diperbarui", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refreshform();
                        datagridview1();
                    }
                    else
                    {
                        MessageBox.Show("Data tidak ditemukan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    koneksi.Close();
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih baris data yang akan dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string idkontrak = txtidkontrak.Text;

                if (string.IsNullOrEmpty(idkontrak))
                {
                    MessageBox.Show("ID Kontrak tidak valid", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string sql = "DELETE FROM kontrak WHERE id_kontrak = @id_kontrak";
                using (SqlCommand command = new SqlCommand(sql, koneksi))
                {
                    command.Parameters.AddWithValue("@id_kontrak", idkontrak);

                    try
                    {
                        koneksi.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data berhasil dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            koneksi.Close();
                            refreshform();
                            datagridview1();
                        }
                        else
                        {
                            MessageBox.Show("Data tidak ditemukan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
