using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Administracion : Form
    {
        public Administracion()
        {
            InitializeComponent();
            tabla();
        }

        private void tabla()
        {
            string select = "select * from marvel.figuras";

            Conector conector = new Conector();
            conector.Select(select, tbFiguras);
        }

        private void Franquicia_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void crear_Click(object sender, EventArgs e)
        {
            Figuras figuras = new Figuras(franquiciaBox.Text, nombreBox.Text, descripcionBox.Text, int.Parse(existencianumeric.Text), int.Parse(precionumeric.Text));

            string insert = $"insert into marvel.figuras(Nombre, Descripcion, Precio, Existencia) values('{figuras.nombre}', '{figuras.descripcion}',{figuras.precio},{figuras.existencia});";
            Conector conector = new Conector();
            conector.Insert(insert);
            tabla();
        }
    }
}
