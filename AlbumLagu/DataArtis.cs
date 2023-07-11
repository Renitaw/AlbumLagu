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

        private void btnadd_Click(object sender, EventArgs e)
        {
            txtidartis.Text = "";
            txtnamaartis.Text = "";
            dttl.Text = "";
            txtgenre.Text = "";
            txtnotelepon.Text = "";
            txtidartis.Enabled = true;
            txtnamaartis.Enabled = true;
            dttl.Enabled = true;
            txtgenre.Enabled = true;
            txtnotelepon.Enabled = true;
            btnsave.Enabled = true;
            btnclear.Enabled = true;
            btnadd.Enabled = false;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            idartis = txtidartis.Text;
            namaartis = txtnamaartis.Text;
            tanggallahir = dttl.Text;
            genre = txtgenre.Text;
            notelepon = txtnotelepon.Text;
            koneksi.Open();
            string str = "insert into dbo.artis (id_artis, nama_artis, tanggal_lahir, genre, no_telepon)" +
                "values(@IDartis, @Namaartis, @tanggallahir, @genre, @notelepon)";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("@IDartis", idartis));
            cmd.Parameters.Add(new SqlParameter("@Namaartis", namaartis));
            cmd.Parameters.Add(new SqlParameter("@tanggallahir", tanggallahir));
            cmd.Parameters.Add(new SqlParameter("@genre", genre));
            cmd.Parameters.Add(new SqlParameter("@notelepon", notelepon));
            cmd.ExecuteNonQuery();
            koneksi.Close();
            MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void clearBinding()
        {
            this.txtidartis.DataBindings.Clear();
            this.txtnamaartis.DataBindings.Clear();
            this.dttl.DataBindings.Clear();
            this.txtgenre.DataBindings.Clear();
            this.txtnotelepon.DataBindings.Clear();
        }

        private void refreshform()
        {
            txtidartis.Enabled = false;
            txtnamaartis.Enabled = false;
            dttl.Enabled = false;
            txtgenre.Enabled = false;
            txtnotelepon.Enabled = false;
            btnsave.Enabled = false;
            btnclear.Enabled = false;
            clearBinding();
            DataArtis_Load();
        }

        private void DataArtis_Load(object sender, EventArgs e)
        {

        }
    }
}
