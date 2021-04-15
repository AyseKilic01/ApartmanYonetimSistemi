using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

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
        }

        private void btnVeriler_Click(object sender, EventArgs e)
        {
            FrmVeri frm = new FrmVeri();
            frm.Show();
        }

        private void btnCRUD_Click(object sender, EventArgs e)
        {
            FrmCRUD frm = new FrmCRUD();
            frm.Show();
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            FrmFoto frm = new FrmFoto();
            frm.Show();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("@CopyRight by Ayşe Kılıç - Software Developer \r\n Apartmanınızın Mühendisi ");
        }

        private void btnKapa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Apartman Yönetim Sistemi ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                System.Windows.Forms.Application.Exit();
        }
    }
}
