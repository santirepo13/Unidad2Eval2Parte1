using System;

namespace WindowsFormsApp1
{
    public static class FiguraFactory
    {
        
        public static Figura CrearFigura(string tipoFigura)
        {
            if (string.IsNullOrWhiteSpace(tipoFigura)) return null;

            var key = tipoFigura.Trim();
            Figura figura = null;

            if (string.Equals(key, "Rectangulo", StringComparison.OrdinalIgnoreCase))
                figura = new Rectangulo();
            else if (string.Equals(key, "Circulo", StringComparison.OrdinalIgnoreCase))
                figura = new Circulo();
            else if (string.Equals(key, "Linea", StringComparison.OrdinalIgnoreCase))
                figura = new Linea();
            else if (string.Equals(key, "Triangulo", StringComparison.OrdinalIgnoreCase))
                figura = new Triangulo();

            if (figura != null)
            {
                figura.Nombre = key; 
            }

            return figura;
        }
    }
}



