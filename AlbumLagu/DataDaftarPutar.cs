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
    public partial class DataDaftarPutar : Form
    {
        private string stringConnection = "data source=RENITAWIDIASTUT\\RENITAWDST;database=ACT6;User ID=sa; Password=Rere2607";
        private SqlConnection koneksi;
        public DataDaftarPutar()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void refreshform()
        {
            txtiddaftarputar.Enabled = false;
            txtnamadaftar.Enabled = false;
            txtidpengguna.Enabled = false;
            cbxidlagu.Enabled = false;
            btnsave.Enabled = false;
            btnclear.Enabled = false;
            btnadd.Enabled = true;

        }

        private void DataDaftarPutar_Load(object sender, EventArgs e)
        {

        }
    }
}
