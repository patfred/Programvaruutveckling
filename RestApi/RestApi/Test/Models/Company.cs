using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestApi.Models;

namespace Test.Models
{
    public class Company
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public ICollection<Tags> Tags { get; set; }
        public ICollection<Contact> Contacts { get; set; }
    }
}