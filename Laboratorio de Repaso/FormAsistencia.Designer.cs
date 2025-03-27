namespace Laboratorio_de_Repaso
{
    partial class FormAsistencia
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregarAsistencia = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.comboBoxEmpleados = new System.Windows.Forms.ComboBox();
            this.numericMes = new System.Windows.Forms.NumericUpDown();
            this.numericHorasxMes = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHorasxMes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(12, 291);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(182, 75);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "No de Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Horas x Mes";
            // 
            // btnAgregarAsistencia
            // 
            this.btnAgregarAsistencia.Location = new System.Drawing.Point(12, 210);
            this.btnAgregarAsistencia.Name = "btnAgregarAsistencia";
            this.btnAgregarAsistencia.Size = new System.Drawing.Size(161, 75);
            this.btnAgregarAsistencia.TabIndex = 7;
            this.btnAgregarAsistencia.Text = "Agregar Asistencia";
            this.btnAgregarAsistencia.UseVisualStyleBackColor = true;
            this.btnAgregarAsistencia.Click += new System.EventHandler(this.btnAgregarAsistencia_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(179, 208);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(154, 77);
            this.btnReporte.TabIndex = 8;
            this.btnReporte.Text = "Ir a Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // comboBoxEmpleados
            // 
            this.comboBoxEmpleados.FormattingEnabled = true;
            this.comboBoxEmpleados.Location = new System.Drawing.Point(153, 19);
            this.comboBoxEmpleados.Name = "comboBoxEmpleados";
            this.comboBoxEmpleados.Size = new System.Drawing.Size(299, 24);
            this.comboBoxEmpleados.TabIndex = 9;
            // 
            // numericMes
            // 
            this.numericMes.Location = new System.Drawing.Point(153, 70);
            this.numericMes.Name = "numericMes";
            this.numericMes.Size = new System.Drawing.Size(120, 22);
            this.numericMes.TabIndex = 10;
            // 
            // numericHorasxMes
            // 
            this.numericHorasxMes.Location = new System.Drawing.Point(153, 118);
            this.numericHorasxMes.Name = "numericHorasxMes";
            this.numericHorasxMes.Size = new System.Drawing.Size(120, 22);
            this.numericHorasxMes.TabIndex = 11;
            // 
            // FormAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 423);
            this.Controls.Add(this.numericHorasxMes);
            this.Controls.Add(this.numericMes);
            this.Controls.Add(this.comboBoxEmpleados);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnAgregarAsistencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrar);
            this.Name = "FormAsistencia";
            this.Text = "FormAsistencia";
            this.Load += new System.EventHandler(this.FormAsistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHorasxMes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregarAsistencia;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.ComboBox comboBoxEmpleados;
        private System.Windows.Forms.NumericUpDown numericMes;
        private System.Windows.Forms.NumericUpDown numericHorasxMes;
    }
}