using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public abstract class Figura
    {

        public int X { get; set; }
        public int Y { get; set; }

        public int Ancho { get; set; }
        public int Alto { get; set; }

        public System.Drawing.Color ColorTrazo { get; set; } = System.Drawing.Color.Black;
        public float GrosorTrazo { get; set; } = 1f;
        public bool Rellenado { get; set; } = false;
        public System.Drawing.Color ColorRelleno { get; set; } = System.Drawing.Color.LightGray;

        public string Nombre { get; set; }

        public static System.Drawing.Color ColorAzul => System.Drawing.Color.Blue;
        public static System.Drawing.Color ColorRojo => System.Drawing.Color.Red;

        public void UsarTrazoAzul() => ColorTrazo = ColorAzul;
        public void UsarRellenoAzul()
        {
            ColorRelleno = ColorAzul;
            Rellenado = true;
        }

        public void UsarTrazoRojo() => ColorTrazo = ColorRojo;
        public void UsarRellenoRojo()
        {
            ColorRelleno = ColorRojo;
            Rellenado = true;
        }

        
                public abstract void Dibujar(System.Drawing.Graphics g);

    }
}
