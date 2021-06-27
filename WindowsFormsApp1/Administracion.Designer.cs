namespace WindowsFormsApp1
{
    partial class Administracion
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
            this.franquiciaBox = new System.Windows.Forms.ComboBox();
            this.franquicia = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.nombreBox = new System.Windows.Forms.TextBox();
            this.descripcion = new System.Windows.Forms.Label();
            this.descripcionBox = new System.Windows.Forms.TextBox();
            this.precio = new System.Windows.Forms.Label();
            this.precionumeric = new System.Windows.Forms.NumericUpDown();
            this.tbFiguras = new System.Windows.Forms.DataGridView();
            this.existencias = new System.Windows.Forms.Label();
            this.existencianumeric = new System.Windows.Forms.NumericUpDown();
            this.crear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.precionumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFiguras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.existencianumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // franquiciaBox
            // 
            this.franquiciaBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.franquiciaBox.FormattingEnabled = true;
            this.franquiciaBox.Items.AddRange(new object[] {
            "Marvel",
            "DC",
            "Capcom"});
            this.franquiciaBox.Location = new System.Drawing.Point(142, 40);
            this.franquiciaBox.Name = "franquiciaBox";
            this.franquiciaBox.Size = new System.Drawing.Size(80, 21);
            this.franquiciaBox.TabIndex = 1;
            // 
            // franquicia
            // 
            this.franquicia.AutoSize = true;
            this.franquicia.Location = new System.Drawing.Point(54, 43);
            this.franquicia.Name = "franquicia";
            this.franquicia.Size = new System.Drawing.Size(59, 13);
            this.franquicia.TabIndex = 2;
            this.franquicia.Text = "Franquicia:";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(54, 104);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(47, 13);
            this.nombre.TabIndex = 3;
            this.nombre.Text = "Nombre:";
            // 
            // nombreBox
            // 
            this.nombreBox.Location = new System.Drawing.Point(139, 101);
            this.nombreBox.Name = "nombreBox";
            this.nombreBox.Size = new System.Drawing.Size(83, 20);
            this.nombreBox.TabIndex = 4;
            // 
            // descripcion
            // 
            this.descripcion.AutoSize = true;
            this.descripcion.Location = new System.Drawing.Point(54, 147);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(66, 13);
            this.descripcion.TabIndex = 5;
            this.descripcion.Text = "Descripcion:";
            // 
            // descripcionBox
            // 
            this.descripcionBox.Location = new System.Drawing.Point(57, 177);
            this.descripcionBox.Name = "descripcionBox";
            this.descripcionBox.Size = new System.Drawing.Size(379, 20);
            this.descripcionBox.TabIndex = 6;
            // 
            // precio
            // 
            this.precio.AutoSize = true;
            this.precio.Location = new System.Drawing.Point(556, 101);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(40, 13);
            this.precio.TabIndex = 7;
            this.precio.Text = "Precio:";
            // 
            // precionumeric
            // 
            this.precionumeric.Location = new System.Drawing.Point(602, 99);
            this.precionumeric.Name = "precionumeric";
            this.precionumeric.Size = new System.Drawing.Size(120, 20);
            this.precionumeric.TabIndex = 8;
            this.precionumeric.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // tbFiguras
            // 
            this.tbFiguras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbFiguras.Location = new System.Drawing.Point(103, 291);
            this.tbFiguras.Name = "tbFiguras";
            this.tbFiguras.Size = new System.Drawing.Size(638, 112);
            this.tbFiguras.TabIndex = 9;
            // 
            // existencias
            // 
            this.existencias.AutoSize = true;
            this.existencias.Location = new System.Drawing.Point(536, 147);
            this.existencias.Name = "existencias";
            this.existencias.Size = new System.Drawing.Size(60, 13);
            this.existencias.TabIndex = 10;
            this.existencias.Text = "Existencias";
            this.existencias.Click += new System.EventHandler(this.label5_Click);
            // 
            // existencianumeric
            // 
            this.existencianumeric.Location = new System.Drawing.Point(602, 145);
            this.existencianumeric.Name = "existencianumeric";
            this.existencianumeric.Size = new System.Drawing.Size(120, 20);
            this.existencianumeric.TabIndex = 11;
            // 
            // crear
            // 
            this.crear.Location = new System.Drawing.Point(103, 246);
            this.crear.Name = "crear";
            this.crear.Size = new System.Drawing.Size(100, 39);
            this.crear.TabIndex = 12;
            this.crear.Text = "Crear";
            this.crear.UseVisualStyleBackColor = true;
            this.crear.Click += new System.EventHandler(this.crear_Click);
            // 
            // Administracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crear);
            this.Controls.Add(this.existencianumeric);
            this.Controls.Add(this.existencias);
            this.Controls.Add(this.tbFiguras);
            this.Controls.Add(this.precionumeric);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.descripcionBox);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.nombreBox);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.franquicia);
            this.Controls.Add(this.franquiciaBox);
            this.Name = "Administracion";
            this.Text = "Administracion";
            ((System.ComponentModel.ISupportInitialize)(this.precionumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFiguras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.existencianumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox franquiciaBox;
        private System.Windows.Forms.Label franquicia;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.TextBox nombreBox;
        private System.Windows.Forms.Label descripcion;
        private System.Windows.Forms.TextBox descripcionBox;
        private System.Windows.Forms.Label precio;
        private System.Windows.Forms.NumericUpDown precionumeric;
        private System.Windows.Forms.DataGridView tbFiguras;
        private System.Windows.Forms.Label existencias;
        private System.Windows.Forms.NumericUpDown existencianumeric;
        private System.Windows.Forms.Button crear;
    }
}