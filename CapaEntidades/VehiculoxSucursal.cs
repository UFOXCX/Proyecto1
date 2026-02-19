using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class VehiculoxSucursal
    {
        #region
        public Sucursal Sucursal { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public int Cantidad { get; set; }
        #endregion
    }
}
