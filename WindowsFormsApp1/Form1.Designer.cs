namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmbFigura = new System.Windows.Forms.ComboBox();
            this.nudX = new System.Windows.Forms.NumericUpDown();
            this.nudY = new System.Windows.Forms.NumericUpDown();
            this.nudTamaño = new System.Windows.Forms.NumericUpDown();
            this.nudX2 = new System.Windows.Forms.NumericUpDown();
            this.nudY2 = new System.Windows.Forms.NumericUpDown();
            this.pbLienzo = new System.Windows.Forms.PictureBox();
            this.pbColor = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtContador = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTamaño)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLienzo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFigura
            // 
            this.cmbFigura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFigura.FormattingEnabled = true;
            this.cmbFigura.Items.AddRange(new object[] {
            "Rectángulo",
            "Círculo",
            "Línea",
            "Triángulo"});
            this.cmbFigura.Location = new System.Drawing.Point(12, 29);
            this.cmbFigura.Name = "cmbFigura";
            this.cmbFigura.Size = new System.Drawing.Size(121, 21);
            this.cmbFigura.TabIndex = 0;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(12, 9);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción";
            // 
            // nudX
            // 
            this.nudX.Location = new System.Drawing.Point(150, 29);
            this.nudX.Maximum = new decimal(new int[] {10000,0,0,0});
            this.nudX.Name = "nudX";
            this.nudX.Size = new System.Drawing.Size(60, 20);
            this.nudX.TabIndex = 2;
            // 
            // nudY
            // 
            this.nudY.Location = new System.Drawing.Point(216, 29);
            this.nudY.Maximum = new decimal(new int[] {10000,0,0,0});
            this.nudY.Name = "nudY";
            this.nudY.Size = new System.Drawing.Size(60, 20);
            this.nudY.TabIndex = 3;
            // 
            // nudTamaño
            // 
            this.nudTamaño.Location = new System.Drawing.Point(282, 29);
            this.nudTamaño.Maximum = new decimal(new int[] {10000,0,0,0});
            this.nudTamaño.Name = "nudTamaño";
            this.nudTamaño.Size = new System.Drawing.Size(60, 20);
            this.nudTamaño.TabIndex = 4;
            // 
            // nudX2
            // 
            this.nudX2.Location = new System.Drawing.Point(348, 29);
            this.nudX2.Maximum = new decimal(new int[] {10000,0,0,0});
            this.nudX2.Name = "nudX2";
            this.nudX2.Size = new System.Drawing.Size(60, 20);
            this.nudX2.TabIndex = 5;
            // 
            // nudY2
            // 
            this.nudY2.Location = new System.Drawing.Point(414, 29);
            this.nudY2.Maximum = new decimal(new int[] {10000,0,0,0});
            this.nudY2.Name = "nudY2";
            this.nudY2.Size = new System.Drawing.Size(60, 20);
            this.nudY2.TabIndex = 6;
            // 
            // pbColor
            // 
            this.pbColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbColor.Location = new System.Drawing.Point(480, 12);
            this.pbColor.Name = "pbColor";
            this.pbColor.Size = new System.Drawing.Size(32, 32);
            this.pbColor.TabIndex = 7;
            this.pbColor.TabStop = false;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(528, 12);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 32);
            this.btnCrear.TabIndex = 8;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(609, 12);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 32);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // txtContador
            // 
            this.txtContador.Location = new System.Drawing.Point(690, 19);
            this.txtContador.Name = "txtContador";
            this.txtContador.ReadOnly = true;
            this.txtContador.Size = new System.Drawing.Size(90, 20);
            this.txtContador.TabIndex = 10;
            // 
            // pbLienzo
            // 
            this.pbLienzo.BackColor = System.Drawing.Color.White;
            this.pbLienzo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbLienzo.Location = new System.Drawing.Point(12, 58);
            this.pbLienzo.Name = "pbLienzo";
            this.pbLienzo.Size = new System.Drawing.Size(768, 380);
            this.pbLienzo.TabIndex = 11;
            this.pbLienzo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbLienzo);
            this.Controls.Add(this.txtContador);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.pbColor);
            this.Controls.Add(this.nudY2);
            this.Controls.Add(this.nudX2);
            this.Controls.Add(this.nudTamaño);
            this.Controls.Add(this.nudY);
            this.Controls.Add(this.nudX);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.cmbFigura);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTamaño)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLienzo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox cmbFigura;
        private System.Windows.Forms.NumericUpDown nudX;
        private System.Windows.Forms.NumericUpDown nudY;
        private System.Windows.Forms.NumericUpDown nudTamaño;
        private System.Windows.Forms.NumericUpDown nudX2;
        private System.Windows.Forms.NumericUpDown nudY2;
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

