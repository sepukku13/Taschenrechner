using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class RechnerModel
    {
        public double Berechne (double ersteZahl, double zweiteZahl, string operation)
        {
            double resultat = 0;
            // Berechnung
            switch (operation)
            {
                case "+":
                    resultat = Addiere(ersteZahl, zweiteZahl);
                    break;
                case "-":
                    resultat = Subtrahiere(ersteZahl, zweiteZahl);
                    break;
                case "*":
                    resultat = Multiplikation(ersteZahl, zweiteZahl);
                    break;
                case "/":
                    resultat = Division(ersteZahl, zweiteZahl);
                    break;
                default:
                    Console.WriteLine("Ungültige Eingabe!");
                    break;
            }
            return resultat;
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
        private double Division(double dividend, double divisor)
        {
            double quotient = dividend / divisor;
            return quotient;
        }




    }

}
