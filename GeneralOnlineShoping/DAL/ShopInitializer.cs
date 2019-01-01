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
                new UserAccount{Name="Fady",Mail="fady.youssef94@yahoo.com",Password = "123"},
                new UserAccount{Name="ahmed",Mail="fady.youssef94@yahoo.com",Password = "123"}
            };
            users.ForEach(u => context.Users.Add(u));
            var items = new List<ItemModel>
            {
                new ItemModel{Name="item1",Price= 32},
                new ItemModel{Name="item2",Price = 36}
            };
            items.ForEach(u => context.Items.Add(u));
            context.SaveChanges();
        }
    }
}