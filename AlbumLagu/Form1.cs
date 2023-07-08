﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbumLagu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataUtamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataPencipta dpn = new DataPencipta();
            dpn.Show();
            this.Hide();
        }

        private void dataLaguToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataAlbum da = new DataAlbum();
            da.Show();
            this.Hide();
        }

        private void dataPenciptaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataLagu dl = new DataLagu();
            dl.Show();
            this.Hide();

        }

        private void dataArtisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataArtis dar = new DataArtis();
            dar.Show();
            this.Hide();
        }

        private void dataProduserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataProduser dpr = new DataProduser();
            dpr.Show();
            this.Hide();
        }
    }
}
