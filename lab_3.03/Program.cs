using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace lab_3._03
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1
            string pattern_1 = "([0-1][0-9][0-9]|[2][0-5][0-5]|[0-9][0-9]|[0-9])\\." +
                "([0-1][0-9][0-9]|[2][0-5][0-5]|[0-9][0-9]|[0-9])\\." +
                "([0-1][0-9][0-9]|[2][0-5][0-5]|[0-9][0-9]|[0-9])\\." +
                "([0-1][0-9][0-9]|[2][0-5][0-5]|[0-9][0-9]|[0-9])$";
            Console.WriteLine("Введите IPv4");
            string task_1 = Console.ReadLine();
            Regex regex_1 = new Regex(pattern_1);
            if (regex_1.IsMatch(task_1))
                Console.WriteLine($"Ваш IP правильный: {task_1}");
            else
                Console.WriteLine("Вы ввели неверный IP, пример IPv4: 192.168.0.9");
            #endregion

            #region 2
            string pattern_2 = "а|е|и|ы|ё|о|ю|я|у";
            Console.WriteLine("\nВведите текст");
            string task_2 = Console.ReadLine();
            MatchCollection myMatch = Regex.Matches(task_2, pattern_2, RegexOptions.IgnoreCase);
            int count = 0;
            foreach (Match i in myMatch)
                count++;
            Console.WriteLine(count);
            #endregion

            #region 3
            string pattern_3 = @"https://\w*|http://\w*|";
            Console.WriteLine("Введите URL");
            string task_3 = Console.ReadLine();
            Regex regex_3 = new Regex(pattern_3);
            if (regex_3.IsMatch(task_3))
                Console.WriteLine($"Ваш URL правильный");
            else
                Console.WriteLine("Вы ввели неверный URL");
            #endregion

            #region 4
            string pattern_4 = @"^\w{1}$";
            Console.WriteLine("Введите значение");
            string task_4 = Console.ReadLine();
            Regex regex_4 = new Regex(pattern_4);
            if (regex_3.IsMatch(task_3))
                Console.WriteLine($"Ваше значение буквенно-цифровой");
            else
                Console.WriteLine("Ваше значение не буквенно-цифровой");
            #endregion

            #region 5
            string pattern_5 = @"^(([01][0-9])|([2][0-3])):[0-5][0-9]:[0-5][0-9]$";
            Console.WriteLine("Введите время\nПример: часы:минуты:секунды");
            string task_5 = Console.ReadLine();
            Regex regex_5 = new Regex(pattern_5);
            if (regex_5.IsMatch(task_5))
                Console.WriteLine($"Ваше время верное: {task_5}");
            else
                Console.WriteLine("Ваше время неверное");
            #endregion

            #region 6
            string pattern_6 = @"[1-8]\d{4}$|[0][1-9]\d{3}$|[9]\d{2}[5][0]$|[9]\d{2}[0-4]\d$";
            Console.WriteLine("Введите индекс США");
            string task_6 = Console.ReadLine();
            Regex regex_6 = new Regex(pattern_6);
            if (regex_6.IsMatch(task_6))
                Console.WriteLine($"Вы ввели верный индекс США");
            else
                Console.WriteLine($"Вы ввели неверный индекс США");
            #endregion
        }
    }
}
