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
        private void LoadData()
        {
            koneksi.Open();
            string query = "SELECT id_kontrak from dbo.lagu where" +
                "select id_artis from dbo.lagu where" +
                "select id_produser from dbo.lagu where" +
                "select tanggal_mulai from dbo.lagu where" +
                "select tanggal_berakhir from dbo.lagu where" +
                "select nilai_kontrak from dbo.lagu where" +
                "not EXISTS(select id_lirik from dbo.lirik)";
            SqlDataAdapter adapter = new SqlDataAdapter(query, koneksi);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            koneksi.Close();
        }
        private void DataKontrak_Load(object sender, EventArgs e)
        {

        }
        private void refreshform()
        {
            txtidartis.Enabled = false;
            txtidkontrak.Enabled = false;
            txtidproduser.Enabled = false;
            txtnilaikontrak.Enabled = false;
            btnsave.Enabled = false;
            btnclear.Enabled = false;
            clearBinding();
            LoadData();

        }
        private void clearBinding()
        {
            this.txtidartis.DataBindings.Clear();
            this.txtidkontrak.DataBindings.Clear();
            this.txtidproduser.DataBindings.Clear();
            this.txtnilaikontrak.DataBindings.Clear();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            LoadData();
            btnopen.Enabled = false;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            txtidkontrak.Enabled = true;
            txtidartis.Enabled = true;
            txtidproduser.Enabled = true;
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
            txtnilaikontrak.Enabled = true;
            btnsave.Enabled = true;
            btnclear.Enabled = true;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string idKontrak = txtidkontrak.Text;
            string idArtis = txtidartis.Text;
            string idProduser = txtidproduser.Text;
            DateTime tanggalMulai = dateTimePicker1.Value;
            DateTime tanggalBerakhir = dateTimePicker2.Value;
            int nilaiKontrak = 0;
            if (!int.TryParse(txtnilaikontrak.Text, out nilaiKontrak))
            {
                MessageBox.Show("Please enter a valid integer value for 'Nilai Kontrak'.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (string.IsNullOrWhiteSpace(idKontrak) ||
                string.IsNullOrWhiteSpace(idArtis) ||
                string.IsNullOrWhiteSpace(idProduser))
            {
                MessageBox.Show("Please enter all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string query = "INSERT INTO kontrak (id_kontrak, id_artis, id_produser, tanggal_mulai, tanggal_berakhir, nilai_kontrak) " +
                               "VALUES (@id_kontrak, @id_artis, @id_produser, @tanggal_mulai, @tanggal_berakhir, @nilai_kontrak)";
                SqlCommand command = new SqlCommand(query, koneksi);
                command.Parameters.AddWithValue("@id_kontrak", idKontrak);
                command.Parameters.AddWithValue("@id_artis", idArtis);
                command.Parameters.AddWithValue("@id_produser", idProduser);
                command.Parameters.AddWithValue("@tanggal_mulai", tanggalMulai);
                command.Parameters.AddWithValue("@tanggal_berakhir", tanggalBerakhir);
                command.Parameters.AddWithValue("@nilai_kontrak", nilaiKontrak);
                command.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                refreshform();
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
