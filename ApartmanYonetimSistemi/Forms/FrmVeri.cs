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
    public partial class FrmVeri : Form
    {
        Entities.ApartmanYonetimSistemiEntities db = new Entities.ApartmanYonetimSistemiEntities();
        public FrmVeri()
        {
            InitializeComponent();
        }
        void Listele()
        {
            listBorc.Items.Clear();
            var degerler = (from x in db.TblUser
                            select new
                            {
                                x.Ad,
                                x.Soyad,    
                                x.Borclar
                            }).ToList();

            foreach (var d in degerler)
            {
                ListViewItem list = new ListViewItem();
                list.Text = d.Ad;
                list.SubItems.Add(d.Soyad.ToString());;
                list.SubItems.Add(d.Borclar.ToString());
                listBorc.Items.Add(list);
            }
        }
        private void FrmVeri_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
