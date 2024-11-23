namespace ProyectoDeGrado_Nomina
{
    partial class Reportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportes));
            this.btnemleados = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.labelresumen = new System.Windows.Forms.Label();
            this.salir = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarexcel = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarpdf = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNominaEmpleados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnemleados
            // 
            this.btnemleados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnemleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnemleados.Image = ((System.Drawing.Image)(resources.GetObject("btnemleados.Image")));
            this.btnemleados.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnemleados.Location = new System.Drawing.Point(36, 67);
            this.btnemleados.Name = "btnemleados";
            this.btnemleados.Size = new System.Drawing.Size(188, 137);
            this.btnemleados.TabIndex = 1;
            this.btnemleados.Text = "Información Empleados";
            this.btnemleados.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnemleados.Click += new System.EventHandler(this.btnemleados_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(281, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(673, 295);
            this.dataGridView1.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(281, 399);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(673, 196);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // labelresumen
            // 
            this.labelresumen.AutoSize = true;
            this.labelresumen.Location = new System.Drawing.Point(278, 598);
            this.labelresumen.Name = "labelresumen";
            this.labelresumen.Size = new System.Drawing.Size(0, 16);
            this.labelresumen.TabIndex = 4;
            // 
            // salir
            // 
            this.salir.ForeColor = System.Drawing.Color.Red;
            this.salir.Image = ((System.Drawing.Image)(resources.GetObject("salir.Image")));
            this.salir.Location = new System.Drawing.Point(36, 595);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(100, 89);
            this.salir.TabIndex = 5;
            this.salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.salir.UseMnemonic = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1042, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarexcel,
            this.exportarpdf});
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.exportarToolStripMenuItem.Text = "Exportar";
            // 
            // exportarexcel
            // 
            this.exportarexcel.Name = "exportarexcel";
            this.exportarexcel.Size = new System.Drawing.Size(133, 26);
            this.exportarexcel.Text = "EXCEL";
            this.exportarexcel.Click += new System.EventHandler(this.exportarexcel_Click);
            // 
            // exportarpdf
            // 
            this.exportarpdf.Name = "exportarpdf";
            this.exportarpdf.Size = new System.Drawing.Size(133, 26);
            this.exportarpdf.Text = "PDF";
            this.exportarpdf.Click += new System.EventHandler(this.exportarpdf_Click);
            // 
            // btnNominaEmpleados
            // 
            this.btnNominaEmpleados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNominaEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNominaEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("btnNominaEmpleados.Image")));
            this.btnNominaEmpleados.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNominaEmpleados.Location = new System.Drawing.Point(36, 282);
            this.btnNominaEmpleados.Name = "btnNominaEmpleados";
            this.btnNominaEmpleados.Size = new System.Drawing.Size(188, 189);
            this.btnNominaEmpleados.TabIndex = 7;
            this.btnNominaEmpleados.Text = "Nomina Empleados";
            this.btnNominaEmpleados.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNominaEmpleados.Click += new System.EventHandler(this.btnNominaEmpleados_Click);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1042, 693);
            this.Controls.Add(this.btnNominaEmpleados);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.labelresumen);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnemleados);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Reportes";
            this.Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnemleados;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label labelresumen;
        private System.Windows.Forms.Label salir;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarexcel;
        private System.Windows.Forms.ToolStripMenuItem exportarpdf;
        private System.Windows.Forms.Label btnNominaEmpleados;
    }
}