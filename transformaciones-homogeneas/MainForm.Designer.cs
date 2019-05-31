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
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelAccion = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // WorkSpace
            // 
            this.WorkSpace.BackColor = System.Drawing.SystemColors.Window;
            this.WorkSpace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WorkSpace.Location = new System.Drawing.Point(9, 10);
            this.WorkSpace.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WorkSpace.Name = "WorkSpace";
            this.WorkSpace.Size = new System.Drawing.Size(552, 547);
            this.WorkSpace.TabIndex = 0;
            this.WorkSpace.MouseClick += new System.Windows.Forms.MouseEventHandler(this.WorkSpace_MouseClick);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(645, 21);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(73, 26);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "Figura";
            // 
            // labelPuntos
            // 
            this.labelPuntos.AutoSize = true;
            this.labelPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPuntos.Location = new System.Drawing.Point(574, 65);
            this.labelPuntos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPuntos.Name = "labelPuntos";
            this.labelPuntos.Size = new System.Drawing.Size(63, 18);
            this.labelPuntos.TabIndex = 2;
            this.labelPuntos.Text = "Puntos: ";
            // 
            // labelRotacion
            // 
            this.labelRotacion.AutoSize = true;
            this.labelRotacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRotacion.Location = new System.Drawing.Point(574, 102);
            this.labelRotacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRotacion.Name = "labelRotacion";
            this.labelRotacion.Size = new System.Drawing.Size(76, 18);
            this.labelRotacion.TabIndex = 3;
            this.labelRotacion.Text = "Rotación: ";
            // 
            // labelEscalar
            // 
            this.labelEscalar.AutoSize = true;
            this.labelEscalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEscalar.Location = new System.Drawing.Point(574, 139);
            this.labelEscalar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEscalar.Name = "labelEscalar";
            this.labelEscalar.Size = new System.Drawing.Size(66, 18);
            this.labelEscalar.TabIndex = 4;
            this.labelEscalar.Text = "Escalar: ";
            // 
            // labelReflectar
            // 
            this.labelReflectar.AutoSize = true;
            this.labelReflectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReflectar.Location = new System.Drawing.Point(574, 176);
            this.labelReflectar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelReflectar.Name = "labelReflectar";
            this.labelReflectar.Size = new System.Drawing.Size(75, 18);
            this.labelReflectar.TabIndex = 5;
            this.labelReflectar.Text = "Reflectar: ";
            // 
            // labelTrasladar
            // 
            this.labelTrasladar.AutoSize = true;
            this.labelTrasladar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrasladar.Location = new System.Drawing.Point(639, 215);
            this.labelTrasladar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTrasladar.Name = "labelTrasladar";
            this.labelTrasladar.Size = new System.Drawing.Size(70, 18);
            this.labelTrasladar.TabIndex = 6;
            this.labelTrasladar.Text = "Trasladar";
            // 
            // labelTrasladarX
            // 
            this.labelTrasladarX.AutoSize = true;
            this.labelTrasladarX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrasladarX.Location = new System.Drawing.Point(608, 240);
            this.labelTrasladarX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTrasladarX.Name = "labelTrasladarX";
            this.labelTrasladarX.Size = new System.Drawing.Size(26, 18);
            this.labelTrasladarX.TabIndex = 7;
            this.labelTrasladarX.Text = "X: ";
            // 
            // labelTrasladarY
            // 
            this.labelTrasladarY.AutoSize = true;
            this.labelTrasladarY.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrasladarY.Location = new System.Drawing.Point(609, 279);
            this.labelTrasladarY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTrasladarY.Name = "labelTrasladarY";
            this.labelTrasladarY.Size = new System.Drawing.Size(25, 18);
            this.labelTrasladarY.TabIndex = 8;
            this.labelTrasladarY.Text = "Y: ";
            // 
            // textBoxRotacion
            // 
            this.textBoxRotacion.Location = new System.Drawing.Point(650, 104);
            this.textBoxRotacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxRotacion.Name = "textBoxRotacion";
            this.textBoxRotacion.Size = new System.Drawing.Size(76, 20);
            this.textBoxRotacion.TabIndex = 10;
            // 
            // textBoxEscalar
            // 
            this.textBoxEscalar.Location = new System.Drawing.Point(650, 141);
            this.textBoxEscalar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxEscalar.Name = "textBoxEscalar";
            this.textBoxEscalar.Size = new System.Drawing.Size(76, 20);
            this.textBoxEscalar.TabIndex = 11;
            // 
            // comboBoxReflectar
            // 
            this.comboBoxReflectar.FormattingEnabled = true;
            this.comboBoxReflectar.Items.AddRange(new object[] {
            "X",
            "Y"});
            this.comboBoxReflectar.Location = new System.Drawing.Point(650, 176);
            this.comboBoxReflectar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxReflectar.Name = "comboBoxReflectar";
            this.comboBoxReflectar.Size = new System.Drawing.Size(92, 21);
            this.comboBoxReflectar.TabIndex = 12;
            // 
            // textBoxTrasladarX
            // 
            this.textBoxTrasladarX.Location = new System.Drawing.Point(650, 241);
            this.textBoxTrasladarX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTrasladarX.Name = "textBoxTrasladarX";
            this.textBoxTrasladarX.Size = new System.Drawing.Size(76, 20);
            this.textBoxTrasladarX.TabIndex = 13;
            // 
            // textBoxTrasladarY
            // 
            this.textBoxTrasladarY.Location = new System.Drawing.Point(650, 280);
            this.textBoxTrasladarY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTrasladarY.Name = "textBoxTrasladarY";
            this.textBoxTrasladarY.Size = new System.Drawing.Size(76, 20);
            this.textBoxTrasladarY.TabIndex = 14;
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(698, 372);
            this.buttonAplicar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAplicar.Name = "buttonAplicar";
            this.buttonAplicar.Size = new System.Drawing.Size(94, 25);
            this.buttonAplicar.TabIndex = 15;
            this.buttonAplicar.Text = "Aplicar";
            this.buttonAplicar.UseVisualStyleBackColor = true;
            this.buttonAplicar.Click += new System.EventHandler(this.buttonAplicar_Click);
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
            this.comboBoxPuntos.Location = new System.Drawing.Point(649, 65);
            this.comboBoxPuntos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxPuntos.Name = "comboBoxPuntos";
            this.comboBoxPuntos.Size = new System.Drawing.Size(92, 21);
            this.comboBoxPuntos.TabIndex = 16;
            this.comboBoxPuntos.SelectedIndexChanged += new System.EventHandler(this.comboBoxPuntos_SelectedIndexChanged);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(582, 372);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(68, 25);
            this.buttonClear.TabIndex = 17;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelAccion
            // 
            this.labelAccion.AutoSize = true;
            this.labelAccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccion.Location = new System.Drawing.Point(565, 326);
            this.labelAccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAccion.Name = "labelAccion";
            this.labelAccion.Size = new System.Drawing.Size(115, 17);
            this.labelAccion.TabIndex = 18;
            this.labelAccion.Text = "Transformacion: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Rotacion",
            "Esclaar",
            "Reflectar",
            "Trasladar"});
            this.comboBox1.Location = new System.Drawing.Point(685, 326);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(106, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 566);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelAccion);
            this.Controls.Add(this.buttonClear);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelAccion;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

