using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace AccesoDatos
{
    public static class ClienteDAL
    {
        public static Cliente[] clientes = new Cliente[5];
        public static int contador = 0;
    
        public static void Agregar(Cliente cliente)
            {
                if(contador > clientes.Length)
            {
                throw new Exception("No se pueden agregar mas clientes");
            }
            clientes[contador] = cliente;
            contador++;
        }
        public static Cliente[] ObtenerClientes()
        {
            return clientes;
        }
    }
}
