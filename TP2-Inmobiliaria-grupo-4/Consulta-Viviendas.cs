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

            int gar = 0;
            int pis = 0;
            int jar = 0;
            int ter = 0;

            
            if (chk_garaje.Checked)
            {
                gar = 1;
            }
            if (chk_jardin.Checked)
            {
                jar = 1;
            }
            if (chk_piscina.Checked)
            {
                pis = 1;
            }
            if (chk_terraza.Checked)
            {
                ter = 1;
            }


            da2 = new SqlDataAdapter("select * from viviendas where"+
                " garage = "+ gar +" and terraza = "+ ter +
                " and piscina = "+ pis +" and jardin = " + jar , cn);


            da2.Fill(dt2);

            dataGrid_con_viv.DataSource = dt2;


            cn.Close();

        }
    }
}
