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
    }
}
