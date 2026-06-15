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
                breite = Math.Round(value, 2);
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
                hoehe = Math.Round(value, 2);
            }
        }

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


        // Drehen Methode:
        public void Drehen()
        {
            double tmp = Breite;
            Breite = Hoehe;
            Hoehe = tmp;
        }

        // Zoomen Methode:
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
