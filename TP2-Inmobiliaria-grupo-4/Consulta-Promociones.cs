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
    public partial class form_Consulta_Promociones : Form
    {
        SqlConnection cn;

        public form_Consulta_Promociones()
        {
            InitializeComponent();
        }

        private void Consulta_Promociones_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(Class1.Cadena());
        }

        private void btn_consulta3_Click(object sender, EventArgs e)
        {
            cn.Open();

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2;

            da2 = new SqlDataAdapter
               ("select promociones.promo_id, nombre, poblacion, " +
               "vivienda_id, superficie, nro_habitaciones, nro_baños, " +
               "precio, terraza, jardin, piscina, garage from viviendas, " +
               "promociones where promociones.promo_id = " + txt_promoid.Text +
               "and viviendas.promo_id = promociones.promo_id", cn);


            da2.Fill(dt2);

            dataGrid_cons_prom.DataSource = dt2;


            cn.Close();
        }
    }
}
