using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDeGrado_Nomina
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void crearActualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Crear_Actualizar_empleado formulario = new Crear_Actualizar_empleado();
            formulario.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Crear_Actualizar_empleado formulario = new Crear_Actualizar_empleado();
            formulario.Show();
            this.Close();
        }

        private void Nomina_Click(object sender, EventArgs e)
        {
            Calculo_Nomina formulario = new Calculo_Nomina();
            formulario.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Reportes formulario = new Reportes();
            formulario.Show();
            this.Close();
        }

        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearUsuario formulario = new CrearUsuario();
            formulario.Show();
            this.Close();
        }
    }
}
