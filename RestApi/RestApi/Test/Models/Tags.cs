using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test.Models.Abstract;

namespace Test.Models
{
    public class Tags : IEntity
    {
        public int ID { get;set; } 
        public string Name { get;set; }
        public int CompanyID { get; set; }
        public virtual Company Company { get; set; }
        public ICollection<Company> Companys { get; set; }
        public ICollection<Contact> Contacts { get; set; }
        public ICollection<Program> Programs { get; set; }
    }
}