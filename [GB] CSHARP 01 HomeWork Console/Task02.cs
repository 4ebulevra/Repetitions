using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _GB__CSHARP_01_HomeWork_Console
{
    class Task02 : Task
    {
        private double Weight;
        private double Height;

        public Task02()
        {
            task = "Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); " +
                   "где m — масса тела в килограммах, h — рост в метрах.\n" +
                   "------------------------------------------------------------------------------ - ";
        }

        private void CollectData()
        {
            Console.Write("Введите вес(кг): ");
            Weight = double.Parse(Console.ReadLine());

            Console.Write("Введите рост(м): ");
            Height = double.Parse(Console.ReadLine());
        }
        private void PrintData()
        {
            Console.WriteLine($"Индекс массы тела: {(Weight / (Height * Height)):0.00}");
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
