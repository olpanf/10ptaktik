using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Практическая
{
    internal class Strelka
    {

        int max;
        int min;
        public Strelka(int Min, int Max)
        {
            max = Max;
            min = Min;
        }
        public ConsoleKey Strleka()
        {
            Global.Ret = 0;
            Global.Doing = 0;
            do
            {
                Console.SetCursorPosition(0, Global.position);
                Console.Write("->");

                Global.key = Console.ReadKey(false);

                if (Global.key.Key == ConsoleKey.UpArrow)
                {
                    Console.SetCursorPosition(0, Global.position);
                    Console.WriteLine("  ");
                    Global.position--;
                }
                else if (Global.key.Key == ConsoleKey.DownArrow)
                {
                    Console.SetCursorPosition(0, Global.position);
                    Console.WriteLine("  ");
                    Global.position++;
                }

                if (Global.position < min)
                {
                    Global.position++;
                }
                else if (Global.position > max)
                {
                    Global.position--;
                }

                if (Global.key.Key == ConsoleKey.Enter)
                {
                    Console.SetCursorPosition(0, Global.position);
                    Console.Write("  ");
                    return Global.key.Key;
                }
                else if (Global.key.Key == ConsoleKey.F1)
                {
                    Global.F = 1;
                    return Global.key.Key;
                }
                else if (Global.key.Key == ConsoleKey.F2)
                {
                    Global.F = 2;
                    return Global.key.Key;
                }
                else if (Global.key.Key == ConsoleKey.F10)
                {
                    Global.F = 10;
                    return Global.key.Key;
                }
                else if (Global.key.Key == ConsoleKey.S)
                {
                    return Global.key.Key;
                }
                else if (Global.key.Key == ConsoleKey.Delete)
                {
                    Global.Del = 1;
                    return Global.key.Key;
                }

            } while (Global.key.Key != ConsoleKey.Escape);

            Global.Ret = 1;
            Console.SetCursorPosition(0, Global.position);
            Console.Write("  ");
            return Global.key.Key;
        }
    }
}

