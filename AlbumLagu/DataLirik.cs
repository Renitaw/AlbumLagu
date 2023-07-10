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
    }
}
