using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public abstract class Figura
    {

        // get/set para la posición de la figura
        public int X { get; set; }
        public int Y { get; set; }

        // ancho  y alto para las figuras
        public int Ancho { get; set; }
        public int Alto { get; set; }

        // Propiedades de trazo/relleno 
        public System.Drawing.Color ColorTrazo { get; set; } = System.Drawing.Color.Black;
        public float GrosorTrazo { get; set; } = 1f;
        public bool Rellenado { get; set; } = false;
        public System.Drawing.Color ColorRelleno { get; set; } = System.Drawing.Color.LightGray;

        // Identificador opcional (en español)
        public string Nombre { get; set; }

        // Presets de color convenientes (en español)
        public static System.Drawing.Color ColorAzul => System.Drawing.Color.Blue;
        public static System.Drawing.Color ColorRojo => System.Drawing.Color.Red;

        // Helpers para aplicar presets rápidamente 
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
