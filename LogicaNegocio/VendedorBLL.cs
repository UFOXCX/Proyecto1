using AccesoDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class VendedorBLL
    {  
        public void AgregarVendedor(Vendedor vendedor)
        {
            VendedorDAL.Agregar(vendedor);
        }
    }
}
