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
    public partial class form_alta_empresas : Form
    {
        SqlConnection cn;
        public form_alta_empresas()
        {
            InitializeComponent();
        }
              
        private void form_alta_empresas_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(Class1.Cadena());
            cn.Open();

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2;

            da2 = new SqlDataAdapter("select * from Empresas", cn);

            da2.Fill(dt2);

            dgv_empresas.DataSource = dt2;
            cn.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            //Abro conexion para realizar el alta de una nueva Empresa
            cn.Open();
            SqlCommand com = new SqlCommand("insert into Empresas " +
                "(nombre,tipo,direccion,telefono,fax,email)" +
                "values(@nombre, @tipo,@direccion,@telefono,@fax,@email )", cn);
            
            com.Parameters.AddWithValue("@nombre", tb_Nombre.Text);
            com.Parameters.AddWithValue("@tipo", tb_tipo.Text);
            com.Parameters.AddWithValue("@direccion", tb_direccion.Text);
            com.Parameters.AddWithValue("@telefono", tb_tel.Text);
            com.Parameters.AddWithValue("@fax", tb_fax.Text);
            com.Parameters.AddWithValue("@email", tb_email.Text);

            com.ExecuteNonQuery();
            cn.Close();
 
            // Recardo el Datagrid para reflejar la nueva alta
            cn.Open();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2;
            da2 = new SqlDataAdapter("select * from Empresas", cn);
            da2.Fill(dt2);
            dgv_empresas.DataSource = dt2;
            cn.Close();

        }
    }
}
