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
    public partial class ModificarGrupoFamiliar : Form
    {
        public ModificarGrupoFamiliar()
        {
            InitializeComponent();
        }


        private SqlConnection conexion;
        private SqlDataAdapter adaptador;
        public DataSet datoObj;
        public DataTable datos;
        public DataTable datos1;
        public DataTable datos2;

        private void ModificarGrupoFamiliar_Load(object sender, EventArgs e)
        {
            
            // TODO: esta línea de código carga datos en la tabla 'pilarSportClubDataSet8.socio' Puede moverla o quitarla según sea necesario.
            this.socioTableAdapter.Fill(this.pilarSportClubDataSet8.socio);
            this.MaximizeBox = false;
            conexion = new SqlConnection("Data Source=DESKTOP-TGHGHKS;Initial Catalog=pilarSportClub;Integrated Security=True");
            adaptador = new SqlDataAdapter();

            //Consulta para Grupo Familiar


            //Procedimiento Almacenado Para Buscar

            if (idSocioNuevo.Text != "INICIAL")
            {
                consultarDatosSocioNuevo();
            }
            inicializar();
        }

        public void consultarDatosSocioNuevo()
        {
            SqlCommand consulta = new SqlCommand("select * from socio where idSocio = @idso", conexion);
            adaptador.SelectCommand = consulta;
            adaptador.SelectCommand.Parameters.Add(new SqlParameter("@idso", SqlDbType.Int));
            datos2 = new DataTable();
            conexion.Open();
            adaptador.SelectCommand.Parameters["@idso"].Value = int.Parse(idSocioNuevo.Text);
            adaptador.Fill(datos2);
            dataGridView1.DataSource = datos2.DefaultView.ToTable(true, "idSocio", "nombreSocio", "apellidoSocio", "estado");
            conexion.Close();
        }
        public void superConsulta(int id)
        {
            SqlCommand consulta = new SqlCommand("select * from socio where socio.grupoFam = (select socio.grupoFam from socio where socio.idSocio = @idso)", conexion);
            adaptador.SelectCommand = consulta;
            adaptador.SelectCommand.Parameters.Add(new SqlParameter("@idso", SqlDbType.Int));
            datos1 = new DataTable();
            conexion.Open();
            adaptador.SelectCommand.Parameters["@idso"].Value = id;
            adaptador.Fill(datos1);
            conexion.Close();
            label5.Text = datos1.Rows[0][10].ToString();
            button2.Visible = true;
            label4.Enabled = true;
            label5.Enabled = true;
            if (idSocioNuevo.Text != "INICIAL")
            {
                //datos1.DefaultView.ToTable(true, "idSocio", "nombreSocio", "apellidoSocio", "estado");
                datos2.Merge(datos1);
                dataGridView1.DataSource = datos2.DefaultView.ToTable(true, "idSocio", "nombreSocio", "apellidoSocio", "estado");
                agregaSocio(int.Parse(idSocioNuevo.Text));
                idSocioNuevo.Text = "INICIAL";
            }
            else
            {
                dataGridView1.DataSource = datos1.DefaultView.ToTable(true, "idSocio", "nombreSocio", "apellidoSocio", "estado");
            }
            
            
           

        }

        public void superConsulta2(int id)
        {
            SqlCommand consulta = new SqlCommand("select * from socio where socio.grupoFam = @gf", conexion);
            adaptador.SelectCommand = consulta;
            adaptador.SelectCommand.Parameters.Add(new SqlParameter("@gf", SqlDbType.Int));
            datos1 = new DataTable();
            conexion.Open();
            adaptador.SelectCommand.Parameters["@gf"].Value = id;
            adaptador.Fill(datos1);
            //dataGridView1.DataSource = datos1.DefaultView.ToTable(true, "idSocio", "nombreSocio", "apellidoSocio", "estado"); ;
            conexion.Close();
            if (datos1.Rows.Count == 0)
            {
                MessageBox.Show("No existen Socios con ese Nro de Grupo Familiar");
                textBox3.Focus();
            }
            else
            {
                label5.Text = datos1.Rows[0][10].ToString();
                button2.Visible = true;
                label4.Enabled = true;
                label5.Enabled = true;
            }
            if (idSocioNuevo.Text != "INICIAL")
            {
                //datos1.DefaultView.ToTable(true, "idSocio", "nombreSocio", "apellidoSocio", "estado");
                datos2.Merge(datos1);
                dataGridView1.DataSource = datos2.DefaultView.ToTable(true, "idSocio", "nombreSocio", "apellidoSocio", "estado");
                
                agregaSocio(int.Parse(idSocioNuevo.Text));
            }
            else
            {
                dataGridView1.DataSource = datos1.DefaultView.ToTable(true, "idSocio", "nombreSocio", "apellidoSocio", "estado");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "")
            {
                if (textBox3.Text != "")
                {
                    superConsulta2(int.Parse(textBox3.Text));
                }
                else
                {
                    adaptador.SelectCommand = new SqlCommand("buscarSociosCGF", conexion);
                    adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adaptador.SelectCommand.Parameters.Add("@palabra1", SqlDbType.VarChar, 50);
                    adaptador.SelectCommand.Parameters.Add("@palabra2", SqlDbType.VarChar, 50);
                    datos = new DataTable();
                    conexion.Open();
                    adaptador.SelectCommand.Parameters["@palabra1"].Value = textBox1.Text;
                    adaptador.SelectCommand.Parameters["@palabra2"].Value = textBox2.Text;
                    adaptador.Fill(datos);
                    conexion.Close();
                    BuscarGrupoFamiliar bgf = new BuscarGrupoFamiliar();
                    AddOwnedForm(bgf);
                    bgf.Show();
                }

            }
            else
            {
                MessageBox.Show("Se debe ingresar al menos un campo de busqueda");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;

            dataGridView1.Enabled = true;
            dataGridView1.ReadOnly = false;
        }



        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Confirma la actualizacion del Grupo Familiar", "Confirma Registro", MessageBoxButtons.YesNo);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void inicializar()
        {
            button2.Visible = false;
            label4.Enabled = false;
            label5.Enabled = false;
            dataGridView1.Enabled = false;
            label5.Text = "- -";
            panel3.Visible = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
            }
            else
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox3.Enabled = false;
            }
            else
            {
                textBox3.Enabled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                textBox3.Enabled = false;
            }
            else
            {
                textBox3.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BuscarSociosSGF bsgf = new BuscarSociosSGF();
            AddOwnedForm(bsgf);
            bsgf.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int idSocio = 0;
            int fila = dataGridView1.CurrentCellAddress.Y;
            if (dataGridView1.Rows.Count == 2)
            {
                MessageBox.Show("El Grupo Familiar Tiene Solo 2 socios y no puede poseer menos");
            }
            else
            {
                if (MessageBox.Show("¿Realemente dese quitar este Socio del grupo Familiar?", "Quitar Socio", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    idSocio = int.Parse(dataGridView1.Rows[fila].Cells[1].Value.ToString());
                    dataGridView1.Rows.RemoveAt(fila);
                    SqlCommand modifica1 = new SqlCommand("update socio set grupoFam=@gf where idSocio=@id", conexion);
                    adaptador.UpdateCommand = modifica1;
                    adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@gf", SqlDbType.Int));
                    adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                    conexion.Open();
                    adaptador.UpdateCommand.Parameters["@gf"].Value = DBNull.Value;
                    adaptador.UpdateCommand.Parameters["@id"].Value = idSocio;
                    adaptador.UpdateCommand.ExecuteNonQuery();
                    conexion.Close();

                    SqlCommand modifica2 = new SqlCommand("update grupoFamiliar set cantIntegrantes=@cant where nroGrupoFam=@idgf", conexion);
                    adaptador.UpdateCommand = modifica2;
                    adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@cant", SqlDbType.Int));
                    adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@idgf", SqlDbType.Int));
                    conexion.Open();
                    adaptador.UpdateCommand.Parameters["@cant"].Value = dataGridView1.Rows.Count;
                    adaptador.UpdateCommand.Parameters["@idgf"].Value = int.Parse(label5.Text);
                    adaptador.UpdateCommand.ExecuteNonQuery();
                    conexion.Close();

                    superConsulta2(int.Parse(label5.Text));
                }
            }
        }

        public void agregaSocio(int idUsu)
        {
            SqlCommand modifica1 = new SqlCommand("update socio set grupoFam=@gf where idSocio=@id", conexion);
            adaptador.UpdateCommand = modifica1;
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@gf", SqlDbType.Int));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            conexion.Open();
            adaptador.UpdateCommand.Parameters["@gf"].Value = int.Parse(label5.Text);
            adaptador.UpdateCommand.Parameters["@id"].Value = idUsu;
            adaptador.UpdateCommand.ExecuteNonQuery();
            conexion.Close();

            SqlCommand modifica2 = new SqlCommand("update grupoFamiliar set cantIntegrantes=@cant where nroGrupoFam=@idgf", conexion);
            adaptador.UpdateCommand = modifica2;
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@cant", SqlDbType.Int));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@idgf", SqlDbType.Int));
            conexion.Open();
            adaptador.UpdateCommand.Parameters["@cant"].Value = dataGridView1.Rows.Count+1;
            adaptador.UpdateCommand.Parameters["@idgf"].Value = int.Parse(label5.Text);
            adaptador.UpdateCommand.ExecuteNonQuery();
            conexion.Close();
            idSocioNuevo.Text = "INICIAL";
            superConsulta2(int.Parse(label5.Text));
        }
    }
}
