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
    public partial class DataLagu : Form
    {
        private string stringConnection = "data source=RENITAWIDIASTUT\\RENITAWDST;database=ALBUMLAGUUAS;User ID=sa; Password=Rere2607";
        private SqlConnection koneksi;
        private string idlagu, idartis, idproduser, judul, durasi, genre;
        BindingSource customerBindingSource = new BindingSource();
        public DataLagu()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            this.bindingNavigator1.BindingSource = this.customerBindingSource;
            refreshform();
        }

        private void DataLagu_Load()
        {
            koneksi.Open();


            SqlDataAdapter artisDataAdapter = new SqlDataAdapter(new SqlCommand("SELECT id_artis, nama_artis FROM dbo.artis", koneksi));
            DataTable artisDataTable = new DataTable();
            artisDataAdapter.Fill(artisDataTable);
            cbxidartis.DataSource = artisDataTable;
            cbxidartis.DisplayMember = "nama_artis";
            cbxidartis.ValueMember = "id_artis";

            SqlDataAdapter produserDataAdapter = new SqlDataAdapter(new SqlCommand("SELECT id_produser, nama_produser FROM dbo.produser", koneksi));
            DataTable produserDataTable = new DataTable();
            produserDataAdapter.Fill(produserDataTable);
            cbxidproduser.DataSource = produserDataTable;
            cbxidproduser.DisplayMember = "nama_produser";
            cbxidproduser.ValueMember = "id_produser";

            koneksi.Close();

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void txtidartis_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxidproduser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clearBinding()
        {
            this.txtidlagu.DataBindings.Clear();
            this.cbxidartis.DataBindings.Clear();
            this.cbxidproduser.DataBindings.Clear();
            this.txtjudul.DataBindings.Clear();
            this.txtdurasi.DataBindings.Clear();
            this.txtgenre.DataBindings.Clear();

        }

        private void DataLagu_Load(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            txtidlagu.Text = "";
            cbxidartis.Text = "";
            cbxidproduser.Text = "";
            txtjudul.Text = "";
            txtdurasi.Text = "";
            txtgenre.Text = "";
            txtidlagu.Enabled = true;
            cbxidartis.Enabled = true;
            cbxidproduser.Enabled = true;
            txtjudul.Enabled = true;
            txtdurasi.Enabled = true;
            txtgenre.Enabled = true;
            btnsave.Enabled = true;
            btnclear.Enabled = true;
            btnadd.Enabled = false;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            idlagu = txtidlagu.Text;
            idartis = cbxidartis.SelectedValue.ToString();
            idproduser = cbxidproduser.SelectedValue.ToString();
            judul = txtjudul.Text;
            durasi = txtdurasi.Text;
            genre = txtgenre.Text;
        }

        private void refreshform()
        {
            txtidlagu.Enabled = false;
            cbxidartis.Enabled = false;
            cbxidproduser.Enabled = false;
            txtjudul.Enabled = false;
            txtdurasi.Enabled = false;
            txtgenre.Enabled = false;
            btnsave.Enabled = false;
            btnclear.Enabled = false;
            clearBinding();
            DataLagu_Load();

        }
    }
}
