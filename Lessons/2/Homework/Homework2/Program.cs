using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Как то так
            int a = 0; int b = 0;           
            Console.WriteLine("Введи 1 число");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введи 2 число");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выбери операцию");
            Console.WriteLine("\t1 - Плюс");
            Console.WriteLine("\t2 - Минус");
            Console.WriteLine("\t3 - Умножить");
            Console.WriteLine("\t4 - Делить");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine($"Сумма равна{(a + b)}");
                    break;
                case "2":                  
                    Console.WriteLine($"Вычетание равно {(a - b)}");
                    break;
                case "3":
                    Console.WriteLine($"Умножение равно {(a * b)}");
                    break;
                case "4":
                    Console.WriteLine($"Деление равно {(a / b)}");
                    break;
            }
            Console.Write("Закрой меня =)");
            Console.ReadKey();
        }
    }
}