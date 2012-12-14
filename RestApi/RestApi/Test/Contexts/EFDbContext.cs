﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test.Models;
using System.Data.Entity;
namespace Test.Contexts
{
    public class EFDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companys { get; set; }
        public DbSet<Contact> Contacs { get; set; }
    }
}