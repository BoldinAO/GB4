//Болдин
/*
3. Решить задачу с логинами из предыдущего урока, только логины и пароли считать из файла в массив.
Создайте структуру Account, содержащую Login и Password.
*/
using System;
using System.Collections.Generic;
using System.IO;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            Account t = new Account();
            Console.Write(t.LogIn("1", "3"));
            Console.ReadKey();
        }
    }

    class Account
    {
        string pathLogin = @"C:\\Users\\Energy\\Desktop\\repo\\GBHW\\HW3\\login.txt";
        string pathPassword = @"C:\\Users\\Energy\\Desktop\\repo\\GBHW\\HW3\\password.txt";

        private List<string> login = new List<string>() { };
        private List<string> password = new List<string>() { };

        public string LogIn(string _login, string _password)
        {
            SetArr(pathLogin, login);
            SetArr(pathPassword, password);
            foreach (string l in login)
            {
                if (_login != l)
                    continue;
                else
                {
                    foreach (string p in password)
                    {
                        if (_password == p)
                        {
                            return "Вы вошли";
                        }
                    }
                }
            }
            return "Не верный логин или пароль";
        }

        void SetArr(string path, List<string> arr)
        {
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        arr.Add(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
