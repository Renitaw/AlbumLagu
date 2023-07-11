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
    public partial class DataProduser : Form
    {
        private string stringConnection = "data source=RENITAWIDIASTUT\\RENITAWDST;database=ALBUMLAGUUAS;User ID=sa; Password=Rere2607";
        private SqlConnection koneksi;
        private string idproduser, namaproduser,perusahaan, alamat, notelepon ;
        BindingSource customerBindingSource = new BindingSource();
        public DataProduser()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            this.bindingNavigator1.BindingSource = this.customerBindingSource;
            refreshform();
        }

        private void DataProduser_Load()
        {
            koneksi.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(new SqlCommand("Select id_produser, nama_produser, perusahaan, alamat, no_telepon from dbo.produser", koneksi));
            DataSet ds = new DataSet();
            dataAdapter1.Fill(ds);

            this.customerBindingSource.DataSource = ds.Tables[0];
            this.txtidproduser.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "id_produser", true));
            this.txtnamaproduser.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "nama_produser", true));
            this.txtperusahaan.DataBindings.Add(
                 new Binding("Text", this.customerBindingSource, "perusahaan", true));
            this.txtalamat.DataBindings.Add(
                 new Binding("Text", this.customerBindingSource, "alamat", true));
            this.txtnotelepon.DataBindings.Add(
                 new Binding("Text", this.customerBindingSource, "no_telepon", true));
            koneksi.Close();

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            idproduser = txtidproduser.Text;
            namaproduser = txtnamaproduser.Text;
            perusahaan = txtperusahaan.Text;
            alamat = txtalamat.Text;
            notelepon = txtnotelepon.Text;
            koneksi.Open();
            string str = "insert into dbo.produser (id_produser, nama_produser, perusahaan, alamat, no_telepon)" +
                "values(@IDproduser, @namaproduser, @perusahaan, @alamat, @notelepon)";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("@IDproduser", idproduser));
            cmd.Parameters.Add(new SqlParameter("@namaproduser", namaproduser));
            cmd.Parameters.Add(new SqlParameter("@perusahaan", perusahaan));
            cmd.Parameters.Add(new SqlParameter("@alamat", alamat));
            cmd.Parameters.Add(new SqlParameter("@notelepon", notelepon));
            cmd.ExecuteNonQuery();
            koneksi.Close();
            MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refreshform();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            txtidproduser.Text = "";
            txtnamaproduser.Text = "";
            txtperusahaan.Text = "";
            txtalamat.Text = "";
            txtnotelepon.Text = "";
            txtidproduser.Enabled = true;
            txtnamaproduser.Enabled = true;
            txtperusahaan.Enabled = true;
            txtalamat.Enabled = true;
            txtnotelepon.Enabled = true;
            btnsave.Enabled = true;
            btnclear.Enabled = true;
            btnadd.Enabled = false;
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
            this.txtidproduser.DataBindings.Clear();
            this.txtnamaproduser.DataBindings.Clear();
            this.txtperusahaan.DataBindings.Clear();
            this.txtalamat.DataBindings.Clear();
            this.txtnotelepon.DataBindings.Clear();
        }

        private void refreshform()
        {
            txtidproduser.Enabled = false;
            txtnamaproduser.Enabled = false;
            txtperusahaan.Enabled = false;
            txtalamat.Enabled = false;
            txtnotelepon.Enabled = false;
            btnsave.Enabled = false;
            btnclear.Enabled = false;
            clearBinding();
            DataProduser_Load();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void DataProduser_Load(object sender, EventArgs e)
        {

        }
    }
}
