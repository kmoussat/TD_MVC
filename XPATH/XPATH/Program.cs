using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XPath;

namespace XPATH
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static void Exo1()
        {
            string fileName = "filmotheque.xml";
            XPathDocument doc = new XPathDocument(fileName);
            XPathNavigator nav = doc.CreateNavigator();

            XPathExpression expr;
            expr = nav.Compile("/filmotheque/film");

            XPathNodeIterator nodes = nav.Select(expr);
            while( nodes.MoveNext() )
            {
                string 
                Console.WriteLine("")
            }

        }
    }
}
