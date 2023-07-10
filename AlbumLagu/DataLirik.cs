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
    public partial class DataLirik : Form
    {
        private string stringConnection = "data source=RENITAWIDIASTUT\\RENITAWDST;database=ALBUMLAGUUAS;User ID=sa; Password=Rere2607";
        private SqlConnection koneksi;

        public DataLirik()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void refreshform()
        {
            txtidlirik.Enabled = false;
            cbxjudul.Enabled = false;
            cbxidpencipta.Enabled = false;
            cbxnamapencipta.Enabled= false;
            txtidlirik.Visible = false;
            cbxjudul.SelectedIndex = -1;
            cbxidpencipta.SelectedIndex = -1;
            cbxnamapencipta.SelectedIndex = -1;
            btnsave.Enabled = false;
            btnclear.Enabled = false;
            btnadd.Enabled = true;
        }

        private void datagridview1()
        {
            koneksi.Open();
            string str = "select * from dbo.lirik";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void cblirik()
        {
            koneksi.Open();
            string str = "select judul, id_pencipta from dbo.lagu where" +
                "select nama_pencipta from dbo.pencipta where" +
                "not EXISTS(select id_lirik from dbo.lirik)";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();

            cbxjudul.DisplayMember = "judul";
            cbxjudul.ValueMember = "judul";
            cbxjudul.DataSource = ds.Tables[0];

        }

        private void DataLirik_Load(object sender, EventArgs e)
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
            txtidlirik.Enabled = true;
            cbxjudul.Enabled = true;
            cbxidpencipta.Enabled = true;
            cbxnamapencipta.Enabled = true;
            cblirik();
            btnclear.Enabled = true;
            btnsave.Enabled = true;
            btnadd.Enabled = false;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string idlirik = txtidlirik.Text;
            string judul = cbxjudul.Text;
            string idpencipta = cbxidpencipta.Text;
            string namapencipta = cbxnamapencipta.Text;
            int count = 0;
            string tempKodelirik = "";
            string kodelirik = "";
            koneksi.Open();

            string str = "select count (*) from dbo.lirik";
            SqlCommand cm = new SqlCommand(str, koneksi);
            count = (int)cm.ExecuteScalar();
            if (count == 0)
            {
                kodelirik = "1";
            }
            else
            {
                string queryString = "select Max(id_lirik) from dbo.lirik";
                SqlCommand cmlirik = new SqlCommand(str, koneksi);
                int totallirik = (int)cmlirik.ExecuteScalar();
                int finalKodelirikInt = totallirik+ 1;
                kodelirik = Convert.ToString(finalKodelirikInt);
            }
            string queryStrings = "insert into dbo.status_mahasiswa (idlirik ,judul ," + "status_mahasiswa, tahun_masuk)" + "values(@ids, @NIM, @sm, @tm)";
            SqlCommand cmd = new SqlCommand(queryStrings, koneksi);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("idlirik", kodelirik));
            cmd.Parameters.Add(new SqlParameter("judl",judul ));
            cmd.Parameters.Add(new SqlParameter("idpencipta", idpencipta));
            cmd.Parameters.Add(new SqlParameter("namapencipta", namapencipta));
            cmd.ExecuteNonQuery();
            koneksi.Close();

            MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refreshform();
            datagridview1();

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void cbxjudul_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
