using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _GB__CSHARP_01_HomeWork_Console
{
    class Task12 : Task
    {
        private int summ;
        public Task12()
        {
            summ = 0;
            task = "С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). " +
                   "Требуется подсчитать сумму всех нечётных положительных чисел. " +
                   "Сами числа и сумму вывести на экран, используя tryParse.\n" +
                   "-------------------------------------------------------------------------------";
        }

        private void CollectData()
        {
            int input = 0;
            while (true)
            {
                while (true)
                {
                    Console.Write("Введите цело положительное число или 0 для подсчёта суммы введёных нечётных чисел: ");
                    if (int.TryParse(Console.ReadLine(), out input) && input >= 0) break;
                    Console.WriteLine("Ввод некорректен!");
                }
                if (input == 0) break;
                if (input % 2 == 1) summ = input + summ;
            }

        }

        private void PrintData()
        {
            Console.WriteLine($"Сумма всех введённых нечётных положительных чисел: {summ}");
        }

        public override void Start()
        {
            Console.Clear();
            Console.Title = "Task12";
            Console.WriteLine($"Задание: {task}");
            CollectData();
            PrintData();

        }
    }
}
