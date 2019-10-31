using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _045_字符串的各种方法
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("请输入你心中所想的那个人的名字");
            //string name = Console.ReadLine();
            //Console.WriteLine("你心中所想的人的名字的长度为{0}", name.Length);
            //Console.ReadKey();

            //Console.WriteLine("请输入你喜欢的课程");
            //string lessonOne = Console.ReadLine();
            ////lessonOne = lessonOne.ToUpper();//转换成大写方式 ToLower()小写
            //Console.WriteLine("请输入你喜欢的课程");
            //string lessonTwo = Console.ReadLine();
            ////lessonTwo = lessonTwo.ToUpper();
            //if (lessonOne.Equals(lessonTwo,StringComparison.OrdinalIgnoreCase))//比较两个字符串 且忽略大小写差别
            //{
            //    Console.WriteLine("你们俩喜欢的课程一样");
            //}
            //else
            //{
            //    Console.WriteLine("你们喜欢的课程不一样");
            //}
            //Console.ReadKey();


            //string s = "a b   dfg _  +  ,,, fdf  ";
            ////分割字符串Split
            //char[] chs={' ','_','+','=',','};
            //string[] str = s.Split(chs,StringSplitOptions.RemoveEmptyEntries);
            //Console.ReadKey();

            //string s = "2008-08-08";
            ////char[] chs = { '-' };
            //string[] str = s.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine("{0}年{1}月{2}日", str[0], str[1], str[2]);

            //string str = "国家关键人物汪兴";
            //if(str.Contains("汪兴"))//确认是否包含
            //{
            //    str = str.Replace("汪兴", "**");//字符串替代
            //}
            //Console.WriteLine(str);
            
            ////Substring 截取字符串
            //string str = "今天天气好晴朗，处处好风光";
            //str = str.Substring(1,5);
            //Console.WriteLine(str);

            //string str = "今天天气好晴朗，处处好风光";
            //if(str.StartsWith("今天"))
            //{
            //    Console.WriteLine("是的");
            //}
            //if(str.EndsWith("光"))
            //{
            //    Console.WriteLine("是的");
            //}

            //string str = "今天天气好天晴朗，处处天好风天光";
            //int index = str.IndexOf("天",2);//报告指定字符串在此实例中的第一个匹配项的从零开始的索引
            //Console.WriteLine(index);

            //string str = "今天天气好晴朗，处处好风光";
            //int index = str.LastIndexOf('天');//报告指定字符串在此实例中的最后一个匹配项的从零开始的索引
            //Console.WriteLine(index);


            //查找最后一个匹配项并截取字符串
            //string path = @"c:\a\b\c\d\e\f\苍g\fd\\fd\苍\fda\\fsd苍a\fd\fe\sdf\苍老师苍.wav";
            //int index = path.LastIndexOf("\\");
            //path = path.Substring(index+1);
            //Console.WriteLine(path);

            //string str = "         hahahah          ";
            ////str=str.Trim();
            //str = str.TrimStart();
            //Console.WriteLine(str);

            //string str = null;
            //if(string.IsNullOrEmpty(str))//判断是否为空
            //{
            //    Console.WriteLine("是的");
            //}

            //string[] names = { "张三", "李四", "王五", "赵六", "田七" };
            //string str=string.Join("|", names);
            //Console.WriteLine(str);

            Console.ReadKey();
        }
    }
}



//1.Length() 获得当前字符串中字符的长度
//2.ToUpper() 将字符串转换成大写形式
//3.ToLower() 将字符串转换成小写形式
//4.Equals(LessonOne,StringComparison.OrdinalIgnoreCase) 比较两个字符串，且忽略大小写
//5.Split() 分割字符串，返回字符串类型的数组
//6.Substring() 截取字符串 在截取的时候包含要截取的那个位置
//7.IndexOf() 判断某个字符串在字符串中第一次出现的那个位置，如果没有返回-1
//8.LastIndexOf() 判断某个字符串在字符串中最后一次出现的位置
//9.StartWith() 判断以...开始
//10.EndWith() 判断以...结束
//11.Replace() 将字符串中某个字符串替换成一个新的字符串
//12.Contains() 判断某个字符串是否包含指定的字符串
//13.Trim() 去掉字符串中前后的空格
//14.TrimStart() 去掉字符串中前面的空格
//15.TrimEnd() 去掉字符串中后面的空格
//16.string.IsNullOrEmpty() 判断一个字符串是否为空或者为Null
//17.string.Join() 将字符串数组以...串联起来