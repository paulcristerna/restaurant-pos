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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToShortDateString().ToString() + " - " + DateTime.Now.ToLongTimeString().ToString();        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start(); 
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            //MOSTRAR EL MENU
            Menu menu = new Menu();
            menu.Show();

            //OCULTAR PANTALLA PRINCIPAL
            this.Hide();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            //MOSTRAR LOS PEDIDOS
            Pedidos pedido = new Pedidos();
            pedido.Show();

            //OCULTAR PANTALLA PRINCIPAL
            this.Hide();
        }       

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            //MOSTRAR LOS EMPLEADOS
            Empleados empleados = new Empleados();
            empleados.Show();

            //OCULTAR PANTALLA PRINCIPAL
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //CERRAR EL SISTEMA
            System.Windows.Forms.Application.Exit();
        }
    }
}
