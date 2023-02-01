using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    public class Standart
    {
        public static void Print(string s, int x, int y, ConsoleColor fg = ConsoleColor.DarkYellow)
        {
            Console.ForegroundColor = fg;
            Console.SetCursorPosition(x, y);
            Console.Write(s);
        }

        public static void HLine(string sym, int x, int y, int length)
        {
            for (int i = 0; i < length; i++)
            {
                Print(sym, x + i, y);
            }
        }

        public static void VLine(string sym, int x, int y, int length)
        {
            for (int i = 0; i < length; i++)
            {
                Print(sym, x, y + i);
            }
        }

        public static void Rectangle(int x, int y, int h, int w)
        {
            Print("╔", x, y);
            HLine("═", x + 1, y, w - 2);
            Print("╗", x + w - 1, y);
            VLine("║", x + w - 1, y + 1, h - 2);
            VLine("║", x, y + 1, h - 2);
            Print("╚", x, y + h - 1);
            HLine("═", x + 1, y + h - 1, w - 2);
            Print("╝", x + w - 1, y + h - 1);

        }
    }

    class UserInterface
    {
        public static void Screen()
        {
            Standart.Rectangle(4, 4, 5, 10);
            Standart.Rectangle(15, 4, 5, 10);
            Standart.Rectangle(26, 4, 5, 10);
            Standart.Rectangle(3, 3, 7, 34);
        }

        public static void Game()
        {
            string[] sym_list = { "♥", "☼", "♠", "♫", "♂", "◘" };
            var rand = new Random();
            int n1, n2, n3;
            n1 = rand.Next(sym_list.Length);
            n2 = rand.Next(sym_list.Length);
            n3 = rand.Next(sym_list.Length);
            Thread.Sleep(500);
            Standart.Print(sym_list[n1], 8, 6, ConsoleColor.White);
            Thread.Sleep(1000);
            Standart.Print(sym_list[n2], 19, 6, ConsoleColor.White);
            Thread.Sleep(1000);
            Standart.Print(sym_list[n3], 30, 6, ConsoleColor.White);
            Standart.Print("", 20, 20);
        }
    }
}
