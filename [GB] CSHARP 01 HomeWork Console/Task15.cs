﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _GB__CSHARP_01_HomeWork_Console
{
    class Task15 : Task
    {
        public Task15()
        {
            task = "Дан целочисленный массив из 20 элементов. " +
                   "Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно. " +
                   "Заполнить случайными числами.Написать программу, позволяющую найти и вывести количество пар элементов массива, " +
                   "в которых только одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих элемента массива. " +
                   "Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.Реализуйте задачу в виде статического класса StaticClass;\n" +
                   "а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;\n" +
                   "б) *Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;\n" +
                   "в) **Добавьте обработку ситуации отсутствия файла на диске.\n" +
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
            Console.Title = "Task15";
            Console.WriteLine($"Задание: {task}");
            CollectData();
            PrintData();
        }
    }
}
