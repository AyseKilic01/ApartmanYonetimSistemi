using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseApartmanYonetimSistemi.BaseControl;
using System.Data.SqlClient;
using ApartmanYonetimSistemi.Entities;
using DevExpress.XtraEditors;

namespace ApartmanYonetimSistemi.Forms
{
    
    public partial class FrmCRUD : Form
    {
        Entities.ApartmanYonetimSistemiEntities db = new Entities.ApartmanYonetimSistemiEntities();
        public FrmCRUD()
        {
            InitializeComponent();
        }
        void Listele()
        {
            listUsers.Items.Clear();
            var degerler = (from x in db.TblUser
                            select new
                            {
                                x.ID,
                                x.Ad,
                                x.Soyad,
                                x.Mail,
                                x.Telefon,
                                x.Daire,
                                x.Borclar

                            }).ToList();
            foreach (var d in degerler)
            {
                ListViewItem list = new ListViewItem();
                list.Text = d.ID.ToString();
                list.SubItems.Add(d.Ad.ToString());
                list.SubItems.Add(d.Soyad.ToString());
                list.SubItems.Add(d.Mail.ToString());
                list.SubItems.Add(d.Telefon.ToString());
                list.SubItems.Add(d.Daire.ToString());
                list.SubItems.Add(d.Borclar.ToString());
                listUsers.Items.Add(list);
            }
        }
        void Temizle()
        {
            txtAd.Text = "";
            txtBorc.Text = "";
            txtDaire.Text = "";
            txtMail.Text = "";
            txtSoyad.Text = "";
            txtTelefon.Text = "";
        }

        private void FrmCRUD_Load(object sender, EventArgs e)
        {
            Listele();
        }
        bool Control()
        {
            if (txtAd.Text != "" && txtDaire.Text != "" && txtMail.Text != ""
            && txtSoyad.Text != ""
            && txtTelefon.Text != "")
                return true;
            return false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (Control())
            {
                TblUser t = new TblUser();
                t.Ad = txtAd.Text;
                t.Soyad = txtSoyad.Text;
                t.Mail = txtMail.Text;
                t.Telefon = txtTelefon.Text;
                t.Daire = txtDaire.Text;
                t.Borclar = txtBorc.Text;
                db.TblUser.Add(t);
                db.SaveChanges();
                XtraMessageBox.Show("Yeni Ev Sahibi/Kiracı Eklendi");
                Listele();
                Temizle();
            }
            else
            {
                XtraMessageBox.Show("Alanlar boş olamaz !!");
                Temizle();
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }
        int id = 0;
        private void listUsers_Click(object sender, EventArgs e)
        {
            id = int.Parse(listUsers.SelectedItems[0].SubItems[0].Text);
            txtAd.Text = listUsers.SelectedItems[0].SubItems[1].Text.Trim();
            txtSoyad.Text = listUsers.SelectedItems[0].SubItems[2].Text.Trim();
            txtMail.Text = listUsers.SelectedItems[0].SubItems[3].Text.Trim();
            txtTelefon.Text = listUsers.SelectedItems[0].SubItems[4].Text.Trim();
            txtDaire.Text = listUsers.SelectedItems[0].SubItems[5].Text.Trim();
            txtBorc.Text = listUsers.SelectedItems[0].SubItems[6].Text.Trim();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {   if (id != null && id != 0)
            {
                var deger = db.TblUser.Find(id);
                db.TblUser.Remove(deger);
                db.SaveChanges();
                XtraMessageBox.Show("Silindi");
                Listele();
                Temizle();
            }
            else
            {
                XtraMessageBox.Show("Satır seçiniz !!");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var deger = db.TblUser.Find(id);
            deger.Ad = txtAd.Text;
            deger.Soyad = txtSoyad.Text;
            deger.Mail = txtMail.Text;
            deger.Telefon = txtTelefon.Text;
            deger.Daire = txtDaire.Text;
            deger.Borclar = txtBorc.Text;
            db.SaveChanges();
            XtraMessageBox.Show("Güncellendi");
            Listele();
            Temizle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            //listUsers.Items.Clear();
       
           var degerlerd = (db.TblUser.Where(x => x.Ad == txtAra.Text).ToList());
            listUsers.Items.Clear();
            foreach (var d in degerlerd)
            {
                ListViewItem list = new ListViewItem();
                list.Text = d.ID.ToString();
                list.SubItems.Add(d.Ad.ToString());
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
