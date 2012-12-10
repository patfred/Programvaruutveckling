using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestApi.Models
{
    public class Contact
    {
        int ID { get;set; } 
        string FirstName { get;set; } 
        string LastName { get;set; } 
        string Title { get;set; } 
        string Phone { get;set; } 
        string EMail { get;set; } 
        string Comments { get;set; } 
    }
}