using System;

namespace Taschenrechner
{
    class ConsoleView
    {
        private readonly RechnerModel model;
        public bool BenutzerWillBeenden { get; private set; }

        //Konstruktor
        public ConsoleView(RechnerModel model1)
        {
            model = model1;
            BenutzerWillBeenden = false;
        }
        public void HoleEingabeFuerErsteBerechnungVomBenutzer()
        {
            model.ErsteZahl = HoleZahlVomBenutzer();
            model.Operation = HoleOperatorVomBenutzer();
            model.ZweiteZahl = HoleZahlVomBenutzer();
        }
        public void HoleEingabenFuerFortlaufendeBerechnung()
        {
            string eingabe = HoleNaechsteAktionVomBenutzer();
            if (eingabe == "fertig")
            {
                BenutzerWillBeenden = true;
            }
            else
            {
                HoleEingabeFuerErsteBerechnungVomBenutzer();
            }
        }
        private string HoleNaechsteAktionVomBenutzer()
        {
            Console.Write("Eingabe 'fertig' zum Beenden: ");
            return Console.ReadLine();
        }
        public double HoleZahlVomBenutzer()
        {
            double zahl;
            string eingabe;
            Console.Write("Bitte Zahl eingeben: ");
            eingabe = Console.ReadLine();
            // TryParse gibt true zurück, wenn erfolgreich konvertiert, daher negieren mit !
            while (!Double.TryParse (eingabe, out zahl))
            {
                Console.WriteLine("Falsche Eingabe. Bitte nochmal!");
                Console.Write("Bitte Zahl eingeben: ");
                eingabe = Console.ReadLine();
            }
            return zahl;
        }
        public string HoleOperatorVomBenutzer()
        {
            Console.Write("Bitte Operator (+ oder - oder * oder /) eingeben: ");
            return Console.ReadLine();
        }
        public void GibResultatAus()
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
    }
}
