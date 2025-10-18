namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

                private void InitializeComponent()
        {
            this.cmbFigura = new System.Windows.Forms.ComboBox();
            this.nudX = new System.Windows.Forms.NumericUpDown();
            this.nudY = new System.Windows.Forms.NumericUpDown();
            this.nudTamano = new System.Windows.Forms.NumericUpDown();
            this.nudX2 = new System.Windows.Forms.NumericUpDown();
            this.nudY2 = new System.Windows.Forms.NumericUpDown();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblTamano = new System.Windows.Forms.Label();
            this.lblX2 = new System.Windows.Forms.Label();
            this.lblY2 = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.pbLienzo = new System.Windows.Forms.PictureBox();
            this.pbColor = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtContador = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTamano)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLienzo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).BeginInit();
            this.SuspendLayout();
           
            this.cmbFigura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFigura.FormattingEnabled = true;
            this.cmbFigura.Items.AddRange(new object[] {
            "Rectangulo",
            "Circulo",
            "Linea",
            "Triangulo"});
            this.cmbFigura.Location = new System.Drawing.Point(12, 29);
            this.cmbFigura.Name = "cmbFigura";
            this.cmbFigura.Size = new System.Drawing.Size(121, 21);
            this.cmbFigura.TabIndex = 0;
            
            this.nudX.Location = new System.Drawing.Point(150, 29);
            this.nudX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudX.Name = "nudX";
            this.nudX.Size = new System.Drawing.Size(60, 20);
            this.nudX.TabIndex = 2;
           
            this.nudY.Location = new System.Drawing.Point(216, 29);
            this.nudY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudY.Name = "nudY";
            this.nudY.Size = new System.Drawing.Size(60, 20);
            this.nudY.TabIndex = 3;
            
                                    this.nudTamano.Location = new System.Drawing.Point(282, 29);
            this.nudTamano.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
                        this.nudTamano.Name = "nudTamano";
            this.nudTamano.Size = new System.Drawing.Size(60, 20);
            this.nudTamano.TabIndex = 4;
           
           
            this.nudX2.Location = new System.Drawing.Point(414, 29);
            this.nudX2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudX2.Name = "nudX2";
            this.nudX2.Size = new System.Drawing.Size(60, 20);
            this.nudX2.TabIndex = 6;
           
            this.nudY2.Location = new System.Drawing.Point(480, 29);
            this.nudY2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudY2.Name = "nudY2";
            this.nudY2.Size = new System.Drawing.Size(60, 20);
            this.nudY2.TabIndex = 7;
         
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(150, 9);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 13);
            this.lblX.TabIndex = 12;
            this.lblX.Text = "X";
          
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(216, 9);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(14, 13);
            this.lblY.TabIndex = 13;
            this.lblY.Text = "Y";
            
                                    this.lblTamano.AutoSize = true;
            this.lblTamano.Location = new System.Drawing.Point(282, 9);
            this.lblTamano.Name = "lblTamano";
            this.lblTamano.Size = new System.Drawing.Size(46, 13);
            this.lblTamano.TabIndex = 14;
            this.lblTamano.Text = "Tamaño";
           
           
           
            this.lblX2.AutoSize = true;
            this.lblX2.Location = new System.Drawing.Point(414, 9);
            this.lblX2.Name = "lblX2";
            this.lblX2.Size = new System.Drawing.Size(20, 13);
            this.lblX2.TabIndex = 15;
            this.lblX2.Text = "X2";
            
            this.lblY2.AutoSize = true;
            this.lblY2.Location = new System.Drawing.Point(480, 9);
            this.lblY2.Name = "lblY2";
            this.lblY2.Size = new System.Drawing.Size(20, 13);
            this.lblY2.TabIndex = 16;
            this.lblY2.Text = "Y2";

        
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(547, 1);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 17;
            this.lblColor.Text = "Color";
            this.pbLienzo.BackColor = System.Drawing.Color.White;
            this.pbLienzo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbLienzo.Location = new System.Drawing.Point(12, 58);
            this.pbLienzo.Name = "pbLienzo";
            this.pbLienzo.Size = new System.Drawing.Size(776, 380);
            this.pbLienzo.TabIndex = 12;
            this.pbLienzo.TabStop = false;
            this.pbLienzo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbColor.Location = new System.Drawing.Point(546, 17);
            this.pbColor.Name = "pbColor";
            this.pbColor.Size = new System.Drawing.Size(32, 32);
            this.pbColor.TabIndex = 8;
            this.pbColor.TabStop = false;
            this.btnCrear.Location = new System.Drawing.Point(584, 12);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 32);
            this.btnCrear.TabIndex = 9;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnLimpiar.Location = new System.Drawing.Point(665, 12);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 32);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.txtContador.Location = new System.Drawing.Point(746, 19);
            this.txtContador.Name = "txtContador";
            this.txtContador.ReadOnly = true;
            this.txtContador.Size = new System.Drawing.Size(46, 20);
            this.txtContador.TabIndex = 11;
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(12, 9);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 1;
                        this.lblDescripcion.Text = "Descripcion";

            this.flpControls = new System.Windows.Forms.FlowLayoutPanel();
            this.flpControls.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpControls.WrapContents = false;
            this.flpControls.AutoScroll = true;
            this.flpControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpControls.Width = 220;
            this.flpControls.Padding = new System.Windows.Forms.Padding(8);

            this.cmbFigura.Width = 180;
            this.nudX.Width = 160;
            this.nudY.Width = 160;
            this.nudTamano.Width = 160;
            this.nudX2.Width = 160;
            this.nudY2.Width = 160;
            this.btnCrear.Width = 180;
            this.btnLimpiar.Width = 180;
            this.txtContador.Width = 180;

            this.nudTamano.Maximum = 10000;

            this.flpControls.Controls.Add(this.lblDescripcion);
            this.flpControls.Controls.Add(this.cmbFigura);
            this.flpControls.Controls.Add(this.lblX);
            this.flpControls.Controls.Add(this.nudX);
            this.flpControls.Controls.Add(this.lblY);
            this.flpControls.Controls.Add(this.nudY);
                        this.flpControls.Controls.Add(this.lblTamano);
            this.flpControls.Controls.Add(this.nudTamano);
            this.flpControls.Controls.Add(this.lblX2);
            this.flpControls.Controls.Add(this.nudX2);
            this.flpControls.Controls.Add(this.lblY2);
            this.flpControls.Controls.Add(this.nudY2);
            this.flpControls.Controls.Add(this.lblColor);
            this.flpControls.Controls.Add(this.pbColor);
            this.flpControls.Controls.Add(this.btnCrear);
            this.flpControls.Controls.Add(this.btnLimpiar);
            this.flpControls.Controls.Add(this.txtContador);

            this.pbLienzo.Dock = System.Windows.Forms.DockStyle.Fill;


            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbLienzo);
            this.Controls.Add(this.flpControls);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTamano)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLienzo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.FlowLayoutPanel flpControls;
        private System.Windows.Forms.ComboBox cmbFigura;
        private System.Windows.Forms.NumericUpDown nudX;
        private System.Windows.Forms.NumericUpDown nudY;
        private System.Windows.Forms.NumericUpDown nudTamano;
        private System.Windows.Forms.NumericUpDown nudX2;
        private System.Windows.Forms.NumericUpDown nudY2;

        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblTamano;
        private System.Windows.Forms.Label lblX2;
        private System.Windows.Forms.Label lblY2;
        private System.Windows.Forms.Label lblColor;

        private System.Windows.Forms.PictureBox pbLienzo;
        private System.Windows.Forms.PictureBox pbColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtContador;
        private System.Windows.Forms.Label lblDescripcion;

        #endregion
    }
}



