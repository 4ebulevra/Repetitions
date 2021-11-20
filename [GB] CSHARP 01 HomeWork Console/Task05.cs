using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _GB__CSHARP_01_HomeWork_Console
{
    class Task05 : Task
    {
        private string name;
        private string surname;
        private string city;
        private string data;

        public Task05()
        {
            task = "Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.\n" +
                   "*Сделать задание, только вывод организовать в центре экрана.\n" +
                   "**Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).\n" +
                   "-------------------------------------------------------------------------------";
        }

        private void CollectData()
        {
            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            surname = Console.ReadLine();
            Console.Write("Введите город: ");
            city = Console.ReadLine();

            data = $"{name} {surname} г.{city}";
        }

        /// <summary>
        /// Вывод по центру
        /// </summary>
        private void PrintData()
        {
            Console.SetCursorPosition((Console.BufferWidth / 2) - (data.Length / 2), 15);
            Console.Write(data);
        }

        /// <summary>
        /// Вывод по указанным координатам
        /// </summary>
        /// <param name="text">строка для вывода</param>
        /// <param name="x">номер столбца</param>
        /// <param name="y">номер строки</param>
        private void PrintData(string text, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(data);
        }

        public override void Start()
        {
            Console.Clear();
            Console.Title = "Task05";
            Console.WriteLine($"Задание: {task}");
            CollectData();
            PrintData();
            Console.WriteLine("\n\nНажмите Enter для продолжения...");

            Console.ReadLine();

            Console.Clear();
            Console.WriteLine($"Вывод по указанным координатам.");
            Console.Write($"Введите X(от 0 до {Console.BufferWidth}): ");

            int x = int.Parse(Console.ReadLine());
            if (x < 0) x = 0;
            if (x > Console.BufferWidth) x = Console.BufferWidth;
            Console.Write($"Введите Y(от 3 до {Console.BufferHeight}): ");

            int y = int.Parse(Console.ReadLine());
            if (y < 3) y = 3;
            if (y > Console.BufferHeight) y = Console.BufferHeight;

            PrintData(data, x, y);
        }
    }
}
