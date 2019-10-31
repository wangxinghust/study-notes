using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _092_创建带属性的XML文档
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            doc.AppendChild(dec);

            XmlElement order = doc.CreateElement("Order");
            doc.AppendChild(order);

            XmlElement customerName = doc.CreateElement("CustomerName");
            customerName.InnerText = "yanshiwei";
            order.AppendChild(customerName);

            XmlElement customerNumber = doc.CreateElement("CustomerNumber");
            customerNumber.InnerText = "100001";
            order.AppendChild(customerNumber);

            XmlElement items = doc.CreateElement("Items");
            order.AppendChild(items);

            XmlElement orderItem1 = doc.CreateElement("OrderItem");
            //给节点添加属性
            orderItem1.SetAttribute("Name", "重启");
            orderItem1.SetAttribute("Count", "11");
            items.AppendChild(orderItem1);

            XmlElement orderItem2 = doc.CreateElement("OrderItem");
            //给节点添加属性
            orderItem2.SetAttribute("Name", "重启");
            orderItem2.SetAttribute("Count", "11");
            items.AppendChild(orderItem2);

            XmlElement orderItem3 = doc.CreateElement("OrderItem");
            //给节点添加属性
            orderItem3.SetAttribute("Name", "重启");
            orderItem3.SetAttribute("Count", "11");
            items.AppendChild(orderItem3);

            doc.Save("Order.xml");
        }
    }
}
