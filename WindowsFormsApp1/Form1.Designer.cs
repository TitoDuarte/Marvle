namespace WindowsFormsApp1
{
    partial class Form1
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
            this.administracion = new System.Windows.Forms.Button();
            this.ventas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // administracion
            // 
            this.administracion.Location = new System.Drawing.Point(305, 68);
            this.administracion.Name = "administracion";
            this.administracion.Size = new System.Drawing.Size(162, 73);
            this.administracion.TabIndex = 0;
            this.administracion.Text = "Administracion";
            this.administracion.UseVisualStyleBackColor = true;
            this.administracion.Click += new System.EventHandler(this.administracion_Click);
            // 
            // ventas
            // 
            this.ventas.Location = new System.Drawing.Point(308, 168);
            this.ventas.Name = "ventas";
            this.ventas.Size = new System.Drawing.Size(158, 71);
            this.ventas.TabIndex = 1;
            this.ventas.Text = "Ventas";
            this.ventas.UseVisualStyleBackColor = true;
            this.ventas.Click += new System.EventHandler(this.ventas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ventas);
            this.Controls.Add(this.administracion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button administracion;
        private System.Windows.Forms.Button ventas;
    }
}

