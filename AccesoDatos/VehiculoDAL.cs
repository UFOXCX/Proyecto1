using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace AccesoDatos
{
    public static class VehiculoDAL
    {
        public static Vehiculo[] vehiculos = new Vehiculo[50];
        public static int contador = 0;

        public static void Agregar(Vehiculo vehiculo)
        {
            if(contador > vehiculos.Length)
            {
                throw new Exception("No se pueden agregar mas vehiculos");
            }
            vehiculos[contador] = vehiculo;
            contador++;
        }
        public static Vehiculo[] ObtenerVehiculos()
        {
            return vehiculos;
        }
    }
}
