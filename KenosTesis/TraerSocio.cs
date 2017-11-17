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
    public partial class TraerSocio : Form
    {
        public TraerSocio()
        {
            InitializeComponent();
        }

        private SqlConnection conexion;
        private SqlDataAdapter adaptador;
        private DataTable datos;
        public String palabraBusq1 = "";
        public String palabraBusq2 = "";
        public String palabraBusq3 = "";


        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dataGridView1.Rows[0].Cells[0].Value.ToString());

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value == null)
                {

                }
                else
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.Equals(true))
                    {
                        ModificarSocio ms = Owner as ModificarSocio;
                        ms.nsocio.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        conexion.Close();
                        ms.Rellenar(int.Parse(ms.nsocio.Text));
                        ms.bloquearCampos();
                        if (ms.ngrupo.Text.Equals("No tiene"))
                        {
                            ms.button1.Visible = false;
                        }
                        else
                        {
                            ms.button1.Visible = true;
                        }
                        ms.button9.Visible = true;
                        ms.asociacionDeporteTableAdapter.Fill(ms.pilarSportClubDataSet27.asociacionDeporte, int.Parse(ms.nsocio.Text));

                        //ms.pintarBloqueados();
                        ms.Show();
                        break;
                    }
                }

            }
            this.Close();
        }

        private void TraerSocio_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            conexion = new SqlConnection("Data Source=DESKTOP-TGHGHKS;Initial Catalog=pilarSportClub;Integrated Security=True");
            adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = new SqlCommand("buscarPorTodo", conexion);
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
            adaptador.SelectCommand.Parameters.Add("@palabra1", SqlDbType.VarChar, 50);
            adaptador.SelectCommand.Parameters.Add("@palabra2", SqlDbType.VarChar, 50);
            adaptador.SelectCommand.Parameters.Add("@palabra3", SqlDbType.VarChar, 50);
            datos = new DataTable();
            adaptador.SelectCommand.Parameters["@palabra1"].Value = textBox1.Text;
            adaptador.SelectCommand.Parameters["@palabra2"].Value = textBox2.Text;
            adaptador.SelectCommand.Parameters["@palabra3"].Value = textBox3.Text;
            adaptador.Fill(datos);
            dataGridView1.DataSource = datos;
            if (datos.Rows.Count == 0)
            {
                this.Visible = false;
                MessageBox.Show("No se encontro ningun Socio con esos datos");
                this.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridView1.CurrentCellAddress.X;
            int columna = dataGridView1.CurrentCellAddress.Y;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = false;
            }
            dataGridView1.Rows[columna].Cells[0].Value = true;
        }

    }
}
