using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;

namespace TreeViewXMLTest
{
    public static class Assit
    {

        public static IEnumerable<XElement> XmlSerachElementXI(this XElement X, string SearchEleXPath)
        {//XI >>> Xml的IEnumerable的簡寫
            IEnumerable XI = (IEnumerable)X.XPathEvaluate(SearchEleXPath);
            IEnumerable<XElement> XAList = XI.Cast<XElement>();
            if (XAList.LongCount() > 0)
                return XAList;
            else return null;//等於0
        }


    }
}
