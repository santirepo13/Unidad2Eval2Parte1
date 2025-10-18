using System.Drawing;

namespace WindowsFormsApp1
{
    public static class FiguraFactory
    {
        // CrearFigura ahora solo instancia según el tipo y no realiza validaciones.
        // tipoFigura: "Rectangulo","Circulo","Linea","Triangulo"
        public static Figura CrearFigura(string tipoFigura)
        {
            if (string.IsNullOrWhiteSpace(tipoFigura)) return null;

            switch (tipoFigura)
            {
                case "Rectangulo":
                    return new Rectangulo();
                case "Circulo":
                    return new Circulo();
                case "Linea":
                    return new Linea();
                case "Triangulo":
                    return new Triangulo();
                default:
                    return null;
            }
        }
    }
}



