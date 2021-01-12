using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner_Iteration_1
{
    class Program
    { 
        static void Main(string[] args)
        {
            char antwort;
            do
            {
                // User Story "Addieren". Als Benutzer möchte ich 2 Zahlen eingeben und addieren.
                string ersterWert = HoleBenutzerEingabe("Bitte erste Zahl eigeben: ");
                string zweiterWert = HoleBenutzerEingabe("Bitte zweite Zahl eigeben: ");
                string operation = HoleBenutzerEingabe("Bitte Operator eingeben (+ oder - oder * oder /: ");

                // Wandel Text in Ganzzahlen
                // TODO: Auslagern in eine Methode
                double ersteZahl = Convert.ToDouble(ersterWert);
                double zweiteZahl = Convert.ToDouble(zweiterWert);

                // Berechnung
                double resultat = Berechnung(ersteZahl, zweiteZahl, operation);

                // Ausgabe
                 antwort = Ausgabe(resultat);
            }
            while ((antwort == 'j') || (antwort== 'J'));
        }
        static string HoleBenutzerEingabe (string eingabetext)
        {
            Console.Write(eingabetext);
            string summand = Console.ReadLine();
            return summand;
        }

        static double Berechnung (double ersteZahl, double zweiteZahl, string operation)
        {
            double resultat = 0;
            // Berechnung
            switch (operation)
            {
                case "+":
                    resultat = Addiere(ersteZahl, zweiteZahl);
                    break;
                case "-":
                    resultat = Subtrahiere(ersteZahl, zweiteZahl);
                    break;
                case "*":
                    resultat = Multiplikation(ersteZahl, zweiteZahl);
                    break;
                case "/":
                    resultat = Division(ersteZahl, zweiteZahl);
                    break;
                default:
                    Console.WriteLine("Ungültige Eingabe!");
                    break;
            }
            return resultat;
        }
        static char Ausgabe (double resultat)
        {
            Console.WriteLine("Ergebnis: {0}", resultat);
            Console.WriteLine("Nochmal J/N?");
            char antwort = Convert.ToChar(Console.ReadLine());
            Console.Clear();
            return antwort;
        }
        static double Addiere(double ersterSummandAlsZahl, double zweiterSummandAlsZahl)
        {
            double summe = ersterSummandAlsZahl + zweiterSummandAlsZahl;
            return summe;
        }
        static double Subtrahiere(double minuend, double subtrahend)
        {
            double differenz = minuend - subtrahend;
            return differenz;
        }
        static double Multiplikation (double faktor1, double faktor2)
        {
            double produkt = faktor1 * faktor2;
            return produkt;
        }
        static double Division (double dividend, double divisor)
        {
            double quotient = dividend / divisor;
            return quotient;
        }
    }
}
