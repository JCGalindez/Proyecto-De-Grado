using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDeGrado_Nomina
{
    public partial class Crear_Actualizar_empleado : Form
    {
        string connectionString = @"Data Source=DESKTOP-84SQO36;Initial Catalog=Bd_nominaplus;Integrated Security=True";

        public Crear_Actualizar_empleado()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            Menu formulario = new Menu();
            formulario.Show();
            this.Close();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtid.Text) ||
                string.IsNullOrWhiteSpace(txtnombre.Text) ||
                string.IsNullOrWhiteSpace(txtapellido.Text) ||
                string.IsNullOrWhiteSpace(txtedad.Text) ||
                string.IsNullOrWhiteSpace(txtemail.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!EsCorreoValido(txtemail.Text))
            {
                MessageBox.Show("El correo ingresado no tiene un formato válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Dictionary<string, decimal> salariosBase = new Dictionary<string, decimal>
            {
                { "Administrativo", 1300000 },
                { "Soporte Tecnico", 1400000 },
                { "Tecnico", 3500000 },
                { "Directivo", 4400000 },
                { "Gerente", 8000000 }
             };
            decimal salario;
            if (!salariosBase.TryGetValue(cargo.Text, out salario))
            {
                MessageBox.Show("Cargo no válido. Seleccione un cargo válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Verificar si el registro existe
                string checkQuery = "SELECT COUNT(*) FROM Empleados WHERE Id = @Id";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@Id", txtid.Text);
                    int exists = (int)checkCmd.ExecuteScalar();

                    string query;
                    if (exists > 0)
                    {
                        query = @"UPDATE Empleados 
                                 SET Nombre = @Nombre,
                                     Apellido = @Apellido,
                                     Edad = @Edad,
                                     Email = @Email,
                                     Cargo = @Cargo,
                                     Salario = @Salario
                                 WHERE Id = @Id";
                    }
                    else
                    {
                        query = @"INSERT INTO Empleados (Id, Nombre, Apellido, Edad, Email, Cargo, Salario)
                                 VALUES (@Id, @Nombre, @Apellido, @Edad, @Email, @Cargo, @Salario)";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id",
                        string.IsNullOrEmpty(txtid.Text) ? DBNull.Value : (object)int.Parse(txtid.Text));
                        cmd.Parameters.AddWithValue("@Nombre", txtnombre.Text);
                        cmd.Parameters.AddWithValue("@Apellido", txtapellido.Text);
                        cmd.Parameters.AddWithValue("@Edad",
                            string.IsNullOrEmpty(txtedad.Text) ? DBNull.Value : (object)int.Parse(txtedad.Text));
                        cmd.Parameters.AddWithValue("@Email",
                            string.IsNullOrEmpty(txtemail.Text) ? DBNull.Value : (object)txtemail.Text);
                        cmd.Parameters.AddWithValue("@Cargo", cargo.Text);
                        cmd.Parameters.AddWithValue("@Salario", salario);


                        cmd.ExecuteNonQuery();

                        MessageBox.Show(exists > 0 ? "Datos empleado actualizados con éxito!" : "Empelado Creado con éxito!",
                                      "Éxito",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);

                        LimpiarFormulario();
                    }
                }
            }

        }
        private bool EsCorreoValido(string email)
        {
            try
            {
                var mailAddress = new MailAddress(email); 
                return true; 
            }
            catch (FormatException)
            {
                return false; 
            }
        }

        private void LimpiarFormulario()
        {
            txtid.Clear();
            txtnombre.Clear();
            txtapellido.Clear();
            txtedad.Clear();
            txtemail.Clear();
            cargo.Text = string.Empty;
        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Enter)
            {
                e.Handled = true;
                MessageBox.Show("El ID debe ser un valor numérico.");
            }
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Enter)
            {
                e.Handled = true;
                MessageBox.Show("El nombre debe contener solo letras.");
            }
        }

        private void txtapellido_KeyPress(object sender, KeyPressEventArgs e )
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Enter)
            {
                e.Handled = true;
                MessageBox.Show("El apellido debe contener solo letras.");
            }
        }

        private void txtedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("La edad debe ser un valor numérico.");
            }
        }

        private void txtid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtnombre.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Tab)
            {
                txtnombre.Focus();
                e.Handled = true;
            }
        }

        private void txtnombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtapellido.Focus();
                e.Handled = true;
            }
           else if (e.KeyCode == Keys.Tab)
            {
                txtapellido.Focus();
                e.Handled = true;
            }
        }

        private void txtapellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtapellido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtedad.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Tab)
            {
                txtedad.Focus();
                e.Handled = true;
            }
        }

        private void txtemail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cargo.Focus();
                e.Handled = true;
            }else if (e.KeyCode == Keys.Tab)
            {
                cargo.Focus();
                e.Handled = true;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtnombre.Clear();
            txtapellido.Clear();
            txtedad.Clear();
            txtemail.Clear();
            cargo.Text = string.Empty;
        }
    }
}
