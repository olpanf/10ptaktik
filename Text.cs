using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Практическая
{
    internal class Text
    {
        public static void Nach()
        {
            Console.Clear();

            Console.SetCursorPosition(40, 0);
            Console.WriteLine("Добро пожаловать в Магазин");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.Write("  Логин: ");
            Console.SetCursorPosition(0, 3);
            Console.Write("  Пароль: ");
            Console.SetCursorPosition(0, 4);
            Console.Write("  Авторизоваться");
        }

        public static void ForAdmin()
        {
            Console.Clear();

            Console.SetCursorPosition(15, 2);
            Console.Write("ID");
            Console.SetCursorPosition(30, 2);
            Console.Write("Логин");
            Console.SetCursorPosition(45, 2);
            Console.Write("Пароль");
            Console.SetCursorPosition(60, 2);
            Console.Write("Роль");

            for (int i = 2; i < 12; i++)
            {
                Console.SetCursorPosition(75, i);
                Console.Write("|");
            }

            Console.SetCursorPosition(80, 2);
            Console.Write("F1 - Добавить запись");
            Console.SetCursorPosition(80, 3);
            Console.Write("F2 - Найти запись");
        }

        public static void Dob()
        {
            Console.SetCursorPosition(30, 0);
            Console.Write("Добро пожаловать, " + Global.Chel[0]);
            Console.SetCursorPosition(70, 0);
            Console.Write("Роль: " + Global.Chel[3]);

            Console.SetCursorPosition(0, 1);
            for (int i = 0; i < 111; i++)
            {
                Console.Write("-");
            }
        }

        public static void F1AT()
        {
            Console.Clear();
            for (int i = 2; i < 12; i++)
            {
                Console.SetCursorPosition(75, i);
                Console.Write("|");
            }

            Console.SetCursorPosition(80, 2);
            Console.Write("0 - Администратор                    ");
            Console.SetCursorPosition(80, 4);
            Console.Write("                                     ");
            Console.SetCursorPosition(80, 5);
            Console.Write("S - Сохранение                       ");
            Console.SetCursorPosition(80, 6);
            Console.Write("ESC - В меню                         ");

            Console.SetCursorPosition(0, 2);
            Console.WriteLine("  ID:                           ");
            Console.WriteLine("  Логин:                        ");
            Console.WriteLine("  Пароль:                       ");
            Console.WriteLine("  Роль:                         ");
        }

        public static void IA()
        {
            for (int i = 2; i < 12; i++)
            {
                Console.SetCursorPosition(75, i);
                Console.Write("|");
            }

            Console.SetCursorPosition(80, 2);
            Console.Write("F10 - Изменить пункт                               ");
            Console.SetCursorPosition(80, 3);
            Console.Write("DEL - Удалить запись                               ");
            Console.SetCursorPosition(80, 4);
            Console.Write("ESC - Вернуться в меню                             ");

            Text.Dob();
        }
    }
}
