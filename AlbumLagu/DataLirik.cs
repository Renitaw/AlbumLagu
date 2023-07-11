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
    public partial class DataLirik : Form
    {
        private string stringConnection = "data source=RENITAWIDIASTUT\\RENITAWDST;database=ALBUMLAGUUAS;User ID=sa; Password=Rere2607";
        private SqlConnection koneksi;

        public DataLirik()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void refreshform()
        {
            txtidlirik.Enabled = false;
            cbxjudul.Enabled = false;
            cbxidpencipta.Enabled = false;
            cbxnamapencipta.Enabled= false;
            btnsave.Enabled = false;
            btnclear.Enabled = false;
            btnadd.Enabled = true;
        }

        private void datagridview1()
        {
            koneksi.Open();
            string str = "SELECT id_lirik, judul, id_pencipta, nama_pencipta FROM dbo.lirik";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }


        private void DataLirik_Load(object sender, EventArgs e)
        {
            FillComboBox();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            datagridview1();
            btnopen.Enabled = false;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            txtidlirik.Enabled = true;
            cbxjudul.Enabled = true;
            cbxidpencipta.Enabled = true;
            cbxnamapencipta.Enabled = true;
            btnclear.Enabled = true;
            btnsave.Enabled = true;
            btnadd.Enabled = false;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string idlirik = txtidlirik.Text;
            string judul = cbxjudul.Text;
            string idpencipta = cbxidpencipta.Text;
            string namapencipta = cbxnamapencipta.Text;

            if (idlirik == "")
            {
                MessageBox.Show("Masukkan Id Lirik", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (judul == "")
            {
                MessageBox.Show("Masukkan judul", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (idpencipta == "")
            {
                MessageBox.Show("Masukkan idpencipta", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (namapencipta == "")
            {
                MessageBox.Show("Masukkan namapencipta", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "INSERT INTO lirik (id_lirik, judul, id_pencipta, nama_pencipta) VALUES (@id_lirik, @judul, @id_pencipta, @nama_pencipta)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@id_lirik", idlirik));
                cmd.Parameters.Add(new SqlParameter("@judul", judul));
                cmd.Parameters.Add(new SqlParameter("@id_pencipta", idpencipta));
                cmd.Parameters.Add(new SqlParameter("@nama_pencipta", namapencipta));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                datagridview1();
                refreshform();

            }
        }

        private void FillComboBox()
        {
            koneksi.Open();
            string str = "SELECT * FROM dbo.lagu";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string judul = reader["judul"].ToString();
                cbxjudul.Items.Add(judul);
            }
            reader.Close();
                string penciptaQuery = "SELECT id_pencipta, nama_pencipta FROM dbo.pencipta";
            SqlCommand penciptaCommand = new SqlCommand(penciptaQuery, koneksi);
            SqlDataReader penciptaReader = penciptaCommand.ExecuteReader();

            while (penciptaReader.Read())
            {
                string idPencipta = penciptaReader["id_pencipta"].ToString();
                string namaPencipta = penciptaReader["nama_pencipta"].ToString();

                cbxidpencipta.Items.Add(idPencipta);
                cbxnamapencipta.Items.Add(namaPencipta);
    }

    penciptaReader.Close();

            koneksi.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void cbxjudul_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
