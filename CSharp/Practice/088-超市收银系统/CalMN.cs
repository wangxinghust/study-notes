using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _088_超市收银系统
{
    /// <summary>
    /// 买M元送N元
    /// </summary>
    class CalMN:CalFather
    {
        public double M
        {
            get;
            set;
        }
        public double N
        {
            get;
            set;
        }
        public CalMN(double m,double n)
        {
            this.M=m;
            this.N=n;
        }
        /// <summary>
        /// 买多少送多少
        /// </summary>
        /// <param name="realMoney"></param>
        /// <returns></returns>
        public override double GetTotalMoney(double realMoney)
        {
            if(realMoney>=this.M)
            {
                //return realMoney - (int)(realMoney / this.M) * this.N;
                for (int i = 0; i < realMoney / this.M; i++)//有多少次即可减多少次
                {
                    realMoney -= this.N;
                }
                return realMoney;
                
            }
            else
            {
                return realMoney;
            }
        }
    }
}
