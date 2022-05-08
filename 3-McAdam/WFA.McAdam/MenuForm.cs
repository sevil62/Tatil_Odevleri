using BLL.BaseRep;
using DAL.Context;
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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }
        BaseRepository<McMenu> menuRepository=new BaseRepository<McMenu>();
        public static List<McMenu> menuList=new List<McMenu>();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            //Menu oluşturma
            McMenu menu=new McMenu();
            menu.MenuName = txtMenuAd.Text;
            menu.MenuFiyat = nudMenuFiyat.Value;

            menuRepository.Create(menu);
            menuList.Add(menu);
           
            


        }


    }
    
}
