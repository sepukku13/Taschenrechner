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
            Console.Write("Bitte ersten Summanden eigeben: ");
            string ersterSummand = Console.ReadLine();
            Console.Write("Bitte zweiten Summanden eigeben: ");
            string zweiterSummand = Console.ReadLine();
            

            // Wandel Text in Ganzzahlen
            double ersterSummandAlsZahl = Convert.ToDouble(ersterSummand);
            double zweiterSummandAlsZahl = Convert.ToDouble(zweiterSummand);

            // Berechnung
            double summe = ersterSummandAlsZahl + zweiterSummandAlsZahl;

            //Ausgabe
            Console.WriteLine("Summe: {0}", summe);
            Console.ReadLine();
        }
    }
}
