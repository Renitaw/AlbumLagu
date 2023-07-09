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
        private string idpencipta, namapencipta;
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
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(new SqlCommand("Select id_lagu, id_artis, id_produser, judul, durasi, genre from dbo.lagu", koneksi));
            DataSet ds = new DataSet();
            dataAdapter1.Fill(ds);

            this.customerBindingSource.DataSource = ds.Tables[0];
            this.txtidlagu.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "id_lagu", true));
            this.txtidartis.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "id_artis", true));
            this.txtidproduser.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "id_produser", true));
            this.txtjudul.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "judul", true));
            this.txtdurasi.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "durasi", true));
            this.txtgenre.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "genre", true));
            koneksi.Close();

        }

        private void clearBinding()
        {
            this.txtidlagu.DataBindings.Clear();
            this.txtidartis.DataBindings.Clear();
            this.txtidproduser.DataBindings.Clear();
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
            txtidartis.Text = "";
            txtidproduser.Text = "";
            txtjudul.Text = "";
            txtdurasi.Text = "";
            txtgenre.Text = "";
            txtidlagu.Enabled = true;
            txtidartis.Enabled = true;
            txtidproduser.Enabled = true;
            txtjudul.Enabled = true;
            txtdurasi.Enabled = true;
            txtgenre.Enabled = true;
            btnsave.Enabled = true;
            btnclear.Enabled = true;
            btnadd.Enabled = false;
        }

        private void refreshform()
        {
            txtidlagu.Enabled = false;
            txtidartis.Enabled = false;
            txtidproduser.Enabled = false;
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
