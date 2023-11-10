using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace proverka1
{
    internal class strelka
    {
        public static int show(int minstrelka, int maxstrelka)
        {
            int pos = minstrelka;
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey();
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("  ");
                if (key.Key == ConsoleKey.UpArrow)
                {
                    if (pos == minstrelka)
                    {
                        pos = maxstrelka;
                    }
                    pos--;
                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    if (pos == maxstrelka)
                    {
                        pos = minstrelka;
                    }
                    pos++;
                }
                if (key.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    return -1;
                }
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");
            } while (key.Key != ConsoleKey.Enter);
            return pos;
        }
    }
}
