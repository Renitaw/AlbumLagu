﻿using System;
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
    public partial class DataKontrak : Form
    {
        private string stringConnection = "data source=RENITAWIDIASTUT\\RENITAWDST;database=ALBUMLAGUUAS;User ID=sa; Password=Rere2607";
        private SqlConnection koneksi;
        private string idkontrak, idartis, idproduser;
        BindingSource customerBindingSource = new BindingSource();
        public DataKontrak()
        {
            InitializeComponent();
        }

        private void DataKontrak_Load(object sender, EventArgs e)
        {

        }
    }
}
