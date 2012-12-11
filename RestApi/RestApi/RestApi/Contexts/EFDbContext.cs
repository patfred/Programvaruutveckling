using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestApi.Models;
using System.Data.Entity;

namespace RestApi.Contexts
{
    public class EFDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}