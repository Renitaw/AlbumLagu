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
            string query = "SELECT id_kontrak from dbo.kontrak where" +
                "select id_artis from dbo.artis where" +
                "select id_produser from dbo.produser where" +
                "select tanggal_mulai from dbo.kontrak where" +
                "select tanggal_berakhir from dbo.kontrak where" +
                "select nilai_kontrak from dbo.kontrak where" +
                "not EXISTS(select id_lirik from dbo.lirik)";
            SqlDataAdapter da = new SqlDataAdapter(query, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }
        private void DataKontrak_Load(object sender, EventArgs e)
        {

        }
        private void refreshform()
        {
            cbxidartis.Enabled = false;
            txtidkontrak.Enabled = false;
            cbxidproduser.Enabled = false;
            txtnilaikontrak.Enabled = false;
            btnsave.Enabled = false;
            btnclear.Enabled = false;
            clearBinding();
            LoadData();

        }
        private void clearBinding()
        {
            this.cbxidartis.DataBindings.Clear();
            this.txtidkontrak.DataBindings.Clear();
            this.cbxidproduser.DataBindings.Clear();
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
            cbxidartis.Enabled = true;
            cbxidproduser.Enabled = true;
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
            txtnilaikontrak.Enabled = true;
            btnsave.Enabled = true;
            btnclear.Enabled = true;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string idkontrak = txtidkontrak.Text;
            string idartis = cbxidartis.Text;
            string idproduser = cbxidproduser.Text;
            DateTime tanggalMulai = dateTimePicker1.Value;
            DateTime tanggalBerakhir = dateTimePicker2.Value;
            int nilaiKontrak = 0;
            if (!int.TryParse(txtnilaikontrak.Text, out nilaiKontrak))
            {
                MessageBox.Show("Please enter a valid integer value for 'Nilai Kontrak'.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (string.IsNullOrWhiteSpace(idkontrak) ||
                string.IsNullOrWhiteSpace(idartis) ||
                string.IsNullOrWhiteSpace(idproduser))
            {
                MessageBox.Show("Please enter all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string query = "INSERT INTO kontrak (id_kontrak, id_artis, id_produser, tanggal_mulai, tanggal_berakhir, nilai_kontrak) " +
                               "VALUES (@id_kontrak, @id_artis, @id_produser, @tanggal_mulai, @tanggal_berakhir, @nilai_kontrak)";
                SqlCommand cmd = new SqlCommand(query, koneksi);
                cmd.Parameters.Add("@id_kontrak", idkontrak);
                cmd.Parameters.Add("@id_artis", idartis);
                cmd.Parameters.Add("@id_produser", idproduser);
                cmd.Parameters.Add("@tanggal_mulai", tanggalMulai);
                cmd.Parameters.Add("@tanggal_berakhir", tanggalBerakhir);
                cmd.Parameters.AddWithValue("@nilai_kontrak", nilaiKontrak);
                cmd.ExecuteNonQuery();

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

        private void cbxproduser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
