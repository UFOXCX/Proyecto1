using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaEntidades
{
    public class Vehiculo
    {
        #region Propiedades
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int anno { get; set; }   

        public decimal Precio { get; set; }
        public CategoriaVehiculo Categoria { get; set; }
        public char Estado { get; set; }
    }
    #endregion

}
