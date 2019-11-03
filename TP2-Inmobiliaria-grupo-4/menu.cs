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
    }
}
