using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        // Einstiegspunkt für das Programm
        static void Main(string[] args)
        {
            /// BackgroundColor ist ein Property von Console. wir setzen ihr eine Wert aus den Enum ConsoleColor.
            // Setzt die Hintergrundfarbe der Konsole
            Console.BackgroundColor = ConsoleColor.DarkGray;
            // Setzt die Schriftfarbe der Konsole
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            // Console.WriteLine("Hallo Welt!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hallo Andrés!");
            Console.ReadKey();

             /*
             * Ich bin ein
             * sehr
             * langer Kommentar
             **/
        }
    }
}
