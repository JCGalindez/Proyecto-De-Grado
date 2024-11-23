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
    public partial class SeleccionarMes : Form
    {
        public string MesSeleccionado { get; private set; }

        public SeleccionarMes()
        {
            InitializeComponent();
            this.Text = "Seleccionar Mes";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            
            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            cbSeleccionMes.Items.AddRange(meses);
            cbSeleccionMes.SelectedIndex = 0; 
        }

        private void btnConfirmarMes_Click(object sender, EventArgs e)
        {
            if (cbSeleccionMes.SelectedItem != null)
            {
                MesSeleccionado = cbSeleccionMes.SelectedItem.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un mes.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
