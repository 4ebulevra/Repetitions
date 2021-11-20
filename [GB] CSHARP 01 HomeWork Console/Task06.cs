using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _GB__CSHARP_01_HomeWork_Console
{
    class Task06 : Task
    {
        private int number;
        public Task06()
        {
            number = new int();
            task = "Написать метод подсчета количества цифр числа.\n" +
                   "-------------------------------------------------------------------------------";
        }
        private void CollectData()
        {
            while (true)
            {
                Console.Write("Введитите целое положительное число: ");
                if (int.TryParse(Console.ReadLine(), out number)) if (number > 0) break;
            }

        }

        private int Nums(int x)
        {
            if (x < 10) return 1;
            return 1 + Nums(x / 10);
        }

        private void PrintData()
        {
            Console.Write($"В заданном числе знаков: {Nums(number)}");
        }

        public override void Start()
        {
            Console.Clear();
            Console.Title = "Task06";
            Console.WriteLine($"Задание: {task}");
            CollectData();
            PrintData();
        }
    }
}
