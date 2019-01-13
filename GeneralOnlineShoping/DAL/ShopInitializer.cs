using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using GeneralOnlineShoping.Models;

namespace GeneralOnlineShoping.DAL
{
    public class ShopInitializer : DropCreateDatabaseIfModelChanges<ShopContext>
    {
        protected override void Seed(ShopContext context)
        {
            
            var users = new List<UserAccount>
            {
                new UserAccount{Id=1,Name="Fady",Mail="fady.youssef94@yahoo.com",Password = "123"},
                new UserAccount{Id=2,Name="ahmed",Mail="fady.youssef94@yahoo.com",Password = "123"}
            };
            users.ForEach(u => context.Users.Add(u));
            var items = new List<ItemModel>
            {
                new ItemModel{Id=1,Name="item1",Price= 32,Category = "x1"},
                new ItemModel{Id=2,Name="item2",Price = 36,Category = "y1"}
            };
            items.ForEach(u => context.Items.Add(u));
            context.SaveChanges();
        }
    }
    
}