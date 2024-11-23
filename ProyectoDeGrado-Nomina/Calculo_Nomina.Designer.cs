namespace ProyectoDeGrado_Nomina
{
    partial class Calculo_Nomina
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculo_Nomina));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbHistorial = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbHorasExtras = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbDiasFestivos = new System.Windows.Forms.ComboBox();
            this.cbDiasTrabajados = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Label();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.txtSalarioBase = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbHistorial);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtResultado);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbHorasExtras);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbDiasFestivos);
            this.groupBox1.Controls.Add(this.cbDiasTrabajados);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Controls.Add(this.cbMes);
            this.groupBox1.Controls.Add(this.txtSalarioBase);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtIdEmpleado);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(107, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(985, 634);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculo Nomina";
            // 
            // rtbHistorial
            // 
            this.rtbHistorial.Location = new System.Drawing.Point(328, 370);
            this.rtbHistorial.Name = "rtbHistorial";
            this.rtbHistorial.Size = new System.Drawing.Size(349, 239);
            this.rtbHistorial.TabIndex = 23;
            this.rtbHistorial.Text = "";
            // 
            // label10
            // 
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.Location = new System.Drawing.Point(823, 418);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 90);
            this.label10.TabIndex = 22;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(494, 308);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(172, 27);
            this.txtResultado.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(324, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Total A Pagar";
            // 
            // cbHorasExtras
            // 
            this.cbHorasExtras.FormattingEnabled = true;
            this.cbHorasExtras.Location = new System.Drawing.Point(234, 226);
            this.cbHorasExtras.Name = "cbHorasExtras";
            this.cbHorasExtras.Size = new System.Drawing.Size(106, 28);
            this.cbHorasExtras.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(528, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Festivos Laborados";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cbDiasFestivos
            // 
            this.cbDiasFestivos.FormattingEnabled = true;
            this.cbDiasFestivos.Location = new System.Drawing.Point(779, 162);
            this.cbDiasFestivos.Name = "cbDiasFestivos";
            this.cbDiasFestivos.Size = new System.Drawing.Size(144, 28);
            this.cbDiasFestivos.TabIndex = 17;
            // 
            // cbDiasTrabajados
            // 
            this.cbDiasTrabajados.FormattingEnabled = true;
            this.cbDiasTrabajados.Location = new System.Drawing.Point(234, 170);
            this.cbDiasTrabajados.Name = "cbDiasTrabajados";
            this.cbDiasTrabajados.Size = new System.Drawing.Size(106, 28);
            this.cbDiasTrabajados.TabIndex = 16;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(691, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(63, 64);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
            this.btnCalcular.Location = new System.Drawing.Point(65, 418);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 90);
            this.btnCalcular.TabIndex = 13;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // cbMes
            // 
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Location = new System.Drawing.Point(779, 229);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(144, 28);
            this.cbMes.TabIndex = 12;
            // 
            // txtSalarioBase
            // 
            this.txtSalarioBase.Enabled = false;
            this.txtSalarioBase.Location = new System.Drawing.Point(695, 100);
            this.txtSalarioBase.Name = "txtSalarioBase";
            this.txtSalarioBase.Size = new System.Drawing.Size(176, 27);
            this.txtSalarioBase.TabIndex = 10;
            this.txtSalarioBase.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(247, 100);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(172, 27);
            this.txtNombre.TabIndex = 8;
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Location = new System.Drawing.Point(381, 39);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(219, 27);
            this.txtIdEmpleado.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(528, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mes a Pagar";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Horas Extras";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dias Laborados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(573, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salario";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label9
            // 
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.Location = new System.Drawing.Point(1098, 522);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 90);
            this.label9.TabIndex = 16;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Calculo_Nomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1210, 678);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Name = "Calculo_Nomina";
            this.Text = "Calculo De Nomina";
            this.Load += new System.EventHandler(this.Calculo_Nomina_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label btnCalcular;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.TextBox txtSalarioBase;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btnBuscar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbDiasFestivos;
        private System.Windows.Forms.ComboBox cbDiasTrabajados;
        private System.Windows.Forms.ComboBox cbHorasExtras;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox rtbHistorial;
    }
}