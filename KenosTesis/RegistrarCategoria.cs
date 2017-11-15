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
    public partial class RegistrarCategoria : Form
    {
        public RegistrarCategoria()
        {
            InitializeComponent();
        }

        private SqlConnection conexion;
        private SqlDataAdapter adaptador;
        private DataSet datoObj;
        private void RegistrarCategoria_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pilarSportClubDataSet26.cateEdad' Puede moverla o quitarla según sea necesario.
            this.cateEdadTableAdapter.Fill(this.pilarSportClubDataSet26.cateEdad);
            // TODO: esta línea de código carga datos en la tabla 'dS_Sexo.sexo' Puede moverla o quitarla según sea necesario.
            this.sexoTableAdapter.Fill(this.dS_Sexo.sexo);
            this.buscarCategoriasTableAdapter.Fill(this.pilarSportClubDataSet17.buscarCategorias);
            this.profesorTableAdapter.Fill(this.pilarSportClubDataSet15.profesor);
            this.deporteTableAdapter.Fill(this.pilarSportClubDataSet14.deporte);
            dateTimePicker1.CustomFormat = ("HH:mm");
            dateTimePicker2.CustomFormat = ("HH:mm");
            this.MaximizeBox = false;
            inicial();
            conexion = new SqlConnection("Data Source=DESKTOP-TGHGHKS;Initial Catalog=pilarSportClub;Integrated Security=True");
            adaptador = new SqlDataAdapter();

        }

        String botGuaReg = "";

        public void inicial()
        {
            panel2.Visible = true;
            panel1.Visible = false;
            button3.Visible = true;
            this.Size = new Size(616, 312);
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            botGuaReg = "Registrar";
            desbloquearCampos();
            foreach (Control c in this.panel1.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }

            }
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            panel2.Visible = false;
            panel1.Visible = true;
            button5.Visible = true;
            button7.Visible = false;
            button5.Text = botGuaReg;
            this.Size = new Size(616, 360);
            panel1.Location = new System.Drawing.Point(18, 13);
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inicial();
            button7.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (botGuaReg.Equals("Guardar"))
            {
                SqlCommand modifica = new SqlCommand("update categoria set nombre=@nom, precio=@pre , descripcion=@desc, profesor=@pro, deporte=@dep, horaInicio=@hsi , horaFin=@hsf, cateSexo=@csex, cateEdad=@ceda where idCategoria=@idc", conexion);
                adaptador.UpdateCommand = modifica;
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@nom", SqlDbType.VarChar, 50));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@pre", SqlDbType.Float));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@desc", SqlDbType.VarChar, 255));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@pro", SqlDbType.Int));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@dep", SqlDbType.Int));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@hsi", SqlDbType.Time, 7));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@hsf", SqlDbType.Time, 7));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@csex", SqlDbType.Int));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@ceda", SqlDbType.Int));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@idc", SqlDbType.Int));

                conexion.Open();
                adaptador.UpdateCommand.Parameters["@nom"].Value = ((DataRowView)comboBox1.SelectedItem)["nombre"].ToString() + " " + ((DataRowView)cbCS.SelectedItem)["descripcion"].ToString() + " " + ((DataRowView)cbCE.SelectedItem)["descripcion"].ToString();
                adaptador.UpdateCommand.Parameters["@pre"].Value = textBox3.Text;
                adaptador.UpdateCommand.Parameters["@desc"].Value = textBox2.Text;
                adaptador.UpdateCommand.Parameters["@pro"].Value = int.Parse(comboBox2.SelectedValue.ToString());
                adaptador.UpdateCommand.Parameters["@dep"].Value = int.Parse(comboBox1.SelectedValue.ToString());
                adaptador.UpdateCommand.Parameters["@hsi"].Value = dateTimePicker1.Value.ToString("HH:mm");
                adaptador.UpdateCommand.Parameters["@hsf"].Value = dateTimePicker1.Value.ToString("HH:mm");
                adaptador.UpdateCommand.Parameters["@csex"].Value = int.Parse(cbCS.SelectedValue.ToString());
                adaptador.UpdateCommand.Parameters["@ceda"].Value = int.Parse(cbCE.SelectedValue.ToString());
                adaptador.UpdateCommand.Parameters["@idc"].Value = int.Parse(label7.Text);
                adaptador.UpdateCommand.ExecuteNonQuery();
                MessageBox.Show("Se modifico correctamente la Categoria " + ((DataRowView)comboBox1.SelectedItem)["nombre"].ToString() + " " + ((DataRowView)cbCS.SelectedItem)["descripcion"].ToString() + " " + ((DataRowView)cbCE.SelectedItem)["descripcion"].ToString());
                conexion.Close();
            }
            if (botGuaReg.Equals("Registrar"))
            {
                SqlCommand alta = new SqlCommand("insert into categoria values (@nom, @pre, @desc, @pro, @dep, @hsi, @hsf, @csex, @ceda)", conexion);
                adaptador.InsertCommand = alta;
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nom", SqlDbType.VarChar, 50));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@pre", SqlDbType.Float));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@desc", SqlDbType.VarChar, 255));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@pro", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@dep", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@hsi", SqlDbType.Time, 7));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@hsf", SqlDbType.Time, 7));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@csex", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@ceda", SqlDbType.Int));
                conexion.Open();
                adaptador.InsertCommand.Parameters["@nom"].Value = ((DataRowView)comboBox1.SelectedItem)["nombre"].ToString() + " " + ((DataRowView)cbCS.SelectedItem)["descripcion"].ToString() + " " + ((DataRowView)cbCE.SelectedItem)["descripcion"].ToString();
                adaptador.InsertCommand.Parameters["@pre"].Value = float.Parse(textBox3.Text);
                adaptador.InsertCommand.Parameters["@desc"].Value = textBox2.Text;
                adaptador.InsertCommand.Parameters["@pro"].Value = int.Parse(comboBox2.SelectedValue.ToString());
                adaptador.InsertCommand.Parameters["@dep"].Value = int.Parse(comboBox1.SelectedValue.ToString());
                adaptador.InsertCommand.Parameters["@hsi"].Value = dateTimePicker1.Value.ToString("HH:mm");
                adaptador.InsertCommand.Parameters["@hsf"].Value = dateTimePicker2.Value.ToString("HH:mm");
                adaptador.InsertCommand.Parameters["@csex"].Value = int.Parse(cbCS.SelectedValue.ToString());
                adaptador.InsertCommand.Parameters["@ceda"].Value = int.Parse(cbCE.SelectedValue.ToString());
                adaptador.InsertCommand.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Categoria Registrada Correctamente con el ID: " + consultaID(), "Alerta", MessageBoxButtons.OK);
                inicial();
                adaptador.SelectCommand = new SqlCommand("buscarCategoria", conexion);
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

        private void button1_Click(object sender, EventArgs e)
        {
            botGuaReg = "Guardar";
            button5.Text = botGuaReg;
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
                        this.Size = new Size(616, 550);
                        panel1.Location = new System.Drawing.Point(15, 204);
                        this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
                        this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
                        label7.Text = dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[1].Value.ToString();
                        SqlCommand consulta = new SqlCommand("select * from categoria where idCategoria=@ic", conexion);
                        adaptador.SelectCommand = consulta;
                        adaptador.SelectCommand.Parameters.Add(new SqlParameter("@ic", SqlDbType.Int));
                        datoObj = new DataSet();
                        conexion.Open();
                        adaptador.SelectCommand.Parameters["@ic"].Value = dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[1].Value;
                        adaptador.Fill(datoObj);
                        conexion.Close();
                        comboBox1.SelectedValue = datoObj.Tables[0].Rows[0][5].ToString();
                        cbCS.SelectedValue = datoObj.Tables[0].Rows[0][8].ToString();
                        cbCE.SelectedValue = datoObj.Tables[0].Rows[0][9].ToString();
                        dateTimePicker1.Value = Convert.ToDateTime(datoObj.Tables[0].Rows[0][6].ToString());
                        dateTimePicker2.Value = Convert.ToDateTime(datoObj.Tables[0].Rows[0][7].ToString());
                        comboBox1.SelectedValue = datoObj.Tables[0].Rows[0][5].ToString();
                        comboBox2.SelectedItem = datoObj.Tables[0].Rows[0][4].ToString();
                        textBox3.Text = datoObj.Tables[0].Rows[0][2].ToString();
                        textBox2.Text = datoObj.Tables[0].Rows[0][3].ToString();
                        bloquearCampos();
                    }
                }

            }
        }

        private void bloquearCampos()
        {
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            cbCE.Enabled = false;
            cbCS.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }
        private void desbloquearCampos()
        {
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            cbCS.Enabled = true;
            cbCE.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
        }

        public String consultaID()
        {
            DataSet datoObj1;
            SqlCommand consulta = new SqlCommand("Select MAX(idCategoria) from categoria", conexion);
            adaptador.SelectCommand = consulta;
            datoObj1 = new DataSet();
            conexion.Open();
            string idSocio = "";
            adaptador.Fill(datoObj1);
            idSocio = datoObj1.Tables[0].Rows[0][0].ToString();
            conexion.Close();
            return idSocio;

        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            adaptador.SelectCommand = new SqlCommand("buscarCategoria", conexion);
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
            adaptador.SelectCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50);

            conexion.Open();
            DataTable datos;
            datos = new DataTable();
            adaptador.SelectCommand.Parameters["@nombre"].Value = textBox4.Text;
            adaptador.Fill(datos);
            conexion.Close();
            dataGridView1.DataSource = datos;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            desbloquearCampos();
            button7.Visible = false;
            button5.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand eliminar = new SqlCommand("delete from categoria where idCategoria=@idc", conexion);
            adaptador.DeleteCommand = eliminar;
            adaptador.DeleteCommand.Parameters.Add(new SqlParameter("@idc", SqlDbType.Int));
            conexion.Open();
            adaptador.DeleteCommand.Parameters["@idc"].Value = dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[1].Value;
            adaptador.DeleteCommand.ExecuteNonQuery();
            conexion.Close();
            adaptador.SelectCommand = new SqlCommand("buscarCategoria", conexion);
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

        private void button6_Click(object sender, EventArgs e)
        {

            RegistrarProfesor rp = new RegistrarProfesor();
            rp.flag = 1;
            AddOwnedForm(rp);
            rp.Show();
            rp.todoBotonNuevo();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            RegistrarDeportes rd = new RegistrarDeportes();
            rd.flag = 1;
            AddOwnedForm(rd);
            rd.Show();
            rd.todoBotonNuevo();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se considera INFANTIL de 6 a 12 anos. JOVENES de 13 a 17. ADULTOS de 18 a 35. VETERANO mas de 36");
        }


    }
}
