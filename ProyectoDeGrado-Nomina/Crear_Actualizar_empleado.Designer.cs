namespace ProyectoDeGrado_Nomina
{
    partial class Crear_Actualizar_empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crear_Actualizar_empleado));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.aceptar = new System.Windows.Forms.Label();
            this.cargo = new System.Windows.Forms.ComboBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.aceptar);
            this.groupBox1.Controls.Add(this.cargo);
            this.groupBox1.Controls.Add(this.txtedad);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.txtapellido);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(92, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 519);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear / Actualizar Empleado";
            // 
            // label8
            // 
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(445, 374);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 90);
            this.label8.TabIndex = 14;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // aceptar
            // 
            this.aceptar.Image = ((System.Drawing.Image)(resources.GetObject("aceptar.Image")));
            this.aceptar.Location = new System.Drawing.Point(197, 374);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(100, 90);
            this.aceptar.TabIndex = 13;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // cargo
            // 
            this.cargo.FormattingEnabled = true;
            this.cargo.Items.AddRange(new object[] {
            "Administrativo",
            "Soporte Tecnico",
            "Tecnico",
            "Directivo",
            "Gerente"});
            this.cargo.Location = new System.Drawing.Point(200, 300);
            this.cargo.Name = "cargo";
            this.cargo.Size = new System.Drawing.Size(219, 28);
            this.cargo.TabIndex = 12;
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(200, 195);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(219, 27);
            this.txtedad.TabIndex = 11;
            this.txtedad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtedad_KeyPress);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(200, 99);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(219, 27);
            this.txtnombre.TabIndex = 10;
            this.txtnombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnombre_KeyDown);
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(200, 247);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(219, 27);
            this.txtemail.TabIndex = 9;
            this.txtemail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtemail_KeyDown);
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(200, 143);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(219, 27);
            this.txtapellido.TabIndex = 8;
            this.txtapellido.TextChanged += new System.EventHandler(this.txtapellido_TextChanged);
            this.txtapellido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtapellido_KeyDown);
            this.txtapellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapellido_KeyPress);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(200, 51);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(219, 27);
            this.txtid.TabIndex = 7;
            this.txtid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtid_KeyDown);
            this.txtid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtid_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cargo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Edad";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label9
            // 
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.Location = new System.Drawing.Point(854, 538);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 90);
            this.label9.TabIndex = 15;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Crear_Actualizar_empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(966, 637);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Name = "Crear_Actualizar_empleado";
            this.Text = "Crear O Actualizar Empleado";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.ComboBox cargo;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.Label aceptar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}