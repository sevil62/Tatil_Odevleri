using BLL.BaseRep;
using DAL.Entity;
using DAL.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA.McAdam
{
    public partial class SiparisForm : Form
    {
        public SiparisForm()
        {
            InitializeComponent();
        }
        public decimal TutarHesapla()
        {
            decimal toplamTutar = 0;

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                SiparisOlustur siparis = (SiparisOlustur)listBox1.Items[i];
                toplamTutar += siparis.ToplamTutar;
            }
            lblToplamTutar.Text = toplamTutar.ToString("C2");
            return toplamTutar;
        }
        BaseRepository<SiparisOlustur>siparisRepository=new BaseRepository<SiparisOlustur>();
        public static List<SiparisOlustur> siparisListesi = new List<SiparisOlustur>();

        private void SiparisForm_Load(object sender, EventArgs e)
        {
           
            foreach (McMenu menu in MenuForm.menuList)
            {
                cmbMenu.Items.Add(menu);
            }
            foreach(Ekstra ekstra in EkstraForm.ekstaList)
            {
                CheckBox chk = new CheckBox();
                chk.Text = ekstra.EkstraName;
                chk.Tag = ekstra;//boxing
                flowLayoutPanel1.Controls.Add(chk);
            }
           
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {

            SiparisOlustur siparis = new SiparisOlustur();
            siparis.McMenu = (McMenu)cmbMenu.SelectedItem;
            if (rbKucuk.Checked)
            {
                siparis.Boyut = Boyut.Small;
            }
            else if (rbOrta.Checked)
            {
                siparis.Boyut = Boyut.Medium;
            }
            else if (rbBuyuk.Checked)
            {
                siparis.Boyut = Boyut.Large;
            }

            siparis.Ekstralar = new List<Ekstra>();

            foreach (CheckBox chk in flowLayoutPanel1.Controls)
            {
                if (chk.Checked)
                {
                    Ekstra ekstra = (Ekstra)chk.Tag;
                    siparis.Ekstralar.Add(ekstra);
                }
            }
            siparis.Adet = Convert.ToInt32(nudAdet.Value);
            siparis.Hesapla();
            listBox1.Items.Add(siparis);
            TutarHesapla();
        }

        private void btnSiparisiTamamla_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Toplam Sipariş Tutarı :" + TutarHesapla().ToString("C2") + " satın almayı tamamlamak istiyor musunuz?", "Sipariş Tamamla", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    SiparisOlustur siparis = (SiparisOlustur)listBox1.Items[i];
                    siparisListesi.Add(siparis);
                }

                listBox1.Items.Clear();
                lblToplamTutar.Text = "0 TL";
                MessageBox.Show("Sipariş tamamlandı");
            }
        }
    }
}
