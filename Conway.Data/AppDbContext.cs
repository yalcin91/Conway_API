using Conway.Core.Model;
using Conway.Data.Configuration;
using Conway.Data.Seeds;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conway.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<BAT_Cigarette> BAT_Cigarettes { get; set; }
        public DbSet<BAT_Tabac> BAT_Tabacs { get; set; }
        public DbSet<ITB_Cigarette> ITB_Cigarettes { get; set; }
        public DbSet<ITB_Tabac> ITB_Tabacs { get; set; }
        public DbSet<JTI_Cigarette> JTI_Cigarettes { get; set; }
        public DbSet<JTI_Tabac> JTI_Tabacs { get; set; }
        public DbSet<PMI_Cigarette> PMI_Cigarettes { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BAT_Cigarette_Config());
            modelBuilder.ApplyConfiguration(new BAT_Tabac_Config());
            modelBuilder.ApplyConfiguration(new ITB_Cigarette_Config());
            modelBuilder.ApplyConfiguration(new ITB_Tabac_Config());
            modelBuilder.ApplyConfiguration(new JTI_Cigarette_Config());
            modelBuilder.ApplyConfiguration(new JTI_Tabac_Config());
            modelBuilder.ApplyConfiguration(new PMI_Cigarette_Config());
            modelBuilder.ApplyConfiguration(new Product_Config());

            modelBuilder.ApplyConfiguration(new BAT_Cigarette_Seed());
            modelBuilder.ApplyConfiguration(new BAT_Tabac_Seed());
            modelBuilder.ApplyConfiguration(new ITB_Cigarette_Seed());
            modelBuilder.ApplyConfiguration(new ITB_Tabac_Seed());
            modelBuilder.ApplyConfiguration(new JTI_Cigarette_Seed());
            modelBuilder.ApplyConfiguration(new JTI_Tabac_Seed());
            modelBuilder.ApplyConfiguration(new PMI_Cigarette_Seed());

        }
    }
}
