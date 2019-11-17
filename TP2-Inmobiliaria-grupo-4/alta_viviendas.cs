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
    public partial class form_alta_viviendas : Form
    {

        SqlConnection cn;

        public form_alta_viviendas()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //LLama a la conexion desde el Class 1
            cn = new SqlConnection(Class1.Cadena());

            // Exporta los datos de promociones
            cn.Open();
            DataTable dt = new DataTable();
            string query = "select promo_id, nombre from promociones ";
            SqlCommand cmd = new SqlCommand(query, cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            //Carga los datos al combobox
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "promo_id";
            comboBox1.DataSource = dt;

            cn.Close();

        }

        private void Btn_agregar_viv_Click(object sender, EventArgs e)
        {
            //para dar de alta los datos de la vivienda
            cn.Open();
            SqlCommand com = new SqlCommand("insert into Viviendas" +
                "(superficie, nro_habitaciones, nro_baños, precio, terraza, jardin, piscina, garage, promo_id)" +
                "values(@su, @ha ,@ba ,@pre, @te, @ja, @pi, @ga, @pro)", cn);

            com.Parameters.AddWithValue("@su", textBox1.Text);
            com.Parameters.AddWithValue("@ha", textBox2.Text);
            com.Parameters.AddWithValue("@ba", textBox3.Text);
            com.Parameters.AddWithValue("@pre", textBox4.Text);
            com.Parameters.AddWithValue("@te", checkBox1.Checked);
            com.Parameters.AddWithValue("@pi", checkBox2.Checked);
            com.Parameters.AddWithValue("@ja", checkBox4.Checked);
            com.Parameters.AddWithValue("@ga", checkBox3.Checked);
            com.Parameters.AddWithValue("@pro", (comboBox1.SelectedIndex + 1));


            com.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Alta exitosa");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
