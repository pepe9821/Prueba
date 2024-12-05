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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Viajes
{

    public partial class RTrans : Form
    {

        SqlConnection coneccion = new SqlConnection("server=.\\SQLEXPRESS ; database=Transporte ; INTEGRATED SECURITY = true");

        public RTrans()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Transportistas pantalla = new Transportistas();
            pantalla.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtID.Text == null)
            {
                MessageBox.Show("El ID no se ha ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
            else if (txtNom.Text == "" || txtNom.Text == null)
            {
                MessageBox.Show("El Nombre no se ha ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTar.Text == "" || txtTar.Text == null)
            {
                MessageBox.Show("La tarifa no se ha ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                coneccion.Open();
                SqlCommand cmd = new SqlCommand("Select ID_Transportista from Transportista where ID_Transportista = @ID_Transportista", coneccion);
                cmd.Parameters.AddWithValue("@ID_Transportista", txtID.Text);

                SqlDataReader lec = cmd.ExecuteReader();
                if (lec.Read())
                {
                    coneccion.Close();
                    MessageBox.Show("El ID ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    coneccion.Close();
                    coneccion.Open();

                    SqlCommand cmd2 = new SqlCommand("Insert into Transportista values ('" + txtID.Text + "','" + txtNom.Text + "','" + int.Parse(txtTar.Text) + "')", coneccion);
                    cmd2.ExecuteNonQuery();
                    coneccion.Close();

                    MessageBox.Show("Registro guardado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Text = "";
                    txtNom.Text = "";
                    txtTar.Text = "";
                }
            }
        }
    }
}
