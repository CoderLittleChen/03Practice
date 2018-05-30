using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _17上机练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //编程输出1-100中能被3整除不能被5整除的数  并统计
            //int count = 0;
            //List<int> list = new List<int>();
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 3 == 0 && i % 5 != 0)
            //    {
            //        list.Add(i);
            //    }
            //}
            //foreach (int item in list)
            //{
            //    Console.Write(item+"  ");
            //}
            //Console.WriteLine("共有"+list.Count.ToString());
            //Console.ReadKey();

            //通过域名解析IP地址
            //string str = "crm.sumavision.com";
            //IPHostEntry ipEntity = Dns.GetHostByName(str);
            //IPAddress ip = ipEntity.AddressList[0];
            //Console.WriteLine(ip.ToString());
            //Console.ReadKey();

            //注意这里的 Round函数 实际上不是我们中国人理解的四舍五入，是老外的四舍五入，具体来说是四舍六入
            //45.365  输出45.36     45.366   输出45.37

            //想要实现我们的四舍五入，需要Round函数 添加参数
            double de = 45.365;
            de = Math.Round(de, 2,MidpointRounding.AwayFromZero);
            Console.WriteLine(de);
            Console.ReadKey();


        }
    }
}
