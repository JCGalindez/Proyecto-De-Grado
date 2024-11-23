using Microsoft.Office.Interop.Excel;
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

namespace ProyectoDeGrado_Nomina
{
    public partial class Calculo_Nomina : Form
    {
        private string connectionString = @"Data Source=DESKTOP-84SQO36;Initial Catalog=Bd_nominaplus;Integrated Security=True";

        public Calculo_Nomina()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIdEmpleado.Text, out int empleadoId))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string query = "SELECT CONCAT(Nombre, ' ', Apellido) AS NombreCompleto, Salario FROM Empleados WHERE Id = @Id";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Id", empleadoId);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    txtNombre.Text = reader["NombreCompleto"].ToString();
                                    txtSalarioBase.Text = reader["Salario"].ToString();
                                }
                                else
                                {
                                    MessageBox.Show("Empleado no encontrado.");
                                    txtNombre.Clear();
                                    txtSalarioBase.Clear();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al consultar los datos del empleado: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un ID de empleado válido.");
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            Menu formulario = new Menu();
            formulario.Show();
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIdEmpleado.Text, out int idEmpleado))
            {
                int diasTrabajados = (int)cbDiasTrabajados.SelectedItem;
                int diasFestivos = (int)cbDiasFestivos.SelectedItem;
                int horasExtras = (int)cbHorasExtras.SelectedItem;
                string mesSeleccionado = cbMes.SelectedItem.ToString();

                if (decimal.TryParse(txtSalarioBase.Text, out decimal salarioBase))
                {
                    decimal pagoDiario = salarioBase / 30;
                    decimal pagoDiasTrabajados = pagoDiario * diasTrabajados;

                    decimal pagoFestivos = pagoDiario * diasFestivos * 1.5m; // Festivos con recargo
                    decimal pagoHorasExtras = (pagoDiario / 8) * horasExtras * 1.25m; // Recargo horas extras
                    decimal extrasalariales = pagoFestivos + pagoHorasExtras;

                    decimal deduccion = salarioBase * 0.04m; // Ejemplo: 4% como deducción
                    decimal bonificacion = salarioBase * 0.1m; // Ejemplo: 10% como bonificación

                    decimal pagoTotal = pagoDiasTrabajados + extrasalariales + bonificacion - deduccion;

                    txtResultado.Text = pagoTotal.ToString("C");

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();

                            string insertQuery = @"
                        INSERT INTO Nomina (idempleado, mes, salario_basico, extrasalariales, deduccion, bonificacion, pago_total) 
                        VALUES (@IdEmpleado, @Mes, @SalarioBasico, @ExtraSalariales, @Deduccion, @Bonificacion, @PagoTotal)";

                            using (SqlCommand command = new SqlCommand(insertQuery, connection))
                            {
                                command.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
                                command.Parameters.AddWithValue("@Mes", mesSeleccionado);
                                command.Parameters.AddWithValue("@SalarioBasico", salarioBase);
                                command.Parameters.AddWithValue("@ExtraSalariales", extrasalariales);
                                command.Parameters.AddWithValue("@Deduccion", deduccion);
                                command.Parameters.AddWithValue("@Bonificacion", bonificacion);
                                command.Parameters.AddWithValue("@PagoTotal", pagoTotal);

                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Cálculo de nómina guardado exitosamente.");

                                    rtbHistorial.AppendText($"Días Trabajados: {diasTrabajados}\n, Festivos: {diasFestivos}\n, Horas Extras: {horasExtras}\n");
                                    rtbHistorial.AppendText($"Salario Básico: {salarioBase:C}\n, Extrasalariales: {extrasalariales:C}\n");
                                    rtbHistorial.AppendText($"Deducción: {deduccion:C}\n, Bonificación: {bonificacion:C}\n");
                                    rtbHistorial.AppendText($"Pago Total: {pagoTotal:C}\n");
                                    rtbHistorial.AppendText("----------------------------------------------\n");
                                }
                                else
                                {
                                    MessageBox.Show("Error al guardar el cálculo de nómina.");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al guardar en la base de datos: " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un salario base válido.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un ID de empleado válido.");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Calculo_Nomina_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 30; i++)
            {
                cbDiasTrabajados.Items.Add(i);
            }

            for (int i = 0; i <= 15; i++)
            {
                cbDiasFestivos.Items.Add(i);
            }

            for (int i = 0; i <= 48; i++)
            {
                cbHorasExtras.Items.Add(i);
            }

            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            cbMes.Items.AddRange(meses);

            cbDiasTrabajados.SelectedIndex = 0;
            cbDiasFestivos.SelectedIndex = 0;
            cbHorasExtras.SelectedIndex = 0;
            cbMes.SelectedIndex = 0;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            txtIdEmpleado.Clear();
            txtSalarioBase.Clear();
            txtNombre.Clear();
            txtResultado.Clear();
            rtbHistorial.Clear();
            cbDiasTrabajados.SelectedIndex = 0;
            cbDiasFestivos.SelectedIndex = 0;
            cbHorasExtras.SelectedIndex = 0;
            cbMes.SelectedIndex = 0;
            txtIdEmpleado.Focus();

        }
    }
}
