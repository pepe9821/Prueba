using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Viajes
{
    public partial class Form1 : Form
    {
        public static string Rol;
        public static string User;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection coneccion = new SqlConnection("server=.\\SQLEXPRESS ; database=Transporte ; INTEGRATED SECURITY = true");

            coneccion.Open();
            SqlCommand comando = new SqlCommand("select Usuario, Contraseña from Usuario where Usuario = @usuario and Contraseña = @contraseña", coneccion);
            comando.Parameters.AddWithValue("@usuario", txtUser.Text);
            comando.Parameters.AddWithValue("@contraseña", txtCont.Text);

            SqlDataReader lector = comando.ExecuteReader();

            if (lector.Read())
            {
                coneccion.Close();
                coneccion.Open();
                SqlCommand cmd = new SqlCommand("select a.Nombre, b.Usuario from Roles a join Usuario b on a.ID_Rol = b.ID_Rol where Usuario = @usuario", coneccion);
                cmd.Parameters.AddWithValue("@usuario", txtUser.Text);


                SqlDataReader lec = cmd.ExecuteReader();
                if (lec.Read())
                {
                    Rol = lec["Nombre"].ToString();
                    User = lec["Usuario"].ToString();
                    coneccion.Close();
                }
                Hide();
                Home pantalla = new Home();
                pantalla.Show();
            }
            else
            {
                MessageBox.Show("Datos Incorrectos", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                txtUser.Text = "";
                txtCont.Text = "";
            }
        }

    }
}
