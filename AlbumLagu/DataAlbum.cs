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

        private void btnclear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            idalbum = txtidalbum.Text;
            namaalbum = txtnamaalbum.Text;
            idartis = cbxidartis.Text;
            idlagu = cbxidlagu.Text;
            perusahaan = txtperusahaan.Text;
            tahunrilis = txttahunrilis.Text;
            genre = txtgenre.Text;
            koneksi.Open();

            string strs = "select id_artis from dbo.artis where id_artis = @IDartis; select id_lagu from dbo.lagu where id_lagu = @IDlagu";
            SqlCommand cm = new SqlCommand(strs, koneksi);
            cm.CommandType = CommandType.Text;
            cm.Parameters.Add(new SqlParameter("@IDartis", idartis));
            cm.Parameters.Add(new SqlParameter("@IDlagu", idlagu));
            SqlDataReader dr = cm.ExecuteReader();
            dr.Close();

            string str = "insert into dbo.album (id_album, nama_album, id_artis, id_lagu, perusahaan, tahun_rilis, genre)" +
                "values(@IDalbum, @namaalbum, @IDartis, @IDlagu, @perusahaan, @tahunrilis, @genre)";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("@IDalbum", idalbum));
            cmd.Parameters.Add(new SqlParameter("@namaalbum", namaalbum));
            cmd.Parameters.Add(new SqlParameter("@IDartis", idartis));
            cmd.Parameters.Add(new SqlParameter("@IDlagu", idlagu));
            cmd.Parameters.Add(new SqlParameter("@perusahaan", perusahaan));
            cmd.Parameters.Add(new SqlParameter("@tahunrilis", tahunrilis));
            cmd.Parameters.Add(new SqlParameter("@genre", genre));
            cmd.ExecuteNonQuery();
            koneksi.Close();
            MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refreshform();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            txtidalbum.Text = "";
            txtnamaalbum.Text = "";
            cbxidartis.Text = "";
            cbxidlagu.Text = "";
            txtperusahaan.Text = "";
            txttahunrilis.Text = "";
            txtgenre.Text = "";
            txtidalbum.Enabled = true;
            txtnamaalbum.Enabled = true;
            cbxidartis.Enabled = true;
            cbxidlagu.Enabled = true;
            txtperusahaan.Enabled = true;
            txttahunrilis.Enabled = true;
            txtgenre.Enabled = true;
            btnsave.Enabled = true;
            btnclear.Enabled = true;
            btnadd.Enabled = false;
            idartiscbx();
            idlagucbx();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void cbxidartis_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public DataAlbum()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            this.bindingNavigator1.BindingSource = this.customerBindingSource;
            refreshform();
        }

        private void DataAlbum_Load()
        {
            // TODO: This line of code loads data into the 'aLBUMLAGUUASDataSet.album' table. You can move, or remove it, as needed.
            this.albumTableAdapter.Fill(this.aLBUMLAGUUASDataSet.album);
            koneksi.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(new SqlCommand("Select id_album, nama_album, id_artis, id_lagu, perusahaan, tahun_rilis, genre from dbo.album", koneksi));
            DataSet ds = new DataSet();
            dataAdapter1.Fill(ds);

            this.customerBindingSource.DataSource = ds.Tables[0];
            this.txtidalbum.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "id_album", true));
            this.txtnamaalbum.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "nama_album", true));
            this.cbxidartis.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "id_artis", true));
            this.cbxidlagu.DataBindings.Add(
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
            this.cbxidartis.DataBindings.Clear();
            this.cbxidlagu.DataBindings.Clear();
            this.txtperusahaan.DataBindings.Clear();
            this.txttahunrilis.DataBindings.Clear();
            this.txtgenre.DataBindings.Clear();

        }

        private void refreshform()
        {
            txtidalbum.Enabled = false;
            txtnamaalbum.Enabled = false;
            cbxidartis.Enabled = false;
            cbxidlagu.Enabled = false;
            txtperusahaan.Enabled = false;
            txttahunrilis.Enabled = false;
            txtgenre.Enabled = false;
            btnsave.Enabled = false;
            btnclear.Enabled = false;
            btnadd.Enabled = true;
            clearBinding();
            DataAlbum_Load();
        }

        private void idartiscbx()
        {
            koneksi.Open();
            string str = "select id_artis from dbo.artis";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();
            cbxidartis.DisplayMember = "id_artis";
            cbxidartis.DataSource = ds.Tables[0];
        }

        private void idlagucbx()
        {
            koneksi.Open();
            string str = "select id_lagu from dbo.lagu";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();
            cbxidlagu.DisplayMember = "id_lagu";
            cbxidlagu.DataSource = ds.Tables[0];
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataAlbum_Load(object sender, EventArgs e)
        {

        }
    }
}
