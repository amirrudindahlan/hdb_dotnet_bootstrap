using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Google.Apis.Customsearch.v1;
using Google.Apis.Customsearch.v1.Data;
using Google.Apis.Services;


namespace hdb_dotnet_bootstrap
{
    public partial class frm_answer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                // show original concerns
                txt_concerns.Text = Session[cls_constants.SESSION_QNS].ToString().Trim();

                // call model via flask api
                try
                {
                    cls_results cr = this.flask_call(Session[cls_constants.SESSION_QNS].ToString());

                    this.txt_answer1.Text = cr.get_y_hat();
                    this.txt_answer2.Text = cr.get_y_hat1();
                    this.txt_answer3.Text = cr.get_y_hat2();
                    this.txt_answer4.Text = cr.get_y_hat3();

                }
                catch (Exception err)
                {
                    Console.WriteLine(err.ToString());
                    //string myStringVariable = "Sorry, seems we are unable to process your concern. Please rephrase or enter a new concern.";
                    //ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + myStringVariable + "');", true);
                    //ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", " alert('Sorry, seems we are unable to process your concern. Please rephrase or enter a new concern.'); window.open('frm_search.aspx');", true);
                    //ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", " alert('Sorry, seems we are unable to process your concern. Please rephrase or enter a new concern.'); Response.Redirect('frm_search.aspx');", true);


                    string message = "Sorry, seems we are unable to process your concern. You will now be redirected to rephrase or enter a new concern.";
                    string url = "frm_search.aspx";
                    string script = "window.onload = function(){ alert('";
                    script += message;
                    script += "');";
                    script += "window.location = '";
                    script += url;
                    script += "'; }";
                    ClientScript.RegisterStartupScript(this.GetType(), "Redirect", script, true);
                    

                }
                
                // do google search on hdb site
                this.do_google_search(txt_answer1.Text);

                // filter qlik by issue type
                HtmlControl qlik_frame = (HtmlControl)this.FindControl("qlik_frame");
                qlik_frame.Attributes["src"] = "http://localhost:4848/extensions/MyMashup/MyMashup.html?classifiedOut=" + Server.HtmlEncode(txt_answer1.Text);
                //qlik_frame.Attributes["src"] = "http://localhost:4848/extensions/MyMashup/MyMashup.html?classifiedOut=" + Server.HtmlEncode("Credit reporting")  + "&town=" + Server.HtmlEncode("ANG MO KIO");

                // assign full view link of qlik
                LinkButton link_qlik_full_view = (LinkButton)this.FindControl("link_qlik_full_view");
                string strURL = qlik_frame.Attributes["src"].ToString();
                link_qlik_full_view.Attributes.Add("onClick", "javascript:window.open('" + strURL + "');return false;");

            }

        }
        
        private string clean_result(string result)
        {

            // split by :    
            string[] result_array = result.Split(':');
            int array_len = result_array.Length;

            // remove {} and double quotes and trim
            result = result_array[array_len - 1];
            result = result.Replace("{", "");
            result = result.Replace("}", "");
            result = result.Replace("\"", "");
            result = result.Trim();

            return result;


        }

        private cls_results clean_result_new(string result)
        {
            // replace
            result = result.Replace("{", "");
            result = result.Replace("}", "");
            result = result.Replace("\"", "");
            result = result.Replace(",", "");
            
            // split by :    
            string[] result_array = result.Split(':');

            // define class
            cls_results cr = new cls_results();

            // loop and store to class
            for (int x = 0; x <= result_array.Length - 1; x++)
            {
                // remove 'yhat' string
                string yhat_removed = result_array[x].Substring(0,result_array[x].Length - 6).Trim();

                System.Diagnostics.Debug.WriteLine(yhat_removed);

                if (x == 2) { cr.set_y_hat(yhat_removed); }
                if (x == 3) { cr.set_y_hat1(yhat_removed); }
                if (x == 4) { cr.set_y_hat2(yhat_removed); }
                if (x == 5) { cr.set_y_hat3(yhat_removed); }
                if (x == 6) { cr.set_y_hat4(result_array[x]); }

            }

            System.Diagnostics.Debug.WriteLine(cr.get_y_hat());
            System.Diagnostics.Debug.WriteLine(cr.get_y_hat1());
            System.Diagnostics.Debug.WriteLine(cr.get_y_hat2());
            System.Diagnostics.Debug.WriteLine(cr.get_y_hat3());
            System.Diagnostics.Debug.WriteLine(cr.get_y_hat4());
            
            return cr;


        }

        public cls_results flask_call(string input_str)
        {
            //double v1 = 5.84;
            //double v2 = 3.0;
            //double v3 = 3.75;
            //double v4 = 1.1;

            var httpWebRequest = (System.Net.HttpWebRequest)System.Net.WebRequest.Create("http://localhost:9000/api");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            var result = "";

            using (var streamWriter = new

            System.IO.StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(new
                {
                    dataIn = input_str

                    //sl = v1,
                    //sw = v2,
                    //pl = v3,
                    //pw = v4

                });

                streamWriter.Write(json);
            }
            var httpResponse = (System.Net.HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new System.IO.StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
                System.Diagnostics.Debug.WriteLine(result.ToString());
            }

            //cls_results cr = this.clean_result_new(result);

            return this.clean_result_new(result); //result;

        }

        protected void btn_link_back_Click(object sender, EventArgs e)
        {
            Response.Redirect(cls_constants.FRM_SEARCH);
        }

        public static CustomsearchService Service = new CustomsearchService(new BaseClientService.Initializer
        {
            ApplicationName = "HDBCustomSearch",
            //ApiKey = "AIzaSyCyqAm432caVHD6ycUEWTbCNtg4rD_ao8Y", //hdb-search 
            ApiKey = "AIzaSyCLGfw__6dnkMett-LnClqDhMBHm69kPTQ", // hdb-search-1 
        });

        public static IList<Result> Search(string query)
        {
            Console.WriteLine("Executing google custom search for query: {0} ...", query);

            CseResource.ListRequest listRequest = Service.Cse.List(query);
            listRequest.Cx = "001132580745589424302:jbscnf14_dw";

            Search search = listRequest.Execute();
            return search.Items;
        }

        public void do_google_search(string value)
        {

            string query = "site:http://www.hdb.gov.sg/ " + value.Trim();
            var results = Search(query);

            // handle null returns
            if (results == null)
            {
                this.txt_articles_not_found.Text = "No relevant sites found.";
                //this.txt_concerns.Text = "No relevant sites found.";
                this.txt_articles_not_found.Visible = true;
                return;
            }
            else
            {
                this.txt_articles_not_found.Visible = false;
            }

            string str_results = "";
            foreach (Result result in results)
            {

                System.Diagnostics.Debug.WriteLine("-----------------------------------");
                System.Diagnostics.Debug.WriteLine("Title: {0}", result.Title);
                System.Diagnostics.Debug.WriteLine("Link: {0}", result.Link);

                // create buffer
                str_results = str_results + Environment.NewLine + Environment.NewLine;
                str_results = str_results + "-----------------------------------";
                str_results = str_results + Environment.NewLine;
                str_results = str_results + result.Title.ToString();
                str_results = str_results + Environment.NewLine;
                str_results = str_results + result.Link.ToString();

                // create new link and next line objects for each link found
                HyperLink hdb_link = new HyperLink();
                LiteralControl next_line = new LiteralControl("<br />");

                // prep links
                hdb_link.Text = result.Title.ToString(); ;
                hdb_link.NavigateUrl = result.Link.ToString();
                hdb_link.Target = "_blank"; // open in new window
                hdb_link.CssClass = "button";

                // append links from google search to panel
                this.pnl_hdb_websites.Controls.Add(hdb_link);
                this.pnl_hdb_websites.Controls.Add(next_line);
                
            }


        }


    }
}