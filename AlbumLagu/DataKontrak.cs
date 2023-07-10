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
            string query = "SELECT id_kontrak, id_artis, id_produser, tanggal_mulai, tanggal_berakhir, nilai_kontrak FROM kontrak";
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
    }
}
