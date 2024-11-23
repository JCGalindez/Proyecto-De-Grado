namespace ProyectoDeGrado_Nomina
{
    partial class SeleccionarMes
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
            this.cbSeleccionMes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmarMes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbSeleccionMes
            // 
            this.cbSeleccionMes.FormattingEnabled = true;
            this.cbSeleccionMes.Location = new System.Drawing.Point(225, 62);
            this.cbSeleccionMes.Name = "cbSeleccionMes";
            this.cbSeleccionMes.Size = new System.Drawing.Size(121, 24);
            this.cbSeleccionMes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccionar Mes";
            // 
            // btnConfirmarMes
            // 
            this.btnConfirmarMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarMes.Location = new System.Drawing.Point(163, 130);
            this.btnConfirmarMes.Name = "btnConfirmarMes";
            this.btnConfirmarMes.Size = new System.Drawing.Size(104, 32);
            this.btnConfirmarMes.TabIndex = 2;
            this.btnConfirmarMes.Text = "Aceptar";
            this.btnConfirmarMes.UseVisualStyleBackColor = true;
            this.btnConfirmarMes.Click += new System.EventHandler(this.btnConfirmarMes_Click);
            // 
            // SeleccionarMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(431, 186);
            this.Controls.Add(this.btnConfirmarMes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSeleccionMes);
            this.Name = "SeleccionarMes";
            this.Text = "SeleccionarMes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSeleccionMes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmarMes;
    }
}