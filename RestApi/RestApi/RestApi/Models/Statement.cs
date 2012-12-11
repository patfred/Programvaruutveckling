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
        public ICollection<Reminder> Reminders { get; set; }
        public int ProgramID { get; set; }
        public virtual Program Program { get; set; }
        public int StatementID { get; set; }
        public virtual Statement Statement { get; set; }
    }
}