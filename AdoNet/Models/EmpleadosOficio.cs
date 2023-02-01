using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet.Models
{
    public class EmpleadosOficio
    {
        public int IdEmpleado { get; set; }
        public string Apellido { get; set; }
        public int Salario { get; set; }
        public string Oficio { get; set; }
    }
}
