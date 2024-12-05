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
using Microsoft.VisualBasic.ApplicationServices;

namespace Viajes
{
    public partial class Rviajes : Form
    {
        public static string Empleado;
        public static string Sucursal;
        public static string Fecha;
        public static string KM;

        SqlConnection coneccion = new SqlConnection("server=.\\SQLEXPRESS ; database=Transporte ; INTEGRATED SECURITY = true");
        public Rviajes()
        {
            InitializeComponent();
            SetMyCustomFormat();

            cargar_datos();
            dataGridView1.Enabled = false;
            dataGridView2.Enabled = false;
            dateTimePicker1.Enabled = false;
            txtDist.Enabled = false;
            txtPre.Enabled = false;

            cargarDGV();
            cargarDGV2();

            if(Form1.Rol != "Gerente de Tienda")
            {
                txtID.Enabled = false;
                txtPre.Enabled = false;
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                button2.Enabled = false;
                dateTimePicker1.Enabled = false;
            }
            else
            {
                txtID.Enabled = true;
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                button2.Enabled = true;
                dateTimePicker1.Enabled = true;
            }
        }

        public void cargarDGV()
        {
            coneccion.Open();
            string query = ("select a.ID_Viaje as 'No. de Viaje', b.Fecha, c.Nombre as Empleado, d.Nombre as Sucursal from Viaje a \r\njoin Viaje_Detalle b on a.ID_Viaje=b.ID_Viaje\r\njoin Empleado c on b.ID_Empleado = c.ID_Empleado\r\njoin Sucursal d on b.ID_Sucursal = d.ID_Sucursal");
            SqlCommand cmd = new SqlCommand(query, coneccion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);

            dataGridView1.DataSource = dt;

            coneccion.Close();
        }

        public void cargarDGV2()
        {
            coneccion.Open();
            string query = ("select a.ID_Viaje as 'No de Viaje', b.Nombre as Conductor from Viaje a join Transportista b on a.ID_Transportista = b.ID_Transportista");
            SqlCommand cmd = new SqlCommand(query, coneccion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);

            dataGridView2.DataSource = dt;

            coneccion.Close();
        }

        public void cargar_datos()
        {
            coneccion.Open();
            SqlCommand cmd = new SqlCommand("Select ID_Empleado, Nombre from Empleado", coneccion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            coneccion.Close();

            DataRow fila = dt.NewRow();
            fila["Nombre"] = "Seleccione un empleado";
            dt.Rows.InsertAt(fila, 0);

            comboBox1.ValueMember = "ID_Empleado";
            comboBox1.DisplayMember = "Nombre";
            comboBox1.DataSource = dt;
        }

        public void cargar_sucursales(string id_Empleado)
        {
            coneccion.Open();
            SqlCommand cmd = new SqlCommand("Select a.ID_Sucursal, a.Nombre from Sucursal a join EMPSUC b on a.ID_Sucursal = b.ID_Sucursal where ID_Empleado = @id_empleado", coneccion);
            cmd.Parameters.AddWithValue("id_empleado", id_Empleado);
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

        public void cargardis()
        {
            coneccion.Open();
            SqlCommand cmd = new SqlCommand("select Distancia from EMPSUC where ID_Empleado = @empleado and ID_Sucursal = @sucursal", coneccion);
            cmd.Parameters.AddWithValue("@empleado", Empleado);
            cmd.Parameters.AddWithValue("@sucursal", Sucursal);


            SqlDataReader lec = cmd.ExecuteReader();
            if (lec.Read())
            {
                txtDist.Text = lec["Distancia"].ToString();
                coneccion.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Viajes pantalla = new Viajes();
            pantalla.Show();
        }

        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM-dd-yyyy";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Fecha = dateTimePicker1.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue.ToString() != null)
            {
                Empleado = comboBox1.SelectedValue.ToString();
                string id_Empelado = comboBox1.SelectedValue.ToString();
                cargar_sucursales(id_Empelado);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedValue.ToString() != null)
            {
                Sucursal = comboBox2.SelectedValue.ToString();
                dateTimePicker1.Enabled = true;
            }

        }

        private void label8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cargardis();
            if (Empleado == null)
            {
                MessageBox.Show("Seleccione un empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Sucursal == null)
            {
                MessageBox.Show("Seleccione una sucursal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Fecha == null)
            {
                MessageBox.Show("Seleccione una fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtID.Text == "")
            {
                MessageBox.Show("Introduzca un Codigo de Viaje", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                coneccion.Open();
                SqlCommand cmd = new SqlCommand("Select ID_Viaje from Viaje where ID_Viaje = @id_viaje", coneccion);
                cmd.Parameters.AddWithValue("@id_viaje", txtID.Text);

                SqlDataReader lec = cmd.ExecuteReader();
                if (lec.Read())
                {
                    coneccion.Close();
                    coneccion.Open();
                    SqlCommand cmd1 = new SqlCommand("Select Fecha from Viaje_Detalle where Fecha = @fecha and ID_Empleado = @empleado", coneccion);
                    cmd1.Parameters.AddWithValue("@fecha", Fecha);
                    cmd1.Parameters.AddWithValue("@empleado", Empleado);
                    //cmd1.Parameters.AddWithValue("@sucursal", Sucursal);

                    SqlDataReader lec1 = cmd1.ExecuteReader();
                    if (lec1.Read())
                    {
                        coneccion.Close();
                        MessageBox.Show("Solo se puede un viaje diario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        coneccion.Close();
                        coneccion.Open();
                        SqlCommand cmd2 = new SqlCommand("Select Total_KM from Viaje where ID_Viaje = @id_viaje1", coneccion);
                        cmd2.Parameters.AddWithValue("@id_viaje1", txtID.Text);
                        SqlDataReader lec2 = cmd2.ExecuteReader();
                        if (lec2.Read())
                        {
                            KM = lec2["Total_KM"].ToString();
                            double suma = Int64.Parse(KM) + Int64.Parse(txtDist.Text);
                            coneccion.Close();
                            if (suma > 100)
                            {
                                MessageBox.Show("No se puede agregar a este viaje ya que excede el kilometraje maximo del viaje total", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                coneccion.Close();
                                coneccion.Open();
                                SqlCommand cdm = new SqlCommand("Select Precio from Transportista", coneccion);
                                SqlDataReader le = cdm.ExecuteReader();
                                if (le.Read())
                                {
                                    string precio = le["Precio"].ToString();
                                    double pkm = Int64.Parse(precio) * Int64.Parse(txtDist.Text);
                                    txtPre.Text = pkm.ToString();

                                    coneccion.Close();

                                    coneccion.Open();

                                    SqlCommand cmd3 = new SqlCommand("Insert into Viaje_Detalle values ('" + txtID.Text + "','" + comboBox1.SelectedValue.ToString() + "','" + comboBox2.SelectedValue.ToString() + "','" + Fecha + "','" + pkm + "','" + Form1.User.ToString() + "')", coneccion);
                                    cmd3.ExecuteNonQuery();
                                    coneccion.Close();
                                    coneccion.Open();
                                    SqlCommand cmd4 = new SqlCommand("UPDATE Viaje SET Total_Precio = (Total_Precio + '" + int.Parse(txtPre.Text) + "'), Total_KM = (Total_KM + '" + int.Parse(txtDist.Text) + "') WHERE ID_Viaje = '" + txtID.Text + "';", coneccion);
                                    cmd4.ExecuteNonQuery();
                                    coneccion.Close();

                                    MessageBox.Show("Registro guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    cargarDGV();
                                    txtID.Text = "";
                                    txtDist.Text = "";
                                    txtPre.Text = "";
                                }
                            }
                        }
                    }

                }
                else
                {
                    MessageBox.Show("El viaje no existe aun.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    coneccion.Close();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtFil_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Sucursal like '{0}%' OR Sucursal like '%{0}%'", txtFil.Text);
        }
    }
}
