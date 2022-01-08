using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _GB__CSHARP_01_HomeWork_Console
{
    internal class Task17 : Task
    {
        public Task17()
        {
            task = "Решить раннюю задачу с логинами, только логины и пароли считать из файла в массив. " +
                   "Создайте структуру Account, содержащую Login и Password.\n" +
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
            Console.Title = "Task17";
            Console.WriteLine($"Задание: {task}");
            CollectData();
            PrintData();
        }
    }
}
