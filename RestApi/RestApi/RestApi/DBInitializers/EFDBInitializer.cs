using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using RestApi.Contexts;
using RestApi.Models;
using System.Security.Cryptography;

namespace RestApi.DBInitializers
{
    public class EFDBInitializer : DropCreateDatabaseAlways<EFDbContext>
    {
        protected override void Seed(EFDbContext context)
        {
            var users = new List<User>
            {
                new User { ID = 1, Admin = 1 },
                new User { ID = 2, Admin = 0 },
                new User { ID = 3, Admin = 1 },
                new User { ID = 4, Admin = 1 }
            };

            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();
        }
    }
}