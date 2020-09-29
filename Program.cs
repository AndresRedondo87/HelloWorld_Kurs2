﻿using System;
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
            //Console.ReadKey();
            /*
            * Ich bin ein
            * sehr
            * langer Kommentar
            **/
            // Deklarieren und Initialisieren der Variable wert1
            int wert1 = 25;
            // Deklarieren
            int wert2;
            // Initialisieren
            wert2 = 15;
            int summe = wert1 + wert2;
            // Deklarieren mehrere Variablen in einer Zeile
            int wert3, wert4, wert5;

            // Verwendung von Gleitkommazahlen mit Double
            double d1 = 333.5;
            double d2 = 1.337;
            double ergebnis = d1 / d2;

            // Verwendung von Gleitkommazahlen mit Float
            float f1 = 1.337f;

            Console.WriteLine("Ergebnis ist " + ergebnis);
            Console.ReadKey();
        }
    }
}
