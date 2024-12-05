using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Viajes
{
    public partial class ViajeG : Form
    {
        public static string Transpor;
        SqlConnection coneccion = new SqlConnection("server=.\\SQLEXPRESS ; database=Transporte ; INTEGRATED SECURITY = true");
        public ViajeG()
        {
            InitializeComponent();
            cargarDGV();
            cargar_datos();
        }

        public void cargarDGV()
        {
            coneccion.Open();
            string query = ("select a.ID_Viaje as 'No de Viaje', b.Nombre as Conductor from Viaje a join Transportista b on a.ID_Transportista = b.ID_Transportista");
            SqlCommand cmd = new SqlCommand(query, coneccion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);

            dataGridView1.DataSource = dt;

            coneccion.Close();
        }

        public void cargar_datos()
        {
            coneccion.Open();
            SqlCommand cmd = new SqlCommand("Select ID_Transportista, Nombre from Transportista", coneccion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            coneccion.Close();

            DataRow fila = dt.NewRow();
            fila["Nombre"] = "Seleccione un conductor";
            dt.Rows.InsertAt(fila, 0);

            comboBox1.ValueMember = "ID_Transportista";
            comboBox1.DisplayMember = "Nombre";
            comboBox1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Viajes pantalla = new Viajes();
            pantalla.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtID.Text == null || txtID.Text == "")
            {
                MessageBox.Show("Introduzca un Codigo de Viaje", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(Transpor == null)
            {
                MessageBox.Show("Seleccione un conductor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                coneccion.Open();
                SqlCommand cmd = new SqlCommand("Select ID_Viaje from Viaje where ID_Viaje = @id_viaje", coneccion);
                cmd.Parameters.AddWithValue("@id_viaje", txtID.Text);

                SqlDataReader lec = cmd.ExecuteReader();
                if (lec.Read())
                {
                    MessageBox.Show("Viaje ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    coneccion.Close();
                }
                else
                {
                    coneccion.Close();
                    coneccion.Open();
                    SqlCommand cmd1 = new SqlCommand("Insert into Viaje values ('" + txtID.Text + "','" + 0 + "','" + 0 + "','" + comboBox1.SelectedValue.ToString() + "')", coneccion);
                    cmd1.ExecuteNonQuery();
                    coneccion.Close();

                    MessageBox.Show("Registro guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDGV();
                    txtID.Text = "";
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue.ToString() != null)
            {
                Transpor = comboBox1.SelectedValue.ToString();
            }
        }
    }
}
