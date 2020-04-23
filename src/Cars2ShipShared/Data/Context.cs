using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cars2Ship.Shared.Models;

namespace Cars2Ship.Shared.Data
{
    public class Context : DbContext
    {
        public  DbSet<Dealer> Dealers { get; set; }

    

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Removing the pluralizing table name convention 
            // so our table names will use our entity class singular names.
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // Using the fluent API to configure entity properties...

            //modelBuilder.Entity<ProductModification>()
            //    .Property(i => i.ModificationDate)
            //    .HasColumnType("datetime2");

            //modelBuilder.Entity<Product>()
            //    .Property(i => i.Date)
            //    .HasColumnType("datetime2");

            //modelBuilder.Entity<InventoryInput>()
            //.Property(i => i.Date)
            //.HasColumnType("datetime2");
        }
    }
}
