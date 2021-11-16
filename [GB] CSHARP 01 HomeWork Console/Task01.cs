using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _GB__CSHARP_01_HomeWork_Console
{

    public class Task01 : Task
    {


        private string Name;
        private string Surname;
        private int Age;
        private int Height;
        private double Weight;

        public Task01()
        {
            task = "Написать программу «Анкета»." +
                   " Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес)." +
                   " В результате вся информация выводится в одну строчку:\n" +
                   "-------------------------------------------------------------------------------";
        }

        private void CollectData()
        {
            Console.Write("Введите имя: ");
            Name = Console.ReadLine();

            Console.Write("Введите фамилию: ");
            Surname = Console.ReadLine();

            Console.Write("Введите возраст: ");
            Age = int.Parse(Console.ReadLine());

            Console.Write("Введите рост(см): ");
            Height = int.Parse(Console.ReadLine());

            Console.Write("Введите вес: ");
            Weight = double.Parse(Console.ReadLine());
        }

        private void PrintData()
        {
            Console.WriteLine($"{Name} {Surname}; возраст(лет): {Age}; рост(см): {Height}; вес: {Weight}.");
        }

        public override void Start()
        {
            Console.Clear();
            Console.Title = "Task01";
            Console.WriteLine($"Задание: {task}");
            CollectData();
            PrintData();
        }
    }
}
