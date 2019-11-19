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
    public partial class Form_consulta2 : Form
    {
        //variables globales
        //string cadena = @"data source = DESKTOP-VM0VUTF\SQLEXPRESS01;" +//nombre servidor
        //                    " initial catalog = Promociones_inmobiliarias ;" + //nombre base de datos
        //                    " integrated security=sspi ";
        SqlConnection cn; //variable para la conexion

        public Form_consulta2()
        {
            InitializeComponent();
        }

        private void btn_consulta2_Click(object sender, EventArgs e)
        {
           DataTable dt = new DataTable();
            cn.Open();
            //SqlDataAdapter da = new SqlDataAdapter("select Empresas.empresa_id,Empresas.nombre,Empresas.tipo,Viviendas.vivienda_id,Viviendas.superficie from Viviendas,Empresas,Promociones,promociones_empresas where Viviendas.promo_id ="+(comboBox1.SelectedIndex+1) +" and Viviendas.promo_id = Promociones.promo_id and promociones_empresas.promo_id = Promociones.promo_id  and Empresas.empresa_id = promociones_empresas.empresa_id", cn);

            SqlDataAdapter da = new SqlDataAdapter("select Empresas.empresa_id,Empresas.nombre,Empresas.tipo,Viviendas.vivienda_id,Viviendas.superficie " +
                "from Viviendas,Empresas,Promociones,promociones_empresas"+
                " where Viviendas.promo_id ="+(comboBox1.SelectedIndex+1)+
                " and Viviendas.promo_id = Promociones.promo_id"+
                " and promociones_empresas.promo_id = Promociones.promo_id"+
                " and Empresas.empresa_id = promociones_empresas.empresa_id", cn);
            da.Fill(dt);
            cn.Close();
            dataGridView1.DataSource = dt;
        }

        private void Form_consulta2_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(Class1.Cadena());
            
            DataTable dt = new DataTable();
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Promociones", cn);
            da.Fill(dt);
            cn.Close();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                    comboBox1.Items.Add(dt.Rows[i][0]);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
