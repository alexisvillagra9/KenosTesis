using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KenosTesis
{
    public partial class RegistrarDeportes : Form
    {
        public RegistrarDeportes()
        {
            InitializeComponent();
        }

        private SqlConnection conexion;
        private SqlDataAdapter adaptador;
        private DataSet datoObj;
        private void button2_Click(object sender, EventArgs e)
        {
            desbloquearCampos();
            estBoton = "Guardar";
            button2.Visible = false;
            button3.Text = estBoton;
        }

        private void RegistrarDeportes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pilarSportClubDataSet13.buscarDeportes' Puede moverla o quitarla según sea necesario.
            this.buscarDeportesTableAdapter.Fill(this.pilarSportClubDataSet13.buscarDeportes);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            inicial();
            this.MaximizeBox = false;
            conexion = new SqlConnection("Data Source=DESKTOP-TGHGHKS;Initial Catalog=pilarSportClub;Integrated Security=True");
            adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = new SqlCommand("buscarDeporte", conexion);
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
            adaptador.SelectCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50);

        }

        String estBoton = "";
        public void nuevoDepo()
        {
            estBoton = "Registrar";
            panel2.Visible = false;
            panel1.Visible = true;
            panel1.Location = new System.Drawing.Point(52, 12);
            button5.Visible = false;
            button2.Visible = false;
            button3.Visible = true;
            button3.Text = estBoton;
            this.Size = new Size(655, 240);
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;


        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.Open();
            DataTable datos;
            datos = new DataTable();
            adaptador.SelectCommand.Parameters["@nombre"].Value = textBox6.Text;
            adaptador.Fill(datos);
            conexion.Close();
            dataGridView1.DataSource = datos;

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

        private void button1_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value == null)
                {

                }
                else
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.Equals(true))
                    {
                        panel1.Visible = true;
                        button5.Visible = false;
                        this.Size = new Size(655, 440);
                        panel1.Location = new System.Drawing.Point(52, 267);
                        this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
                        this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
                        label13.Text = dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[1].Value.ToString();
                        SqlCommand consulta = new SqlCommand("select * from dbo.deporte where idDeporte=@id", conexion);
                        adaptador.SelectCommand = consulta;
                        adaptador.SelectCommand.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                        datoObj = new DataSet();
                        conexion.Open();
                        adaptador.SelectCommand.Parameters["@id"].Value = dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[1].Value;
                        adaptador.Fill(datoObj);
                        conexion.Close();
                        textBox1.Text = datoObj.Tables[0].Rows[0][1].ToString();
                        textBox2.Text = datoObj.Tables[0].Rows[0][2].ToString();
                        button2.Visible = true;
                        bloquearCampos();
                    }
                }

            }


        }

        public void bloquearCampos()
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            button3.Visible = false;
        }

        public void desbloquearCampos()
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            button3.Visible = true;
        }
        

        public void inicial()
        {
            panel2.Visible = true;
            panel1.Visible = false;
            button5.Visible = true;
            this.Size = new Size(655, 385);
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            inicial();
            button2.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            todoBotonNuevo();
        }

       
        public void todoBotonNuevo()
        {
            desbloquearCampos();

            foreach (Control c in this.panel1.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }

            }
            nuevoDepo();
        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            RegistrarCategoria rd = Owner as RegistrarCategoria;
            if (estBoton == "Guardar")
            {
                SqlCommand modifica = new SqlCommand("update deporte set nombre=@nom, precioinicial=@pre where idDeporte=@id", conexion);
                adaptador.UpdateCommand = modifica;
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@nom", SqlDbType.VarChar, 50));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@pre", SqlDbType.Float));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));

                conexion.Open();
                adaptador.UpdateCommand.Parameters["@nom"].Value = textBox1.Text;
                adaptador.UpdateCommand.Parameters["@pre"].Value = textBox2.Text;
                adaptador.UpdateCommand.Parameters["@id"].Value = int.Parse(label13.Text);
                adaptador.UpdateCommand.ExecuteNonQuery();
                MessageBox.Show("Se modifico correctamente el Deporte " + textBox1.Text);
                conexion.Close();
            }
            if (estBoton == "Registrar")
            {
                SqlCommand alta = new SqlCommand("insert into deporte values (@nom, @pre)", conexion);
                adaptador.InsertCommand = alta;
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nom", SqlDbType.VarChar, 50));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@pre", SqlDbType.Float));
          
                conexion.Open();
                adaptador.InsertCommand.Parameters["@nom"].Value = textBox1.Text;
                adaptador.InsertCommand.Parameters["@pre"].Value = textBox2.Text;
                adaptador.InsertCommand.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Deporte Registrado Correctamente con el ID: " + consultaID(), "Alerta", MessageBoxButtons.OK);
                if (flag == 1)
                {
                    rd.Show();
                    flag = 0;
                    rd.deporteTableAdapter.Fill(rd.pilarSportClubDataSet14.deporte);
                    rd.comboBox1.DataSource = rd.deporteBindingSource;
                    rd.comboBox1.SelectedValue = consultaID();
                    this.Close();
                }
                else { 
                inicial();
                adaptador.SelectCommand = new SqlCommand("buscarDeporte", conexion);
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                adaptador.SelectCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50);
                conexion.Open();
                DataTable datos;
                datos = new DataTable();
                adaptador.SelectCommand.Parameters["@nombre"].Value = "";
                adaptador.Fill(datos);
                conexion.Close();
                dataGridView1.DataSource = datos;}
            }


        }

        public String consultaID()
        {
            DataSet datoObj1;
            SqlCommand consulta = new SqlCommand("Select MAX(idDeporte) from deporte", conexion);
            adaptador.SelectCommand = consulta;
            datoObj1 = new DataSet();
            conexion.Open();
            string idSocio = "";
            adaptador.Fill(datoObj1);
            idSocio = datoObj1.Tables[0].Rows[0][0].ToString();
            conexion.Close();
            return idSocio;

        }
        public int flag = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand eliminar = new SqlCommand("delete from deporte where idDeporte=@id", conexion);
            adaptador.DeleteCommand = eliminar;
            adaptador.DeleteCommand.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            conexion.Open();
            adaptador.DeleteCommand.Parameters["@id"].Value = dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[1].Value;
            adaptador.DeleteCommand.ExecuteNonQuery();
            conexion.Close();
            adaptador.SelectCommand = new SqlCommand("buscarDeporte", conexion);
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
            adaptador.SelectCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50);
            conexion.Open();
            DataTable datos;
            datos = new DataTable();
            adaptador.SelectCommand.Parameters["@nombre"].Value = "";
            adaptador.Fill(datos);
            conexion.Close();
            dataGridView1.DataSource = datos;
        }

       
    }
}
