using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyStruct;

namespace MyStruct
{
    public class Point
    {
        public double x;
        public double y;
    }
}

namespace _GB__CSHARP_01_HomeWork_Console
{
    class Task03 : Task
    {
        private Point a, b;

        public Task03()
        {
            task = "Написать программу, которая подсчитывает расстояние между точками " +
                   "с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). " +
                   "Вывести результат, с двумя знаками после запятой; " +
                   "*Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.\n" +
                   "-------------------------------------------------------------------------------";
            a = new Point();
            b = new Point();
        }

        private void CollectData()
        {
            Console.Write("Введит X для точки \"A\": ");
            a.x = double.Parse(Console.ReadLine());
            Console.Write("Введит Y для точки \"A\": ");
            a.y = double.Parse(Console.ReadLine());
            Console.Write("Введит X для точки \"B\": ");
            b.x = double.Parse(Console.ReadLine());
            Console.Write("Введит Y для точки \"B\": ");
            b.y = double.Parse(Console.ReadLine());
        }

        private void PrintData()
        {
            Console.WriteLine($"Расстояние между точкой A(x = {a.x} _ y = {a.y}) и точкой B(x = {b.x} - y = {b.y}) = " +
                              $"{Math.Sqrt(Math.Pow(b.x - a.x, 2) + Math.Pow(b.y - a.y, 2)):00.00}");
        }

        public override void Start()
        {
            Console.Clear();
            Console.Title = "Task02";
            Console.WriteLine($"Задание: {task}");
            CollectData();
            PrintData();
        }
    }
}
