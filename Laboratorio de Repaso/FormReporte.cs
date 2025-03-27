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
    public partial class FormReporte : Form
    {
        List<Empleado> empleados = new List<Empleado>();
        List<Asistencia> asistencias = new List<Asistencia>();
        List<ReporteSueldo> reporteSueldos = new List<ReporteSueldo>();
        public FormReporte()
        {
            InitializeComponent();
        }
        private void CargarEmpleados()
        {
            EmpleadoArchivo empleadoArchivo = new EmpleadoArchivo();
            empleados = empleadoArchivo.Leer("../../Empleados.json");

            dataGridView1.DataSource = null;        
            dataGridView1.Refresh();
        }

        private void CargarAsistencia()
        {
            AsistenciaArchivo asistenciaArchivo = new AsistenciaArchivo();
            asistencias = asistenciaArchivo.Leer("../../Asistencias.json");

        }
        private void btnMostrarReporte_Click(object sender, EventArgs e)
        {
            //Recorrer cada empleado
            foreach(var empleado in empleados)
            {
                //si el No de empleado
                foreach(var asistencia in asistencias)
                {
                    if (empleado.NoEmpleado == asistencia.NoEmpleado)
                    {
                        ReporteSueldo reporte = new ReporteSueldo();
                        reporte.Nombre = empleado.Nombre;
                        reporte.Mes = asistencia.mes.ToString();
                        reporte.SueldoTotal = empleado.SueldoHora * asistencia.horasMes;

                        reporteSueldos.Add(reporte);


                    }
                }
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = reporteSueldos;
            dataGridView1.Refresh();
        }

        private void FormReporte_Load(object sender, EventArgs e)
        {
            CargarAsistencia();
            CargarEmpleados();
        }
    }
}
