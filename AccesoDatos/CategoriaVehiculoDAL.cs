using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AccesoDatos
{
    public static class CategoriaVehiculoDAL
    {
        public static CategoriaVehiculo[] categorias = new CategoriaVehiculo[20];
        public static int contador = 0;

        public static void Agregar(CategoriaVehiculo categoria)
        {
            if(contador > categorias.Length)
            {
                throw new Exception("No se pueden agregar mas categorias");
            }
            categorias[contador] = categoria;
            contador++;
        }
        public static CategoriaVehiculo[] ObtenerCategorias()
        {
            return categorias;
        }
    }
}
