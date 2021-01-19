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
                RechnerModel model = new RechnerModel();
                ConsoleView view = new ConsoleView(model);
                string ersterWert = view.HoleZahlVomBenutzer();
                string operation = view.HoleOperatorVomBenutzer();
                string zweiterWert = view.HoleZahlVomBenutzer();


                // Wandel Text in Ganzzahlen
                // TODO: Auslagern in eine Methode
                double ersteZahl = Convert.ToDouble(ersterWert);
                double zweiteZahl = Convert.ToDouble(zweiterWert);

                // Berechnung
                
                model.Berechne(ersteZahl, zweiteZahl, operation);

                // Ausgabe
                antwort = view.WarteAufEndeDurchBenutzer();
            }
            while ((antwort == 'j') || (antwort== 'J'));
        }
    }
}
