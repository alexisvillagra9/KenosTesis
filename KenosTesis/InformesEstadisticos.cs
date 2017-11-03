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
    public partial class InformesEstadisticos : Form
    {
        public InformesEstadisticos()
        {
            InitializeComponent();
        }

        private void InformesEstadisticos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'graficoCircularEstadosSocios.InformeGrafico' Puede moverla o quitarla según sea necesario.
            this.informeGraficoTableAdapter.Fill(this.graficoCircularEstadosSocios.InformeGrafico);
            // TODO: esta línea de código carga datos en la tabla 'pilarSportClubDataSet22.buscarSocios' Puede moverla o quitarla según sea necesario.

        }
    }
}
