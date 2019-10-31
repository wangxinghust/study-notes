using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _094_读取xml文档
{
    class Program
    {
        static void Main(string[] args)
        {
            //普通读取


            //XmlDocument doc = new XmlDocument();
            ////加载要读取的xml
            //doc.Load("Books.xml");

            ////获得根节点
            //XmlElement books = doc.DocumentElement;
            ////获得子节点
            //XmlNodeList xnl = books.ChildNodes;
            //foreach (XmlNode item in xnl)
            //{
            //    Console.WriteLine(item.InnerText);
            //}
            //Console.ReadKey();


            //读取带属性的


            //XmlDocument doc = new XmlDocument();
            //doc.Load("Order.xml");
            //XmlNodeList xnl = doc.SelectNodes("/Order/Items/OrderItem");
            //foreach (XmlNode node in xnl)
            //{
            //    Console.WriteLine(node.Attributes["Name"].Value);
            //    Console.WriteLine(node.Attributes["Count"].Value);
            //}

            //XmlDocument doc = new XmlDocument();
            //doc.Load("Order.xml");
            //XmlNodeList xnl = doc.SelectNodes("/Order/Items/OrderItem");

            //foreach (XmlNode node in xnl)
            //{
            //    Console.WriteLine(node.Attributes["Name"].Value);
            //    Console.WriteLine(node.Attributes["Count"].Value);
            //}

            //Console.ReadKey();


            //删除节点
            XmlDocument doc = new XmlDocument();
            doc.Load("Order.xml");
            XmlNode xn = doc.SelectSingleNode("/Order/Items");
            xn.RemoveAll();
            doc.Save("Order.xml");

        }
    }
}
