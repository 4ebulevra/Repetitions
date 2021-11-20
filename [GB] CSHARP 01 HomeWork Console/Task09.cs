using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _GB__CSHARP_01_HomeWork_Console
{
    class Task09 : Task
    {
        private double Weight;
        private double Height;
        private int IMT;

        public Task09()
        {
            task = "Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, " +
                   "нужно ли человеку похудеть, набрать вес или всё в норме.\n" +
                   "*Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.\n" +
                   "-------------------------------------------------------------------------------";
        }
        private void CollectData()
        {
            Console.Write("Введите вес(кг): ");
            Weight = double.Parse(Console.ReadLine());

            Console.Write("Введите рост(м): ");
            Height = double.Parse(Console.ReadLine());

            IMT = (int) (Weight / (Height * Height));
        }

        private void PrintData()
        {
            Console.WriteLine(IMT);
        }

        public override void Start()
        {
            Console.Clear();
            Console.Title = "Task09";
            Console.WriteLine($"Задание: {task}");
            CollectData();
            PrintData();
        }
    }
}
