using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test.Models.Abstract;

namespace Test.Models
{
    public class User : IEntity
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Admin { get; set; }
        public string Salt { get; set; }
    }
}