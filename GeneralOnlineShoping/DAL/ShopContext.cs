using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using GeneralOnlineShoping.Models;

namespace GeneralOnlineShoping.DAL
{
    public class ShopContext : DbContext
    {
        public ShopContext() : base("ShopContext")
        {

        }
        public DbSet<ItemModel> Items { set; get; }
        public DbSet<UserAccount> Users { set; get; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}