using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace P1_Genpact
{
    public partial class NoAplicable : Form
    {
        string path = @"C:\Users\Henry Peralta\Pictures\Genpact\P1 Genpact\P1_Genpact\P1_Genpact\NoAplicable"; //Ruta de la carpeta no aplicable
        public NoAplicable()
        {
            InitializeComponent();
        }

        private void NoAplicable_Load(object sender, EventArgs e)
        {
            fileSystemWatcher1.Path = path;
            ObtenerArchivos();
        }

        private void ObtenerArchivos()
        {
            string[] Archivos = Directory.GetFiles(path);
            textBox1.Text = "";
            foreach (var larchivos in Archivos)
            {
                string nArchivo = System.IO.Path.GetFileName(larchivos);
                textBox1.Text += nArchivo + Environment.NewLine;

            }
        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {
            ObtenerArchivos();
        }

        private void fileSystemWatcher1_Renamed(object sender, RenamedEventArgs e)
        {
            ObtenerArchivos();
        }
    }
}
