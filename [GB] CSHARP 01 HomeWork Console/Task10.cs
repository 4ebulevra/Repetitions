using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _GB__CSHARP_01_HomeWork_Console
{
    class Task10 : Task
    {
        private int count;
        public Task10()
        {
            count = 0;
            task = "Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. " +
                   "«Хорошим» называется число, которое делится на сумму своих цифр.\n" +
                   "*Реализовать подсчёт времени выполнения программы, используя структуру DateTime.\n" +
                   "-------------------------------------------------------------------------------";
        }

        private bool CheckGoodNum(int x)
        {
            int num = x;
            int sum = 0;
            while (true)
            {
                if (x <= 0)
                {
                    break;
                }
                else if (x > 10)
                {
                    sum = sum + x % 10;
                    x = x / 10;
                }
                else
                {
                    sum = sum + x;
                    break;
                }
            }
            if (sum > 0 && (num % sum) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void PrintData()
        {
            Console.Write("Введите верхний диапазон поиска хороших чисел: ");
            int maxValue = int.Parse(Console.ReadLine());
            Console.WriteLine($"Производится поиск хороших чисел в диапазоне от 1 до {maxValue}...");
            var a = DateTime.Now;
            for (int i = 1; i < maxValue; i++)
            {
                if (CheckGoodNum(i)) count++;
            }
            var b = DateTime.Now;
            Console.WriteLine($"Найдено хороших чисел: {count}\n" +
                              $"Затрачено времени: {(b - a).ToString()}");
        }

        public override void Start()
        {
            Console.Clear();
            Console.Title = "Task10";
            Console.WriteLine($"Задание: {task}");
            PrintData();
        }
    }
}
