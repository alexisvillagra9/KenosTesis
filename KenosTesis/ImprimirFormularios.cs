using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KenosTesis
{
    public partial class ImprimirFormularios : Form
    {
        public ImprimirFormularios()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inscripcion i = new Inscripcion();
            i.Text = "renuncia";
            i.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inscripcion i = new Inscripcion();
            i.Text = "inscripcion";
            i.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String nuevo = "";
            String viejo = "D:/Visual Studio 2015/Projects/KenosTesis/KenosTesis/fomularios/inscripcion.pdf";
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Cursor Files|*.pdf";
            openFileDialog1.Title = "Selecciona el nuevo Formulario de Inscripcion";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                nuevo = openFileDialog1.FileName;
                File.Replace(nuevo, viejo, "D:/Visual Studio 2015/Projects/KenosTesis/KenosTesis/fomularios/back.pdf");
                File.Delete("D:/Visual Studio 2015/Projects/KenosTesis/KenosTesis/fomularios/back.pdf");
                MessageBox.Show("Formulario Reemplazado Correctamente");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String nuevo = "";
            String viejo = "D:/Visual Studio 2015/Projects/KenosTesis/KenosTesis/fomularios/renuncia.pdf";
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Cursor Files|*.pdf";
            openFileDialog1.Title = "Selecciona el nuevo Formulario de Renuncia";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                nuevo = openFileDialog1.FileName;
                File.Replace(nuevo, viejo, "D:/Visual Studio 2015/Projects/KenosTesis/KenosTesis/fomularios/back.pdf");
                File.Delete("D:/Visual Studio 2015/Projects/KenosTesis/KenosTesis/fomularios/back.pdf");
                MessageBox.Show("Formulario Reemplazado Correctamente");
            }
        }
    }
}
