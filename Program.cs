using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    // Klassennamen wie z.B. ClientActivity
    class Program
    {
        // Konstanten sind normalerweise Felder welche während
        // der Kompilierzeit bekannt sind und danach für die gesamte Laufzeit 
        // des Programmes nicht verändert werden können.
        const double PI = 3.14159265359;
        const int weeks = 52, months = 12;
        const string birthday = "31.05.1988";



        // Methodenname wie z.B. CalculateValue
        // Methodenargumente werden klein geschrieben
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
            //--------------------------------------------------- Zahlen int, double,float
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

            //--------------------------------------------------- Text bzw. Strings
            // Deklarieren und Initialisieren der Variablen meinName
            String meinName = "Denis";
            meinName = "Not "+ meinName;    //Waren strings nicht immutable??
            string nachricht = "Mein Name ist " + meinName;
            int laengeDesStrings = nachricht.Length;
            // die ToUpper Methode gibt den String in Großschrift zurück.
            string allesGrossGeschrieben = nachricht.ToUpper();
            string allesKleinGeschrieben = nachricht.ToLower();
            Console.WriteLine(allesKleinGeschrieben);
            Console.WriteLine(allesGrossGeschrieben);
            Console.WriteLine(nachricht + " ist {0} Zeichen lang", laengeDesStrings);
            Console.WriteLine(nachricht + $" ist {laengeDesStrings} Zeichen lang");
            Console.ReadKey();

            //----------------------------------------------- Parsing - von String nach zahl konvertieren
            string myString = "15";
            string mySecondString = "13";
            int num1 = int.Parse(myString);
            int num2 = int.Parse(mySecondString);
            int resultInt = num1 + num2;
            string result = myString + mySecondString;
            Console.WriteLine(resultInt);
            Console.ReadKey();

            //--------------------------------------------------- Namensgebung
            // variable heißt wie z.B. itemCount 
            // nutze userControl statt usrCtr

            // keine Zahlen bei Variablennamen am Anfang verwenden
            int num5 = 3;

            // richtig:
            string myName;
            int year;
            bool isSaved;

            // vermeide:
            // String myName;
            // Int32 lastNum;
            // Boolean isSaved;


            //--------------------------------------------------- Implizite und Explizite Konvertierung
            // Implizite Konvertierung
            int num = 1232346;
            long bigNum = num;

            float myFloat = 13.37f;
            double myDouble = myFloat;

            // Explizite Konvertierung
            int myInt;
            double myNewDouble = 13.37;
            myInt = (int)myNewDouble;

            string myString4 = myNewDouble.ToString(); // "13.37";
            string myString2 = myString4 + "12";
            bool sunIsShining = true;

            string myBoolString = sunIsShining.ToString();

            Console.WriteLine(myBoolString);
            Console.ReadKey();


            //Herausforderung
            int entero = 1;
            bool verdadero = true;
            float flotante = 123.456f;
            double doblado = 654.321;
            //... usw

            string cadena1 = "Ich kontrolliere den Text";
            string cadena2 = "45600";
            double parseado = double.Parse(cadena2);
            Console.WriteLine(cadena1);
            Console.WriteLine(cadena2);
            double triple = 3 * parseado;
            Console.WriteLine(triple);

            //--------------------------------------------------- Konstanten
            Console.WriteLine("Mein Geburtstag ist am {0}", birthday);
            Console.ReadKey();


        }
    }
}
