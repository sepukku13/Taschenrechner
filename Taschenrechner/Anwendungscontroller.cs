using System;

namespace Taschenrechner
{
    class Anwendungscontroller
    {
        //2 Attribute von Typen ConsoleView und RechnerModel
        private ConsoleView view;
        private RechnerModel model;

        // Konstruktor
        public Anwendungscontroller (ConsoleView view, RechnerModel model)
        {
            this.view = view;
            this.model = model;
        }

        // öffentliche Methode
        public void Ausfuehren()
        {
            double ersteZahl = view.HoleZahlVomBenutzer();
            string operation = view.HoleOperatorVomBenutzer();
            double zweiteZahl = view.HoleZahlVomBenutzer();

            // Berechnung
            model.Berechne(ersteZahl, zweiteZahl, operation);

            // Ausgabe
            view.GibResultatAus();
            view.WarteAufEndeDurchBenutzer();
        }
    }
}
