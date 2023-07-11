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
        }

        private void DataArtis_Load(object sender, EventArgs e)
        {

        }
    }
}
