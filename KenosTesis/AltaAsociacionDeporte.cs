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
    public partial class AltaAsociacionDeporte : Form
    {
        public AltaAsociacionDeporte()
        {
            InitializeComponent();
        }

        int flag = 0;
        private SqlConnection conexion;
        private SqlDataAdapter adaptador;
        private DataSet datoObj;
        private void AltaAsociacionDeporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsCategoria.categoria' Puede moverla o quitarla según sea necesario.
            // this.categoriaTableAdapter.Fill(this.dsCategoria.categoria);
            // TODO: esta línea de código carga datos en la tabla 'dS_Categoria.categoria' Puede moverla o quitarla según sea necesario.
            // TODO: esta línea de código carga datos en la tabla 'pilarSportClubDataSet24.deporte' Puede moverla o quitarla según sea necesario.
            this.deporteTableAdapter.Fill(this.pilarSportClubDataSet24.deporte);
            conexion = new SqlConnection("Data Source=DESKTOP-TGHGHKS;Initial Catalog=pilarSportClub;Integrated Security=True");
            adaptador = new SqlDataAdapter();
            SqlCommand alta = new SqlCommand("insert into asociacionDeporte values (@fecI, @fecF, @est, @cat, @cdep,@socio)", conexion);
            adaptador.InsertCommand = alta;
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@fecI", SqlDbType.Date));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@fecF", SqlDbType.Date));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@est", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@cat", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@cdep", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@socio", SqlDbType.Int));
            comboBox2.Visible = false;
            button1.Visible = false;
            label3.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                this.categoriaTableAdapter.Fill(this.dsCategoria.categoria, int.Parse(label1.Text), int.Parse(comboBox1.SelectedValue.ToString()));
                comboBox2.Visible = true;
                button1.Visible = true;
                label3.Visible = true;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ModificarSocio ms = Owner as ModificarSocio;
            conexion.Open();
            adaptador.InsertCommand.Parameters["@fecI"].Value = DateTime.Today;
            adaptador.InsertCommand.Parameters["@fecF"].Value = System.DBNull.Value;
            adaptador.InsertCommand.Parameters["@est"].Value = 1;
            adaptador.InsertCommand.Parameters["@cat"].Value = comboBox2.SelectedValue;
            adaptador.InsertCommand.Parameters["@cdep"].Value = System.DBNull.Value;
            adaptador.InsertCommand.Parameters["@socio"].Value = ms.nsocio.Text;
            adaptador.InsertCommand.ExecuteNonQuery();
            conexion.Close();
            ms.asociacionDeporteTableAdapter.Fill(ms.pilarSportClubDataSet27.asociacionDeporte, int.Parse(ms.nsocio.Text));
            flag = 1;
            MessageBox.Show("Asociacion a Deporte Correcta");
            ms.Show();
            this.Close();
        }
    }
}
