using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _GB__CSHARP_01_HomeWork_Console
{
    class Task11 : Task
    {
        private int a;
        private int b;
        public Task11()
        {
            task = "Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).\n" +
                   "*Разработать рекурсивный метод, который считает сумму чисел от a до b.\n" +
                   "-------------------------------------------------------------------------------";
        }

        private void CollectData()
        {
            Console.Write("Введите число а: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите число b: ");
            b = int.Parse(Console.ReadLine());
        }

        private void PrintList(int x, int y)
        {
            Console.WriteLine(x);
            if (x < y) PrintList(x + 1, y);
        }

        private int Sum(int x, int y)
        {
            return y == x ? y : Sum(x, y - 1) + y;
        }

        public override void Start()
        {
            Console.Clear();
            Console.Title = "Task11";
            Console.WriteLine($"Задание: {task}");
            CollectData();
            Console.WriteLine($"Сумма чисел в диапазоне: {Sum(a < b ? a : b, b > a ? b : a)}");
            Console.Write("Нажмите Enter, что бы вывести список чисел в диапазоне...");
            Console.ReadLine();
            PrintList(a < b ? a : b, b > a ? b : a);
        }
    }
}
