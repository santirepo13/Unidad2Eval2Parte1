using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public abstract class Figura
    {

        //getters y setters para la posicion de la figura
        public int X { get; set; }
        public int Y { get; set; }

        // ancho y alto para las figuras
        public int Width { get; set; }
        public int Height { get; set; }

        // Propiedades de trazo/relleno
        public System.Drawing.Color StrokeColor { get; set; } = System.Drawing.Color.Black;
        public float StrokeWidth { get; set; } = 1f;
        public bool Filled { get; set; } = false;
        public System.Drawing.Color FillColor { get; set; } = System.Drawing.Color.LightGray;

        // Identificador opcional
        public string Name { get; set; }

        // Método abstracto que las subclases deben implementar para dibujarse
        public abstract void Dibujar(System.Drawing.Graphics g);

    }
}
