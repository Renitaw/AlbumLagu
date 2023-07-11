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
    public partial class DataArtis : Form
    {
        private string stringConnection = "data source=RENITAWIDIASTUT\\RENITAWDST;database=ALBUMLAGUUAS;User ID=sa; Password=Rere2607";
        private SqlConnection koneksi;
        private string idartis, namaartis,tanggallahir, genre, notelepon;
        BindingSource customerBindingSource = new BindingSource();
        public DataArtis()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            this.bindingNavigator1.BindingSource = this.customerBindingSource;
            refreshform();
        }
        private void DataArtis_Load()
        {
            koneksi.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(new SqlCommand("Select id_artis, nama_artis, tanggal_lahir, genre, no_telepon from dbo.artis", koneksi));
            DataSet ds = new DataSet();
            dataAdapter1.Fill(ds);

            this.customerBindingSource.DataSource = ds.Tables[0];
            this.txtidartis.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "id_artis", true));
            this.txtnamaartis.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "nama_artis", true));
            this.dttl.DataBindings.Add(
                new Binding("Date", this.customerBindingSource, "tanggal_lahir", true));
            this.txtgenre.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "genre", true));
            this.txtnotelepon.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "no_telepon", true));
            koneksi.Close();

        }


        private void refreshform()
        {

        }

        private void DataArtis_Load(object sender, EventArgs e)
        {

        }
    }
}
