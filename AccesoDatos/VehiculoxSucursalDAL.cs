using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace AccesoDatos
{
    public static class VehiculoxSucursalDAL
    {
        public static VehiculoxSucursal[] vehiculoxsucursales = new VehiculoxSucursal[100];
        public static int contador = 0;
    
        public static void Agregar(VehiculoxSucursal vehiculoxsucursal)
            {
              if(contador > vehiculoxsucursales.Length)
                {
                  throw new Exception("No se pueden agregar mas vehiculoxsucursal");
                }
                vehiculoxsucursales[contador] = vehiculoxsucursal;
                contador++;
        }
        public static VehiculoxSucursal[] ObtenerVehiculoxSucursal()
        {
            return vehiculoxsucursales;
        }
    }
}
