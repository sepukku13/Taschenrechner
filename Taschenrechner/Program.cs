using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
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
                RechnerModel model = new RechnerModel();
                double resultat = model.Berechne(ersteZahl, zweiteZahl, operation);

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
                
        static char Ausgabe (double resultat)
        {
            Console.WriteLine("Ergebnis: {0}", resultat);
            Console.WriteLine("Nochmal J/N?");
            char antwort = Convert.ToChar(Console.ReadLine());
            Console.Clear();
            return antwort;
        }
        
    }
}
