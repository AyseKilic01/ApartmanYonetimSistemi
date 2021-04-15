using ApartmanYonetimSistemi.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmanYonetimSistemi.Forms
{
    public partial class FrmDaire : Form
    {
        ApartmanYonetimSistemiEntities db = new ApartmanYonetimSistemiEntities();
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
        private void Goster(string text)
        {
            string[] sayi = Regex.Split(text, @"\D+");
            foreach (var c in sayi)
            {
                int sayis;
                if (int.TryParse(c, out sayis))
                {
                    Console.WriteLine(c);

                    var degerlerd = (db.TblUser.Where(x => x.Daire.Contains(sayis.ToString())).ToList());

                    listUsers.Items.Clear();
                    foreach (var d in degerlerd)
                    {
                        ListViewItem list = new ListViewItem();
                        list.Text = d.Ad.ToString();
                        list.SubItems.Add(d.Soyad.ToString());
                        list.SubItems.Add(d.Mail.ToString());
                        list.SubItems.Add(d.Telefon.ToString());
                        list.SubItems.Add(d.Daire.ToString());
                        list.SubItems.Add(d.Borclar.ToString());
                        listUsers.Items.Add(list);
                    }
                }
            }
        }
        private void FrmDaire_Load(object sender, EventArgs e)
        {
            Colors();
            
        }

        private void btnDaire1_Click(object sender, EventArgs e)
        {
            Colors();
            this.btnDaire1.Appearance.BackColor = Color.CadetBlue;
            Goster(btnDaire1.Text);

        }

        private void btnDaire2_Click(object sender, EventArgs e)
        {
            Colors();
            this.btnDaire2.Appearance.BackColor = Color.CadetBlue;
            Goster(btnDaire2.Text);
        }

        private void btnDaire3_Click(object sender, EventArgs e)
        {
            Colors();
            this.btnDaire3.Appearance.BackColor = Color.CadetBlue;
            Goster(btnDaire3.Text);
        }

        private void btnDaire4_Click(object sender, EventArgs e)
        {
            Colors();
            this.btnDaire4.Appearance.BackColor = Color.CadetBlue;
            Goster(btnDaire4.Text);
        }

        private void btnDaire5_Click(object sender, EventArgs e)
        {
            Colors();
            this.btnDaire5.Appearance.BackColor = Color.CadetBlue;
            Goster(btnDaire5.Text);
        }

        private void btnDaire6_Click(object sender, EventArgs e)
        {
            Colors();
            this.btnDaire6.Appearance.BackColor = Color.CadetBlue;
            Goster(btnDaire6.Text);
        }

        private void btnDaire7_Click(object sender, EventArgs e)
        {
            Colors();
            this.btnDaire7.Appearance.BackColor = Color.CadetBlue;
            Goster(btnDaire7.Text);
        }

        private void btnDaire8_Click(object sender, EventArgs e)
        {
            Colors();
            this.btnDaire8.Appearance.BackColor = Color.CadetBlue;
            Goster(btnDaire8.Text);
        }
    }
}
