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
        public string HoleZahlVomBenutzer()
        {
            Console.Write("Bitte Zahl eingeben: ");
            return Console.ReadLine();
        }
        public string HoleOperatorVomBenutzer()
        {
            Console.Write("Bitte Operator eingeben (+ oder - oder * oder /: ");
            return Console.ReadLine();
        }
        public char WarteAufEndeDurchBenutzer()
        {
            Console.WriteLine("Ergebnis: {0}", model.Resultat);
            Console.WriteLine("Nochmal J/N?");
            char antwort = Convert.ToChar(Console.ReadLine());
            Console.Clear();
            return antwort;

        }
    }
}
