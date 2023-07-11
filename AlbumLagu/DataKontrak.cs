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

        }
        private void refreshform()
        {
            txtidkontrak.Enabled = false;
            cbxidartis.Enabled = false;
            cbxidproduser.Enabled = false;
            dtm.Enabled = false;
            dttb.Enabled = false;
            btnsave.Enabled = false;
            btnclear.Enabled = false;
            btnadd.Enabled = true;
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
            string idartis = cbxidartis.ValueMember;
            string idproduser = cbxidproduser.ValueMember;
            DateTime tanggalmulai = dtm.Value;
            DateTime tanggalberakhir = dttb.Value;
            string nilaikontrak = txtnilaikontrak.Text;

            if (idkontrak == "")
            {
                MessageBox.Show("Masukkan id_kontrak", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (idartis == "")
            {
                MessageBox.Show("Masukkan id_artis", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (idproduser == "")
            {
                MessageBox.Show("Masukkan id_produser", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (string.IsNullOrEmpty(tanggalmulai.ToString()))
            {
                MessageBox.Show("Masukkan tanggal_mulai", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (string.IsNullOrEmpty(tanggalberakhir.ToString()))
            {
                MessageBox.Show("Masukkan tanggal_berakhir", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "INSERT INTO lirik (id_lirik, judul, id_pencipta, nama_pencipta) VALUES (@id_lirik, @judul, @id_pencipta, @nama_pencipta)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@id_kontrak", idkontrak));
                cmd.Parameters.Add(new SqlParameter("@id_artis", idartis));
                cmd.Parameters.Add(new SqlParameter("@id_produser", idproduser));
                cmd.Parameters.Add(new SqlParameter("@tanggal_mulai", tanggalmulai));
                cmd.Parameters.Add(new SqlParameter("@tanggal_berakhir", tanggalberakhir));
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
    }
}
