using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _046_字符串的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 练习1
            //string str = "abcdefg";
            ////for (int i = str.Length-1; i >= 0; i--)
            ////{
            ////    Console.Write(str[i]);
            ////}
            //char[] chs = str.ToCharArray();
            //for (int i = 0; i < chs.Length/2; i++)
            //{
            //    char temp = chs[i];
            //    chs[i] = chs[chs.Length - 1 - i];
            //    chs[chs.Length - 1 - i] = temp;
            //}
            //str = new string(chs);
            //Console.WriteLine(str); 
            #endregion

            #region 练习2
            //string str = "hello c sharp";
            //string[] strNew = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //for (int i = 0; i < strNew.Length / 2; i++)
            //{
            //    string temp = strNew[i];
            //    strNew[i] = strNew[strNew.Length - 1 - i];
            //    strNew[strNew.Length - 1 - i] = temp;
            //}
            ////for (int i = 0; i < strNew.Length; i++)
            ////{
            ////    Console.WriteLine(strNew[i]);
            ////}
            //str = string.Join(" ", strNew);
            //Console.WriteLine(str); 
            #endregion

            #region 练习3
            //string email = "avbdeda@163.com";
            //int index = email.IndexOf('@');
            //string userName = email.Substring(0, index);
            //string domainName = email.Substring(index + 1);
            //Console.WriteLine(userName);
            //Console.WriteLine(domainName); 
            #endregion


            #region 练习4
            //string path = @"C:\Users\wx\Documents\Visual Studio 2013\Projects\Practice\046-字符串的练习\1.txt";
            //string[] contents = File.ReadAllLines(path, Encoding.Default);
            //for (int i = 0; i < contents.Length; i++)
            //{
            //    string[] strNew = contents[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //    Console.WriteLine((strNew[0].Length > 10 ? strNew[0].Substring(0, 7) + "..." : strNew[0]) + "|" + strNew[1]);
            //} 
            #endregion

            #region 练习5
            //string str = "abcdefgefgefgefgefgefgefg";
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (str[i] == 'e')
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //int index = str.IndexOf('e');
            //Console.WriteLine("第一次出现e的位置是{0}", index);
            ////index = str.IndexOf('e', index + 1);
            ////Console.WriteLine("第二次出现e的位置是{0}", index);
            ////循环体 从上次出现e的位置+1的位置找下一次e出现的位置
            ////循环条件 index!=-1
            //int count = 1;
            //while(index!=-1)
            //{
            //    count++;
            //    index = str.IndexOf('e', index + 1);
            //    if (index == -1)
            //    {
            //        break;
            //    }
            //    Console.WriteLine("第{0}次出现e的位置是{1}",count,index);
            //} 
            #endregion

            #region 练习6
            //string str = "老牛很邪恶";
            //if (str.Contains("邪恶"))
            //{
            //    str = str.Replace("邪恶", "**");
            //}
            //Console.WriteLine(str); 
            #endregion

            #region 练习7
            string[] names = { "诸葛亮", "鸟叔", "卡卡西", "卡哇伊" };
            string str = string.Join("|", names);
            string[] strNew = str.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries); 
            #endregion
            
                       
            Console.ReadKey();
        }
    }
}
