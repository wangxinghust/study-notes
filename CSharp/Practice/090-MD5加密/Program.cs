using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _090_MD5加密
{
    class Program
    {
        static void Main(string[] args)
        {
            //202cb962ac59075b964b07152d234b70 123
            string s = GetMD5("123");
            Console.WriteLine(s);
            Console.ReadKey();
        }
        public static string GetMD5(string str)
        {
            //创建MD5对象
            MD5 md5 = MD5.Create();
            //开始加密
            //需要将字符串转换为字节数组
            byte[] buffer = Encoding.UTF8.GetBytes(str);
            byte[] MD5Buffer = md5.ComputeHash(buffer);
            //将字节数组转换成字符串
            //字节数组---字符串
            //将字节数组中每个元素按照指定的编码格式解析成字符串
            //直接将数组ToString();
            //将字节数组中的每个元素ToString()
            //return Encoding.UTF8.GetString(MD5Buffer);
            //189 273 345 我爱你
            //189 273 345
            string strNew = "";
            for (int i = 0; i < MD5Buffer.Length; i++)
            {
                strNew += MD5Buffer[i].ToString("x2");//加上"x"转换为16进制 加上"x2"转换为16进制，每次都是两位数
                //ToString的一些特殊用法，可Google
            }
            return strNew;
        }
    }
}
