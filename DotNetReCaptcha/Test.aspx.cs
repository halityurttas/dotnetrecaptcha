using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotNetReCaptcha
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsend_Click(object sender, EventArgs e)
        {
            Helpers.CaptchaHelper captha = new Helpers.CaptchaHelper(HttpContext.Current);
            if (captha.Validate())
            {
                lblResult.Text = "Tamamdır";
            }
            else
            {
                lblResult.Text = "Olmadı";
            }
        }
    }
}