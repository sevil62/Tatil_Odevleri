using BLL.BaseRep;
using BLL.DesignPatterns.BuilderPattern.Abstract;
using BLL.DesignPatterns.BuilderPattern.Concrete;
using DAL.Entity;
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
    public partial class KrediKartForm : Form
    {
        public KrediKartForm()
        {
            InitializeComponent();
        }
        BaseRepository<KrediKarti>kredikartRepository=new BaseRepository<KrediKarti>();
        public static List<KrediKarti>krediKartListesi=new List<KrediKarti>();
        
       

        string[] bankaListesi = { "Türkiye İş Bankası", "Ziraat Bankası", "Garanti" };
        string[] kartTipListesi = { "Master", "Visa" };

        private void KrediKartForm_Load(object sender, EventArgs e)
        {
            cmbBanka.DataSource = bankaListesi;
            cmbKartTip.DataSource = kartTipListesi;
            
        }

        KrediKartiBuilder builder;

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            KrediKarti krediKarti=new KrediKarti();
            krediKarti.BankaAdi = cmbBanka.Text;
            krediKarti.Karttip = cmbKartTip.Text;
            switch (cmbKartTip.Text)
            {
                case "Master":
                    builder = new MasterCartConc();
                    break;
                case "Visa":
                    builder = new VisaCartConc();
                    break;

            }


            krediKarti.KartLimit = numericUpDown1.Value;
            KartKullan kullan = new KartKullan();

            bool taksit = rbEvet.Checked ? true : false;
            krediKarti.Taksit = taksit;
           

            kullan.KrediKartiKullan(builder, cmbBanka.Text, numericUpDown1.Value, taksit, cmbKartTip.Text);
            kredikartRepository.Create(krediKarti);
            
            ListView();
           
        }

        public void ListView()
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = builder.Kart.BankaAdi;
            lvi.SubItems.Add(builder.Kart.KartLimit.ToString());
            lvi.SubItems.Add(builder.Kart.Taksit.ToString());
            lvi.SubItems.Add(builder.Kart.Karttip.ToString());
            listView1.Items.Add(lvi);
          
        }
    }
    
}
