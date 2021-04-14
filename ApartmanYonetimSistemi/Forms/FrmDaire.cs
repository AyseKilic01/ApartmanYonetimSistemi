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
    public partial class FrmDaire : Form
    {
        public FrmDaire()
        {
            InitializeComponent();
        }
        private void Colors()
        {

            this.btnDaire1.Appearance.BackColor = Color.FloralWhite;
            this.btnDaire2.Appearance.BackColor = Color.FloralWhite;
            this.btnDaire3.Appearance.BackColor = Color.FloralWhite;
            this.btnDaire4.Appearance.BackColor = Color.FloralWhite;
            this.btnDaire5.Appearance.BackColor = Color.FloralWhite;
            this.btnDaire6.Appearance.BackColor = Color.FloralWhite;
            this.btnDaire7.Appearance.BackColor = Color.FloralWhite;
            this.btnDaire8.Appearance.BackColor = Color.FloralWhite;

        }
        private void FrmDaire_Load(object sender, EventArgs e)
        {
            Colors();
            lblAdSoyad.Text = "";
        }

        private void btnDaire1_Click(object sender, EventArgs e)
        {
            Colors();
            this.btnDaire1.Appearance.BackColor = Color.CadetBlue;
            lblAdSoyad.Text = "Ayşe Kılıç";
        }

        private void btnDaire2_Click(object sender, EventArgs e)
        {
            Colors();
            this.btnDaire2.Appearance.BackColor = Color.CadetBlue;
            lblAdSoyad.Text = "Mehmet Aknar";
        }

        private void btnDaire3_Click(object sender, EventArgs e)
        {
            Colors();
            this.btnDaire3.Appearance.BackColor = Color.CadetBlue;
            lblAdSoyad.Text = "Özkan Açık";
        }

        private void btnDaire4_Click(object sender, EventArgs e)
        {
            Colors();
            this.btnDaire4.Appearance.BackColor = Color.CadetBlue;
            lblAdSoyad.Text = "A.Kadir Dikmen";
        }

        private void btnDaire5_Click(object sender, EventArgs e)
        {
            Colors();
            this.btnDaire5.Appearance.BackColor = Color.CadetBlue;
            lblAdSoyad.Text = "Hulusi Kentmen";
        }

        private void btnDaire6_Click(object sender, EventArgs e)
        {
            Colors();
            this.btnDaire6.Appearance.BackColor = Color.CadetBlue;
            lblAdSoyad.Text = "Dilara Çapanoğlu";
        }

        private void btnDaire7_Click(object sender, EventArgs e)
        {
            Colors();
            this.btnDaire7.Appearance.BackColor = Color.CadetBlue;
            lblAdSoyad.Text = "Bulut Kaya";
        }

        private void btnDaire8_Click(object sender, EventArgs e)
        {
            Colors();
            this.btnDaire8.Appearance.BackColor = Color.CadetBlue;
            lblAdSoyad.Text = "Esma Deniz";
        }
    }
}
