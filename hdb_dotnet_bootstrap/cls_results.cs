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
            "y_hat": "Payday loan", 
            "y_hat1": "Payday loan", 
            "y_hat2": "Unsolvable", 
            "y_hat3": "Undetermined", 
            "y_hat4": "Input text classified as Payday loan. It is Unsolvable. Recommend to send to Payday loan department. Proposed Response: Undetermined", 
            "y_hat5": "case ID 33290 --> Because I 'm pay every 2 weekS and never decrease loan. \ncase ID 21285 --> I never got this loan. \ncase ID 7293 --> BEING XXXX BY CASH CALL ON A INSTALLMENT LOAN ... // \ncase ID 31740 --> My auto loan company started to call me at my place of employment, leaving messages on a shared voicemail, sending emails through my work email, making repeat phone calls through my work phone. When calling my work cell at no time do they ever mention 1. who they are 2.that they are debt collector, just their name and to call them. After getting repeat phones calls from the time I arrive at work until XXXX at night. XX/XX/XXXX I sent a email to the manager to stop harrassing me while I 'm working. i received his response on XX/XX/XXXX stating the he place the cease and desist on my account, as per my request and will be honoring the cease and desist going forward. However sin the last few months I have received over XXXX threatening calls/emailed combined on my work phone and shared email account. when i post my XX/XX/XXXX payment on line as requested by a letter i received in the mail that it must be paid by XX/XX/XXXX, immediate after it posted I received another threatening call telling me I 'm still not caught up. Please help me in this matter I 'm a XXXX and receiving all of these threatening calls and emails are causing a great deal of stress and try to do my job so that i will have monies to pay my loan. \ncase ID 55340 --> I am a XXXX patient unable to pay loan due to unemployment. \n"
            }
        }
         */

        string y_hat;
        string y_hat1;
        string y_hat2;
        string y_hat3;
        string y_hat4;
        string y_hat5;
        string y_hat6;

        public void set_y_hat(string i_y_hat) { this.y_hat = i_y_hat; }
        public void set_y_hat1(string i_y_hat1) { this.y_hat1 = i_y_hat1; }
        public void set_y_hat2(string i_y_hat2) { this.y_hat2 = i_y_hat2; }
        public void set_y_hat3(string i_y_hat3) { this.y_hat3 = i_y_hat3; }
        public void set_y_hat4(string i_y_hat4) { this.y_hat4 = i_y_hat4; }
        public void set_y_hat5(string i_y_hat5) { this.y_hat5 = i_y_hat5; }
        public void set_y_hat6(string i_y_hat6) { this.y_hat6 = i_y_hat6; }

        public string get_y_hat() { return y_hat; }
        public string get_y_hat1() { return y_hat1; }
        public string get_y_hat2() { return y_hat2; }
        public string get_y_hat3() { return y_hat3; }
        public string get_y_hat4() { return y_hat4; }
        public string get_y_hat5() { return y_hat5; }
        public string get_y_hat6() { return y_hat6; }

    }
}