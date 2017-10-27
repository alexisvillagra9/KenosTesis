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
    public partial class BuscarGrupoFamiliar : Form
    {
        public BuscarGrupoFamiliar()
        {
            InitializeComponent();
        }


        public String idSocio = "";

        private void button1_Click(object sender, EventArgs e)
        {
            int fila = dataGridView1.CurrentCellAddress.X;
            ModificarGrupoFamiliar modgf = Owner as ModificarGrupoFamiliar;
            modgf.superConsulta(int.Parse(dataGridView1.Rows[fila].Cells[1].Value.ToString()));
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridView1.CurrentCellAddress.X;
            int columna = dataGridView1.CurrentCellAddress.Y;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = false;
            }
            dataGridView1.Rows[columna].Cells[fila].Value = true;
        }

        public void BuscarGrupoFamiliar_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            // TODO: esta línea de código carga datos en la tabla 'pilarSportClubDataSet1.buscarSocios' Puede moverla o quitarla según sea necesario.
            ModificarGrupoFamiliar mgf = Owner as ModificarGrupoFamiliar;
            dataGridView1.DataSource = mgf.datos;

        }

    }
}
