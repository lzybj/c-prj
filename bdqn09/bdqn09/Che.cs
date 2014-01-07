using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bdqn09
{
    public abstract class Che
    {
        private string cNo;

        public string CNo
        {
            get { return cNo; }
            set { cNo = value; }
        }
        private string cName;

        public string CName
        {
            get { return cName; }
            set { cName = value; }
        }
        private string cColor;

        public string CColor
        {
            get { return cColor; }
            set { cColor = value; }
        }
        private int cDayNum;

        public int CDayNum
        {
            get { return cDayNum; }
            set { cDayNum = value; }
        }
        private float cUnitPrice;

        public float CUnitPrice
        {
            get { return cUnitPrice; }
            set { cUnitPrice = value; }
        }
        private int cLoad;

        public int CLoad
        {
            get { return cLoad; }
            set { cLoad = value; }
        }
        private string cUserName;

        public string CUserName
        {
            get { return cUserName; }
            set { cUserName = value; }
        }

        public Che(string cNo,string cName,string cColor,int cDayNum,float cUnitPrice,int cLoad)
        {
            this.cNo = cNo;
            this.cName = cName;
            this.cColor = cColor;
            this.cDayNum = cDayNum;
            this.cUnitPrice = cUnitPrice;
            this.cLoad = cLoad;
        }

        public Che()
        {
        }

        public abstract float JieSuan();

    }
}
