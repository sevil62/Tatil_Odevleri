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
    public partial class EkstraForm : Form
    {
        public EkstraForm()
        {
            InitializeComponent();
        }
        BaseRepository<Ekstra>ekstraRepository=new BaseRepository<Ekstra>();
        public static List<Ekstra> ekstaList = new List<Ekstra>();
        private void btnEkstraEkle_Click(object sender, EventArgs e)
        {

            Ekstra ekstra = new Ekstra();
            ekstra.EkstraName = txtEkstra.Text;
            ekstra.EkstraFiyat = nudEkstraFiyat.Value;
            ekstraRepository.Create(ekstra);
            ekstaList.Add(ekstra);
        }
    }
}

