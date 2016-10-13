using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TreeViewXMLTest;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement X = XElement.Load("XML.xml");

            var Xitems = X.XmlSerachElementXI("item");

            if (Xitems != null)
            {
                foreach (XElement item in Xitems)
                {
                    foreach (XElement property in item.Elements())
                    {
                        Console.WriteLine(property.Value);
                    }


                }



            }

            Console.Read();
        }
    }
}
