using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viajes
{
    public partial class Viajes : Form
    {
        public Viajes()
        {
            InitializeComponent();
            if (Form1.Rol == "Gerente de Tienda")
            {
                btnRVD.Enabled = true;
                btnRV.Enabled = true;
            }
            else
            {
                btnRVD.Enabled = true;
                btnRV.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Home pantalla = new Home();
            pantalla.Show();
        }

        private void btnRV_Click(object sender, EventArgs e)
        {
            Hide();
            ViajeG pantalla = new ViajeG();
            pantalla.Show();
        }

        private void btnRVD_Click(object sender, EventArgs e)
        {
            Hide();
            Rviajes pantalla = new Rviajes();
            pantalla.Show();
        }

        private void Viajes_Load(object sender, EventArgs e)
        {

        }
    }
}
