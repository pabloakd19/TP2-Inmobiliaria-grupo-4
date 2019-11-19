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
    public partial class form_alta_promociones : Form

    {
        SqlConnection cn;
        public form_alta_promociones()
        {
            InitializeComponent();
        }

        private void form_alta_promociones_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(Class1.Cadena());
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //para dar de alta wacheen
            cn.Open();
            SqlCommand com = new SqlCommand("insert into Promociones " +
                "(nombre, poblacion)" +
                "values(@nombre, @poblacion )", cn);

            com.Parameters.AddWithValue("@nombre", tb_Nombre.Text);
            com.Parameters.AddWithValue("@poblacion", tb_poblacion.Text);

            com.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Alta exitosa");
        }
    }
}
