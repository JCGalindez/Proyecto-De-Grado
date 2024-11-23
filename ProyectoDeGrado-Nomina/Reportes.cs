using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;
using iTextSharp.text;
using iTextSharp.text.pdf;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ProyectoDeGrado_Nomina
{
    public partial class Reportes : Form
    {
        private string connectionString = @"Server=DESKTOP-84SQO36;Initial Catalog=Bd_nominaplus;Integrated Security=True;";
        public Reportes()
        {
            InitializeComponent();
        }

        private void btnemleados_Click(object sender, EventArgs e)
        {
            tipoReporteActual = TipoReporte.Empleados;
            GenerarReporteEmpleados();

        }
        private enum TipoReporte
        {
            Empleados,
            Nomina
        }

        private TipoReporte tipoReporteActual;

        private void GenerarReporteEmpleados()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        SELECT 
                            Id, 
                            Nombre, 
                            Apellido, 
                            Edad, 
                            Email, 
                            Cargo, 
                            Salario 
                        FROM Empleados 
                        ORDER BY Apellido, Nombre";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dtEmpleados = new DataTable();
                        adapter.Fill(dtEmpleados);

                        // Mostrar datos en un DataGridView
                        dataGridView1.DataSource = dtEmpleados;

                        // Mostrar información detallada en un RichTextBox
                        MostrarInformacionDetallada(dtEmpleados);

                        // Generar resumen
                        GenerarResumenEmpleados(dtEmpleados);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MostrarInformacionDetallada(DataTable dtEmpleados)
        {
            richTextBox1.Clear();
            richTextBox1.AppendText("Detalles de Empleados:\n\n");

            foreach (DataRow empleado in dtEmpleados.Rows)
            {
                richTextBox1.AppendText(
                    $"ID: {empleado["Id"]}\n" +
                    $"Nombre Completo: {empleado["Nombre"]} {empleado["Apellido"]}\n" +
                    $"Edad: {empleado["Edad"]} años\n" +
                    $"Cargo: {empleado["Cargo"]}\n" +
                    $"Salario: {Convert.ToDecimal(empleado["Salario"]):C2}\n" +
                    $"Email: {empleado["Email"]}\n\n"
                );
            }
        }

        private void GenerarResumenEmpleados(DataTable dtEmpleados)
        {
            int totalEmpleados = dtEmpleados.Rows.Count;
            decimal promedioSalario = Convert.ToDecimal(dtEmpleados.Compute("AVG(Salario)", ""));
            int promedioEdad = Convert.ToInt32(dtEmpleados.Compute("AVG(Edad)", ""));

            labelresumen.Text = $"Total Empleados: {totalEmpleados}\n" +
                                $"Salario Promedio: {promedioSalario:C2}\n" +
                                $"Edad Promedio: {promedioEdad} años";
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Menu formulario = new Menu();
            formulario.Show();
            this.Close();
        }

        private void exportarexcel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Archivos de Excel (*.xlsx)|*.xlsx",
                    Title = tipoReporteActual == TipoReporte.Empleados
                        ? "Exportar Empleados a Excel"
                        : "Exportar Nómina a Excel"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (tipoReporteActual == TipoReporte.Empleados)
                    {
                        ExportarAExcel(saveFileDialog.FileName, "Empleados");
                    }
                    else
                    {
                        ExportarAExcel(saveFileDialog.FileName, "Nómina");
                    }

                    MessageBox.Show("Exportación a Excel completada", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar a Excel: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exportarpdf_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Archivos PDF (*.pdf)|*.pdf",
                    Title = tipoReporteActual == TipoReporte.Empleados
                        ? "Exportar Empleados a PDF"
                        : "Exportar Nómina a PDF"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (tipoReporteActual == TipoReporte.Empleados)
                    {
                        ExportarAPdf(saveFileDialog.FileName, "Empleados");
                    }
                    else
                    {
                        ExportarAPdf(saveFileDialog.FileName, "Nómina");
                    }

                    MessageBox.Show("Exportación a PDF completada", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar a PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para exportar a Excel
        private void ExportarAExcel(string filePath, string tituloHoja)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add(tituloHoja);

                // Escribir encabezados desde el DataGridView
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1].Value = dataGridView1.Columns[i].HeaderText;
                }

                // Escribir datos
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = dataGridView1.Rows[i].Cells[j].Value;
                    }
                }

                // Guardar archivo
                FileInfo fileInfo = new FileInfo(filePath);
                package.SaveAs(fileInfo);
            }
        }
        private void ExportarAPdf(string filePath, string tituloReporte)
        {
            Document document = new Document(PageSize.A4.Rotate());
            PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
            document.Open();

            // Título
            document.Add(new Paragraph(tituloReporte)
            {
                Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18),
                Alignment = Element.ALIGN_CENTER
            });

            document.Add(new Paragraph("\n")); // Espacio en blanco

            // Crear tabla PDF con las mismas columnas que el DataGridView
            PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count)
            {
                WidthPercentage = 100
            };

            // Agregar encabezados
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)))
                {
                    BackgroundColor = BaseColor.LIGHT_GRAY,
                    HorizontalAlignment = Element.ALIGN_CENTER
                };
                pdfTable.AddCell(cell);
            }

            // Agregar filas
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        pdfTable.AddCell(new Phrase(cell.Value?.ToString() ?? string.Empty, FontFactory.GetFont(FontFactory.HELVETICA, 10)));
                    }
                }
            }

            document.Add(pdfTable);
            document.Close();
        }

        private void btnNominaEmpleados_Click(object sender, EventArgs e)
        {
            using (SeleccionarMes seleccionarMes = new SeleccionarMes())
            {
                if (seleccionarMes.ShowDialog() == DialogResult.OK)
                {
                    string mesSeleccionado = seleccionarMes.MesSeleccionado;
                    tipoReporteActual = TipoReporte.Nomina;

                    MostrarNominaPorMes(mesSeleccionado);
                    GenerarResumenPorMes(mesSeleccionado);
                    labelresumen.Text = string.Empty;
                    
                }
            }
        }
        private void MostrarNominaPorMes(string mesSeleccionado)
        {
            string query = @"
        SELECT 
            n.id AS [ID Nómina], 
            n.idempleado AS [ID Empleado], 
            e.Nombre + ' ' + e.Apellido AS [Empleado], 
            n.mes AS [Mes], 
            n.salario_basico AS [Salario Básico], 
            n.extrasalariales AS [Extrasalariales], 
            n.deduccion AS [Deducción], 
            n.bonificacion AS [Bonificación], 
            n.pago_total AS [Pago Total]
        FROM Nomina n
        INNER JOIN Empleados e ON n.idempleado = e.Id
        WHERE n.mes = @Mes";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Mes", mesSeleccionado);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        // Mostrar los datos en el DataGridView
                        dataGridView1.DataSource = table;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al consultar la base de datos: " + ex.Message);
                }
            }
        }
        private void GenerarResumenPorMes(string mesSeleccionado)
        {
            string query = @"
        SELECT 
            COUNT(*) AS [Total Empleados], 
            SUM(n.salario_basico) AS [Total Salarios Básicos], 
            SUM(n.extrasalariales) AS [Total Extrasalariales], 
            SUM(n.deduccion) AS [Total Deducciones], 
            SUM(n.bonificacion) AS [Total Bonificaciones], 
            SUM(n.pago_total) AS [Total Pago]
        FROM Nomina n
        WHERE n.mes = @Mes";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Mes", mesSeleccionado);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int totalEmpleados = reader.GetInt32(0);
                                decimal totalSalariosBasicos = reader.GetDecimal(1);
                                decimal totalExtrasalariales = reader.GetDecimal(2);
                                decimal totalDeducciones = reader.GetDecimal(3);
                                decimal totalBonificaciones = reader.GetDecimal(4);
                                decimal totalPago = reader.GetDecimal(5);

                                // Mostrar resumen en el RichTextBox
                                richTextBox1.Clear();
                                richTextBox1.AppendText($"Resumen Nómina - {mesSeleccionado}\n");
                                richTextBox1.AppendText("----------------------------------------------\n");
                                richTextBox1.AppendText($"Total Empleados: {totalEmpleados}\n");
                                richTextBox1.AppendText($"Total Salarios Básicos: {totalSalariosBasicos:C}\n");
                                richTextBox1.AppendText($"Total Extrasalariales: {totalExtrasalariales:C}\n");
                                richTextBox1.AppendText($"Total Deducciones: {totalDeducciones:C}\n");
                                richTextBox1.AppendText($"Total Bonificaciones: {totalBonificaciones:C}\n");
                                richTextBox1.AppendText($"Total Pago: {totalPago:C}\n");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el resumen: " + ex.Message);
                }
            }
        }
    }
}
