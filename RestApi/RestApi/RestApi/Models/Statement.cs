using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestApi.Models
{
    public class Statement
    {
        public int ID { get;set; }
        public string Comment { get;set; }
        public DateTime Date { get;set; }
    }
}