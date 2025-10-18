using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Reflection;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Figura> figuras = new List<Figura>();
        private bool colorSeleccionado = false;

        public Form1()
        {
            InitializeComponent();

            btnCrear.Click += BtnCrear_Clic;
            btnLimpiar.Click += BtnLimpiar_Clic;
            pbLienzo.Paint += PbLienzo_Pintar;
            pbColor.Click += PbColor_Clic;
            cmbFigura.SelectedIndexChanged += CmbFigura_IndiceCambiado;

            var prop = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance);
            prop?.SetValue(pbLienzo, true, null);

            txtContador.Text = "0";

            ActualizarControlesParaFigura();

            pbLienzo.Dock = DockStyle.Fill;
        }

        private void BtnCrear_Clic(object sender, EventArgs e)
        {
            var seleccionado = cmbFigura.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(seleccionado))
            {
                MessageBox.Show("Seleccione una figura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tipo = seleccionado;

            if (!colorSeleccionado)
            {
                MessageBox.Show("Seleccione un color antes de crear la figura.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var figura = FiguraFactory.CrearFigura(tipo);
            if (figura == null)
            {
                MessageBox.Show("Tipo de figura no soportado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int x = (int)nudX.Value;
            int y = (int)nudY.Value;
            int tamaño = (int)nudTamano.Value;
            int x2 = (int)nudX2.Value;
            int y2 = (int)nudY2.Value;

            figura.X = x;
            figura.Y = y;

            figura.ColorTrazo = pbColor.BackColor;
            figura.ColorRelleno = figura.ColorTrazo;
            figura.Rellenado = true;

            switch (tipo)
            {
                case "Rectangulo":
                    figura.Ancho = tamaño;
                    figura.Alto = tamaño;
                    break;
                case "Circulo":
                    figura.Ancho = tamaño;
                    figura.Alto = tamaño;
                    break;
                case "Linea":
                    if (figura is Linea linea)
                    {
                        linea.PuntoX = x;
                        linea.PuntoY = y;
                        linea.PuntoX2 = x2;
                        linea.PuntoY2 = y2;
                    }
                    break;
                case "Triangulo":
                    if (figura is Triangulo tri)
                    {
                        tri.PuntoX2 = x + tamaño;
                        tri.PuntoY2 = y;
                        tri.PuntoX3 = x;
                        tri.PuntoY3 = y + tamaño;
                    }
                    break;
            }

            if (tipo == "Rectangulo" || tipo == "Circulo" || tipo == "Triangulo" || tipo == "Linea")
            {
                string error = ValidarFiguraEnLienzo(figura);
                if (error != null)
                {
                    MessageBox.Show(error, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            figuras.Add(figura);
            txtContador.Text = figuras.Count.ToString();
            pbLienzo.Refresh();
        }

        private void BtnLimpiar_Clic(object sender, EventArgs e)
        {
            figuras.Clear();
            txtContador.Text = "0";

            colorSeleccionado = false;
            pbColor.BackColor = SystemColors.Control;

            nudX.Value = 0;
            nudY.Value = 0;
            nudTamano.Value = 0;
            nudX2.Value = 0;
            nudY2.Value = 0;

            pbLienzo.Refresh();
        }

        private void PbLienzo_Pintar(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;

            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.TextRenderingHint = TextRenderingHint.AntiAlias;

            g.Clear(Color.White);

            using (var gridPen = new Pen(Color.FromArgb(20, Color.Gray), 1))
            {
                for (int x = 0; x <= pbLienzo.Width; x += 50)
                    g.DrawLine(gridPen, x, 0, x, pbLienzo.Height);
                for (int y = 0; y <= pbLienzo.Height; y += 50)
                    g.DrawLine(gridPen, 0, y, pbLienzo.Width, y);
            }

            foreach (var f in figuras)
            {
                f.Dibujar(g);
            }

            using (var borderPen = new Pen(Color.FromArgb(80, Color.Black), 1))
            {
                g.DrawRectangle(borderPen, 0, 0, pbLienzo.Width - 1, pbLienzo.Height - 1);
            }
        }

        private string ValidarFiguraEnLienzo(Figura figura)
        {
            int lienzoAncho = pbLienzo.Width;
            int lienzoAlto = pbLienzo.Height;

            if (figura is Rectangulo)
            {
                if (figura.Ancho <= 0 || figura.Alto <= 0)
                    return "Rectangulo: el tamaño debe ser mayor que 0.";
                if (figura.X < 0 || figura.Y < 0)
                    return "Rectangulo: las coordenadas deben ser no negativas.";
                if (figura.X + figura.Ancho > lienzoAncho || figura.Y + figura.Alto > lienzoAlto)
                    return "Rectangulo: la figura debe ser completamente visible dentro del lienzo.";
                return null;
            }

            if (figura is Circulo)
            {
                int diametro = figura.Ancho;
                if (diametro <= 0)
                    return "Circulo: el tamaño debe ser mayor que 0.";
                if (figura.X < 0 || figura.Y < 0)
                    return "Circulo: las coordenadas deben ser no negativas.";
                if (figura.X + diametro > lienzoAncho || figura.Y + diametro > lienzoAlto)
                    return "Circulo: la figura debe ser completamente visible dentro del lienzo.";
                return null;
            }

            if (figura is Triangulo tri)
            {
                int minX = Math.Min(tri.X, Math.Min(tri.PuntoX2, tri.PuntoX3));
                int maxX = Math.Max(tri.X, Math.Max(tri.PuntoX2, tri.PuntoX3));
                int minY = Math.Min(tri.Y, Math.Min(tri.PuntoY2, tri.PuntoY3));
                int maxY = Math.Max(tri.Y, Math.Max(tri.PuntoY2, tri.PuntoY3));

                if (maxX - minX <= 0 || maxY - minY <= 0)
                    return "Triangulo: el tamaño debe ser mayor que 0.";
                if (minX < 0 || minY < 0)
                    return "Triangulo: las coordenadas deben ser no negativas.";
                if (maxX > lienzoAncho || maxY > lienzoAlto)
                    return "Triangulo: la figura debe ser completamente visible dentro del lienzo.";
                return null;
            }

            if (figura is Linea lin)
            {
                if (lin.PuntoX < 0 || lin.PuntoY < 0 || lin.PuntoX2 < 0 || lin.PuntoY2 < 0)
                    return "Linea: los puntos deben tener coordenadas no negativas.";
                if (lin.PuntoX > lienzoAncho || lin.PuntoX2 > lienzoAncho || lin.PuntoY > lienzoAlto || lin.PuntoY2 > lienzoAlto)
                    return "Linea: ambos puntos deben estar dentro del lienzo.";
                return null;
            }

            return null;
        }

        private void PbColor_Clic(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pbColor.BackColor = colorDialog1.Color;
                colorSeleccionado = true;
            }
        }

        private void CmbFigura_IndiceCambiado(object sender, EventArgs e)
        {
            ActualizarControlesParaFigura();
        }

        private void ActualizarControlesParaFigura()
        {
            var seleccionado = cmbFigura.SelectedItem?.ToString() ?? string.Empty;

            bool habilitarTamaño = false;
            bool habilitarPunto2 = false;

            switch (seleccionado)
            {
                case "Rectangulo":
                case "Circulo":
                case "Triangulo":
                    habilitarTamaño = true;
                    habilitarPunto2 = false;
                    break;
                case "Linea":
                    habilitarTamaño = false;
                    habilitarPunto2 = true;
                    break;
                default:
                    break;
            }

            lblTamano.Enabled = habilitarTamaño;
            nudTamano.Enabled = habilitarTamaño;

            lblX2.Enabled = habilitarPunto2;
            nudX2.Enabled = habilitarPunto2;
            lblY2.Enabled = habilitarPunto2;
            nudY2.Enabled = habilitarPunto2;

            lblX.Enabled = true;
            nudX.Enabled = true;
            lblY.Enabled = true;
            nudY.Enabled = true;
        }
    }
}
