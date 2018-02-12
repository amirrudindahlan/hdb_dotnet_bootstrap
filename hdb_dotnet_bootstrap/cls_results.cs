using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hdb_dotnet_bootstrap
{
    public class cls_results
    {
        /*
        {
        "results": {
        "y_hat": "Mortgage", 
        "y_hat1": "Conventional fixed mortgage", 
        "y_hat2": "Unsolvable", 
        "y_hat3": "Undetermined", 
        "y_hat4": "Input text classified as Mortgage. It is Unsolvable. Recommend to send to Conventional fixed mortgage department. Proposed Response: Undetermined"
        }
        }
        */

        string y_hat;
        string y_hat1;
        string y_hat2;
        string y_hat3;
        string y_hat4;

        public void set_y_hat(string i_y_hat) { this.y_hat = i_y_hat; }
        public void set_y_hat1(string i_y_hat1) { this.y_hat1 = i_y_hat1; }
        public void set_y_hat2(string i_y_hat2) { this.y_hat2 = i_y_hat2; }
        public void set_y_hat3(string i_y_hat3) { this.y_hat3 = i_y_hat3; }
        public void set_y_hat4(string i_y_hat4) { this.y_hat4 = i_y_hat4; }

        public string get_y_hat() { return y_hat; }
        public string get_y_hat1() { return y_hat1; }
        public string get_y_hat2() { return y_hat2; }
        public string get_y_hat3() { return y_hat3; }
        public string get_y_hat4() { return y_hat4; }

    }
}