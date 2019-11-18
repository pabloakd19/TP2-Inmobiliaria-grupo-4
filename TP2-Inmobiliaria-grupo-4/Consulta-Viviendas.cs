using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace TP2_Inmobiliaria_grupo_4
{
    public partial class form_Consulta_Viviendas : Form
    {
        SqlConnection cn;

        public form_Consulta_Viviendas()
        {
            InitializeComponent();
        }

        private void Consulta_Viviendas_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(Class1.Cadena());
        }

        private void btn_consulta4_Click(object sender, EventArgs e)
        {
            cn.Open();

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2;

            da2 = new SqlDataAdapter("select ** from viviendas, promociones, viviendas-promociones where" +
                " garaje = " + chk_garaje.Checked + 
                " and terraza = " + chk_terraza.Checked +
                " and piscina = " + chk_piscina.Checked + 
                " and jardin = " + chk_jardin.Checked , cn);


            da2.Fill(dt2);

            cn.Close();

        }
    }
}
