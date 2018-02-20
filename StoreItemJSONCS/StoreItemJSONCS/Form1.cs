using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

namespace Test_New
{
    public partial class Form1 : Form
    {
        string strResponse;
        string responseStatusCode;

        List<StoreItem> JsonStoreItem;

        public Form1()
        {
            strResponse = string.Empty;
            InitializeComponent();    
        }



#region UI event Handlers
        //This is a method which creates CLient object stores URL and POSTdata and Processes the response
        private void cmdGo_Click(object sender, EventArgs e)
        {
            
            try
            {
                TableStoreItem.Visible = false;
                
                CLient cl = new CLient();
                cl.URL = TxtRestURL.Text;
                //DebugOutput("Client Created");
                bool isvalidJSONstr = true;
                
                switch (cbxVerb.Text)
                {
                    case "POST":
                        cl.HttpMethod = HttpWeb.POST;
                        
                        cl.postJSON = txtPOSTData.Text;
                        isvalidJSONstr =IsValidJson(cl.postJSON);
                        break;
                    default:
                        cl.HttpMethod = HttpWeb.GET;
                        break;
                }

                if (isvalidJSONstr == true)
                {
                    strResponse = string.Empty;
                    strResponse = cl.MakeRequest(ref responseStatusCode);
                    
                    if (strResponse == string.Empty)
                    {
                        DebugOutput("CLient POST Request made"+Environment.NewLine+ "Status Code: " + 
                            responseStatusCode);
                    }
                    else
                    {
                        DebugOutput("Client GET Request made"+Environment.NewLine+ 
                            "Received Response"+Environment.NewLine+ "Status Code: " + 
                            responseStatusCode);
                    }
                    
                }
                else
                {
                    DebugOutput("PostData input is invalid" + Environment.NewLine + 
                        "Hence POST request is not made");
                }
            }
            catch (Exception exp)
            {
                DebugOutput("Error Message: "+exp.Message);
            }

            try
            {
                if (strResponse != string.Empty)
                {
                    JsonStoreItem = JsonConvert.DeserializeObject<List<StoreItem>>(strResponse);
                    DebugOutput("Server data captured." + Environment.NewLine + 
                        "Want to see the result? CLick on \"DIsplay Store Item\"");
                }
            }
            catch(Exception exp)
            {
                DebugOutput("Invalid JSON string Received"+Environment.NewLine+ 
                    "So cannot be processed and Stored"+ Environment.NewLine + "Error Message: " + exp.Message);
            }

        }
        // This is a display method to display all the StoreItem received by server as a response to GET request.
        private void Display_Click(object sender, EventArgs e)
        {
            try
            {
                
                DataTable dt = new DataTable();

                dt.Columns.Add("Store Item Table");
                dt.Columns.Add("Barcode");
                dt.Columns.Add("Id");
                dt.Columns.Add("ItemId");
                dt.Columns.Add("StoreDesc Id");
                dt.Columns.Add("StoreDesc ItemId");
                dt.Columns.Add("StoreDesc LandId");
                dt.Columns.Add("Store Description");       
                dt.Columns.Add("StoreItem Prices Id");
                dt.Columns.Add("StoreItem Prices Landid");
                dt.Columns.Add("StoreItem Prices BuyPrice");
                dt.Columns.Add("StoreItem Prices SellPrice");

                if (strResponse != String.Empty)
                {
                    int i = 0;

                    foreach (var num in JsonStoreItem)
                    {
                        dt.Rows.Add("Item " + (i+1).ToString(), 
                            JsonStoreItem[i].Barcode, JsonStoreItem[i].Id, 
                            JsonStoreItem[i].ItemId, JsonStoreItem[i].StoreItemDescriptions[0].Id, 
                            JsonStoreItem[i].StoreItemDescriptions[0].ItemId, 
                            JsonStoreItem[i].StoreItemDescriptions[0].LandId, 
                            JsonStoreItem[i].StoreItemDescriptions[0].Description, 
                            JsonStoreItem[i].StoreItemPrices[0].Id, JsonStoreItem[i].StoreItemPrices[0].LandId, 
                            JsonStoreItem[i].StoreItemPrices[0].BuyPrice, JsonStoreItem[i].StoreItemPrices[0].Sellprice);
                        i++;
                    }

                    DebugOutput("Table of Store Items Displayed Below");
                    TableStoreItem.Visible = true;
                    TableStoreItem.DataSource = dt;
                    JsonStoreItem.Clear();
                }
                else
                {
                    DebugOutput("No data is captured in StoreItem");
                }
            }
            catch (Exception ex)
            {
                DebugOutput("We had a problem " + ex.Message.ToString());
            }
        }


        #endregion
        //DebugOutput is a Method of class Form1. This method is used to display the message to user.
        private void DebugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write("========================="+ Environment.NewLine + strDebugText + Environment.NewLine);
                txtResponse.Text = txtResponse.Text + strDebugText + Environment.NewLine+ "========================="+ Environment.NewLine;
                txtResponse.SelectionStart = txtResponse.TextLength;
                txtResponse.ScrollToCaret();

            }
            catch(Exception e)
            {
                System.Diagnostics.Debug.Write(e.Message.ToString() + Environment.NewLine);
            }
        }
        //This method is used to check whether the input strInput is in proper JSON format of StoreItem.  
        private static bool IsValidJson(string strInput)
        {
            strInput = strInput.Trim();
            if ((strInput.StartsWith("{") && strInput.EndsWith("}")) || //For object
                (strInput.StartsWith("[") && strInput.EndsWith("]"))) //For array
            {
                try
                {
                    List < StoreItem > result = JsonConvert.DeserializeObject<List<StoreItem>>(strInput);
                    if (result.Count == 0)
                        return false;
                    else
                        return true;
                }
                catch (JsonReaderException jex)
                {
                    //Exception in parsing json
                    Console.WriteLine(jex.Message);
                    return false;
                }
                catch (Exception ex) //some other exception
                {
                    Console.WriteLine(ex.Message.ToString());
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
