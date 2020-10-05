using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

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
            //Console.ReadKey();

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
            //Console.ReadKey();

            //----------------------------------------------- Parsing - von String nach zahl konvertieren
            string myString = "15";
            string mySecondString = "13";
            int num1 = int.Parse(myString);
            int num2 = int.Parse(mySecondString);
            int resultInt = num1 + num2;
            string result = myString + mySecondString;
            Console.WriteLine(resultInt);
            //Console.ReadKey();

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
            //Console.ReadKey();


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
            //Console.ReadKey();
            Console.WriteLine();


            //------------------------------------------------------------------------------METHODEN
            //--------------------------------------------------- Void Methoden
            WriteSomething();
            WriteSomething();
            WriteSomething();
            string myArgument = "Hallo, ich bin super Text";
            WriteSomethingSpecific(myArgument);

            //--------------------------------------------------- Methoden Mit Rueckgabewert und Parametern
            //int result = Add(15, 23);
            Console.WriteLine(Multiply(32, 55));
            Console.WriteLine(Divide(13, 23));
            Console.WriteLine(Add(15, 23));
            Console.WriteLine(Add(Add(Add(2,2),6), 10));

            string amigo1 = "Pedro";
            string amigo2 = "Paco";
            string amigo3 = "Francisco";
            SaludaAMiAmigo(amigo1);
            SaludaAMiAmigo(amigo2);
            SaludaAMiAmigo(amigo3);
            SaludaATodosMisAmigos(amigo1, amigo2, amigo3);

            Console.WriteLine(Calculate());
            //Console.ReadKey();


            // --------------------------------- TRY CATCH UND FINALLY - Zum abfangen von Fehlern
            Console.WriteLine("Bitte trage eine Zahl ein (0 zum Exception testen)");
            string userInput = Console.ReadLine();

            //try
            //{
            //    int userInputAsInt = int.Parse(userInput);
            //    int resultDivision = 5 / userInputAsInt;
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Durch 0 teilen ist nicht erlaubt!");

            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Grundlegender Fehler!");
            //}

            // Beim maus auf den Parse zu halten, zeig t es die Moeglichen Exceptions die es verursachen kann: hier sind die drei behandelt:
            //selber alle trycatch sachen zusammen gepackt



            // Create the source, if it does not already exist.
            if (!EventLog.SourceExists("MySource"))
            {
                //An event log source should not be created and immediately used.
                //There is a latency time to enable the source, it should be created
                //prior to executing the application that uses the source.
                //Execute this sample a second time to use the new source.
                EventLog.CreateEventSource("MySource", "MyNewLog");
                Console.WriteLine("CreatedEventSource");
                Console.WriteLine("Exiting, execute the application a second time to use the source.");
                // The source is created.  Exit the application to allow it to be registered.
                return;
            }
            // Create an EventLog instance and assign its source.
            EventLog myLog = new EventLog();
            myLog.Source = "MySource";

            // Write an informational entry to the event log.
            myLog.WriteEntry("Initiating event log.");

            try
            {
                int userInputAsInt = int.Parse(userInput);
                int resultDivision = 5 / userInputAsInt;
            }
            catch (FormatException)
            {
                Console.WriteLine("Format war inkorrekt. Du hättest eine Nummer eintragen sollen!");
                myLog.WriteEntry("FormatException");

            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNullException, der wert war leer (null)");
                myLog.WriteEntry("ArgumentNullException");

            }
            catch (OverflowException)
            {
                Console.WriteLine("OverflowException, der eingegebene Wert, war zu lang");
                myLog.WriteEntry("OverflowException");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Durch 0 teilen ist nicht erlaubt!");
                myLog.WriteEntry("DivideByZeroException");
            }
            catch (Exception)
            {
                Console.WriteLine("Grundlegender Fehler! UNBEKANNTE FEHLER");
                myLog.WriteEntry("Grundlegender Fehler! UNBEKANNTE FEHLER");
            }

            //Finally wird sowieso immer ausgeführt
            finally
            {
                // Verbindung schließen, oder Datei schließen.
                Console.WriteLine("Finally sagt: Ich werde sowieso immer ausgeführt, \nauch wenn es fehlerfrei gelaufen ist!!");
                myLog.WriteEntry("Entry for finally in log.");
            }
            // --------------------------------- TRY CATCH UND FINALLY - Zum abfangen von Fehlern Ende

            Console.ReadKey();

        }


        public static int Calculate()
        {
            Console.WriteLine("Bitte trage die erste Zahl ein.");
            string number1Input = Console.ReadLine();
            Console.WriteLine("Bitte trage die zweite Zahl ein.");
            string number2Input = Console.ReadLine();

            int num1 = int.Parse(number1Input);
            int num2 = int.Parse(number2Input);

            int result = num1 + num2;

            Console.WriteLine("Die Summe davon ist: ");
            return result;
        }
        public static void SaludaAMiAmigo(string miAmigo)
        {
            Console.WriteLine("Hola " + miAmigo + ", amigo mío!");
        }
        public static void SaludaATodosMisAmigos(string miAmigo1, string miAmigo2, string miAmigo3)
        {
            Console.WriteLine("Hola {0}, {1}, {2}, meine Freunde!", miAmigo1, miAmigo2, miAmigo3);
            Console.WriteLine($"Hola {miAmigo1}, {miAmigo2}, {miAmigo3}, meine Freunde!");

        }

        // Zugriffsmodifizierer (static) Rückgabetyp Methodenname(Parameter1, Parameter2){MethodenRumpf}
        public static void WriteSomething()
        {
            Console.WriteLine("Ich bin eine Methode!");
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }


        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }

        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
