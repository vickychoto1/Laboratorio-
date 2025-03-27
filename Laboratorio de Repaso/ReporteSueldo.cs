using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_de_Repaso
{
    internal class ReporteSueldo
    {
        //se obtiene desde la clase Empleado
        public string Nombre {  get; set; }
        
        //Hay que convertir Mes de Asistencia en su nombre
        public string Mes {  get; set; }

        public decimal SueldoTotal { get; set; }
    }
}
