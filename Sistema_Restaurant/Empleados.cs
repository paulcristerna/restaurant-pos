using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Restaurant
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            //VOLVER A LAS OPCIONES PRINCIPALES
            Form1 form1 = new Form1();
            form1.Show();

            //OCULTAR LA PANTALLA ACTUAL
            this.Hide();
        }
    }
}
