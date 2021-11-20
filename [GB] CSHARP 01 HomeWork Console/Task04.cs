using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _GB__CSHARP_01_HomeWork_Console
{
    class Task04 : Task
    {
        private int X;
        private int Y;

        public Task04()
        {
            task = "Написать программу обмена значениями двух переменных:\n" +
                   "\tа) с использованием третьей переменной;\n" +
                   "\tб) *без использования третьей переменной.\n" +
                   "-------------------------------------------------------------------------------";
        }

        private void CollectData()
        {
            Console.Write("Введите целое число для переменной X: ");
            X = int.Parse(Console.ReadLine());
            Console.Write("Введите целое число для переменной Y: ");
            Y = int.Parse(Console.ReadLine());
        }

        private void PrintData()
        {
            Console.WriteLine($"\nX = {X} \t Y = {Y}");

            Console.WriteLine("\nПроводим обмен значениями без участия 3й переменной: \n" +
                              "X = X + Y\n" +
                              "Y = X - Y\n" +
                              "X = X - Y");
            X = X + Y;
            Y = X - Y;
            X = X - Y;

            Console.WriteLine($"\nX = {X} \t Y = {Y}");
            Console.WriteLine("\nПроводим обмен значениями c участием 3й переменной: \n" +
                              "Z = X\n" +
                              "X = Y\n" +
                              "Y = Z");
            int Z = X;
            X = Y;
            Y = Z;
            Console.WriteLine($"\nX = {X} \t Y = {Y}");
        }

        public override void Start()
        {
            Console.Clear();
            Console.Title = "Task04";
            Console.WriteLine($"Задание: {task}");
            CollectData();
            PrintData();
        }
    }
}

