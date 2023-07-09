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
    public partial class DataAlbum : Form
    {
        private string stringConnection = "data source=RENITAWIDIASTUT\\RENITAWDST;database=ALBUMLAGUUAS;User ID=sa; Password=Rere2607";
        private SqlConnection koneksi;
        private string idalbum, namaalbum, idartis, idlagu, perusahaan, tahunrilis, genre;
        BindingSource customerBindingSource = new BindingSource();
        public DataAlbum()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            this.bindingNavigator1.BindingSource = this.customerBindingSource;
            refreshform();
        }

        private void DataAlbum_Load()
        {
            koneksi.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(new SqlCommand("Select id_album, nama_album, id_artis, id_lagu, perusahaan, tahun_rilis, genre from dbo.album", koneksi));
            DataSet ds = new DataSet();
            dataAdapter1.Fill(ds);

            this.customerBindingSource.DataSource = ds.Tables[0];
            this.txtidalbum.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "id_album", true));
            this.txtnamaalbum.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "id_album", true));
            this.txtidartis.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "id_artis", true));
            this.txtidlagu.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "id_lagu", true));
            this.txtperusahaan.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "perusahaan", true));
            this.txttahunrilis.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "tahun_rilis", true));
            this.txtgenre.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "genre", true));
            koneksi.Close();

        }

        private void clearBinding()
        {
            this.txtidalbum.DataBindings.Clear();
            this.txtnamaalbum.DataBindings.Clear();
            this.txtidartis.DataBindings.Clear();
            this.txtidlagu.DataBindings.Clear();
            this.txtperusahaan.DataBindings.Clear();
            this.txttahunrilis.DataBindings.Clear();
            this.txtgenre.DataBindings.Clear();

        }

        private void refreshform()
        {
            txtidalbum.Enabled = false;
            txtnamaalbum.Enabled = false;
            txtidartis.Enabled = false;
            txtidlagu.Enabled = false;
            txtperusahaan.Enabled = false;
            txttahunrilis.Enabled = false;
            txtgenre.Enabled = false;
            btnsave.Enabled = false;
            btnclear.Enabled = false;
            clearBinding();
            DataAlbum_Load();


        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataAlbum_Load(object sender, EventArgs e)
        {

        }
    }
}
