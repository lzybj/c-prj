using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace bdqn10
{
    public class TVManager
    {
        private List<TV> allTv = null;
        public List<TV> FindByAllTV()
        {
            allTv = new List<TV>();
            XmlDocument doc = new XmlDocument();
            doc.Load("../../files/FullChannels.xml");
            XmlNodeList channels = doc.GetElementsByTagName("Channel");

            foreach (XmlNode item in channels)
            {
                string channelType = item["channelType"].InnerText;
                string tvChannel = item["tvChannel"].InnerText;
                string path = item["path"].InnerText;
                TV myTv = TVFactory.getInstances(tvChannel);
                myTv.TvType = channelType;
                myTv.TvName = tvChannel;
                myTv.JieMusURL = path;
                allTv.Add(myTv);
            }
            

            return allTv;
        }
    }
}
