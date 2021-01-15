using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите последнее число");
            int lastNum = Convert.ToInt32(Console.ReadLine());
            var i=0;
            
            while (i<=lastNum)
            {
                var multiply=firstNum*i;
                Console.WriteLine($"{firstNum}*{i}={multiply}");
                i++;
            }
            Console.ReadLine();
        }
    }
}
//Напишите программу, которая выводит на консоль таблицу умножения