using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _07判断浏览器的类别
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write(Environment.OSVersion.VersionString);
            //Response.Write("浏览器的型号为："+Request.Browser.Type);
            //Response.Write("浏览器的名称为：" + Request.Browser.Browser);
            //Response.Write("浏览器的版本为：" + Request.Browser.Version);
            //Response.Write("当前操作系统为：" + Request.Browser.Platform);
            //Response.Write("当前IP地址为：" + Request.UserHostAddress);

            //Accept-Encoding是浏览器发给服务器，声明浏览器支持的编码类型
            string str = Request.Headers["Accept-Encoding"].ToString().ToUpperInvariant();
            Response.Write(str);

        }
        /// <summary>
        /// 根据
        /// </summary>
        /// <param name="version"></param>
        /// <returns></returns>
        public string JudgePlatform(string version)
        {
            return "操作系统";
        }
    }
}