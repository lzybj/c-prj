using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bdqn04.entity
{
    public class Car
    {
        private string carName;

        public string CarName
        {
            get { return carName; }
            set { carName = value; }
        }
        private string carColor;

        public string CarColor
        {
            get { return carColor; }
            set { carColor = value; }
        }
        private string carAddr;

        public string CarAddr
        {
            get { return carAddr; }
            set { carAddr = value; }
        }
        public Car()
        {
        }
        public Car(string carName,string carColor,string carAddr)
        {
            this.carName = carName;
            this.carColor = carColor;
            this.carAddr = carAddr;
        }
        public void run()
        {
            Console.WriteLine("我是一辆" + this.carName + ",我的颜色是" + this.carColor + ",我的产地是" + this.carAddr);
        }
        public void run(int speed)
        {
            Console.WriteLine("我是一辆" + this.carName + ",我的颜色是" + this.carColor + ",我的产地是" + this.carAddr + ",我的最高时速是" + speed);

        }

    }
}
