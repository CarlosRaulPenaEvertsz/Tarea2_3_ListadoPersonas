using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tarea2_3_ListadoPersonas.Models
{
    public class Persona
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Ocupacion { get; set; }
        public string Sexo { get; set; }
        public int Edad { get; set; }
    }
}