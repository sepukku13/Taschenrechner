using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class ConsoleView
    {
        private RechnerModel model;

        //Konstruktor
        public ConsoleView (RechnerModel model1)
        {
            model = model1;
        }
        public void HoleEingabeVomBenutzer()
        {
            model.ErsteZahl = HoleZahlVomBenutzer();
            model.Operation = HoleOperatorVomBenutzer();
            model.ZweiteZahl = HoleZahlVomBenutzer();
        }
        public double HoleZahlVomBenutzer()
        {
            string zahl;
            Console.Write("Bitte Zahl eingeben: ");
            zahl = Console.ReadLine();
            return Convert.ToDouble(zahl);
        }
        public string HoleOperatorVomBenutzer()
        {
            Console.Write("Bitte Operator (+ oder - oder * oder /) eingeben: ");
            return Console.ReadLine();
        }
        public void GibResultatAus ()
        {
            switch (model.Operation)
            {
                case "+":
                    Console.WriteLine("Die Summe ist: {0}", model.Resultat);
                    break;
                case "-":
                    Console.WriteLine("Die Differenz ist: {0}", model.Resultat);
                    break;
                case "/":
                    Console.WriteLine("Der Wert des Quotienten ist: {0}", model.Resultat);
                    break;
                case "*":
                    Console.WriteLine("Das Produkt ist: {0}", model.Resultat);
                    break;
                default:
                    Console.WriteLine("Du hast eine ungültige Auswahl der Operation getroffen.");
                    break;
            }
        }
        public void WarteAufEndeDurchBenutzer()
        {
            Console.WriteLine("Enter zum Beenden!");
            Console.ReadLine();
        }
    }
}
