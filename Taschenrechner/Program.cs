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
                ConsoleView view = new ConsoleView();
                string ersterWert = view.HoleBenutzerEingabe("Bitte erste Zahl eigeben: ");
                string zweiterWert = view.HoleBenutzerEingabe("Bitte zweite Zahl eigeben: ");
                string operation = view.HoleBenutzerEingabe("Bitte Operator eingeben (+ oder - oder * oder /: ");

                // Wandel Text in Ganzzahlen
                // TODO: Auslagern in eine Methode
                double ersteZahl = Convert.ToDouble(ersterWert);
                double zweiteZahl = Convert.ToDouble(zweiterWert);

                // Berechnung
                RechnerModel model = new RechnerModel();
                model.Berechne(ersteZahl, zweiteZahl, operation);
                
                // Ausgabe
                 antwort = view.Ausgabe(model.Resultat);
            }
            while ((antwort == 'j') || (antwort== 'J'));
        }
    }
}
