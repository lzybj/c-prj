using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace bdqn10
{
    public class TVTypeA : TV
    {
        public TVTypeA()
            :base()
        {
        }
        public TVTypeA(string tvType,string tvName,string jieMusURL)
            :base(tvType,tvName,jieMusURL)
        {
        }
        public override void GetJieMuData()
        {
            /**
             *1.生成XML对象
             *2.导入指定文件
             *3.根据标签名获得所有此标签节点集合(tvprogram)
             *4.遍历集合将其放入节目对象类，同时添加到节目集合中
             */
            XmlDocument doc = new XmlDocument();
            doc.Load("../../" + this.JieMusURL);
            XmlNodeList tvPrograms = doc.GetElementsByTagName("tvProgram");

            foreach (XmlNode item in tvPrograms)
            {
                DateTime jieMuTime = DateTime.Parse(item["playTime"].InnerText);
                string jieMuTimeDuan = item["meridien"].InnerText;
                string jieMuName = item["programName"].InnerText;
                string jieMuURL = item["path"].InnerText;

                JieMu jieMu = new JieMu(jieMuTime, jieMuName, jieMuTimeDuan, jieMuURL);

                this.JieMus.Add(jieMu);

            }

        }
    }
}
