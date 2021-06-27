namespace WindowsFormsApp1
{
    partial class Ventas
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
            this.franquiciav = new System.Windows.Forms.Label();
            this.franquiciaBoxv = new System.Windows.Forms.ComboBox();
            this.figuradeaccion = new System.Windows.Forms.Label();
            this.figuraBox = new System.Windows.Forms.ComboBox();
            this.dataGridventas = new System.Windows.Forms.DataGridView();
            this.comprar = new System.Windows.Forms.Button();
            this.Total = new System.Windows.Forms.Label();
            this.totalBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridventas)).BeginInit();
            this.SuspendLayout();
            // 
            // franquiciav
            // 
            this.franquiciav.AutoSize = true;
            this.franquiciav.Location = new System.Drawing.Point(63, 90);
            this.franquiciav.Name = "franquiciav";
            this.franquiciav.Size = new System.Drawing.Size(56, 13);
            this.franquiciav.TabIndex = 0;
            this.franquiciav.Text = "Franquicia";
            // 
            // franquiciaBoxv
            // 
            this.franquiciaBoxv.FormattingEnabled = true;
            this.franquiciaBoxv.Items.AddRange(new object[] {
            "Marvel",
            "DC",
            "Capcom"});
            this.franquiciaBoxv.Location = new System.Drawing.Point(125, 87);
            this.franquiciaBoxv.Name = "franquiciaBoxv";
            this.franquiciaBoxv.Size = new System.Drawing.Size(121, 21);
            this.franquiciaBoxv.TabIndex = 1;
            // 
            // figuradeaccion
            // 
            this.figuradeaccion.AutoSize = true;
            this.figuradeaccion.Location = new System.Drawing.Point(448, 86);
            this.figuradeaccion.Name = "figuradeaccion";
            this.figuradeaccion.Size = new System.Drawing.Size(90, 13);
            this.figuradeaccion.TabIndex = 2;
            this.figuradeaccion.Text = "Figura de Accion:";
            // 
            // figuraBox
            // 
            this.figuraBox.FormattingEnabled = true;
            this.figuraBox.Location = new System.Drawing.Point(544, 82);
            this.figuraBox.Name = "figuraBox";
            this.figuraBox.Size = new System.Drawing.Size(145, 21);
            this.figuraBox.TabIndex = 3;
            // 
            // dataGridventas
            // 
            this.dataGridventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridventas.Location = new System.Drawing.Point(125, 243);
            this.dataGridventas.Name = "dataGridventas";
            this.dataGridventas.Size = new System.Drawing.Size(564, 105);
            this.dataGridventas.TabIndex = 4;
            // 
            // comprar
            // 
            this.comprar.Location = new System.Drawing.Point(125, 155);
            this.comprar.Name = "comprar";
            this.comprar.Size = new System.Drawing.Size(78, 40);
            this.comprar.TabIndex = 5;
            this.comprar.Text = "Comprar";
            this.comprar.UseVisualStyleBackColor = true;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(541, 182);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(31, 13);
            this.Total.TabIndex = 6;
            this.Total.Text = "Total";
            this.Total.Click += new System.EventHandler(this.Total_Click);
            // 
            // totalBox
            // 
            this.totalBox.Location = new System.Drawing.Point(586, 180);
            this.totalBox.Name = "totalBox";
            this.totalBox.Size = new System.Drawing.Size(64, 20);
            this.totalBox.TabIndex = 7;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.totalBox);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.comprar);
            this.Controls.Add(this.dataGridventas);
            this.Controls.Add(this.figuraBox);
            this.Controls.Add(this.figuradeaccion);
            this.Controls.Add(this.franquiciaBoxv);
            this.Controls.Add(this.franquiciav);
            this.Name = "Ventas";
            this.Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridventas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label franquiciav;
        private System.Windows.Forms.ComboBox franquiciaBoxv;
        private System.Windows.Forms.Label figuradeaccion;
        private System.Windows.Forms.ComboBox figuraBox;
        private System.Windows.Forms.DataGridView dataGridventas;
        private System.Windows.Forms.Button comprar;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.TextBox totalBox;
    }
}