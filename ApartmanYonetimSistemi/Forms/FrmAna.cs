using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmanYonetimSistemi.Forms
{
    public partial class FrmAna : Form
    {
        public FrmAna()
        {
            InitializeComponent();
        }

        private void btnDaireler_Click(object sender, EventArgs e)
        {
            FrmDaire frm = new FrmDaire();
            frm.Show();
            this.Hide();
        }

        private void btnVeriler_Click(object sender, EventArgs e)
        {
            FrmVeri frm = new FrmVeri();
            frm.Show();
            this.Hide();
        }

        private void btnCRUD_Click(object sender, EventArgs e)
        {
            FrmCRUD frm = new FrmCRUD();
            frm.Show();
            this.Hide();
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            FrmFoto frm = new FrmFoto();
            frm.Show();
            this.Hide();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            FrmInfo frm = new FrmInfo();
            frm.Show();
            this.Hide();
        }

        private void btnKapa_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
