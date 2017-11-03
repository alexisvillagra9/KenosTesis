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
    public partial class BuscarSociosSGF : Form
    {
        public BuscarSociosSGF()
        {
            InitializeComponent();
        }

        private SqlConnection conexion;
        private SqlDataAdapter adaptador;
        DataTable datos;

        public DataTable dt = new DataTable();

        RegistrarGrupoFamiliar rng = new RegistrarGrupoFamiliar();
        private void button1_Click(object sender, EventArgs e)
        {


            /*int i = 0;
            int c = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                if (row.Cells[0].Value == DBNull.Value)
                    continue;
                
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    //
                    if(c==0)
                    {
                        rng.dataGridView1.Rows[c].Cells[0].Value = row.Cells[1].Value.ToString();
                        rng.dataGridView1.Rows[c].Cells[1].Value = row.Cells[2].Value.ToString();
                        rng.dataGridView1.Rows[c].Cells[2].Value = row.Cells[3].Value.ToString();
                        c++;
                    }
                    else
                    {
                        rng.dataGridView1.Rows.Add(1);
                        rng.dataGridView1.Rows[c].Cells[0].Value = row.Cells[1].Value.ToString();
                        rng.dataGridView1.Rows[c].Cells[1].Value = row.Cells[2].Value.ToString();
                        rng.dataGridView1.Rows[c].Cells[2].Value = row.Cells[3].Value.ToString();
                        c++;

                    }
                    

                }
                
            }*/

            ModificarGrupoFamiliar ms = Owner as ModificarGrupoFamiliar;


            int fila = dataGridView1.CurrentCellAddress.Y;
            ms.agregaSocio(int.Parse(dataGridView1.Rows[fila].Cells[1].Value.ToString()));
            this.Close();
            ms.Show();
        }

        private void BuscarSociosSGF_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pilarSportClubDataSet9.buscarSocios' Puede moverla o quitarla según sea necesario.
            this.buscarSociosTableAdapter.Fill(this.pilarSportClubDataSet9.buscarSocios);
            this.MaximizeBox = false;
            // TODO: esta línea de código carga datos en la tabla 'pilarSportClubDataSet6.socio' Puede moverla o quitarla según sea necesario.
            this.socioTableAdapter.Fill(this.pilarSportClubDataSet6.socio);

            conexion = new SqlConnection("Data Source=DESKTOP-TGHGHKS;Initial Catalog=pilarSportClub;Integrated Security=True");
            adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = new SqlCommand("buscarSocioGF", conexion);
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
            adaptador.SelectCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50);
            dataGridView1.ReadOnly = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            dataGridView1.ReadOnly = false;

            datos = new DataTable();
            adaptador.SelectCommand.Parameters["@nombre"].Value = textBox1.Text;
            adaptador.Fill(datos);
            dataGridView1.DataSource = datos;
        }


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
