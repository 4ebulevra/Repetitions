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
        private string stage;

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
            if (IMT < 16)
            {
                stage =  $"выраженный дефицит массы тела, необходимл набрать {(21 * (Height * Height)) - Weight}кг.";
            }
            else if (IMT < 18)
            {
                stage = $"недостаточная масса тела, необходимл набрать {(21 * (Height * Height)) - Weight}кг.";
            }
            else if (IMT < 25)
            {
                stage = $"ваш вес в норме.";
            }
            else if (IMT < 30)
            {
                stage = $"Избыточная масса тела (предожирение), необходимл сбросить {Weight - (21 * (Height * Height))}кг.";
            }
            else if (IMT < 35)
            {
                stage = $"ожирение 1 степени, необходимл сбросить {Weight - (21 * (Height * Height))}кг.";
            }
            else if (IMT < 40)
            {
                stage = $"ожирение 2 степени, необходимл сбросить {Weight - (21 * (Height * Height))}кг.";
            }
            else
            {
                stage = $"ожирение 3 степени, необходимл сбросить {Weight - (21 * (Height * Height))}кг.";
            }

            Console.WriteLine($"Ваш индекс: {IMT}, {stage}");
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
