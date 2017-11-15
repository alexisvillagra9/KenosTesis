using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KenosTesis
{
    public partial class ModificarSocio : Form
    {
        public ModificarSocio()
        {
            InitializeComponent();
        }

        private SqlConnection conexion;
        private SqlDataAdapter adaptador;
        private DataSet datoObj;
        private void ModificarSocio_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pilarSportClubDataSet11.sexo' Puede moverla o quitarla según sea necesario.
            this.MaximizeBox = false;
            // TODO: esta línea de código carga datos en la tabla 'pilarSportClubDataSet2.sexo' Puede moverla o quitarla según sea necesario.
            this.sexoTableAdapter.Fill(this.pilarSportClubDataSet2.sexo);
            conexion = new SqlConnection("Data Source=DESKTOP-TGHGHKS;Initial Catalog=pilarSportClub;Integrated Security=True");
            adaptador = new SqlDataAdapter();
            SqlCommand consulta = new SqlCommand("select * from dbo.socio where idSocio=@is", conexion);
            adaptador.SelectCommand = consulta;
            adaptador.SelectCommand.Parameters.Add(new SqlParameter("@is", SqlDbType.Int));

            //dataGridView1.Rows.Add(1);
            //dataGridView1.Rows[0].Cells[1].Value = "hola";
            if (nsocio.Text != "")
            {
                Rellenar(Int32.Parse(nsocio.Text));
                bloquearCampos();
                //pintarBloqueados();
            }


            SqlCommand modifica = new SqlCommand("update socio set nombreSocio=@nom, apellidoSocio=@ape, fechaNacimiento=@fec, localidad=@loc, telefono=@tel, dni=@dni, sexo=@sex, observacion=@obs where idSocio=@id", conexion);
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
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@obs", SqlDbType.VarChar, 255));

        }

        public void Rellenar(int nroSocio)
        {
            datoObj = new DataSet();
            conexion.Open();
            adaptador.SelectCommand.Parameters["@is"].Value = nroSocio;
            adaptador.Fill(datoObj);
            ndni.Text = datoObj.Tables[0].Rows[0][7].ToString();
            apellido.Text = datoObj.Tables[0].Rows[0][2].ToString();
            textBox3.Text = datoObj.Tables[0].Rows[0][1].ToString();
            textBox7.Text = datoObj.Tables[0].Rows[0][4].ToString();
            comboBox2.SelectedItem = datoObj.Tables[0].Rows[0][5].ToString();
            if (datoObj.Tables[0].Rows[0][9].ToString() == "1")
            {
                estadoSocio.Text = "Activo";
                estadoSocio.ForeColor = Color.Green;
                button2.Text = "Dar de Baja";
            }
            else
            {
                estadoSocio.Text = "Inactivo";
                estadoSocio.ForeColor = Color.Red;
                button2.Text = "Dar de Alta";
            }

            if (datoObj.Tables[0].Rows[0][10].ToString().Equals(""))
            {
                ngrupo.Text = "No tiene";
                button1.Enabled = false;
            }
            else
            {
                ngrupo.Text = datoObj.Tables[0].Rows[0][10].ToString();
            }

            //MessageBox.Show(datoObj.Tables[0].Rows[0][3].ToString());
            dateTimePicker1.Value = DateTime.ParseExact(datoObj.Tables[0].Rows[0][3].ToString(), "dd/MM/yyyy H:mm:ss", CultureInfo.InvariantCulture);
            //armaFecha(datoObj.Tables[0].Rows[0][3].ToString());
            comboBox1.SelectedValue = datoObj.Tables[0].Rows[0][8].ToString();
            traeTelefono(datoObj.Tables[0].Rows[0][6].ToString());
            textBox1.Text = datoObj.Tables[0].Rows[0][11].ToString();
            conexion.Close();

        }

        public void traeTelefono(String telefono)
        {
            string[] numero;
            numero = telefono.Split('-');
            String prefijo = numero[0].ToString();
            String sufijo = numero[1].ToString();
            textBox9.Text = prefijo;
            textBox10.Text = sufijo;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AltaAsociacionDeporte aadep = new AltaAsociacionDeporte();
            AddOwnedForm(aadep);
            aadep.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void bloquearCampos()
        {
            panel1.Enabled = true;
            panel2.Enabled = true;
            panel3.Enabled = true;
            nsocio.Enabled = false;
            ndni.Enabled = false;
            apellido.Enabled = false;
            textBox3.Enabled = false;
            textBox7.Enabled = false;
            comboBox2.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;
            comboBox1.Enabled = false;
            dateTimePicker1.Enabled = false;
            button6.Visible = false;
            textBox1.Enabled = false;
            button2.Enabled = false;
            button1.Enabled = false;
        }
        public void pintarBloqueados()
        {
            nsocio.ForeColor = Color.Black;
            ndni.ForeColor = Color.Black;
            apellido.ForeColor = Color.Black;
            textBox3.ForeColor = Color.Black;
            textBox7.ForeColor = Color.Black;
            comboBox2.ForeColor = Color.Black;
            textBox9.ForeColor = Color.Black;
            textBox10.ForeColor = Color.Black;
            comboBox1.ForeColor = Color.Black;
            dateTimePicker1.ForeColor = Color.Black;
            textBox1.ForeColor = Color.Black;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (nsocio.Text != "" || ndni.Text != "" || apellido.Text != "")
            {
                TraerSocio ts = new TraerSocio();
                ts.textBox1.Text = nsocio.Text;
                ts.textBox2.Text = ndni.Text;
                ts.textBox3.Text = apellido.Text;
                AddOwnedForm(ts);
                ts.Show();
                //this.Close();
                /*bloquearCampos();
                nsocio.Text = "12";
                ndni.Text = "35869605";
                apellido.Text = "Villagra";
                textBox3.Text = "Alexis";
                textBox4.Text = "12";
                textBox5.Text = "03";
                textBox6.Text = "1991";
                textBox7.Text = "Rafael Nunez 1669";
                textBox8.Text = "Pilar";
                textBox9.Text = "03572";
                textBox10.Text = "15507080";
                comboBox1.SelectedIndex = 0;
                estadoSocio.Text = "ACTIVO";
                estadoSocio.ForeColor = Color.Green;
                ngrupo.Text = "15";*/
                tabControl1.Enabled = true;
            }
            else
            {
                MessageBox.Show("Algunos de los campos debe estar con valores para buscar", "Alerta", MessageBoxButtons.OK);
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            button6.Visible = true;
            ndni.Enabled = true;
            apellido.Enabled = true;
            textBox3.Enabled = true;
            textBox7.Enabled = true;
            comboBox2.Enabled = true;
            textBox9.Enabled = true;
            textBox10.Enabled = true;
            comboBox1.Enabled = true;
            dateTimePicker1.Enabled = true;
            textBox1.Enabled = true;
            button2.Enabled = true;
            button1.Enabled = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            estadoSocio.Text = "- - - - - -";
            ngrupo.Text = "- - -";
            nsocio.Text ="";
            ndni.Text = "";
            apellido.Text = "";
            textBox3.Text = "";
            textBox7.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox1.Text = "";
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedItem = "Pilar";
            textBox1.Enabled = false;
            panel1.Enabled = false;
            panel2.Enabled = false;
            panel3.Enabled = false;
            nsocio.Enabled= true;
            ndni.Enabled = true;
            apellido.Enabled = true;
            button9.Visible = false;
            button2.Visible = true;
            button1.Visible = true;
            button2.Enabled = false;
            button1.Enabled = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModificarGrupoFamiliar mgf = new ModificarGrupoFamiliar();
            mgf.Show();
            mgf.superConsulta(int.Parse(nsocio.Text));
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public String armaFecha()
        {
            //String dt = textBox6.Text + "-" + textBox5.Text + "-" + textBox4.Text;
            String dt = dateTimePicker1.Value.Year.ToString() + "-" + dateTimePicker1.Value.Month.ToString() + "-" + dateTimePicker1.Value.Day.ToString();
            return dt;
        }

        public String armaTelefono()
        {
            String at = textBox9.Text + "-" + textBox10.Text;
            return at;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(dateTimePicker1.Value).Date >= DateTime.Today)
            {
                MessageBox.Show("La fecha elegida no es valida, debe ser anterior a la Actual");
            }
            else
            {


                if (MessageBox.Show("¿Confirma la Modificacion del Socio?", "Confirma la Modificacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    conexion.Open();
                    adaptador.UpdateCommand.Parameters["@nom"].Value = textBox3.Text;
                    adaptador.UpdateCommand.Parameters["@ape"].Value = apellido.Text;
                    adaptador.UpdateCommand.Parameters["@fec"].Value = armaFecha();
                    adaptador.UpdateCommand.Parameters["@dir"].Value = textBox7.Text;
                    adaptador.UpdateCommand.Parameters["@loc"].Value = comboBox2.SelectedItem;
                    adaptador.UpdateCommand.Parameters["@tel"].Value = armaTelefono();
                    adaptador.UpdateCommand.Parameters["@dni"].Value = ndni.Text;
                    adaptador.UpdateCommand.Parameters["@sex"].Value = comboBox1.SelectedValue;
                    adaptador.UpdateCommand.Parameters["@id"].Value = nsocio.Text;
                    adaptador.UpdateCommand.Parameters["@obs"].Value = textBox1.Text;
                    adaptador.UpdateCommand.ExecuteNonQuery();
                    MessageBox.Show("Se modifico correctamente el Socio " + textBox3.Text + " " + apellido.Text);
                    conexion.Close();
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int estado = 1;
            if (estadoSocio.Text.ToString().Equals("Activo"))
            {
                estado = 0;
            }
            SqlCommand modifica2 = new SqlCommand("update socio set estado=@est2 where idSocio=@idest", conexion);
            adaptador.UpdateCommand = modifica2;
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@est2", SqlDbType.Int));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@idest", SqlDbType.Int));
            conexion.Open();
            adaptador.UpdateCommand.Parameters["@est2"].Value = estado;
            adaptador.UpdateCommand.Parameters["@idest"].Value = nsocio.Text;
            adaptador.UpdateCommand.ExecuteNonQuery();
            conexion.Close();
            Rellenar(Int32.Parse(nsocio.Text));
            bloquearCampos();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
