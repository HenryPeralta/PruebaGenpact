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
using System.Diagnostics;

namespace P1_Genpact
{
    public partial class CarpetaRaiz : Form
    {
        string path = @"C:\Users\Henry Peralta\Pictures\Genpact\P1 Genpact\P1_Genpact\P1_Genpact\CarpetaRaiz"; //Ruta de la carpeta Raiz
        string pathCp = @"C:\Users\Henry Peralta\Pictures\Genpact\P1 Genpact\P1_Genpact\P1_Genpact\Procesado\";
        string pathN = @"C:\Users\Henry Peralta\Pictures\Genpact\P1 Genpact\P1_Genpact\P1_Genpact\NoAplicable\";
        string pathLibroMaestro = @"C:\Users\Henry Peralta\Pictures\Genpact\P1 Genpact\P1_Genpact\P1_Genpact\Procesado\LibroMaestro.xls";

        int contador = 0;
        int contadorHojas = 0;
        public CarpetaRaiz()
        {
            InitializeComponent();
        }

        private void CarpetaRaiz_Load(object sender, EventArgs e)
        {
            ObtenerArchivos(contadorHojas);
        }

        private void ObtenerArchivos(int numeroH)
        {
            string[] Archivos = Directory.GetFiles(path);
            textBox1.Text = "";
            foreach(var larchivos in Archivos)
            {
                string nArchivo = System.IO.Path.GetFileName(larchivos);
                textBox1.Text += nArchivo + Environment.NewLine;

                if (larchivos.EndsWith(".xls"))
                {
                    File.Copy(larchivos, pathCp + nArchivo, true);
                    unirExcel(pathCp + nArchivo, numeroH);
                    contador++;
                }
                else
                {
                    File.Copy(larchivos, pathN + nArchivo, true);
                }
            }
        }

        private void unirExcel(string ruta, int numeracion)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

                //La ruta del archivo inicial
                Microsoft.Office.Interop.Excel.Workbook wbSource = excel.Workbooks.Open(ruta, 0, false, 1, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, 9, true, false, 0, true, false, false);

                //La ruta del archivo final
                Microsoft.Office.Interop.Excel.Workbook wbDestination = excel.Workbooks.Open(pathLibroMaestro, 0, false, 1, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, 9, true, false, 0, true, false, false);

                int cantidadHojasF = wbDestination.Sheets.Count;
                int cantidadHojasI = wbSource.Sheets.Count;

                if(contador == 0)
                {
                    for (int i = 1; i < cantidadHojasI + 1; i++)
                    {
                        Microsoft.Office.Interop.Excel.Worksheet plantillaExcelInicial = wbSource.Sheets[i];
                        plantillaExcelInicial.UsedRange.Copy(Type.Missing);
                        Microsoft.Office.Interop.Excel.Worksheet plantillaExcelFinal = wbDestination.Sheets[i];
                        plantillaExcelFinal.UsedRange.PasteSpecial(Microsoft.Office.Interop.Excel.XlPasteType.xlPasteAll, Microsoft.Office.Interop.Excel.XlPasteSpecialOperation.xlPasteSpecialOperationNone, Type.Missing, Type.Missing);
                        plantillaExcelFinal.Name = plantillaExcelInicial.Name;
                        plantillaExcelFinal.Columns.AutoFit();
                    }

                    contadorHojas = cantidadHojasI;

                }else if (contador >= 1)
                {

                }

                wbDestination.Sheets[1].Activate();

                wbDestination.Save();
                wbSource.Close();
                wbDestination.Close();
                excel.Application.Quit();
                excel.Quit();

                NAR(wbSource);
                NAR(wbDestination);
                excel.Quit();
                NAR(excel);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NAR(object o)
        {
            try
            {
                while (System.Runtime.InteropServices.Marshal.ReleaseComObject(o) > 0) ;
            }
            catch { }
            finally
            {
                o = null;
            }
        }
        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {
            System.Diagnostics.Process[] objProcess = System.Diagnostics.Process.GetProcessesByName("EXCEL");

            if (objProcess.Length > 0)
            {
                System.Collections.Hashtable objHashtable = new System.Collections.Hashtable();

                // check to kill the right process
                foreach (System.Diagnostics.Process processInExcel in objProcess)
                {
                    if (objHashtable.ContainsKey(processInExcel.Id) == false)
                    {
                        processInExcel.Kill();
                    }
                }
                objProcess = null;
            }

            ObtenerArchivos(contadorHojas);
        }

        private void fileSystemWatcher1_Renamed(object sender, RenamedEventArgs e)
        {
            ObtenerArchivos(contadorHojas);
        }
    }
}
