using System.Drawing;

namespace WindowsFormsApp1
{
    public class Rectangulo : Figura
    {
        public Rectangulo() { }

        public override void Dibujar(Graphics g)
        {
            int ancho = Ancho;
            int alto = Alto;
            var rectangulo = new Rectangle(X, Y, ancho, alto);

            if (Rellenado)
            {
                using (var brocha = new SolidBrush(ColorRelleno))
                {
                    g.FillRectangle(brocha, rectangulo);
                }
            }

            using (var lapiz = new Pen(ColorTrazo, GrosorTrazo))
            {
                g.DrawRectangle(lapiz, rectangulo);
            }
        }
    }
}
