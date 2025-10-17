using System.Drawing;

namespace WindowsFormsApp1
{
    public class Triangulo : Figura
    {
        public Triangulo() { }

        public int PuntoX2 { get; set; }
        public int PuntoY2 { get; set; }
        public int PuntoX3 { get; set; }
        public int PuntoY3 { get; set; }

        public override void Dibujar(Graphics g)
        {
            var puntos = new Point[]
            {
                new Point(X, Y),
                new Point(PuntoX2, PuntoY2),
                new Point(PuntoX3, PuntoY3)
            };

            if (Rellenado)
            {
                using (var brocha = new SolidBrush(ColorRelleno))
                {
                    g.FillPolygon(brocha, puntos);
                }
            }

            using (var lapiz = new Pen(ColorTrazo, GrosorTrazo))
            {
                g.DrawPolygon(lapiz, puntos);
            }
        }
    }
}
