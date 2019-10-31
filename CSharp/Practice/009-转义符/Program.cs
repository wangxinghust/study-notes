using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_转义符
{
    class Program
    {
        static void Main(string[] args)
        {
            //转义符指的是\+
            // \n表示换行
            Console.WriteLine("今天天气好晴朗\n处处好风光");
            Console.WriteLine("我想在这句话输出一个英文半角的双引号\"\"");
            string name1 = "张三";
            string name2 = "李俊高富帅";
            string name3 = "井里溪边水上君";
            string name4 = "wangxiaowu";
            // \t 相当于Tab
            Console.WriteLine("{0}\t{1}", name1, name2);
            Console.WriteLine("{0}\t{1}", name3, name4);

            // \r回车
            // \b 退格(BS) ，将当前位置移到前一列
            // \0 空字符（NULL）

            //windows以\r\n作为换行；mac认识\n
            string str = "今天处处好晴朗\r\n处处好风光";
            System.IO.File.WriteAllText(@"C:\Users\wx\Desktop\111.txt",str);
            Console.WriteLine("写入成功！！！");
            

            // \\也是表示一个\
            // @符号表示取消\在字符串中的转义作用 将字符串按照编辑的原格式输出（作用2）
            Console.ReadKey();
        }
    }
}
