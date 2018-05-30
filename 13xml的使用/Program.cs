using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _13xml的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml("12");
            XmlNodeList list = doc.ChildNodes;
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list.Item(0).InnerText);
            }
        }
    }
}
