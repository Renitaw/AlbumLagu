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

        private void btnsave_Click(object sender, EventArgs e)
        {
            idlagu = txtidlagu.Text;
            idartis = txtidartis.Text;
            idproduser = txtidproduser.Text;
            judul = txtjudul.Text;
            durasi = txtdurasi.Text;
            genre = txtgenre.Text;
            koneksi.Open();
            string str = "insert into dbo.lagu (id_lagu, id_artis, id_produser, judul, durasi, genre)" +
                "values(@IDlagu, @IDartis, @IDproduser, @jdl, @drs, @gnr)";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("@IDlagu", idlagu));
            cmd.Parameters.Add(new SqlParameter("@IDartis", idartis));
            cmd.Parameters.Add(new SqlParameter("@IDproduser", idproduser));
            cmd.Parameters.Add(new SqlParameter("@jdl", judul));
            cmd.Parameters.Add(new SqlParameter("@drs", durasi));
            cmd.Parameters.Add(new SqlParameter("@gnr", genre));
            cmd.ExecuteNonQuery();
            koneksi.Close();

            MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

            refreshform();
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
