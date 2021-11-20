using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _GB__CSHARP_01_HomeWork_Console
{
    class Task08 : Task
    {
        private string login;
        private string pass;
        private int tryAuth;
        private bool passed;
        public Task08()
        {
            passed = false;
            tryAuth = 3;
            task = "Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. " +
                   "На выходе истина, если прошел авторизацию, и ложь, если не прошел(Логин: root, Password: GeekBrains).\n" +
                   "Используя метод проверки логина и пароля,написать программу: пользователь вводит логин и пароль, " +
                   "программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками." +
                   "-------------------------------------------------------------------------------";
        }

        private bool CheckAuth(string _login, string _pass)
        {
            if (_login == "root" && _pass == "GeekBrains") return true;

            return false;
        }


        private void PrintData()
        {
            if (passed)
            {
                Console.WriteLine("Данные для входа верны!");
            }
            else
            {
                Console.WriteLine("Данные для входа НЕверны!");
            }
        }

        public override void Start()
        {
            Console.Clear();
            Console.Title = "Task08";
            Console.WriteLine($"Задание: {task}");

            
            do
            {
                Console.Write("Введите логин: ");
                login = Console.ReadLine();
                Console.Write("Введите пароль: ");
                pass = Console.ReadLine();
                if (CheckAuth(login, pass))
                {
                    passed = true;
                    break;
                }
                tryAuth = tryAuth - 1;
            } while (tryAuth > 0);

            PrintData();
        }
    }
}
