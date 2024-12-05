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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            label1.Text = Form1.Rol;
            

        }
        private void Home_Load(object sender, EventArgs e)
        {
            label1.Text = Form1.Rol;
            if (label1.Text == "Gerente de Tienda")
            {
                btnSuc.Enabled = true;
                btnTrs.Enabled = true;  
                btnViajes.Enabled = true;
            }
            else
            {
                btnSuc.Enabled = true;
                btnTrs.Hide();
                btnViajes.Hide();
            }
        }

        private void btnSuc_Click(object sender, EventArgs e)
        {
            Hide();
            Sucursales pantalla = new Sucursales();
            pantalla.Show();
        }

        private void btnViajes_Click(object sender, EventArgs e)
        {
            Hide();
            Viajes pantalla = new Viajes();
            pantalla.Show();
        }

        private void btnTrs_Click(object sender, EventArgs e)
        {
            Hide();
            Transportistas pantalla = new Transportistas();
            pantalla.Show();
        }
    }
}
