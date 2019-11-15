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
            cn = new SqlConnection(Class1.Cadena());
            cn.Open();

        }

        private void Btn_agregar_viv_Click(object sender, EventArgs e)
        {
            //para dar de alta wacheen
            cn.Open();
            SqlCommand com = new SqlCommand("insert into Viviendas" +
                "(superficie, habitaciones, baños, precio, terraza, jardin, piscina, garage, promo_id)" +
                "values(@su, @ha ,@ba ,@pre, @te, @ja, @pi, @ga, @pro)", cn);

            com.Parameters.AddWithValue("@su", textBox1.Text);
            com.Parameters.AddWithValue("@ha", textBox2.Text);
            com.Parameters.AddWithValue("@ba", textBox3.Text);
            com.Parameters.AddWithValue("@pre", textBox4.Text);
            com.Parameters.AddWithValue("@te", checkBox1.Checked);
            com.Parameters.AddWithValue("@pi", checkBox2.Checked);
            com.Parameters.AddWithValue("@ja", checkBox4.Checked);
            com.Parameters.AddWithValue("@ga", checkBox3.Checked);

            com.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Alta exitosa");
        }
    }
}
