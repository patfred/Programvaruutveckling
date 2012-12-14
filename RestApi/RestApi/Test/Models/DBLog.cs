﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test.Models;

namespace RestApi.Models {
    public class DbLog {
        public int ID {
            get;
            set;
        }
        public string Activity {
            get;
            set;
        }
        public DateTime Date {
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