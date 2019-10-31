using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _088_超市收银系统
{
    class SupperMarket
    {
        Warehouse wh = new Warehouse();
        public SupperMarket()
        {
            wh.Purchase("Acer", 1000);
            wh.Purchase("SamSung", 1000);
            wh.Purchase("SoySauce", 1000);
            wh.Purchase("Banana", 1000);
        }
        public void AskBuying()
        {
            Console.WriteLine("欢迎光临，请问您需要些什么");
            Console.WriteLine("我们有Acer、SamSung、SoySauce、Banana，你要买哪种");
            string strType = Console.ReadLine();
            Console.WriteLine("您需要多少件？");
            int count = Convert.ToInt32(Console.ReadLine());
            //去仓库取货物
            ProductFather[] pros = wh.PickUp(strType, count);
            //下面该计算加钱了
            double realMoney = GetMoney(pros);
            Console.WriteLine("您总共应付{0}元", realMoney);
            Console.WriteLine("请选择您的打折方式1-不打折 2-打九折 3-打85折 4-买300送50 5-买500送100");
            string input=Console.ReadLine();
            //通过简单工厂设计模式根据用户的输入获得一个打折对象
            CalFather cal = GetCal(input);
            double totalMoney = cal.GetTotalMoney(realMoney);
            Console.WriteLine("打完折后，您应付{0}元", totalMoney);
            Console.WriteLine("以下是您的购物信息");
            foreach (var item in pros)
            {
                Console.WriteLine("货物名称" + item.Name + ",\t货物单价" + item.Price + ",\t货物编号" + item.ID);
            }
        }


        /// <summary>
        /// 根据用户的选择打折方式返回一个打着对象
        /// </summary>
        /// <param name="input">用户的选择</param>>
        /// <returns>返回的父类对象，但是里面装的是自雷对象</returns>
        public CalFather GetCal(string input)
        {
            CalFather cal = null;
            switch (input)
            {
                case "1": cal = new CalNormal();
                    break;
                case "2": cal = new CalRate(0.9);
                    break;
                case "3": cal = new CalRate(0.85);
                    break;
                case "4": cal = new CalMN(300, 50);
                    break;
                case "5": cal = new CalMN(500, 100);
                    break;
            }
            return cal;
        }
        /// <summary>
        /// 根据货物计算总价钱
        /// </summary>
        /// <param name="pros"></param>
        /// <returns></returns>
        public double GetMoney(ProductFather[] pros)
        {
            double realMoney = 0;
            //realMoney = pros[0].Price * pros.Length;以下方法可拓展
            for (int i = 0; i < pros.Length; i++)
            {
                realMoney += pros[i].Price;
            }
            return realMoney;
        }
        public void ShowPros()
        {
            wh.ShowPros();
        }
    }
}
