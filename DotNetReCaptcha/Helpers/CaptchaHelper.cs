using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNetReCaptcha.Helpers
{
    public class CaptchaHelper
    {
        private dynamic ctx;
        public CaptchaHelper(object httpContext)
        {
            ctx = httpContext;
        }

        public bool Validate()
        {
            string posted = ctx.Request.Form["g-recaptcha-response"];
            System.Net.HttpWebRequest req = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(
                "https://www.google.com/recaptcha/api/siteverify?secret=6Lc8lwcTAAAAAIZI9aeiIQbJ0FXoElmYWemeGlgF&response=" + posted);
            try
            {
                System.Net.WebResponse response = req.GetResponse();
                System.IO.StreamReader rdr = new System.IO.StreamReader(response.GetResponseStream());
                string responseData = rdr.ReadToEnd();
                rdr.Close();
                System.Web.Script.Serialization.JavaScriptSerializer jss = new System.Web.Script.Serialization.JavaScriptSerializer();
                string strSuccess = jss.Deserialize<ResultTransfer>(responseData).success;
                if (bool.Parse(strSuccess))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }

    public class ResultTransfer
    {
        public string success { get; set; }
    }
}