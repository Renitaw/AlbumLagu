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
    public partial class DataDaftarPutar : Form
    {
        private string stringConnection = "data source=RENITAWIDIASTUT\\RENITAWDST;database=ACT6;User ID=sa; Password=Rere2607";
        private SqlConnection koneksi;
        public DataDaftarPutar()
        {
            InitializeComponent();
        }

        private void DataDaftarPutar_Load(object sender, EventArgs e)
        {

        }
    }
}
