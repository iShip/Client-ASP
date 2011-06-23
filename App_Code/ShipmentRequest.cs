using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization.Json;
using System.Web.Script.Serialization;

namespace AspDotnetStoreFrontShipRequest
{
    public class JsonShipRequest
    //ShipmentRequest
    {
        public auth auth = new auth();
        public String action;
        public ship ship = new ship();

    }

    public class auth
    {
        public string key;
        public string token;
        public string mode;
        public string ref;
    }

    public class ship
    {
        public string type;
        public string date;
        public org org = new org();
        public dest dest = new dest();
        public package package = new package();
        public duti duti = new duti();
        public ins ins = new ins();
    }

    public class org
    {
        public string company;
        public string name;
        public string address;
        public string address2;
        public string city;
        public string division;
        public string postal;
        public string country;
        public string email;
        public string phone;
    }

    public class dest
    {
        public string company;
        public string name;
        public string address;
        public string address2;
        public string city;
        public string division;
        public string postal;
        public string country;
        public string email;
        public string phone;

    }

    public class package
    {
        public double weight;
        public double depth;
        public double height;
        public double width;
        public string content;
        public string note;

    }

    public class duti
    {
        public bool use;
        public double value;
        public string party;
        public filling filling = new filling();
    }

    public class filling
    {
        public string type;
        public string ftsr;
        public string itn;
        public string ein;
    }

    public class ins
    {
        public bool use;
        public double value;
    }

}