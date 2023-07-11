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
        private string stringConnection = "data source=RENITAWIDIASTUT\\RENITAWDST;database=ACT6;User ID=sa; Password=Rere2607";
        private SqlConnection koneksi;
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

        private void datagridview1()
        {
            koneksi.Open();
            string str = "select * from dbo.daftar_putar";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void DataDaftarPutar_Load(object sender, EventArgs e)
        {

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
            txtiddaftarputar.Enabled = true;
            txtnamadaftar.Enabled = true;
            txtidpengguna.Enabled = true;
            cbxidlagu.Enabled = true;
            btnclear.Enabled = true;
            btnsave.Enabled = true;
            btnadd.Enabled = false;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string iddaftarputar = txtiddaftarputar.Text;
            string namadaftar = txtnamadaftar.Text;
            string idpengguna = txtidpengguna.Text;
            string idlagu = cbxidlagu.Text;

            if (iddaftarputar == "")
            {
                MessageBox.Show("Masukkan iddaftarputar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (namadaftar == "")
            {
                MessageBox.Show("Masukkan namadaftar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (idpengguna == "")
            {
                MessageBox.Show("Masukkan idpengguna", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (idlagu == "")
            {
                MessageBox.Show("Masukkan idlagu", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "INSERT INTO daftar_putar (id_daftar_putar, nama_daftar, id_pengguna, id_lagu) VALUES (@id_daftar_putar, @nama_daftar, @id_pengguna, @id_lagu";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@id_daftar_putar", iddaftarputar));
                cmd.Parameters.Add(new SqlParameter("@nama_daftar", namadaftar));
                cmd.Parameters.Add(new SqlParameter("@id_pengguna", idpengguna));
                cmd.Parameters.Add(new SqlParameter("@id_lagu", idlagu));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                datagridview1();
                refreshform();
            }
        }
    }
}
