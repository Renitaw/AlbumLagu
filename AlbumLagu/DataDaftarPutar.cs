using System;
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
    public partial class DataDaftarPutar : Form
    {
        private string stringConnection = "data source=RENITAWIDIASTUT\\RENITAWDST;database=ALBUMLAGUUAS;User ID=sa; Password=Rere2607";
        private SqlConnection koneksi;
        BindingSource customerBindingSource = new BindingSource();
        public DataDaftarPutar()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void refreshform()
        {
            txtiddaftarputar.Enabled = false;
            txtnamadaftar.Enabled = false;
            txtidpengguna.Enabled = false;
            cbxidlagu.Enabled = false;
            btnsave.Enabled = false;
            btnclear.Enabled = false;
            btnadd.Enabled = true;

        }
        private void FormDataDaftarPutar_Load()
        {
            koneksi.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(new SqlCommand("Select d.id_daftar_putar, d.nama_daftar, d.id_pengguna, d.id_lagu, l.id_lagu FROM dbo.daftar_putar d JOIN dbo.lagu p ON d.id_lagu = l.id_lagu", koneksi));
            DataSet ds = new DataSet();
            dataAdapter1.Fill(ds);

            this.customerBindingSource.DataSource = ds.Tables[0];
            this.txtiddaftarputar.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "iddaftarputar", true));
            this.txtnamadaftar.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "nama_daftar", true));
            this.txtidpengguna.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "alamat", true));
            this.cbxidlagu.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "id_lagu", true));

            koneksi.Close();
        }

        private void dataGridView()
        {
            koneksi.Open();
            string query = "SELECT id_daftar_putar, nama_daftar, id_pengguna, id_lagu FROM dbo.daftar_putar";
            SqlDataAdapter da = new SqlDataAdapter(query, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void DataDaftarPutar_Load(object sender, EventArgs e)
        {
            FillComboBox();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnopen.Enabled = false;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            txtiddaftarputar.Enabled = true;
            txtnamadaftar.Enabled = true;
            txtidpengguna.Enabled = true;
            cbxidlagu.Enabled = true;
            btnsave.Enabled = true;
            btnclear.Enabled = false;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string iddaftarputar = txtiddaftarputar.Text;
            string namadaftar = txtnamadaftar.Text;
            string idpengguna = txtidpengguna.Text;
            string idlagu = cbxidlagu.ValueMember;
            if (iddaftarputar == "")
            {
                MessageBox.Show("Masukkan id daftar putar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (namadaftar == "")
            {
                MessageBox.Show("Masukkan nama daftar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (idpengguna == "")
            {
                MessageBox.Show("Masukkan id pengguna", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (idlagu == "")
            {
                MessageBox.Show("Masukkan id lagu", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "INSERT INTO daftar_putar (id_daftar_putar, nama_daftar, id_pengguna) VALUES (@id_daftar_putar, @nama_daftar, @id_pengguna)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@id_daftar_putar", iddaftarputar));
                cmd.Parameters.Add(new SqlParameter("@nama_daftar", namadaftar));
                cmd.Parameters.Add(new SqlParameter("@id_pengguna", idpengguna));
                cmd.Parameters.Add(new SqlParameter("@id_lagu", idlagu));
                cmd.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
            }
        }

        private void FillComboBox()
        {
            koneksi.Open();
            string query = "SELECT id_lagu FROM dbo.lagu";
            SqlDataAdapter adapter = new SqlDataAdapter(query, koneksi);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "Lagu");
            cbxidlagu.DisplayMember = "id_lagu";
            cbxidlagu.ValueMember = "id_lagu";
            cbxidlagu.DataSource = dataset.Tables["Lagu"];
            koneksi.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
                        Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void btnupdt_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih baris data yang akan diperbarui", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string iddaftarputar = txtiddaftarputar.Text;
            string namadaftar = txtnamadaftar.Text;
            string idpengguna = txtidpengguna.Text;
            string idlagu = cbxidlagu.SelectedValue.ToString();

            if (string.IsNullOrEmpty(iddaftarputar))
            {
                MessageBox.Show("ID Daftar Putar tidak valid", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(namadaftar))
            {
                MessageBox.Show("Masukkan Nama Daftar", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(idpengguna))
            {
                MessageBox.Show("Masukkan ID Pengguna", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(idlagu))
            {
                MessageBox.Show("Pilih ID Lagu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = "UPDATE daftar_putar SET nama_daftar = @nama_daftar, id_pengguna = @id_pengguna, id_lagu = @id_lagu WHERE id_daftar_putar = @id_daftar_putar";
            using (SqlCommand command = new SqlCommand(sql, koneksi))
            {
                command.Parameters.AddWithValue("@id_daftar_putar", iddaftarputar);
                command.Parameters.AddWithValue("@nama_daftar", namadaftar);
                command.Parameters.AddWithValue("@id_pengguna", idpengguna);
                command.Parameters.AddWithValue("@id_lagu", idlagu);

                try
                {
                    koneksi.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data berhasil diperbarui", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        koneksi.Close();
                        refreshform();
                        dataGridView();
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

        private void btndlt_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih baris data yang akan dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string iddaftarputar = dataGridView1.SelectedRows[0].Cells["id_daftar_putar"].Value.ToString();

            string sql = "DELETE FROM daftar_putar WHERE id_daftar_putar = @id_daftar_putar";
            using (SqlCommand command = new SqlCommand(sql, koneksi))
            {
                command.Parameters.AddWithValue("@id_daftar_putar", iddaftarputar);

                try
                {
                    koneksi.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data berhasil dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        koneksi.Close();
                        refreshform();
                        dataGridView();
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

        private void cbxidlagu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
