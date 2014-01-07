using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace bdqn13
{
    public class ComputerService
    {
        public List<string> getBrands()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../xmlComputer.xml");
            XmlNodeList brands = doc.GetElementsByTagName("Breed");
            List<string> brandsList = new List<string>();
            foreach (XmlNode item in brands)
            {
                XmlElement myitem = item as XmlElement;
                brandsList.Add(myitem.GetAttribute("name"));
                //Console.WriteLine(item.Attributes[0].Value);
            }
            return brandsList;
        }

        public List<string> findByBrand(string parBrand)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../xmlComputer.xml");
            XmlElement brand = null;
            XmlNodeList brands = doc.GetElementsByTagName("Breed");
            foreach (XmlNode item in brands)
            {
                XmlElement myitem = item as XmlElement;
                if (myitem.GetAttribute("name").Equals(parBrand))
                {
                    brand = myitem;
                }
            }
            XmlNodeList computerNames = brand.GetElementsByTagName("Name");
            List<string> computerNamesList = new List<string>();
            foreach (XmlNode item in computerNames)
            {
                XmlElement myitem = item as XmlElement;
                computerNamesList.Add(myitem.InnerText);
            }
            return computerNamesList;
        }

        public Computer findByComputerName(string parComputerName)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../xmlComputer.xml");
            XmlNodeList computerNames = doc.GetElementsByTagName("Name");

            foreach (XmlNode item in computerNames)
            {
                if (item.InnerText.Equals(parComputerName))
                {
                    XmlElement myitem = item as XmlElement;
                    XmlElement model = (myitem.ParentNode) as XmlElement;
                    XmlElement brand = (model.ParentNode) as XmlElement;
                    string computerNameText = model["Name"].InnerText;
                    string cpuText = model["Cpu"].InnerText;
                    string hardDiskText = model["HardDisk"].InnerText;
                    string memDiskText = model["Mem"].InnerText;
                    string displayText = model["Display"].InnerText;
                    string modelText = model.GetAttribute("Kind");
                    if (modelText.Equals("PC"))
                    {
                        string hostTypeText = model["HostType"].InnerText;
                    }
                    else
                    {
                        string batteryText = model["Battery"].InnerText;
                    }
                    string brandText = brand.GetAttribute("name");
                    Computer myComputer = ComputerFactory.getInstance(modelText);
                    myComputer.BrandName = brandText;
                    myComputer.ComputerName = computerNameText;
                    myComputer.CpuType = cpuText;
                    myComputer.HardDisk = hardDiskText;
                    myComputer.Mem = memDiskText;
                    myComputer.Display = displayText;
                    if (modelText.Equals("PC"))
                    {
                        (myComputer as PC).HostType = model["HostType"].InnerText;
                    }
                    else
                    {
                        (myComputer as NoteBook).Battery = model["Battery"].InnerText;
                    }
                    return myComputer;

                }
            }
            return null;

        }

    }
}
