using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IPLogger
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string IpAdress = Request.UserHostAddress;

            if (true == string.IsNullOrEmpty(IpAdress))
                    return;

            Literal1.Text = IpAdress;

            string sName = Request.QueryString["name"];


            if (true == string.IsNullOrEmpty(sName))
                 return;





            System.IO.File.WriteAllText(Server.MapPath(sName + ".txt"), IpAdress);


            

        }
    }
}
