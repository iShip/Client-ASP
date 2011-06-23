using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Runtime.Serialization.Json;


/// <summary>
/// Summary description for JsonRequest
/// </summary>
/// 

namespace AspDotnetStoreFrontShipResponse
{
    public class ShipmentResponse
    {
        public auth auth = new auth();
        public string status;
        public res res = new res();
        public req req = new req();
    }

    public class auth
    {
        public string key;
        public string mode;
        public string ref;
    }

    public class res
    {
        public status status=new status();
        public service service = new service();
        public string airbill;
        public string type;
        public string img;
        public rate rate = new rate();

    }
    public class status
    {
        public string code;
        public string decs;
    }
    public class service
    {
        public string commitment;
        public string code;
        public string name;
        public string station;
        public string routecode;
    }
    public class rate
    {
        public double total;
    }

    public class req
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