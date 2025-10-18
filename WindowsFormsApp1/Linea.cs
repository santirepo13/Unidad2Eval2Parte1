using System.Drawing;

namespace WindowsFormsApp1
{
    public class Linea : Figura
    {
        public Linea() { }

        public int PuntoX { get => X; set => X = value; }
        public int PuntoY { get => Y; set => Y = value; }

        public int PuntoX2 { get; set; }
        public int PuntoY2 { get; set; }

        public override void Dibujar(Graphics g)
        {
            using (var lapiz = new Pen(ColorTrazo, GrosorTrazo))
            {
                g.DrawLine(lapiz, PuntoX, PuntoY, PuntoX2, PuntoY2);
            }
        }
    }
}
