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
            view.HoleEingabeFuerErsteBerechnungVomBenutzer();
            // Berechnung
            model.Berechne();
            // Ausgabe
            view.GibResultatAus();
            view.HoleEingabenFuerFortlaufendeBerechnung();

            while (!view.BenutzerWillBeenden)
            {
                model.Berechne();
                view.GibResultatAus();
                view.HoleEingabenFuerFortlaufendeBerechnung();
            }
        }
    }
}
