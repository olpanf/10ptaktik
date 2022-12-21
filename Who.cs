using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Практическая
{
    internal class Who
    {
        public static void Login()
        {
            Global.login = "";
            Global.login = Console.ReadLine();
        }

        public static void Password()
        {
            Global.password = "";
            Global.password = string.Empty;
            ConsoleKey key;

            do
            {
                var keyInfo = Console.ReadKey(intercept: true);
                key = keyInfo.Key;

                if (key == ConsoleKey.Backspace && Global.password.Length > 0)
                {
                    Console.Write("\b \b");
                    Global.password = Global.password[0..^1];
                }
                else if (!char.IsControl(keyInfo.KeyChar))
                {
                    Console.Write("*");
                    Global.password += keyInfo.KeyChar;
                }
            } while (key != ConsoleKey.Enter);
        }

        public static void Avtoriz()
        {
            SandDs.Ds();
            List<List<string>> Vse = Global.AllVse;

            foreach (var item in Vse)
            {
                if (item[0] == Global.login && item[1] == Global.password)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        Global.Chel[i] = item[i];
                    }

                    Global.Doing = 0;

                    Roles.UseRoles();
                }

            }
            Console.SetCursorPosition(0, 4);
            Console.WriteLine("   Авторизоваться");

            Console.SetCursorPosition(0, 6);
            Console.WriteLine(" Такого пользователя нет");
        }
    }
}
