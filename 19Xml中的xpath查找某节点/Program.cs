using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _19Xml中的xpath查找某节点
{
    class Program
    {
        static void Main(string[] args)
        {
            //1、查询已知绝对路径的节点
            //2、查询已知相对路径的节点
            //3、查询已知元素名的节点【在使用不规则的层次文档的时候，可用//符号来越过中间的节点,查询其子孙】
            //4、查询属性节点
            //5、查询text节点
            //6、查询特定条件的节点

            XmlDocument xdoc = new XmlDocument();
            //加载xml文档有两种方法  一种是Load方法  参数是xml文档的路径，另一种是LoadXml方法，参数是一个xml格式的字符串

            //这里注意  如果路径直接写1.xml  那么默认是该文档是在和exe文件在同一目录下（即Debug目录下）
            xdoc.Load("../../1.xml");

            //在后面加/@name  表示查询的指定路径节点的指定属性


            //          root//LinixServer                                   返回的是节点
            //          root//LinixServer/@name                       返回的是节点对应的属性对象  需要通过Value字段来获取值
            //          root//LinixServer[@name='CentOS']       返回的是节点
            //          root/Conputer|root/LinixServer               使用|可以获得多重模式的节点

            //这里注意  拿到xml节点的属性对象  一定要通过value值来进行输出  
            XmlNode node = xdoc.SelectSingleNode("root//LinixServer/@name");
            //然后直接通过node.value 进行输出 
            Console.WriteLine(node.Value);
            //Console.WriteLine(node.Attributes["price"].Value);
            Console.ReadKey();

        }
    }
}
