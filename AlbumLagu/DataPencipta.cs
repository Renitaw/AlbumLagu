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
        private string stringConnection = "data source=RENITAWIDIASTUT\\RENITAWDST;database=ALBUMLAGUUUAS;User ID=sa; Password=Rere2607";
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
                new Binding("Text", this.customerBindingSource, "idpencipta", true));
            this.txtnamapencipta.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "nama_pencipta", true));
            koneksi.Close();

        }

        private void clearBinding()
        {
            this.txtidpencipta.DataBindings.Clear();
            this.txtnamapencipta.Clear();

        }

        private void refreshform()
        {
           
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
           
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
           
        }

        private void DataPencipta_Load(object sender, EventArgs e)
        {

        }
    }
}
