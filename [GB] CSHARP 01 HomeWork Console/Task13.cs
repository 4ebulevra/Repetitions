using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _GB__CSHARP_01_HomeWork_Console
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
            get { return im; }
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

        public static Complex Addition(Complex a, Complex b)
        {
            return new Complex(a.Re + b.Re, a.Im + b.Im);
        }
        public static Complex Subtraction(Complex a, Complex b)
        {
            return new Complex(a.Re - b.Re, a.Im - b.Im);
        }
        public static Complex Multiplication(Complex a, Complex b)
        {
            return new Complex(a.Re * b.Re, (a.Im * b.Re) + (a.Re * b.Im));
        }

        public override string ToString()
        {
            if (im > 0.0)
            {
                return $"{re} + {im}i";
            }
            else if (im < 0.0)
            {
                return $"{re} {im}i";
            }
            else
            {
                return $"{re}";
            }
        }
    }

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

            int switcher;
            do
            {
                Console.Write($"\nДоступные операции:\n" +
                              $"(1) Сложение комплексного числа {a} и комплексного числа {b}.\n" +
                              $"(2) Вычитание комплексного числа {b} из комплексного числа {a}.\n" +
                              $"(3) Произведение комплексного числа {a} и комплексного числа {b}.\n" +
                              $"(любое другое число) для выхода.\n");
                Console.Write("Введите номер желаемой операции: ");
            } while (!int.TryParse(Console.ReadLine(), out switcher));
            switch (switcher)
            {
                case 1:
                    Console.WriteLine($"{a} + {b} = {Complex.Addition(a, b)}");
                    break;
                case 2:
                    Console.WriteLine($"{a} - {b} = {Complex.Subtraction(a, b)}");
                    break;
                case 3:
                    Console.WriteLine($"{a} x {b} = {Complex.Multiplication(a, b)}");
                    break;
                default:
                    break;
            }

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
