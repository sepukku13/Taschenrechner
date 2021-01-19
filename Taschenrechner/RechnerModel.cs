using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class RechnerModel
    {
        public double Resultat { get; private set; }

        // Konstruktor
        // Konstruktor muss selben Namen wie Klasse haben
        // Wird meist dazu verwendet um Variablen zu initialisieren -> Resultat
        public RechnerModel ()
        {
            Resultat = 0;
        }
        public void Berechne (double ersteZahl, double zweiteZahl, string operation)
        {
            // Berechnung
            switch (operation)
            {
                case "+":
                    Resultat = Addiere(ersteZahl, zweiteZahl);
                    break;
                case "-":
                    Resultat = Subtrahiere(ersteZahl, zweiteZahl);
                    break;
                case "*":
                    Resultat = Multiplikation(ersteZahl, zweiteZahl);
                    break;
                case "/":
                    Resultat = Division(ersteZahl, zweiteZahl);
                    break;
                default:
                    Console.WriteLine("Ungültige Eingabe!");
                    break;
            }
        }
        private double Addiere(double ersterSummandAlsZahl, double zweiterSummandAlsZahl)
        {
            double summe = ersterSummandAlsZahl + zweiterSummandAlsZahl;
            return summe;
        }
        private double Subtrahiere(double minuend, double subtrahend)
        {
            double differenz = minuend - subtrahend;
            return differenz;
        }
        private double Multiplikation(double faktor1, double faktor2)
        {
            double produkt = faktor1 * faktor2;
            return produkt;
        }
        static double Division(double dividend, double divisor)
        {
            double quotient = dividend / divisor;
            return quotient;
        }
    }
}
