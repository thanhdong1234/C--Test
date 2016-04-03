using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3
{
    public class GuesRespone
    {
        string name, Email, Phone;

        public string PHONE
        {
            get { return Phone; }
            set { Phone = value; }
        }

        public string EMAIL
        {
            get { return Email; }
            set { Email = value; }
        }

        public string NAME
        {
            get { return name; }
            set { name = value; }
        }
        bool? willAttend;

        public bool? WILLATTEND
        {
            get { return willAttend; }
            set { willAttend = value; }
        }
    }
}