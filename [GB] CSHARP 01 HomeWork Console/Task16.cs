using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _GB__CSHARP_01_HomeWork_Console
{
    internal class Task16 : Task
    {
        public Task16()
        {
            task = "Дописать класс для работы с одномерным массивом. Реализовать конструктор, " +
                   "создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом. " +
                   "Создать свойство Sum, которое возвращает сумму элементов массива, " +
                   "метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива(старый массив, остается без изменений), " +
                   "метод Multi, умножающий каждый элемент массива на определённое число, " +
                   "свойство MaxCount, возвращающее количество максимальных элементов.\n" +
                   "**Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки\n" +
                   "***Подсчитать частоту вхождения каждого элемента в массив (коллекция Dictionary< int,int>)\n" +
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
            Console.Title = "Task16";
            Console.WriteLine($"Задание: {task}");
            CollectData();
            PrintData();
        }
    }
}
