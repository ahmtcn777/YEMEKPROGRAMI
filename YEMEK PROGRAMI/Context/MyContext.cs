using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YEMEK_PROGRAMI.Entity;

namespace YEMEK_PROGRAMI.Context
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    class MyContext : DbContext
    {
        public MyContext() : base("MyContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public DbSet<Yemekler> Yemek { get; set; }
        public DbSet<Menu> GunlukMenu { get; set; }
        public DbSet<MenuIc> MenuIc { get; set; }
        public DbSet<MenuDis> MenuDis { get; set; }
        public DbSet<Ayarlar> Ayarlar { get; set; }
    }
}

