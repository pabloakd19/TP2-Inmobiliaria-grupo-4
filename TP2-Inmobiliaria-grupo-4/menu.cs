using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2_Inmobiliaria_grupo_4
{
    public partial class form_menu : Form
    {
        public form_menu()
        {
            InitializeComponent();
        }

        private void btn_alta_viviendas_Click(object sender, EventArgs e)
        {
            form_alta_viviendas alta_viviendas = new form_alta_viviendas();
            alta_viviendas.Show();
        }

        private void form_menu_Load(object sender, EventArgs e)
        {

        }

        private void btn_aboutus_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Grupo 4 Integrantes:\n Andrea Lopez\n Alcides Barrios\n Federico Perez Krohn\n Fernando Puchalski\n Pablo Tartalo");
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
          this.Close();
        }



        private void btn_consultas_Click(object sender, EventArgs e)
        {
            form_consultas consultas = new form_consultas();
            consultas.Show();
        }

        private void btn_alta_promociones_Click(object sender, EventArgs e)
        {
            alta_promociones alta_promociones = new alta_promociones();
            alta_promociones.Show();

        }
    }
}
