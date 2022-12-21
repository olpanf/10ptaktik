using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _10_Практическая
{
    internal class AD : CRUD
    {
        public void Admin()
        {

            while (Global.Doing != 1)
            {
                Global.Ret = 1;
                Global.F = 0;
                Global.Del = 0;


                Read();

                int i = 2;
                int str = 3;
                if (Global.poisk == 0)
                {
                    Text.ForAdmin();
                    Text.Dob();

                    foreach (var item in Global.AllVse)
                    {
                        Console.SetCursorPosition(15, str);
                        Console.Write(item[2]);
                        Console.SetCursorPosition(30, str);
                        Console.Write(item[0]);
                        Console.SetCursorPosition(45, str);
                        Console.Write(item[1]);
                        Console.SetCursorPosition(60, str);
                        Console.Write(item[3]);
                        str += 1;
                        i += 1;
                    }
                }

                if (Global.poisk == 1)
                {
                    Text.ForAdmin();
                    Text.Dob();

                    foreach (var item in Global.SerchVse)
                    {
                        Console.SetCursorPosition(15, str);
                        Console.Write(item[2]);
                        Console.SetCursorPosition(30, str);
                        Console.Write(item[0]);
                        Console.SetCursorPosition(45, str);
                        Console.Write(item[1]);
                        Console.SetCursorPosition(60, str);
                        Console.Write(item[3]);
                        str += 1;
                        i += 1;
                        Global.poisk = 0;
                    }
                }

                Global.position = 3;
                Strelka StrelkaUsing = new Strelka(3, i);
                StrelkaUsing.Strleka();

                if (Global.Ret == 1)
                {
                    Program.Main();
                }
                else if (Global.F == 1)
                {
                    Create();
                }
                else if (Global.F == 2)
                {
                    Console.Clear();
                    Search();
                }

                if (Global.key.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Text.IA();
                    Podrobnaya();
                }
            }
        }

        public void Create()
        {
            Text.F1AT();
            Text.Dob();
            string[] ADD = new string[4];
            List<string> ADDL = new List<string>();

            while (true)
            {
                Strelka StrelkaUsing = new Strelka(2, 5);
                StrelkaUsing.Strleka();

                if (Global.key.Key == ConsoleKey.S)
                {
                    Console.Clear();
                    break;
                }
                else if (Global.Ret == 1)
                {
                    AD AdUsing = new AD();
                    AdUsing.Admin();
                }

                if (Global.position == 2)
                {
                    Console.SetCursorPosition(7, 2);
                    ADD[2] = Console.ReadLine();
                }
                else if (Global.position == 3)
                {
                    Console.SetCursorPosition(10, 3);
                    ADD[0] = Console.ReadLine();
                }
                else if (Global.position == 4)
                {
                    Console.SetCursorPosition(11, 4);
                    ADD[1] = Console.ReadLine();
                }
                else if (Global.position == 5)
                {
                    Console.SetCursorPosition(23, 5);
                    ADD[3] = Console.ReadLine();
                }
            }

            if (ADD[3] == "0")
            {
                ADD[3] = "Administrator";
            }
            else
            {
                ADD[3] = "Polsovatel";
            }

            for (int i = 0; i < 4; i++)
            {
                ADDL.Add(ADD[i]);
            }

            Global.AllVse.Add(ADDL);
            SandDs.S();
            AD AdminUsing = new AD();
            AdminUsing.Admin();
        }
        public void Read()
        {
            SandDs.Ds();
        }
        public void Update()
        {
            if (Global.position == 2)
            {
                Console.SetCursorPosition(7, 2);
                Global.PInf[2] = Console.ReadLine();
            }
            else if (Global.position == 3)
            {
                Console.SetCursorPosition(10, 3);
                Global.PInf[0] = Console.ReadLine();
            }
            else if (Global.position == 4)
            {
                Console.SetCursorPosition(11, 4);
                Global.PInf[1] = Console.ReadLine();
            }
            else if (Global.position == 5)
            {
                Console.SetCursorPosition(23, 5);
                Global.PInf[3] = Console.ReadLine();
            }

            SandDs.S();
            AD AdminUsing = new AD();
            AdminUsing.Admin();
        }
        public void Delete(int Massiv)
        {
            Global.AllVse.RemoveAt(Massiv);
            SandDs.S();
            AD AdminUsing = new AD();
            AdminUsing.Admin();
        }

        private void Podrobnaya()
        {
            int position = Global.position;
            int Massiv = position - 3;
            Global.PInf = Global.AllVse[Massiv];

            while (Global.Doing != 1)
            {
                Console.SetCursorPosition(0, 2);
                Console.Write("  ID: "); Console.WriteLine(Global.PInf[2]);
                Console.Write("  Логин: "); Console.WriteLine(Global.PInf[0]);
                Console.Write("  Пароль: "); Console.WriteLine(Global.PInf[1]);
                Console.Write("  Роль: "); Console.WriteLine(Global.PInf[3]);

                Strelka StrelkaUsing = new Strelka(2, 5);
                StrelkaUsing.Strleka();

                if (Global.F == 10)
                {
                    Update();
                }
                else if (Global.Del == 1)
                {
                    Delete(Massiv);
                }
                else if (Global.key.Key == ConsoleKey.Escape)
                {
                    AD AdminUsing = new AD();
                    AdminUsing.Admin();
                }
            }
            for (int i = 0; i < 4; i++)
            {
                Global.AllVse[Massiv] = Global.PInf;
            }
            if (Global.Ret == 1)
            {
                AD AdminUsing = new AD();
                AdminUsing.Admin();
            }
        }
        private void Search()
        {
            Global.SerchVse.Clear();
            Text.Dob();
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("Выберите, по какому пункту вы хотите произвести поиск:");
            Console.WriteLine("  ID");
            Console.WriteLine("  Логин");
            Console.WriteLine("  Пароль");
            Console.WriteLine("  Роль");

            string sear = "";
            int isear = 0;

            while (Global.Del != 1)
            {
                Strelka StrelkaUsing = new Strelka(3, 6);
                StrelkaUsing.Strleka();
                if (Global.position == 3)
                {
                    isear = 2;
                }
                else if (Global.position == 4)
                {
                    isear = 0;
                }
                else if (Global.position == 5)
                {
                    isear = 1;
                }
                else if (Global.position == 6)
                {
                    isear = 3;
                }
                Console.SetCursorPosition(0, 8);
                Console.WriteLine("Введите данные чтоб искать");
                sear = Console.ReadLine();
                foreach (var item in Global.AllVse)
                {
                    if (item[isear] == sear)
                    {
                        Global.SerchVse.Add(item);
                    }
                }
                Global.poisk = 1;
                AD AdminUsing = new AD();
                AdminUsing.Admin();
            }
        }
    }
}
