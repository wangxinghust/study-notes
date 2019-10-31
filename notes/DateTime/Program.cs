using System;
using System.Data;
using System.Globalization;

namespace DateTimeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DateTime localDate = DateTime.Now;
            DateTime utcDate = DateTime.UtcNow;
            String[] cultureNames = { "en-US", "en-GB", "fr-FR", "de-DE", "ru-RU" };
            foreach (var cultureName in cultureNames)
            {
                var culture = new CultureInfo(cultureName);
                Console.WriteLine("{0}:", culture.NativeName);
                Console.WriteLine("  Local date and time : {0}, {1:G}",
                    localDate.ToString(culture), localDate.Kind);
                Console.WriteLine("  UTC date and time : {0}, {1:G}",
                    utcDate.ToString(culture), utcDate.Kind);
            }
            Console.WriteLine("-----------");

            // C# DateTime 转成 MySQL DateTime 的字符串
            string mysqlDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            Console.WriteLine(mysqlDateTime);
            // MySQL 读出的 DateTime 转换成 C# 的 DateTime
            DataTable dt = new DataTable();
            int i = 0;
            DateTime recTime = Convert.ToDateTime(Convert.ToDateTime(dt.Rows[i]["recTime"]).ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine(recTime.ToString("F"));
        }
    }
}

// UTC 协调世界时间