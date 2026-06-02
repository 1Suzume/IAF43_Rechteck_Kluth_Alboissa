using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechteck_Projekt
{
    internal class Rechteck
    {
        private double breite;
        public double Breite
        {
            get { return breite; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Die Breite muss größer als 0 sein");
                }
                breite = value;
            }
        }
        private double hoehe;
        public double Hoehe
        {
            get { return hoehe; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Die Höhe muss größer als 0 sein");
                }
                hoehe = value;
            }
        }

        public double Umfang
        {
            get { return 2 * hoehe + 2 * breite; }
        }



        public double Diagonale
        {
            get { return Math.Sqrt(hoehe * hoehe + breite * breite); }
        }
        public double Flaeche
        {
            get { return hoehe * breite; }
        }


        // Drehen Methode:
        public void Drehen()
        {
            double tmp = breite;
            breite = hoehe;
            hoehe = tmp;
        }

        // Zoomen Methode:
        public void zoom(bool minus)
        {
            if (!minus)
            {
                breite *= 1.1;
                hoehe *= 1.1;
            }
            else
            {
                breite /= 1.1;
                hoehe /= 1.1;
            }
        }
    }
}
