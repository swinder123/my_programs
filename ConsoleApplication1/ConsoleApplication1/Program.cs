using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static string n = "---", playerA = "", playerB = "";
        public static void Main(string[] args)
        {

            //this is the race game
            Random rnd = new Random();
            Program pg = new Program();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            Console.ResetColor();
            pg.turnPlayerA();



        }
        public void turnPlayerA()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n Player A turn");
            Console.ResetColor();

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n Player B turn *");
            Console.ResetColor();

            Console.WriteLine("\n Press Enter to throw Dice");
            Random rnd2 = new Random();
            int z = rnd2.Next(1, 6);

            for (int j = 0; j < z; j++)
            {
                playerA = n + playerA;


            }
            if (playerA.Length >= Console.WindowWidth)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n Player A wins");
                Console.ResetColor();
                Console.WriteLine("\n Press any key to exit");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n" + playerA + "A");
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n" + playerB + "B");
                Console.ResetColor();

            }
            Console.ReadKey();
            Console.Clear();
            turnPlayerB();
        }
        public void turnPlayerB()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n Player A turn *");
            Console.ResetColor();

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n Player B turn");
            Console.ResetColor();
            Console.WriteLine("\n Press Enter to throw Dice");
            Random rnd2 = new Random();
            int z = rnd2.Next(1, 6);

            for (int j = 0; j < z; j++)
            {
                playerB = n + playerB;


            }
            if (playerB.Length >= Console.WindowWidth)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n Player B wins");
                Console.ResetColor();
                Console.WriteLine("\n Press any key to exit");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n" + playerA + "A");
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n" + playerB + "B");
                Console.ResetColor();

            }
            Console.ReadKey();
            Console.Clear();
            turnPlayerA();
        }
    }
}

