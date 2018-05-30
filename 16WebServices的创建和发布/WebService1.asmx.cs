using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace _16WebServices的创建和发布
{
    /// <summary>
    /// WebService1 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        //服务和项目类似  其中也可以定义方法  完成后需要发布到服务器  然后可以通过ip地址来调用
        [WebMethod]
        public string HelloWorld()
        {           
            return "Hello World";
        }

        [WebMethod(Description ="加法")]
        public int Add(int a, int b)
        {
            return a + b;
        }

        [WebMethod(Description ="乘法")]
        public int Sum(int a,int b)
        {
            return a * b;
        }

    }
}
