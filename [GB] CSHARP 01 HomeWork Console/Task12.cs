using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _GB__CSHARP_01_HomeWork_Console
{
    class Task12 : Task
    {
        public Task12()
        {
            task = "С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). " +
                   "Требуется подсчитать сумму всех нечётных положительных чисел. " +
                   "Сами числа и сумму вывести на экран, используя tryParse.\n" +
                   "-------------------------------------------------------------------------------";
        }

        private void CollectData()
        {
            Console.Write("Введите цело положительное число или 0 для подсчёта суммы введёных нечётных чисел: ");
        }

        private void PrintData()
        {

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
