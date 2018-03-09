using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace hdb_dotnet_bootstrap
{
    public partial class frm_search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {
            // set the qns to session var
            Session[cls_constants.SESSION_QNS] = txt_complains.Text.Trim();
            Response.Redirect(cls_constants.FRM_ANSWER);
        }
        

    }
}