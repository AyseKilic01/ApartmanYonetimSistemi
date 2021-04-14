using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmanYonetimSistemi
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKullanici.Text == "admin" && txtSifre.Text == "1234")
            {
                Forms.FrmAna frm = new Forms.FrmAna();
                frm.Show();
                this.Hide();
            }
        }
    }
}
