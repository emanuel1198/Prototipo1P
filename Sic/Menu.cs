using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sic
{
    public partial class Menu : Form
    {
        Conexion cn = new Conexion();
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new Catalogos();
            frm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnprocesos_Click(object sender, EventArgs e)
        {
            Form frm = new procesos();
            frm.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            Form frm = new informes();
            frm.Show();
            this.Hide();
        }

        private void btnHerramientas_Click(object sender, EventArgs e)
        {
            Form frm = new herramientas();
            frm.Show();
            this.Hide();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Form frm = new ayuda();
            frm.Show();
            this.Hide();
        }
    }
}
