using System;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;
using AspDotnetStoreFrontQuoteRequest;
using AspDotnetStoreFrontQuoteResponse;
using AspDotnetStoreFrontShipRequest;
using AspDotnetStoreFrontShipResponse;
using System.Text;
using System.Net;



public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        QuoteRequest();
        ShipRequest();
       
       
     }

    // This methos is used to send the Quote reuqest to the api

    private void QuoteRequest()
    {
        JsonQuoteRequest[] obj = new JsonQuoteRequest[1];
        obj[0] = new JsonQuoteRequest();
        
        //Set Auth Info
	        	//Your assigned Access key
	        obj[0].auth.key = "**********";
	        	//Your assigned Access Token
	        obj[0].auth.token = "**********";
	        	//Your assigned Access Mode {'test' or 'live'}
	        obj[0].auth.mode = "test";
	        obj[0].auth.ref = "this is ref";
	    
	    //Set request action
        	obj[0].action = "quote";

        //Set Ship Date
        	//Date format YYYY/MM/DD
        	obj[0].ship.date = "2010/04/22";
        
        //package type (l = lettor, p = package)
        	obj[0].ship.type = "p";
        
        // Where we are sending it to
	        // to company
	        obj[0].ship.org.company = "company";
        
        	// to person name
        	obj[0].ship.org.name = "name"; 
        
        	//to address line 1
       		obj[0].ship.org.address = "123 Fake street"; 
        
        	//to address line 2
        	obj[0].ship.org.address2 = "apt 2";
        
        	//to city
        	obj[0].ship.org.city = "Salt Lake City";
        
        	//to state or devision name
        	obj[0].ship.org.division = "utah";
        
        	//to postal or zip code
        	obj[0].ship.org.postal = "84010";
        
        	//to country code
        	obj[0].ship.org.country = "us";
        	//if you need i can provide you a database of all country codes from the country name
        
        	//to email address
        	obj[0].ship.org.email = "anshu@gmail.com";
        
        	//To Phone Number
        	obj[0].ship.org.phone = "8011237654";
        
        
        //Set where we are sending to
	        // to company
	        obj[0].ship.dest.company = "company";
        
        	// to person name
        	obj[0].ship.dest.name = "name"; 
        
        	//to address line 1
       		obj[0].ship.dest.address = "123 Fake street"; 
        
        	//to address line 2
        	obj[0].ship.dest.address2 = "apt 2";
        
        	//to city
        	obj[0].ship.dest.city = "sydeny";
        
        	//to state or devision name
        	obj[0].ship.dest.division = "state name";
        
        	//to postal or zip code
        	obj[0].ship.dest.postal = "12345";
        
        	//to country code
        	obj[0].ship.dest.country = "uk";
        	//if you need i can provide you a database of all country codes from the country name
        
        	//to email address
			obj[0].ship.dest.email = "user@gmail.com";
        
        	//To Phone Number
        	obj[0].ship.dest.phone = "8001237654";
        
        //Set Package Info
        	// what is in the package all summed up into a few words
			obj[0].ship.package.content = "second content";
			//Note on package
			obj[0].ship.package.note = "second note";
			
			//Package Dims
				//height
				obj[0].ship.package.height = 10;
				//depth or length
				obj[0].ship.package.depth = 12;
				//package width
				obj[0].ship.package.width = 12;
				//package weight in lbs
				obj[0].ship.package.weight = 11;
			
		//Set Duty Info
			obj[0].ship.duti.use = false;
			obj[0].ship.duti.value = 0.00;
			//who is responcable for paying duty fees (r, s = sender)
			obj[0].ship.duti.party = "r";
			//duty filing type (ftr, itn, ein)
			obj[0].ship.duti.filing.type = "ftr";
			//uncomment used methoud
				obj[0].ship.duti.filling.ftsr = "30.37(a)";
				//obj[0].ship.duti.filling.itn = "";
				//obj[0].ship.duti.filling.ein = "";
		
		//Set Insurance Info
			obj[0].ship.ins.use = false;
			obj[0].ship.ins.value = 0.00;
        


        JavaScriptSerializer js = new JavaScriptSerializer();




        string loginURL = @"http://usa.api.inxpressusa.com/api/json.php";
        HttpWebRequest webRequest = WebRequest.Create(loginURL) as HttpWebRequest;
        webRequest.Method = WebRequestMethods.Http.Post;
        webRequest.AllowAutoRedirect = false;
        webRequest.ContentType = "application/x-www-form-urlencoded";

        //Serialize the object to obtain data in json format
        string postData = "json=" + (js.Serialize(obj));

        //Convert json data to byte format
        byte[] byteArray1 = Encoding.ASCII.GetBytes(postData);
        webRequest.ContentLength = byteArray1.Length;

        //post data 
        Stream dataStream = webRequest.GetRequestStream();
        dataStream.Write(byteArray1, 0, byteArray1.Length);
        dataStream.Close();

        //Get the respone
        WebResponse response = webRequest.GetResponse();
        dataStream = response.GetResponseStream();
        StreamReader reader = new StreamReader(dataStream);
        string responseFromServer = reader.ReadToEnd();

        //Write the response to the page
        Response.Write(responseFromServer);
        Response.Write("<br/><br/>");

    }

    // This methos is used to send the Ship reuqest to the api
    private void ShipRequest()
    {
        JsonShipRequest[] obj = new JsonShipRequest[1];
        obj[0] = new JsonShipRequest();
        
        //Set Auth Info
	        	//Your assigned Access key
	        obj[0].auth.key = "**********";
	        	//Your assigned Access Token
	        obj[0].auth.token = "**********";
	        	//Your assigned Access Mode {'test' or 'live'}
	        obj[0].auth.mode = "test";
	        obj[0].auth.ref = "this is ref";
	    
	    //Set request action
        	obj[0].action = "ship";

        //Set Ship Date
        	//Date format YYYY/MM/DD
        	obj[0].ship.date = "2010/04/22";
        
        //package type (l = lettor, p = package)
        	obj[0].ship.type = "p";
        
        // Where we are sending it to
	        // to company
	        obj[0].ship.org.company = "company";
        
        	// to person name
        	obj[0].ship.org.name = "name"; 
        
        	//to address line 1
       		obj[0].ship.org.address = "123 Fake street"; 
        
        	//to address line 2
        	obj[0].ship.org.address2 = "apt 2";
        
        	//to city
        	obj[0].ship.org.city = "Salt Lake City";
        
        	//to state or devision name
        	obj[0].ship.org.division = "utah";
        
        	//to postal or zip code
        	obj[0].ship.org.postal = "84010";
        
        	//to country code
        	obj[0].ship.org.country = "us";
        	//if you need i can provide you a database of all country codes from the country name
        
        	//to email address
        	obj[0].ship.org.email = "anshu@gmail.com";
        
        	//To Phone Number
        	obj[0].ship.org.phone = "8011237654";
        
        
        //Set where we are sending to
	        // to company
	        obj[0].ship.dest.company = "company";
        
        	// to person name
        	obj[0].ship.dest.name = "name"; 
        
        	//to address line 1
       		obj[0].ship.dest.address = "123 Fake street"; 
        
        	//to address line 2
        	obj[0].ship.dest.address2 = "apt 2";
        
        	//to city
        	obj[0].ship.dest.city = "sydeny";
        
        	//to state or devision name
        	obj[0].ship.dest.division = "state name";
        
        	//to postal or zip code
        	obj[0].ship.dest.postal = "12345";
        
        	//to country code
        	obj[0].ship.dest.country = "uk";
        	//if you need i can provide you a database of all country codes from the country name
        
        	//to email address
			obj[0].ship.dest.email = "anshu@gmail.com";
        
        	//To Phone Number
        	obj[0].ship.dest.phone = "8001237654";
        
        //Set Package Info
        	// what is in the package all summed up into a few words
			obj[0].ship.package.content = "second content";
			//Note on package
			obj[0].ship.package.note = "second note";
			
			//Package Dims
				//height
				obj[0].ship.package.height = 10;
				//depth or length
				obj[0].ship.package.depth = 12;
				//package width
				obj[0].ship.package.width = 12;
				//package weight in lbs
				obj[0].ship.package.weight = 11;
			
		//Set Duty Info
			obj[0].ship.duti.use = false;
			obj[0].ship.duti.value = 0.00;
			//who is responcable for paying duty fees (r, s = sender)
			obj[0].ship.duti.party = "r";
			//duty filing type (ftr, itn, ein)
			obj[0].ship.duti.filling.type = "ftr";
			//uncomment used methoud
				obj[0].ship.duti.filling.ftsr = "30.37(a)";
				//obj[0].ship.duti.filling.itn = "";
				//obj[0].ship.duti.filling.ein = "";
		
		//Set Insurance Info
			obj[0].ship.ins.use = false;
			obj[0].ship.ins.value = 0.00;


        JavaScriptSerializer js = new JavaScriptSerializer();




        string loginURL = @"http://usa.api.inxpressusa.com/api/json.php";
        HttpWebRequest webRequest = WebRequest.Create(loginURL) as HttpWebRequest;
        webRequest.Method = WebRequestMethods.Http.Post;
        webRequest.AllowAutoRedirect = false;
        webRequest.ContentType = "application/x-www-form-urlencoded";
        string postData = "json=" + (js.Serialize(obj));

        byte[] byteArray1 = Encoding.Default.GetBytes(postData);
        webRequest.ContentLength = byteArray1.Length;

        //string postData = ;
        Stream dataStream = webRequest.GetRequestStream();
        dataStream.Write(byteArray1, 0, byteArray1.Length);
        dataStream.Close();


        WebResponse response = webRequest.GetResponse();
        dataStream = response.GetResponseStream();
        StreamReader reader = new StreamReader(dataStream);
        string responseFromServer = reader.ReadToEnd();
        Response.Write(responseFromServer);

    }
}