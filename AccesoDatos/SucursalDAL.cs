using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public static class SucursalDAL
    {
        public static Sucursal[] sucursales = new Sucursal[5];
        public static int contador = 0;
        public static void Agregar(Sucursal sucursal)
        {
            if(contador > sucursales.Length)
            {
                throw new Exception("No se pueden agregar mas sucursales");
            }
            sucursales[contador] = sucursal;
            contador++;
        }
        public static Sucursal[] ObtenerSucursales()
        {
            return sucursales;
        }
    }
}
