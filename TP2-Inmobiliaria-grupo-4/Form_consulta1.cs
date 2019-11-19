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
    public partial class Form_consulta1 : Form
    {
        //variables globales
        //string cadena = @"data source = DESKTOP-VM0VUTF\SQLEXPRESS01;" +//nombre servidor
         //                   " initial catalog = Promociones_inmobiliarias ;" + //nombre base de datos
           //                 " integrated security=sspi ";
        SqlConnection cn; //variable para la conexion

        public Form_consulta1()
        {
            InitializeComponent();
        }

        private void btn_consulta_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter ("select Viviendas.vivienda_id from Empresas,Viviendas,Promociones,promociones_empresas" +
" where Viviendas.promo_id=Promociones.promo_id" +
" and promociones_empresas.empresa_id = Empresas.empresa_id" +
" and promociones_empresas.promo_id = Promociones.promo_id"+
" and Empresas.nombre like '" + txt_nombre.Text + "' and Empresas.tipo like '" + txt_tipo.Text +"'", cn);
            da.Fill(dt);
            cn.Close();
            dataGridView1.DataSource = dt;

        }

        private void Form_consulta1_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(Class1.Cadena());

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
