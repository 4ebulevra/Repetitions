using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _GB__CSHARP_01_HomeWork_Console
{
    class Task14 : Task
    {
        public Task14()
        {
            task = "*Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. " +
                   "Предусмотреть методы сложения, вычитания, умножения и деления дробей.* Написать программу, " +
                   "демонстрирующую все разработанные элементы класса.\n" +
                   "* Добавить свойства типа int для доступа к числителю и знаменателю;\n" +
                   "*Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;\n" +
                   "**Добавить проверку, чтобы знаменатель не равнялся 0. " +
                   "Выбрасывать исключение ArgumentException(\"Знаменатель не может быть равен 0\");\n" +
                   "***Добавить упрощение дробей." +
                   "-------------------------------------------------------------------------------";
        }

        private void CollectData()
        {

        }

        private void PrintData()
        {

        }

        public override void Start()
        {
            Console.Clear();
            Console.Title = "Task14";
            Console.WriteLine($"Задание: {task}");
            CollectData();
            PrintData();

        }
    }
}
