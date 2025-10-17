using System.Drawing;

namespace WindowsFormsApp1
{
    public class Circulo : Figura
    {
        public Circulo() { }

        public override void Dibujar(Graphics graficos)
        {
            int diametro = Ancho; 
            Rectangle rectangulo = new Rectangle(X, Y, diametro, diametro);

            if (Rellenado)
            {
                using (SolidBrush pincelRelleno = new SolidBrush(ColorRelleno))
                {
                    graficos.FillEllipse(pincelRelleno, rectangulo);
                }
            }

            using (Pen lapizTrazo = new Pen(ColorTrazo, GrosorTrazo))
            {
                graficos.DrawEllipse(lapizTrazo, rectangulo);
            }
        }
    }
}
