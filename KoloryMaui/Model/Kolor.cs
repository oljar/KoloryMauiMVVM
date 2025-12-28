using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoloryMaui.Model

{
    public class Kolor
    {
        private double ograniczDoZakresu(double x )
        {
            if (x < 0.0) return 0.0;
            else if (x > 1.0) return 1.0;
            else return x;
        }

        private double r, g, b;
        public double R
        {
            get => ograniczDoZakresu(r);
            set { r = value; }
        }
        public double G
        {
            get => ograniczDoZakresu(g);
            set { g = value; }
        }
        public double B
        {
            get => ograniczDoZakresu(b);
            set { b = value; }
        
        }

       
        public Kolor(double r, double g, double b)
        {
            this.R = r;
            this.G = g;
            this.B = b;
        }

    
        public Color Coleur
        {
            get
            {
                return Color.FromRgb(r, g, b);
            }
            set
            {
                // Rozbij wartość Color na składowe i przypisz do r, g, b
                r = value.Red;
                g = value.Green;
                b = value.Blue;
            }
        }


        public static Kolor Czarny => new Kolor(0.0, 0.0, 0.0);


    }

}
