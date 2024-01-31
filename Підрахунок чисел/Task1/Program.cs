using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            double first, second, suma;
            Console.Write("Введіть перше значення: ");
            while (!double.TryParse(Console.ReadLine(), out first))
            {
                Console.WriteLine("Ви ввели не правильне значення!");
                Console.Write("Введіть перше значення: ");
            }

            Console.Write("Введіть друге значення: ");
            while (!double.TryParse(Console.ReadLine(), out second))
            {
                Console.WriteLine("Ви ввели не правильне значення!");
                Console.Write("Введіть друге значення: ");
            }
            suma = first + second;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Сума чисел: {suma}");
            Console.ReadKey();  

        }
    }
}
