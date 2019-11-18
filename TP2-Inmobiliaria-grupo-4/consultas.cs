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
    public partial class form_consultas : Form
    {
        public form_consultas()
        {
            InitializeComponent();
        }

        private void btn_cons_viviendas_Click(object sender, EventArgs e)
        {
            form_Consulta_Viviendas Consulta_Viviendas = new form_Consulta_Viviendas();
            Consulta_Viviendas.Show();
        }

        private void btn_consulta1_Click(object sender, EventArgs e)
        {
            Form_consulta1 consulta1 = new Form_consulta1();
            consulta1.Show();
        }

        private void btn_consulta2_Click(object sender, EventArgs e)
        {
            Form_consulta2 consulta2 = new Form_consulta2();
            consulta2.Show();
        }

        private void form_consultas_Load(object sender, EventArgs e)
        {

        }
    }
}
