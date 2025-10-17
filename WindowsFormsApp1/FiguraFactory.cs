namespace WindowsFormsApp1
{
    public static class FiguraFactory
    {
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