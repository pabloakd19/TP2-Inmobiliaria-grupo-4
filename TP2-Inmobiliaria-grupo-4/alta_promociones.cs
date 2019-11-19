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
            cn.Open();

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2;

            da2 = new SqlDataAdapter("select * from Promociones", cn);

            da2.Fill(dt2);

            dataGridView1.DataSource = dt2;
            cn.Close();
            //cn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Para realzar el alta de una nueva Promocion
            cn.Open();
            SqlCommand com = new SqlCommand("insert into Promociones " +
                "(nombre,poblacion)" +
                "values(@nombre, @poblacion )", cn);

            com.Parameters.AddWithValue("@nombre", tb_Nombre.Text);
            com.Parameters.AddWithValue("@poblacion", tb_poblacion.Text);

            com.ExecuteNonQuery();
            cn.Close();
            //MessageBox.Show("Alta exitosa");

            // Recargo el Datagrid con la nueva alta
            cn.Open();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2;
            da2 = new SqlDataAdapter("select * from Promociones", cn);
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
            cn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
