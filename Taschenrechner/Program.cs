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
            int ersterSummandAlsZahl = Convert.ToInt32(ersterSummand);
            int zweiterSummandAlsZahl = Convert.ToInt32(zweiterSummand);

            // Berechnung
            int summe = ersterSummandAlsZahl + zweiterSummandAlsZahl;

            //Ausgabe
            Console.WriteLine("Summe: {0}", summe);
            Console.ReadLine();
        }
    }
}
