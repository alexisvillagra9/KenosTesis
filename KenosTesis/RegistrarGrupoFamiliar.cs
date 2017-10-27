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
    public partial class RegistrarGrupoFamiliar : Form
    {
        public RegistrarGrupoFamiliar()
        {
            InitializeComponent();
        }

        private SqlConnection conexion;
        private SqlDataAdapter adaptador;
       

        private void RegistrarGrupoFamiliar_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            // TODO: esta línea de código carga datos en la tabla 'pilarSportClubDataSet7.buscarSocios' Puede moverla o quitarla según sea necesario.
            this.buscarSociosTableAdapter.Fill(this.pilarSportClubDataSet7.buscarSocios);
            conexion = new SqlConnection("Data Source=DESKTOP-TGHGHKS;Initial Catalog=pilarSportClub;Integrated Security=True");
            adaptador = new SqlDataAdapter();
            SqlCommand modifica = new SqlCommand("update socio set grupoFam=@gf where idSocio=@id", conexion);
            adaptador.UpdateCommand = modifica;
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@gf", SqlDbType.Int));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));


            SqlCommand alta = new SqlCommand("insert into grupoFamiliar values (@cant,@prom)", conexion);
            adaptador.InsertCommand = alta;
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@cant", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@prom", SqlDbType.Int));


            adaptador.SelectCommand = new SqlCommand("buscarSocioGF", conexion);
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
            adaptador.SelectCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuscarSociosSGF bspgf = new BuscarSociosSGF();
            bspgf.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount < 2)
            {
                MessageBox.Show("Para registrar un grupo familiar se deben agregar por los menos dos socios");
            }
            else
            {
                if (MessageBox.Show("¿Confirma Generar el Grupo Familiar?", "Confirma Grupo Familiar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    conexion.Open();
                    adaptador.InsertCommand.Parameters["@cant"].Value = dataGridView1.RowCount;
                    adaptador.InsertCommand.Parameters["@prom"].Value = System.DBNull.Value;
                    adaptador.InsertCommand.ExecuteNonQuery();
                    SqlCommand consultagf = new SqlCommand("select max(nroGrupoFam) from grupoFamiliar", conexion);
                    adaptador.SelectCommand = consultagf;
                    DataSet datoObj = new DataSet();
                    adaptador.Fill(datoObj);
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        adaptador.UpdateCommand.Parameters["@gf"].Value = int.Parse(datoObj.Tables[0].Rows[0][0].ToString());
                        adaptador.UpdateCommand.Parameters["@id"].Value = dataGridView1.Rows[i].Cells[0].Value.ToString();
                        adaptador.UpdateCommand.ExecuteNonQuery();
                    }
                    MessageBox.Show("Grupo Familiar Generado Correctamente. Con Numero: " + int.Parse(datoObj.Tables[0].Rows[0][0].ToString()), "Grupo Generado", MessageBoxButtons.OK);
                    conexion.Close();
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataTable datos;
            datos = new DataTable();
            adaptador.SelectCommand.Parameters["@nombre"].Value = textBox1.Text;
            adaptador.Fill(datos);
            dataGridView2.DataSource = datos;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int flag=0;
            int fila = dataGridView2.CurrentCellAddress.Y;
            //int columna = dataGridView1.CurrentCellAddress.Y;
            if (dataGridView1.RowCount == 0)
            {
                dataGridView1.Rows.Add(dataGridView2.Rows[fila].Cells[0].Value.ToString(), dataGridView2.Rows[fila].Cells[1].Value.ToString(), dataGridView2.Rows[fila].Cells[2].Value.ToString(), dataGridView2.Rows[fila].Cells[3].Value.ToString());
            }
            else
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView2.Rows[fila].Cells[0].Value.ToString().Equals(dataGridView1.Rows[i].Cells[0].Value.ToString()))
                    {
                        MessageBox.Show("El Socio Ya esta Agregado");
                        flag = 1;
                        break;
                        
                    }
                  
                }
                if(flag==0)
                {
                        dataGridView1.Rows.Add(dataGridView2.Rows[fila].Cells[0].Value.ToString(), dataGridView2.Rows[fila].Cells[1].Value.ToString(), dataGridView2.Rows[fila].Cells[2].Value.ToString(), dataGridView2.Rows[fila].Cells[3].Value.ToString());
                        
                 }
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridView1.CurrentCellAddress.Y;
            //int columna = dataGridView1.CurrentCellAddress.Y;

            dataGridView1.Rows.RemoveAt(fila);
        }
    }
}
