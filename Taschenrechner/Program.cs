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
            double resultat = 0;
            
            // User Story "Addieren". Als Benutzer möchte ich 2 Zahlen eingeben und addieren.
            string ersterWert = HoleBenutzerEingabe ("Bitte erste Zahl eigeben: ");
            string zweiterWert = HoleBenutzerEingabe("Bitte zweite Zahl eigeben: ");
            string operation = HoleBenutzerEingabe("Bitte Operator eingeben (+ / -): ");

            // Wandel Text in Ganzzahlen
            // TODO: Auslagern in eine Methode
            double ersteZahl = Convert.ToDouble(ersterWert);
            double zweiteZahl = Convert.ToDouble(zweiterWert);

            // Berechnung
            if (operation == "+")
            {
                resultat = Addiere(ersteZahl, zweiteZahl);
                Console.WriteLine("Ergebnis: {0}", resultat);
            }
            else if (operation == "-")
            {
                resultat = Subtrahiere(ersteZahl, zweiteZahl);
                Console.WriteLine("Ergebnis: {0}", resultat);
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe!");
            }
            HoleBenutzerEingabe("Drücke Return zum Beenden der Anwendung!");
        }
        static string HoleBenutzerEingabe (string eingabetext)
        {
            Console.Write(eingabetext);
            string summand = Console.ReadLine();
            return summand;
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
    }
}
