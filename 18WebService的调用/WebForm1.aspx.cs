using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _18WebService的调用
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //MyService.WebService1SoapClient client = new MyService.WebService1SoapClient();
            //int sum = client.Add(1, 2);
            //Response.Write(sum);

            ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient();
            int sum = client.Sum(1, 22);
            Response.Write(sum);

        }
    }
}