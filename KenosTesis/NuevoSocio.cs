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
    public partial class NuevoSocio : Form
    {
        public NuevoSocio()
        {
            InitializeComponent();
            panel1.Enabled = false;
            button2.Enabled = false;
        }
        private SqlConnection conexion;
        private SqlDataAdapter adaptador;
        private DataSet datoObj;

        private void NuevoSocio_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            comboBox2.SelectedIndex = 5;
            // TODO: esta línea de código carga datos en la tabla 'pilarSportClubDataSet.sexo' Puede moverla o quitarla según sea necesario.
            this.sexoTableAdapter.Fill(this.pilarSportClubDataSet.sexo);
            conexion = new SqlConnection("Data Source=DESKTOP-TGHGHKS;Initial Catalog=pilarSportClub;Integrated Security=True");
            adaptador = new SqlDataAdapter();
            SqlCommand consulta = new SqlCommand("select * from dbo.socio where dni=@doc", conexion);
            adaptador.SelectCommand = consulta;
            adaptador.SelectCommand.Parameters.Add(new SqlParameter("@doc", SqlDbType.VarChar));
            datoObj = new DataSet();

            //Alta
            SqlCommand alta = new SqlCommand("insert into socio values (@nom, @ape, @fec, @dir, @loc, @tel, @dni, @sex, @est, @gf, @obs, @feci,@fecf,@cso, @aso)", conexion);
            adaptador.InsertCommand = alta;
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nom", SqlDbType.VarChar, 50));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@ape", SqlDbType.VarChar, 50));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@fec", SqlDbType.Date));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@dir", SqlDbType.VarChar, 50));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@loc", SqlDbType.VarChar, 50));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@tel", SqlDbType.VarChar, 50));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@dni", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@sex", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@est", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@gf", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@obs", SqlDbType.VarChar, 255));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@feci", SqlDbType.Date));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@fecf", SqlDbType.Date));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@cso", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@aso", SqlDbType.Int));

            //Modifica para Asignar el ID De cuota social.
            SqlCommand modifica = new SqlCommand("update socio set idCuotaXSocio=@cso where idSocio=@idso", conexion);
            adaptador.UpdateCommand = modifica;
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@cso", SqlDbType.Int));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@idso", SqlDbType.Int));
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
        public string validarCampos()
        {
            String campos = "\n";
            if (textBox1.Text == "")
            {
                campos = campos + "Documento\n";
            }
            if (textBox2.Text == "")
            {
                campos = campos + "Nombre\n";
            }
            if (textBox3.Text == "")
            {
                campos = campos + "Apellido\n";
            }
            /*if (textBox4.Text == "")
            {
                campos = campos + "Dia Nacimiento - ";
            }
            if (textBox5.Text == "")
            {
                campos = campos + "Mes Nacimiento - ";
            }
            if (textBox6.Text == "")
            {
                campos = campos + "Anio Nacimiento - ";
            }*/
            if (textBox7.Text == "")
            {
                campos = campos + "Direccion\n";
            }
            if (textBox9.Text == "")
            {
                campos = campos + "Caracteristica Telefono\n";
            }
            if (textBox10.Text == "")
            {
                campos = campos + "Numero Telefono\n";
            }
            if (Convert.ToDateTime(dateTimePicker1.Value).Date >= DateTime.Today)
            {
                campos = campos + "Fecha";
            }
            return campos;
        }

        public String consultaID()
        {
            string idSocio = "";
            adaptador.SelectCommand.Parameters["@doc"].Value = int.Parse(textBox1.Text);
            adaptador.Fill(datoObj);
            idSocio = datoObj.Tables[0].Rows[0][0].ToString();
            return idSocio;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            adaptador.SelectCommand.Parameters["@doc"].Value = int.Parse(textBox1.Text);
            adaptador.Fill(datoObj);
            if (datoObj.Tables[0].Rows.Count != 0)
            {
                if (textBox1.Text == datoObj.Tables[0].Rows[0][7].ToString())
                {
                    //MessageBox.Show("El Usuario ya se encuentra registrado, ¿desea cargar sus datos?", "Usuario Existente", MessageBoxButtons.YesNo);
                    if (MessageBox.Show("El Usuario ya se encuentra registrado, ¿desea cargar sus datos?", "Usuario Existente", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ModificarSocio ms = new ModificarSocio();
                        ms.nsocio.Text = consultaID();
                        conexion.Close();
                        ms.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        this.Close();
                    }
                }


            }
            else
            {

                panel1.Enabled = true;
                button2.Enabled = true;
            }
            conexion.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexion.Open();
            if (validarCampos() == "\n")
            {
                if (MessageBox.Show("¿Confirma Registro de Socio?", "Confirma Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    adaptador.InsertCommand.Parameters["@nom"].Value = textBox2.Text;
                    adaptador.InsertCommand.Parameters["@ape"].Value = textBox3.Text;
                    adaptador.InsertCommand.Parameters["@fec"].Value = armaFecha();
                    adaptador.InsertCommand.Parameters["@dir"].Value = textBox7.Text;
                    adaptador.InsertCommand.Parameters["@loc"].Value = comboBox2.SelectedItem;
                    adaptador.InsertCommand.Parameters["@tel"].Value = armaTelefono();
                    adaptador.InsertCommand.Parameters["@dni"].Value = Int32.Parse(textBox1.Text);
                    adaptador.InsertCommand.Parameters["@sex"].Value = comboBox1.SelectedValue;
                    adaptador.InsertCommand.Parameters["@est"].Value = 1;
                    adaptador.InsertCommand.Parameters["@gf"].Value = System.DBNull.Value;
                    adaptador.InsertCommand.Parameters["@obs"].Value = textBox4.Text;
                    adaptador.InsertCommand.Parameters["@feci"].Value = DateTime.Today;
                    adaptador.InsertCommand.Parameters["@fecf"].Value = System.DBNull.Value;
                    adaptador.InsertCommand.Parameters["@cso"].Value = System.DBNull.Value;
                    adaptador.InsertCommand.Parameters["@aso"].Value = System.DBNull.Value;
                    adaptador.InsertCommand.ExecuteNonQuery();

                    MessageBox.Show("Socio Registrado Correctamente con el ID: " + consultaID(), "Alerta", MessageBoxButtons.OK);

                    /*adaptador.UpdateCommand.Parameters["@cso"].Value = consultaID();
                    adaptador.UpdateCommand.Parameters["@idso"].Value = consultaID();
                    adaptador.UpdateCommand.ExecuteNonQuery();*/
                    conexion.Close();
                }
                else
                {
                    this.Close();
                }
                if (MessageBox.Show("¿Desea agregar este socio a un Grupo Familiar?", "Grupo Familiar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ModificarGrupoFamiliar mgf = new ModificarGrupoFamiliar();
                    //mgf.idSocio = consultaID();
                    mgf.Show();
                    this.Close();
                    //
                    // MessageBox.Show("ACA ABRE EL GRUPO FAMILIAR", "Alerta", MessageBoxButtons.OK);
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                if (validarCampos().ToString().Equals("\nFecha"))
                {
                    MessageBox.Show("La fecha elegida no es valida, debe ser anterior a la actual");
                    conexion.Close();
                }
                else
                {
                    MessageBox.Show("Faltan los siguientes campos de completar: " + validarCampos(), "Alerta", MessageBoxButtons.OK);
                    conexion.Close();
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
