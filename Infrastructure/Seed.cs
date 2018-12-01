using Microsoft.AspNetCore.Identity;
using System;
using System.Linq;
using Vue.Models;

namespace Vue.Infrastructure
{
    public static class Seed
    {
        public static UserManager<User> UserManager { get; set; }

        public static void Initializer(this ApplicationContext context)
        {
            try
            {
                var userHas = context.Users.FirstOrDefault(x => x.Login == "User");
                if (userHas == null)
                {
                    var user = new User
                    {
                        Login = "User",
                        FirstName = "User",
                        LastName = "FirstUser",
                        Email = "user@email.com",
                        EmailConfirmed = true,
                        LockoutEnabled = false
                    };
                    context.Users.Add(user);
                    context.SaveChangesAsync();
                    //UserManager.CreateAsync(user, "Password1*").GetAwaiter().GetResult();
                }

                var product = context.Products.Count();
                if (product < 1)
                {
                    var item = new Product
                    {
                        Id = new Guid().ToString(),
                        Name = "Product",
                        Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Perferendis",
                        Price = 200,
                    };
                    context.Products.Add(item);
                    context.SaveChangesAsync();
                }
            }
            catch (Exception e)
            {

            }

        }
    }
}
