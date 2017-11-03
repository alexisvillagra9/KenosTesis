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

namespace KenosTesis
{
    public partial class AltaAsociacionDeporte : Form
    {
        public AltaAsociacionDeporte()
        {
            InitializeComponent();
        }

        private SqlConnection conexion;
        private SqlDataAdapter adaptador;
        private void AltaAsociacionDeporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_Categoria.categoria' Puede moverla o quitarla según sea necesario.
            // TODO: esta línea de código carga datos en la tabla 'pilarSportClubDataSet24.deporte' Puede moverla o quitarla según sea necesario.
            this.deporteTableAdapter.Fill(this.pilarSportClubDataSet24.deporte);
            conexion = new SqlConnection("Data Source=DESKTOP-TGHGHKS;Initial Catalog=pilarSportClub;Integrated Security=True");
            adaptador = new SqlDataAdapter();
        }
    }
}
