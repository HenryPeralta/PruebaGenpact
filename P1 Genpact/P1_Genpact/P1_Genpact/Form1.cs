using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1_Genpact
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AbrirFormHija(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.Clear();
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new CarpetaRaiz());
        }

        private void btnProcesado_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Procesado());
        }

        private void btnNoAplicable_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new NoAplicable());
        }
    }
}
