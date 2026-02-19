using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public static class VendedorDAL
    {
        public static Vendedor[] vendedores = new Vendedor[20];
        public static int contador = 0;    
        public static void Agregar(Vendedor vendedor)
        {
            if(contador > vendedores.Length)
            {
                throw new Exception("No se pueden agregar mas vendedores");
            }
            vendedores[contador] = vendedor;
            contador++;
        }
        public static Vendedor[] ObtenerVendedor()
        {
            return vendedores;
        }
    }
}
