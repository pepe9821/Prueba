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
    public partial class Transportistas : Form
    {
        public Transportistas()
        {
            InitializeComponent();
        }

        private void btnRV_Click(object sender, EventArgs e)
        {
            Hide();
            RTrans pantalla = new RTrans();
            pantalla.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Home pantalla = new Home();
            pantalla.Show();
        }

        private void btnRVD_Click(object sender, EventArgs e)
        {
            Hide();
            Estadisticas pantalla = new Estadisticas();
            pantalla.Show();
        }
    }
}
