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
           
            this.laguTableAdapter.Fill(this.aLBUMLAGUUASDataSet.lagu);
            koneksi.Open();


            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(new SqlCommand("Select id_lagu, id_artis, id_produser, judul, durasi, genre from dbo.lagu", koneksi));
            DataSet ds = new DataSet();
            dataAdapter1.Fill(ds);

            this.customerBindingSource.DataSource = ds.Tables[0];
            this.txtidlagu.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "id_lagu", true));
            this.cbxidartis.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "id_artis", true));
            this.cbxidproduser.DataBindings.Add(
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

        private void txtidartis_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxidproduser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void clearBinding()
        {
            this.txtidlagu.DataBindings.Clear();
            this.cbxidartis.DataBindings.Clear();
            this.cbxidproduser.DataBindings.Clear();
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
            cbxidartis.Text = "";
            cbxidproduser.Text = "";
            txtjudul.Text = "";
            txtdurasi.Text = "";
            txtgenre.Text = "";
            txtidlagu.Enabled = true;
            cbxidartis.Enabled = true;
            cbxidproduser.Enabled = true;
            txtjudul.Enabled = true;
            txtdurasi.Enabled = true;
            txtgenre.Enabled = true;
            btnsave.Enabled = true;
            btnclear.Enabled = true;
            btnadd.Enabled = false;
            idartiscbx();
            idprodusercbx();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            idlagu = txtidlagu.Text;
            idartis = cbxidartis.Text;
            idproduser = cbxidproduser.Text;
            judul = txtjudul.Text;
            durasi = txtdurasi.Text;
            genre = txtgenre.Text;

            koneksi.Open();
            string strs = "select id_artis from dbo.artis where id_artis = @ia";
            SqlCommand cm = new SqlCommand(strs, koneksi);
            cm.CommandType = CommandType.Text;
            cm.Parameters.Add(new SqlParameter("@ia", idartis));
            SqlDataReader dr = cm.ExecuteReader();
            dr.Close();

            string str = "INSERT INTO dbo.lagu (id_lagu, id_artis, id_produser, judul, durasi, genre) " +
                         "VALUES (@IDlagu, @ia, @IDproduser, @jdl, @drs, @gnr)";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("@IDlagu", idlagu));
            cmd.Parameters.Add(new SqlParameter("@ia", idartis));
            cmd.Parameters.Add(new SqlParameter("@IDproduser", idproduser));
            cmd.Parameters.Add(new SqlParameter("@jdl", judul));
            cmd.Parameters.Add(new SqlParameter("@drs", TimeSpan.Parse(durasi)));
            cmd.Parameters.Add(new SqlParameter("@gnr", genre));

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while saving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                koneksi.Close();
            }

            refreshform();
        }

        private void refreshform()
        {
            txtidlagu.Enabled = false;
            cbxidartis.Enabled = false;
            cbxidproduser.Enabled = false;
            txtjudul.Enabled = false;
            txtdurasi.Enabled = false;
            txtgenre.Enabled = false;
            btnsave.Enabled = false;
            btnclear.Enabled = false;
            clearBinding();
            DataLagu_Load();

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

        private void idprodusercbx()
        {
            koneksi.Open();
            string str = "select id_produser from dbo.produser";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();
            cbxidproduser.DisplayMember = "id_produser";
            cbxidproduser.DataSource = ds.Tables[0];
        }
    }
}
