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
    public partial class DataPencipta : Form
    {
        private string stringConnection = "data source=RENITAWIDIASTUT\\RENITAWDST;database=ALBUMLAGUUAS;User ID=sa; Password=Rere2607";
        private SqlConnection koneksi;
        private string idpencipta, namapencipta;
        BindingSource customerBindingSource = new BindingSource();
        public DataPencipta()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            this.bindingNavigator1.BindingSource = this.customerBindingSource;
            refreshform();
        }

        private void DataPencipta_Load()
        {
            koneksi.Open(); 
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(new SqlCommand("Select id_pencipta, nama_pencipta from dbo.pencipta", koneksi));
            DataSet ds = new DataSet();
            dataAdapter1.Fill(ds);

            this.customerBindingSource.DataSource = ds.Tables[0];
            this.txtidpencipta.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "id_pencipta", true));
            this.txtnamapencipta.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "nama_pencipta", true));
            koneksi.Close();

        }

        private void clearBinding()
        {
            this.txtidpencipta.DataBindings.Clear();
            this.txtnamapencipta.DataBindings.Clear();

        }

        private void refreshform()
        {
            txtidpencipta.Enabled = false;
            txtnamapencipta.Enabled = false;
            btnsave.Enabled = false;
            btnclear.Enabled = false;
            clearBinding();
            DataPencipta_Load();

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            txtidpencipta.Text = "";
            txtnamapencipta.Text = "";
            txtidpencipta.Enabled = true;
            txtnamapencipta.Enabled = true;
            btnsave.Enabled = true;
            btnclear.Enabled = true;
            btnadd.Enabled = false;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            idpencipta = txtidpencipta.Text;
            namapencipta = txtnamapencipta.Text;
            koneksi.Open();
            string str = "insert into dbo.pencipta (id_pencipta, nama_pencipta)" +
                "values(@IDpencipta, @Nm)";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("@IDpencipta", idpencipta));
            cmd.Parameters.Add(new SqlParameter("@Nm", namapencipta));
            cmd.ExecuteNonQuery();
            koneksi.Close();

            MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

            refreshform();
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

        private void DataPencipta_Load(object sender, EventArgs e)
        {

        }
    }
}
