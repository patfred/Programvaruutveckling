using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Test.Contexts;
using Test.Models;

namespace Test.DBInitializers
{
    public class EFDBInitializer : DropCreateDatabaseAlways<EFDbContext>
    {
        protected override void Seed(EFDbContext context)
        {
            var users = new List<User>
            {
                new User { ID = 1, Email = "test@gmail.com", Admin = 1 },
                new User { ID = 2, Email = "test@gmail.com", Admin = 0 },
                new User { ID = 3, Email = "test@gmail.com", Admin = 1 },
                new User { ID = 4, Email = "test@gmail.com", Admin = 1 }
            };

            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();
        }
    }
}