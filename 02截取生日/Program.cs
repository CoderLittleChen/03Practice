using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02截取生日
{
    class Program
    {
        static void Main(string[] args)
        {
            //string idCard = "142202199610140316";
            //string year = idCard.Substring(6, 4);
            //string month = idCard.Substring(10, 2);
            //string day = idCard.Substring(12, 2);
            //string birthday = year + "-" + month + "-" + day;
            ////string dt = string.Format("{0:d}", birthday);
            ////Console.WriteLine(dt);
            //// ToLongDateString 是把日期转换成年月日的格式
            //Console.WriteLine(Convert.ToDateTime(birthday).ToLongDateString());
            //Console.WriteLine(birthday);
            ////EditPage主要是用来修改网格的数据源
            //Console.WriteLine("瞌睡了就起来走动一下");
            //Console.ReadKey();

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);
            //ToString d参数  意思是只截取日期部门
            //SubString 第一个参数 从指定位置开始截取字符串
            Console.WriteLine(dt.ToString("d").Substring(2));
            Console.ReadKey();
        }
    }
}
