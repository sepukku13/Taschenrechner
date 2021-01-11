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
            // User Story "Addieren". Als Benutzer möchte ich 2 Zahlen eingeben und addieren.
            Console.Write("Bitte ersten Summanden eigeben: ");
            string ersterSummand = Console.ReadLine();
            Console.Write("Bitte zweiten Summanden eigeben: ");
            string zweiterSummand = Console.ReadLine();
            
            // Wandel Text in Ganzzahlen
            double ersterSummandAlsZahl = Convert.ToDouble(ersterSummand);
            double zweiterSummandAlsZahl = Convert.ToDouble(zweiterSummand);

            // Addiere
            double summe = Addiere(ersterSummandAlsZahl, zweiterSummandAlsZahl);

            //Ausgabe
            Console.WriteLine("Summe: {0}", summe);
            WarteAufEingabe();

        }
        static void WarteAufEingabe()
        {
            Console.WriteLine("Drücke Return zum Beenden der Anwendung!");
            Console.ReadLine();
        }
        static double Addiere(double ersterSummandAlsZahl, double zweiterSummandAlsZahl)
        {
            double summe = ersterSummandAlsZahl + zweiterSummandAlsZahl;
            return summe;
        }
    }
}
