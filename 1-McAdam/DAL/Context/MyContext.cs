using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public class MyContext:DbContext
    {
        public MyContext()
        {
            Database.Connection.ConnectionString = "server=REDHACK;database=NTierMcAdamDB;integrated security=true";
        }

        public DbSet<McMenu>Menus { get; set; }
        public DbSet<Ekstra>Ekstras { get; set; }
        public DbSet<SiparisOlustur>SiparisOlusturs { get; set; }
        public DbSet<Rapor>Rapors { get; set; }

       

    }
    
}
