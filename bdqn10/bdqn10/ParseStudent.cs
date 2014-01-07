using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace bdqn10
{
    public class ParseStudent
    {
        public void parseXML()
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("../../students.xml");
                XmlNodeList students = doc.GetElementsByTagName("student");

                foreach (XmlNode item in students)
                {
                    Console.WriteLine(item["stucode"].InnerText);
                    Console.WriteLine(item["stuname"].InnerText);
                    Console.WriteLine(item["stuage"].InnerText);
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
