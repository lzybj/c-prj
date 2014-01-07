using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JiSuanQi.service
{
    public class JiSuanQiService
    {
        private double Jia(int par,int par2)
        {
            return par + par2;
        }
        private double Jian(int par,int par2)
        {
            return par - par2;
        }
        private double Chu(int par,int par2)
        {
            return par / par2;
        }
        private double Chen(int par,int par2)
        {
            return par * par2;
        }
        public double JiSuan(int par,string fuhao,int par2)
        {
            double res = 0;
            switch(fuhao)
            {
                case "+":
                    res = this.Jia(par,par2);
                    break;
                case "-":
                    res = this.Jian(par,par2);
                    break;
                case "*":
                    res = this.Chen(par,par2);
                    break;
                case "/":
                    res = this.Chu(par,par2);
                    break;
            }
            return res;
        }

    }
}
