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
            task = "Задание" +
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