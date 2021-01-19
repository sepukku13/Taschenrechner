using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class ConsoleView
    {
        public string HoleBenutzerEingabe(string eingabetext)
        {
            Console.Write(eingabetext);
            string summand = Console.ReadLine();
            return summand;
        }
        public char Ausgabe(double resultat)
        {
            Console.WriteLine("Ergebnis: {0}", resultat);
            Console.WriteLine("Nochmal J/N?");
            char antwort = Convert.ToChar(Console.ReadLine());
            Console.Clear();
            return antwort;
        }
    }
}
