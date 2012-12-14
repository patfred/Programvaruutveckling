using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test.Models.Abstract;

namespace RestApi.Models
{
    public class Contact : IEntity
    {
        int ID { get;set; } 
        string FirstName { get;set; } 
        string LastName { get;set; } 
        string Title { get;set; } 
        string Phone { get;set; } 
        string EMail { get;set; } 
        string Comments { get;set; }
        public int CompanyID { get; set; }
        public virtual Company Company { get; set; }
        public ICollection<Tags> Tags { get; set; }
        public ICollection<Statement> Statements { get; set; }
        public ICollection<Program> Programs { get; set; }
    }
}