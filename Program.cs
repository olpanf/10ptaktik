using static System.Net.Mime.MediaTypeNames;

namespace _10_Практическая
{
    internal class Program
    {
        /*А я говорил*/
        public static void Main()
        {
            while (Global.AddDF != 1)
            {
                List<string> a = new List<string>();
                Directory.CreateDirectory("D:\\10 Практическая");
                a.Add("admin");
                a.Add("admin");
                a.Add("1");
                a.Add("Administrator");
                Global.AllVse.Add(a);
                SandDs.S();
                Global.AddDF = 1;
            }
            Text.Nach();

            while (Global.Doing != 1)
            {
                Strelka StrelkaUsing = new Strelka(2, 4);
                StrelkaUsing.Strleka();

                AvtoriZ();
            }
        }

        private static void AvtoriZ()
        {
            if (Global.position == 2)
            {
                Console.SetCursorPosition(9, Global.position);
                Console.WriteLine("                                                                                                    ");

                Console.SetCursorPosition(9, Global.position);
                Who.Login();
            }
            else if (Global.position == 3)
            {
                Console.SetCursorPosition(10, Global.position);
                Console.WriteLine("                                                                                                    ");

                Console.SetCursorPosition(10, Global.position);
                Who.Password();
            }
            else if (Global.position == 4)
            {
                Who.Avtoriz();
            }
        }
    }
}