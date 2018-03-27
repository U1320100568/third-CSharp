using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    public class TestGetSet
    {
        //get
        public string a;
        public string b
        {
            get { return a; }
        }

        //set
        public string c;
        public string d
        {
            set
            {
                System.Web.HttpContext.Current.Response.Write("<br/>value :  " + value + "<br/>");
            }
        }

        //set & get
        public string e;
        public string f;
        public string g
        {
            get { return e; }
            set
            {
                e = f;
                System.Web.HttpContext.Current.Response.Write("<br/>g value : " + value + "<br/>");
            }
        }

    }
}