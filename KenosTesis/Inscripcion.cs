using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KenosTesis
{
    public partial class Inscripcion : Form
    {
        public Inscripcion()
        {
            InitializeComponent();
        }

        

        private void Inscripcion_Load(object sender, EventArgs e)
        {
            String path = "C:/Users/Usuario/Documents/Visual Studio 2015/Projects/KenosTesis/KenosTesis/fomularios/"+this.Text+".pdf";
            axAcroPDF1.LoadFile(path);
        }
    }
}
