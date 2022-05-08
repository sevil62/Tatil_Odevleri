using BLL.BaseRep;
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
    public partial class RaporForm : Form
    {
        public RaporForm()
        {
            InitializeComponent();
        }
        BaseRepository<Rapor> raporlar = new BaseRepository<Rapor>();
        SiparisOlustur siparis=new SiparisOlustur();
        Ekstra ekstra=new Ekstra();
        McMenu menu=new McMenu();
        private void RaporForm_Load(object sender, EventArgs e)
        {
            Rapor rapor=new Rapor();
            rapor.Ciro += siparis.ToplamTutar;
            rapor.SatilanEkstraAdet +=ekstra.EkstraName.Count();
            rapor.SatilanEkstra += ekstra.EkstraName;
            rapor.KDVHaricFiyat += ((siparis.ToplamTutar) / 1.18m);
            rapor.SatilanMenuAdet += menu.MenuName.Count();

            lblCiro.Text=rapor.Ciro.ToString("C2");
            lblKdv.Text = rapor.KDVHaricFiyat.ToString("C2");
            lblEkstraAdet.Text = rapor.SatilanEkstraAdet.ToString();
            lblSatilanEkstra.Text=rapor.SatilanEkstra.ToString();
            lblMenuAdet.Text=rapor.SatilanMenuAdet.ToString();
           
            raporlar.Create(rapor);
            listBox1.DataSource = raporlar;
        }
    }
}
