using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COMPLEX;

namespace COMPLEX
{
    class Complex
    {
        //Вещественная часть
        private double re;
        public double Re
        {
            get { return re; }
        }

        //Мнимая часть
        private double im;
        public double Im
        {
            get { return Im; }
        }

        /// <summary>
        /// Конструктор комплексного числа
        /// </summary>
        /// <param name="a">Вещественная часть</param>
        /// <param name="b">Мнимая часть</param>
        public Complex(double a, double b)
        {
            re = a;
            im = b;
        }

        public Complex Addition(Complex a, Complex b)
        {
            return new Complex(a.Re + b.Re, a.Im + b.Im);
        }
        public override string ToString()
        {
            if (im > 0.0)
            {
                return $"{re} + {im}i";
            } else if (im < 0.0)
            {
                return $"{re} {im}i";
            } else
            { 
                return $"{re}"; 
            }
        }
    }
}

namespace _GB__CSHARP_01_HomeWork_Console
{
    class Task13 : Task
    {
        Complex a;
        Complex b;
        public Task13()
        {
            task = "Написать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.\n" +
                   "Реализовать диалог с пользователем, используя switch демонстрирующий работу класса.\n" +
                   "-------------------------------------------------------------------------------";
        }

        private void CollectData()
        {
            double a1, a2, b1, b2;
            do
            {
                Console.Write("Введите вещественную часть числа (a): ");
            } while (!double.TryParse(Console.ReadLine(), out a1));
            do
            {
                Console.Write("Введите мнимую часть числа (a): ");
            } while (!double.TryParse(Console.ReadLine(), out a2));
            a = new Complex(a1, a2);

            do
            {
                Console.Write("Введите вещественную часть числа (b): ");
            } while (!double.TryParse(Console.ReadLine(), out b1));
            do
            {
                Console.Write("Введите мнимую часть числа (b): ");
            } while (!double.TryParse(Console.ReadLine(), out b2));
            b = new Complex(b1, b2);

            Console.Write($"Доступные операции:\n" +
                          $"(1) Сложение комплексного числа {a} и комплексного числа {b}.\n");
            Console.Write("Введите номер желаемой операции: ");
        }

        private void PrintData()
        {

        }

        public override void Start()
        {
            Console.Clear();
            Console.Title = "Task13";
            Console.WriteLine($"Задание: {task}");
            CollectData();
            PrintData();

        }
    }
}
