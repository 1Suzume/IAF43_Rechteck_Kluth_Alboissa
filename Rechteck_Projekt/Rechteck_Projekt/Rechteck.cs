using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechteck_Projekt
{
    internal class Rechteck
    {
        // Private Felder für Breite und Höhe, die auf 1 gesetzt werden, wenn der parameterlose Konstruktor aufgerufen wird
        private double breite;
        private double hoehe;

        public Rechteck()
        {
            this.breite = 1;
            this.hoehe = 1;
        }

        // Konstruktor, der die Werte für Breite und Höhe als Parameter entgegennimmt
        public Rechteck(double breite, double hoehe)
        {
            this.Breite = breite;
            this.Hoehe = hoehe;
        }

        // Eigenschaften für Breite und Höhe, die sicherstellen, dass die Werte größer als 0 sind und auf 2 Dezimalstellen gerundet werden
        public double Breite
        {
            get { return breite; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Die Breite muss größer als 0 sein");
                }
                breite = Math.Round(value, 2);
            }
        }
        
        public double Hoehe
        {
            get { return hoehe; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Die Höhe muss größer als 0 sein");
                }
                hoehe = Math.Round(value, 2);
            }
        }

        // Berechnet den Umfang, die Diagonale und die Fläche des Rechtecks und rundet sie auf 2 Dezimalstellen
        public double Umfang
        {
            get { return Math.Round(2 * hoehe + 2 * breite, 2); }
        }
        public double Diagonale
        {
            get { return Math.Round(Math.Sqrt(hoehe * hoehe + breite * breite), 2); }
        }
        public double Flaeche
        {
            get { return Math.Round(hoehe * breite, 2); }
        }


        // Drehen Methode, die die Werte von Breite und Höhe vertauscht
        public void Drehen()
        {
            double tmp = Breite;
            Breite = Hoehe;
            Hoehe = tmp;
        }

        // Zoom Methode, die die Werte von Breite und Höhe um 10% vergrößert oder verkleinert, je nachdem ob der Parameter "minus" true oder false ist
        public void zoom(bool minus)
        {
            if (!minus)
            {
                Breite *= 1.1;
                Hoehe *= 1.1;
            }
            else
            {
                Breite /= 1.1;
                Hoehe /= 1.1;
            }
        }
    }
}
