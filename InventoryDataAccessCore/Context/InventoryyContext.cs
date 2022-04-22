using InventoryDataAccessCore.DTO;
using InventoryDataAccessCore.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryDataAccessCore.Context
{
  public  class InventoryyContext : IdentityDbContext<ApplicationUser>
    {
        public InventoryyContext(DbContextOptions<InventoryyContext> options) : base(options)
       {

       }
        /*  IConfiguration configuration;
          public InventoryyContext(IConfiguration _configuration)
          {
              configuration = _configuration;
          }*/
        public DbSet<Attrub> attributes { set; get; }
        public DbSet<AttrubuitValue> attrubuitValues { set; get; }
        public DbSet<Brands> brands { set; get; }
        public DbSet<Category> categories { set; get; }
        public DbSet<Company> companies { set; get; }
        public DbSet<Country> countries { set; get; }
        public DbSet<Currency> currencies { set; get; }
        public DbSet<Order> orders { set; get; }
        public DbSet<Products> products { set; get; }

        public DbSet<Stores> stores { set; get; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //  optionsBuilder.UseSqlServer(" data source = localhost; initial catalog= Inventory; integrated security=true ");
        //    optionsBuilder.UseSqlServer(configuration.GetConnectionString("Inventory"));
        //    base.OnConfiguring(optionsBuilder);
        //}





    }

}
