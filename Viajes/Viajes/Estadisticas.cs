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

namespace Viajes
{
    public partial class Estadisticas : Form
    {
        SqlConnection coneccion = new SqlConnection("server=.\\SQLEXPRESS ; database=Transporte ; INTEGRATED SECURITY = true");

        public Estadisticas()
        {
            InitializeComponent();
            dataGridView1.Enabled = false;
            cargarDGV();
            cargarDGV2();
        }

        public void cargarDGV()
        {
            coneccion.Open();
            string query = ("select c.Nombre, a.ID_Viaje, a.Total_KM as Kilometraje from Viaje a \r\njoin Transportista c on a.ID_Transportista = c.ID_Transportista");
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
            string query = ("select c.Nombre, sum(a.Total_Precio) as 'Total Pago' from Viaje a \r\njoin Transportista c on a.ID_Transportista = c.ID_Transportista\r\ngroup by a.ID_Transportista, c.Nombre");
            SqlCommand cmd = new SqlCommand(query, coneccion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);

            dataGridView2.DataSource = dt;

            coneccion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Transportistas pantalla = new Transportistas();
            pantalla.Show();
            Hide();
        }


        private void txtFil_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nombre like '{0}%' OR Nombre like '%{0}%'", txtFil.Text);
            (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nombre like '{0}%' OR Nombre like '%{0}%'", txtFil.Text);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
