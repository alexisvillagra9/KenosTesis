using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KenosTesis
{
    public partial class RegistrarClienteAlquiler : Form
    {
        public RegistrarClienteAlquiler()
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

        private void RegistrarClienteAlquiler_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pilarSportClubDataSet23.buscarCA' Puede moverla o quitarla según sea necesario.
            this.buscarCATableAdapter.Fill(this.pilarSportClubDataSet23.buscarCA);
            // TODO: esta línea de código carga datos en la tabla 'dSsexo.sexo' Puede moverla o quitarla según sea necesario.
            this.sexoTableAdapter.Fill(this.dSsexo.sexo);
            // TODO: esta línea de código carga datos en la tabla 'pilarSportClubDataSet21.sexo' Puede moverla o quitarla según sea necesario.
            //this.sexoTableAdapter.Fill(this.pilarSportClubDataSet21.sexo);
            // TODO: esta línea de código carga datos en la tabla 'pilarSportClubDataSet20.buscarCA' Puede moverla o quitarla según sea necesario.
            //this.buscarCATableAdapter.Fill(this.pilarSportClubDataSet20.buscarCA);


            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            inicial();
            this.MaximizeBox = false;
           // this.buscarProfesoresTableAdapter.Fill(this.pilarSportClubDataSet10.buscarProfesores);
            conexion = new SqlConnection("Data Source=DESKTOP-TGHGHKS;Initial Catalog=pilarSportClub;Integrated Security=True");
            adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = new SqlCommand("buscarClienteAlquiler", conexion);
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
            adaptador.SelectCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50);

        }

        public void todoBotonNuevo()
        {
            desbloquearCampos();
            dateTimePicker1.Value = DateTime.Now;
            comboBox1.SelectedValue = 1;
            comboBox2.SelectedItem = "Pilar";

            foreach (Control c in this.panel1.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }

            }
            nuevoClienteAlquiler();
        }

        String estBoton = "";
        public void nuevoClienteAlquiler()
        {
            estBoton = "Registrar";
            panel2.Visible = false;
            panel1.Visible = true;
            panel1.Location = new System.Drawing.Point(52, 12);
            button5.Visible = false;
            button2.Visible = false;
            button3.Visible = true;
            button3.Text = estBoton;
            this.Size = new Size(655, 385);


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
            dataGridView1.Rows[columna].Cells[0].Value = true;
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
                        button2.Visible = true;
                        this.Size = new Size(655, 645);
                        panel1.Location = new System.Drawing.Point(52, 267);
                        this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
                        this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
                        label13.Text = dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[1].Value.ToString();
                        SqlCommand consulta = new SqlCommand("select * from dbo.clienteAlquiler where idClienteAlq=@ica", conexion);
                        adaptador.SelectCommand = consulta;
                        adaptador.SelectCommand.Parameters.Add(new SqlParameter("@ica", SqlDbType.Int));
                        datoObj = new DataSet();
                        conexion.Open();
                        adaptador.SelectCommand.Parameters["@ica"].Value = dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[1].Value;
                        adaptador.Fill(datoObj);
                        conexion.Close();
                        textBox1.Text = datoObj.Tables[0].Rows[0][1].ToString();
                        textBox2.Text = datoObj.Tables[0].Rows[0][2].ToString();
                        textBox3.Text = datoObj.Tables[0].Rows[0][4].ToString();
                        traeTelefono(datoObj.Tables[0].Rows[0][6].ToString());
                        dateTimePicker1.Value = DateTime.ParseExact(datoObj.Tables[0].Rows[0][3].ToString(), "dd/MM/yyyy H:mm:ss", CultureInfo.InvariantCulture);
                        comboBox1.SelectedValue = datoObj.Tables[0].Rows[0][5].ToString();
                        comboBox2.SelectedItem = datoObj.Tables[0].Rows[0][8].ToString();
                        textBox5.Text = datoObj.Tables[0].Rows[0][7].ToString();
                        bloquearCampos();
                    }
                }

            }


        }

        public void bloquearCampos()
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            dateTimePicker1.Enabled = false;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            textBox7.Enabled = false;
            button3.Visible = false;
        }

        public void desbloquearCampos()
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            dateTimePicker1.Enabled = true;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            textBox7.Enabled = true;
            button3.Visible = true;
        }
        public void traeTelefono(String telefono)
        {
            string[] numero;
            numero = telefono.Split('-');
            String prefijo = numero[0].ToString();
            String sufijo = numero[1].ToString();
            textBox4.Text = prefijo;
            textBox7.Text = sufijo;
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

        public void button5_Click(object sender, EventArgs e)
        {
            todoBotonNuevo();
        }

        public String armaFecha()
        {
            //String dt = textBox6.Text + "-" + textBox5.Text + "-" + textBox4.Text;
            String dt = dateTimePicker1.Value.Year.ToString() + "-" + dateTimePicker1.Value.Month.ToString() + "-" + dateTimePicker1.Value.Day.ToString();
            return dt;
        }

        public String armaTelefono()
        {
            String at = textBox4.Text + "-" + textBox7.Text;
            return at;
        }

        public int flag = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            if (estBoton == "Guardar")
            {
                SqlCommand modifica = new SqlCommand("update clienteAlquiler set nombreClienteAlq=@nom, apellidoClienteAlq=@ape, fechaNacimiento=@fec, localidad=@loc, telefono=@tel, dni=@dni, sexo=@sex, direccion=@dir where idClienteAlq=@id", conexion);
                adaptador.UpdateCommand = modifica;
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@nom", SqlDbType.VarChar, 50));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@ape", SqlDbType.VarChar, 50));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@fec", SqlDbType.Date));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@dir", SqlDbType.VarChar, 50));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@loc", SqlDbType.VarChar, 50));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@tel", SqlDbType.VarChar, 50));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@dni", SqlDbType.Int));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@sex", SqlDbType.Int));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));

                conexion.Open();
                adaptador.UpdateCommand.Parameters["@nom"].Value = textBox1.Text;
                adaptador.UpdateCommand.Parameters["@ape"].Value = textBox2.Text;
                adaptador.UpdateCommand.Parameters["@fec"].Value = armaFecha();
                adaptador.UpdateCommand.Parameters["@dir"].Value = textBox5.Text;
                adaptador.UpdateCommand.Parameters["@loc"].Value = comboBox2.SelectedItem;
                adaptador.UpdateCommand.Parameters["@tel"].Value = armaTelefono();
                adaptador.UpdateCommand.Parameters["@dni"].Value = textBox3.Text;
                adaptador.UpdateCommand.Parameters["@sex"].Value = comboBox1.SelectedValue;
                adaptador.UpdateCommand.Parameters["@id"].Value = int.Parse(label13.Text);
                adaptador.UpdateCommand.ExecuteNonQuery();
                MessageBox.Show("Se modifico correctamente el Cliente de Alquiler " + textBox1.Text + " " + textBox2.Text);
                conexion.Close();
            }
            if (estBoton == "Registrar")
            {
                RegistrarCategoria rc = Owner as RegistrarCategoria;
                SqlCommand alta = new SqlCommand("insert into clienteAlquiler values (@nom, @ape, @fec, @dni, @sex, @tel, @dir, @loc)", conexion);
                adaptador.InsertCommand = alta;
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nom", SqlDbType.VarChar, 50));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@ape", SqlDbType.VarChar, 50));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@fec", SqlDbType.Date));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@dir", SqlDbType.VarChar, 50));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@loc", SqlDbType.VarChar, 50));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@tel", SqlDbType.VarChar, 50));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@dni", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@sex", SqlDbType.Int));
                conexion.Open();
                adaptador.InsertCommand.Parameters["@nom"].Value = textBox1.Text;
                adaptador.InsertCommand.Parameters["@ape"].Value = textBox2.Text;
                adaptador.InsertCommand.Parameters["@fec"].Value = armaFecha();
                adaptador.InsertCommand.Parameters["@dir"].Value = textBox5.Text;
                adaptador.InsertCommand.Parameters["@loc"].Value = comboBox2.SelectedItem;
                adaptador.InsertCommand.Parameters["@tel"].Value = armaTelefono();
                adaptador.InsertCommand.Parameters["@dni"].Value = textBox3.Text;
                adaptador.InsertCommand.Parameters["@sex"].Value = comboBox1.SelectedValue;
                adaptador.InsertCommand.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Cliente de Alquiler Registrado Correctamente con el ID: " + consultaID(), "Alerta", MessageBoxButtons.OK);
                if (flag == 1)
                {
                    rc.Show();
                    flag = 0;
                    rc.profesorTableAdapter.Fill(rc.pilarSportClubDataSet15.profesor);
                    rc.comboBox2.DataSource = rc.profesorBindingSource;
                    rc.comboBox2.SelectedValue = consultaID();
                    this.Close();
                }
                else
                {
                    inicial();
                    adaptador.SelectCommand = new SqlCommand("buscarClienteAlquiler", conexion);
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

        public String consultaID()
        {
            DataSet datoObj1;
            SqlCommand consulta = new SqlCommand("select idClienteAlq from clienteAlquiler where dni=@doc", conexion);
            adaptador.SelectCommand = consulta;
            adaptador.SelectCommand.Parameters.Add(new SqlParameter("@doc", SqlDbType.VarChar));
            datoObj1 = new DataSet();
            conexion.Open();
            string idSocio = "";
            adaptador.SelectCommand.Parameters["@doc"].Value = int.Parse(textBox3.Text);
            adaptador.Fill(datoObj1);
            idSocio = datoObj1.Tables[0].Rows[0][0].ToString();
            conexion.Close();
            return idSocio;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand eliminar = new SqlCommand("delete from clienteAlquiler where idClienteAlq=@ica", conexion);
            adaptador.DeleteCommand = eliminar;
            adaptador.DeleteCommand.Parameters.Add(new SqlParameter("@ica", SqlDbType.Int));
            conexion.Open();
            adaptador.DeleteCommand.Parameters["@ica"].Value = dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[1].Value;
            adaptador.DeleteCommand.ExecuteNonQuery();
            conexion.Close();
            adaptador.SelectCommand = new SqlCommand("buscarClienteAlquiler", conexion);
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
