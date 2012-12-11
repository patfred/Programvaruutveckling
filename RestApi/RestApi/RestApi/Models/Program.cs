using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestApi.Models
{
    public class Program
    {
        public int ID { get;set; } 
        public string Name { get;set; }
        public string ShortName { get;set; }
        public DateTime StartDate { get;set; }
        public DateTime EndDate { get;set; }
        public string City { get; set; }
        public ICollection<Statement> Statements { get; set; }
        public ICollection<Contact> Contacts { get; set; }
        public ICollection<Tags> Tags { get; set; }
    }
}