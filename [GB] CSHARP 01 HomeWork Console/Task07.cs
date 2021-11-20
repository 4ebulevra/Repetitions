using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _GB__CSHARP_01_HomeWork_Console
{
    class Task07 : Task
    {
        private int sum;
        public Task07()
        {
            sum = 0;
            task = "С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.\n" +
                   "-------------------------------------------------------------------------------";
        }
        private void CollectData()
        {
            int number = 0;
            while (true)
            {
                Console.Write("Введитите целое положительное число или 0 для подсчёта суммы введённых чисел: ");
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    if (number == 0) break;
                    if (number > 0 && number % 2 == 1) sum = sum + number;
                }

            }
        }

        private void PrintData()
        {
            Console.WriteLine($"Сумма введённых чисел: {sum}");
        }

        public override void Start()
        {
            Console.Clear();
            Console.Title = "Task07";
            Console.WriteLine($"Задание: {task}");
            CollectData();
            PrintData();
        }
    }
}
