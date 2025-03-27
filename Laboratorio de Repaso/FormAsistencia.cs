using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_de_Repaso
{
    public partial class FormAsistencia : Form
    {
        List<Empleado> empleados = new List<Empleado>();
        List<Asistencia> asistencias = new List<Asistencia>();
        public FormAsistencia()
        {
            InitializeComponent();
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarAsistencia_Click(object sender, EventArgs e)
        {
            Asistencia asistencia = new Asistencia();
            asistencia.NoEmpleado = Convert.ToInt16(comboBoxEmpleados.SelectedValue);
            asistencia.horasMes = ((int)numericHorasxMes.Value);
            asistencia.mes = Convert.ToInt16(numericMes.Value);

            asistencias.Add(asistencia);
            
            AsistenciaArchivo asistenciaArchivo = new AsistenciaArchivo();

            asistenciaArchivo.Guardar(@"../../Asistencias.json", asistencias);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            FormReporte formReporte = new FormReporte();
            formReporte.Show();
        }

        private void FormAsistencia_Load(object sender, EventArgs e)
        {
            List<Empleado> empleados = new List<Empleado>();
            EmpleadoArchivo empleadoArchivo = new EmpleadoArchivo();
            empleados = empleadoArchivo.Leer(@"../../Empleados.json");

            comboBoxEmpleados.DisplayMember = "Nombre";
            comboBoxEmpleados.ValueMember = "NoEmpleado";
            comboBoxEmpleados.DataSource = empleados;
        }


    }
}
