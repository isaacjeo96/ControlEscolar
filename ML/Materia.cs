using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Materia
    {
        public int IdMateria { get; set; }
        [Required(ErrorMessage = "Ingrese el Nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Ingrese el Costo")]
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        public decimal Costo { get; set; }
        public List<object> Materias { get; set; }
    }
}
