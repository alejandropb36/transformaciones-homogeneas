namespace transformaciones_homogeneas
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.WorkSpace = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelPuntos = new System.Windows.Forms.Label();
            this.labelRotacion = new System.Windows.Forms.Label();
            this.labelEscalar = new System.Windows.Forms.Label();
            this.labelReflectar = new System.Windows.Forms.Label();
            this.labelTrasladar = new System.Windows.Forms.Label();
            this.labelTrasladarX = new System.Windows.Forms.Label();
            this.labelTrasladarY = new System.Windows.Forms.Label();
            this.textBoxRotacion = new System.Windows.Forms.TextBox();
            this.textBoxEscalar = new System.Windows.Forms.TextBox();
            this.comboBoxReflectar = new System.Windows.Forms.ComboBox();
            this.textBoxTrasladarX = new System.Windows.Forms.TextBox();
            this.textBoxTrasladarY = new System.Windows.Forms.TextBox();
            this.buttonAplicar = new System.Windows.Forms.Button();
            this.comboBoxPuntos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // WorkSpace
            // 
            this.WorkSpace.BackColor = System.Drawing.SystemColors.Window;
            this.WorkSpace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WorkSpace.Location = new System.Drawing.Point(12, 12);
            this.WorkSpace.Name = "WorkSpace";
            this.WorkSpace.Size = new System.Drawing.Size(736, 673);
            this.WorkSpace.TabIndex = 0;
            this.WorkSpace.MouseClick += new System.Windows.Forms.MouseEventHandler(this.WorkSpace_MouseClick);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(860, 26);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(91, 31);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "Figura";
            // 
            // labelPuntos
            // 
            this.labelPuntos.AutoSize = true;
            this.labelPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPuntos.Location = new System.Drawing.Point(766, 80);
            this.labelPuntos.Name = "labelPuntos";
            this.labelPuntos.Size = new System.Drawing.Size(78, 24);
            this.labelPuntos.TabIndex = 2;
            this.labelPuntos.Text = "Puntos: ";
            // 
            // labelRotacion
            // 
            this.labelRotacion.AutoSize = true;
            this.labelRotacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRotacion.Location = new System.Drawing.Point(766, 126);
            this.labelRotacion.Name = "labelRotacion";
            this.labelRotacion.Size = new System.Drawing.Size(94, 24);
            this.labelRotacion.TabIndex = 3;
            this.labelRotacion.Text = "Rotación: ";
            // 
            // labelEscalar
            // 
            this.labelEscalar.AutoSize = true;
            this.labelEscalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEscalar.Location = new System.Drawing.Point(766, 171);
            this.labelEscalar.Name = "labelEscalar";
            this.labelEscalar.Size = new System.Drawing.Size(82, 24);
            this.labelEscalar.TabIndex = 4;
            this.labelEscalar.Text = "Escalar: ";
            // 
            // labelReflectar
            // 
            this.labelReflectar.AutoSize = true;
            this.labelReflectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReflectar.Location = new System.Drawing.Point(766, 216);
            this.labelReflectar.Name = "labelReflectar";
            this.labelReflectar.Size = new System.Drawing.Size(93, 24);
            this.labelReflectar.TabIndex = 5;
            this.labelReflectar.Text = "Reflectar: ";
            // 
            // labelTrasladar
            // 
            this.labelTrasladar.AutoSize = true;
            this.labelTrasladar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrasladar.Location = new System.Drawing.Point(852, 265);
            this.labelTrasladar.Name = "labelTrasladar";
            this.labelTrasladar.Size = new System.Drawing.Size(88, 24);
            this.labelTrasladar.TabIndex = 6;
            this.labelTrasladar.Text = "Trasladar";
            // 
            // labelTrasladarX
            // 
            this.labelTrasladarX.AutoSize = true;
            this.labelTrasladarX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrasladarX.Location = new System.Drawing.Point(810, 295);
            this.labelTrasladarX.Name = "labelTrasladarX";
            this.labelTrasladarX.Size = new System.Drawing.Size(34, 24);
            this.labelTrasladarX.TabIndex = 7;
            this.labelTrasladarX.Text = "X: ";
            // 
            // labelTrasladarY
            // 
            this.labelTrasladarY.AutoSize = true;
            this.labelTrasladarY.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrasladarY.Location = new System.Drawing.Point(812, 343);
            this.labelTrasladarY.Name = "labelTrasladarY";
            this.labelTrasladarY.Size = new System.Drawing.Size(32, 24);
            this.labelTrasladarY.TabIndex = 8;
            this.labelTrasladarY.Text = "Y: ";
            // 
            // textBoxRotacion
            // 
            this.textBoxRotacion.Location = new System.Drawing.Point(866, 128);
            this.textBoxRotacion.Name = "textBoxRotacion";
            this.textBoxRotacion.Size = new System.Drawing.Size(100, 22);
            this.textBoxRotacion.TabIndex = 10;
            // 
            // textBoxEscalar
            // 
            this.textBoxEscalar.Location = new System.Drawing.Point(866, 173);
            this.textBoxEscalar.Name = "textBoxEscalar";
            this.textBoxEscalar.Size = new System.Drawing.Size(100, 22);
            this.textBoxEscalar.TabIndex = 11;
            // 
            // comboBoxReflectar
            // 
            this.comboBoxReflectar.FormattingEnabled = true;
            this.comboBoxReflectar.Location = new System.Drawing.Point(866, 216);
            this.comboBoxReflectar.Name = "comboBoxReflectar";
            this.comboBoxReflectar.Size = new System.Drawing.Size(121, 24);
            this.comboBoxReflectar.TabIndex = 12;
            // 
            // textBoxTrasladarX
            // 
            this.textBoxTrasladarX.Location = new System.Drawing.Point(866, 297);
            this.textBoxTrasladarX.Name = "textBoxTrasladarX";
            this.textBoxTrasladarX.Size = new System.Drawing.Size(100, 22);
            this.textBoxTrasladarX.TabIndex = 13;
            // 
            // textBoxTrasladarY
            // 
            this.textBoxTrasladarY.Location = new System.Drawing.Point(866, 345);
            this.textBoxTrasladarY.Name = "textBoxTrasladarY";
            this.textBoxTrasladarY.Size = new System.Drawing.Size(100, 22);
            this.textBoxTrasladarY.TabIndex = 14;
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(860, 419);
            this.buttonAplicar.Name = "buttonAplicar";
            this.buttonAplicar.Size = new System.Drawing.Size(126, 31);
            this.buttonAplicar.TabIndex = 15;
            this.buttonAplicar.Text = "Aplicar";
            this.buttonAplicar.UseVisualStyleBackColor = true;
            // 
            // comboBoxPuntos
            // 
            this.comboBoxPuntos.FormattingEnabled = true;
            this.comboBoxPuntos.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxPuntos.Location = new System.Drawing.Point(865, 80);
            this.comboBoxPuntos.Name = "comboBoxPuntos";
            this.comboBoxPuntos.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPuntos.TabIndex = 16;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 697);
            this.Controls.Add(this.comboBoxPuntos);
            this.Controls.Add(this.buttonAplicar);
            this.Controls.Add(this.textBoxTrasladarY);
            this.Controls.Add(this.textBoxTrasladarX);
            this.Controls.Add(this.comboBoxReflectar);
            this.Controls.Add(this.textBoxEscalar);
            this.Controls.Add(this.textBoxRotacion);
            this.Controls.Add(this.labelTrasladarY);
            this.Controls.Add(this.labelTrasladarX);
            this.Controls.Add(this.labelTrasladar);
            this.Controls.Add(this.labelReflectar);
            this.Controls.Add(this.labelEscalar);
            this.Controls.Add(this.labelRotacion);
            this.Controls.Add(this.labelPuntos);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.WorkSpace);
            this.Name = "MainForm";
            this.Text = "Work Space";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel WorkSpace;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelPuntos;
        private System.Windows.Forms.Label labelRotacion;
        private System.Windows.Forms.Label labelEscalar;
        private System.Windows.Forms.Label labelReflectar;
        private System.Windows.Forms.Label labelTrasladar;
        private System.Windows.Forms.Label labelTrasladarX;
        private System.Windows.Forms.Label labelTrasladarY;
        private System.Windows.Forms.TextBox textBoxRotacion;
        private System.Windows.Forms.TextBox textBoxEscalar;
        private System.Windows.Forms.ComboBox comboBoxReflectar;
        private System.Windows.Forms.TextBox textBoxTrasladarX;
        private System.Windows.Forms.TextBox textBoxTrasladarY;
        private System.Windows.Forms.Button buttonAplicar;
        private System.Windows.Forms.ComboBox comboBoxPuntos;
    }
}

