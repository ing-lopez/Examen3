//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Examen3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Nominas
    {
        public int id_nomina { get; set; }
        public int id_empleado { get; set; }
        public string fecha { get; set; }
        public double Sueldo_por_dia { get; set; }
        public int Dias_laborales { get; set; }
        public double Sueldo_quincenal { get; set; }
    
        public virtual Empleados Empleados { get; set; }
    }
}
