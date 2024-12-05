using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Viajes
{
    public partial class Sucursales : Form
    {
        SqlConnection coneccion = new SqlConnection("server=.\\SQLEXPRESS ; database=Transporte ; INTEGRATED SECURITY = true");
        public Sucursales()
        {
            InitializeComponent();
            cargar_datos();
        }



        public void cargar_datos()
        {
            coneccion.Open();
            SqlCommand cmd = new SqlCommand("Select ID_Ciudad, Nombre from Ciudad", coneccion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            coneccion.Close();

            DataRow fila = dt.NewRow();
            fila["Nombre"] = "Seleccione una ciudad";
            dt.Rows.InsertAt(fila, 0);

            comboBox1.ValueMember = "ID_Ciudad";
            comboBox1.DisplayMember = "Nombre";
            comboBox1.DataSource = dt;
        }

        public void cargar_sucursales(string id_ciudad)
        {
            coneccion.Open();
            SqlCommand cmd = new SqlCommand("Select ID_Sucursal, Nombre from Sucursal where ID_Ciudad = @id_ciudad", coneccion);
            cmd.Parameters.AddWithValue("id_ciudad", id_ciudad);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            coneccion.Close();

            DataRow fila = dt.NewRow();
            fila["Nombre"] = "Seleccione una sucursal";
            dt.Rows.InsertAt(fila, 0);

            comboBox2.ValueMember = "ID_Sucursal";
            comboBox2.DisplayMember = "Nombre";
            comboBox2.DataSource = dt;
        }


        private void Sucursales_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue.ToString() != null)
            {
                string id_ciudad = comboBox1.SelectedValue.ToString();
                cargar_sucursales(id_ciudad);
            }
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Length < 13)
            {
                MessageBox.Show("El ID deben ser 13 numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (int.Parse(txtDis.Text) <= 0 || int.Parse(txtDis.Text) > 50)
            {
                MessageBox.Show("La distancia debe ser mayor a 0KM o menor que 50KM", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                coneccion.Open();
                SqlCommand comando = new SqlCommand("select ID_Empleado, ID_Sucursal from EMPSUC where ID_Empleado = @ID_Empleado and ID_Sucursal = @ID_Sucursal", coneccion);
                comando.Parameters.AddWithValue("@ID_Empleado", txtID.Text);
                comando.Parameters.AddWithValue("@ID_Sucursal", comboBox2.SelectedValue);

                SqlDataReader lector = comando.ExecuteReader();


                if (lector.Read())
                {
                    MessageBox.Show("El empleado ya esta asignado a esta sucursal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    coneccion.Close();
                }
                else
                {
                    coneccion.Close();
                    coneccion.Open();
                    string cmdEmp = "insert into Empleado values(" + txtID.Text + ",'" + txtName.Text + "', '" + txtDir.Text + "' , '" + comboBox1.SelectedValue + "')";
                    string cmdES = "insert into EMPSUC values(" + txtID.Text + ", '" + comboBox2.SelectedValue + "' , '" + txtDis.Text + "')";
                    SqlCommand cmdE1 = new SqlCommand(cmdEmp, coneccion);
                    SqlCommand cmdE2 = new SqlCommand(cmdES, coneccion);
                    cmdE1.ExecuteNonQuery();
                    cmdE2.ExecuteNonQuery();
                    MessageBox.Show("Registro guardado satisfactoriamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    coneccion.Close();
                    txtID.Text = "";
                    txtName.Text = "";
                    txtDir.Text = "";
                    txtDis.Text = "";
                    cargar_datos();
                }
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Home pantalla = new Home();
            pantalla.Show();
        }
    }
}
