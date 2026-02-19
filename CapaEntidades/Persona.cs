using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Persona
    {
        #region Propiedades
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public string Identificacion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        #endregion
    }
}
