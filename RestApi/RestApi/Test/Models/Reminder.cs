using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test.Models;

namespace RestApi.Models {
    public class Reminder {
        public int ID {
            get;
            set;
        }
        public DateTime EventDate {
            get;
            set;
        }
        public DateTime ReminderDate {
            get;
            set;
        }
        public string Message {
            get;
            set;
        }
        public int UserID {
            get;
            set;
        }
        public virtual User User {
            get;
            set;
        }
    }
}