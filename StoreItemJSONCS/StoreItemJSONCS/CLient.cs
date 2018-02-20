using System;
using System.IO;
using System.Net;
using System.Text;


namespace Test_New
{
    // enum declared to make more readable which request is made to server
    //dealing with GET request and POST request
    public enum HttpWeb
    {
        GET,
        POST
    }
    //CLass client is used to store required details of the server to talk to server.
    //captures server URL, Method of the request and data which is to be posted to server
    //creates request and receives response from the server for further processing.
    public class CLient
    {
        public string URL { get; set; }
        public HttpWeb HttpMethod { get; set; }
        public string postJSON { get; set; }
        

        public CLient()
        {
            URL = string.Empty;
            HttpMethod = HttpWeb.GET;
            postJSON = string.Empty;

        }

        //Method of the class CLient. this method creates request and receives response 
        //from the server for further processing. This method returns the response data received from server. 
        //This method takes one argument responseStatusCOde which is passed by reference to capture the 
        //statuscode returned by the server
        public string MakeRequest(ref string responseStatusCode)
        {
          
                string strResponseValue = string.Empty;

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
                request.Method = HttpMethod.ToString();

            if (request.Method == "POST" && postJSON != string.Empty)
            {
                request.ContentType = "application/json";
                using (StreamWriter swJSON = new StreamWriter(request.GetRequestStream()))
                {
                    swJSON.Write(postJSON);
                    swJSON.Close();
                }
                
            }
            HttpWebResponse response = null;
                using (response = (HttpWebResponse)request.GetResponse())
                {
                responseStatusCode = response.StatusCode.ToString();
                

                if (response.StatusCode != HttpStatusCode.OK)
                    {
                        throw new ApplicationException("STatus Code Received - Error Code:" + responseStatusCode);
                    }
                    
                
                    //process the response string
                     using (Stream responseStream = response.GetResponseStream())
                     {
                        if (responseStream != null)
                        {
                            using (StreamReader reader = new StreamReader(responseStream))
                            {
                                strResponseValue = reader.ReadToEnd();
                                reader.Close(); 

                            }//end of using streamReader
                        }
                        responseStream.Close();
                    }//end of using responsestream
                }// end of using httpwebresponse

                return strResponseValue;
            
        }
    }
}
