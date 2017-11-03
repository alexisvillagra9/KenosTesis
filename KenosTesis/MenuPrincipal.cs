using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KenosTesis
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void nuevoSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoSocio ns = new NuevoSocio();
            ns.ShowDialog();
        }

        private void consultarSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarSocio ms = new ModificarSocio();
            ms.panel1.Enabled = false;
            ms.panel2.Enabled = false;
            ms.panel3.Enabled = false;
            ms.button6.Visible = false;
            ms.tabControl1.Enabled = false;
            ms.textBox1.Enabled = false;
            ms.button9.Visible = false;
            ms.ShowDialog();
        }

        private void registrarNuevoGrupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarGrupoFamiliar rgf = new RegistrarGrupoFamiliar();
            rgf.ShowDialog();
        }

        private void consultarGrupoFamiliarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarGrupoFamiliar mcgf = new ModificarGrupoFamiliar();
            mcgf.ShowDialog();
        }

        private void crearFormulariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImprimirFormularios cf = new ImprimirFormularios();
            cf.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NuevoSocio ns = new NuevoSocio();
            ns.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModificarSocio ms = new ModificarSocio();
            ms.panel1.Enabled = false;
            ms.panel2.Enabled = false;
            ms.panel3.Enabled = false;
            ms.button6.Visible = false;
            ms.tabControl1.Enabled = false;
            ms.textBox1.Enabled = false;
            ms.button9.Visible = false;
            ms.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegistrarGrupoFamiliar rgf = new RegistrarGrupoFamiliar();
            rgf.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ModificarGrupoFamiliar mcgf = new ModificarGrupoFamiliar();
            mcgf.ShowDialog();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ImprimirFormularios cf = new ImprimirFormularios();
            cf.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RegistrarProfesor rp = new RegistrarProfesor();
            rp.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RegistrarDeportes rd = new RegistrarDeportes();
            rd.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RegistrarCategoria rc = new RegistrarCategoria();
            rc.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            RegistrarClienteAlquiler ca = new RegistrarClienteAlquiler();
            ca.ShowDialog();
        }

        private void informesEstadisticosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformesEstadisticos ie = new InformesEstadisticos();
            ie.ShowDialog();
        }
    }
}
