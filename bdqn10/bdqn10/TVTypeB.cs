using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace bdqn10
{
    public class TVTypeB : TV
    {
        public TVTypeB()
            :base()
        {
        }
        public TVTypeB(string tvType,string tvName,string jieMusURL)
            :base(tvType,tvName,jieMusURL)
        {
        }
        public override void GetJieMuData()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../" + this.JieMusURL);

            XmlNodeList programs = doc.GetElementsByTagName("Program");

            foreach (XmlNode item in programs)
            {
                DateTime jieMuTime =  DateTime.Parse(item["playTime"].InnerText);
                string jieMuName = item["name"].InnerText;
                string jieMuURL = item["path"].InnerText;

                JieMu jieMu = new JieMu(jieMuTime,jieMuName,jieMuURL);

                this.JieMus.Add(jieMu);

            }

        }
    }
}
