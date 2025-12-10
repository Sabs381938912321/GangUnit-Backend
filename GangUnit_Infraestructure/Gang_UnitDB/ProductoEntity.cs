using System;
using System.Collections.Generic;
using System.Text;

namespace GangUnit_Infraestructure.Gang_UnitDB
{
    namespace GangUnitAPI.Models
    {
        public class Producto
        {
            public int ProductoID { get; set; }
            public string? Nombre { get; set; }
            public string? Slug { get; set; }
            public string? Descripcion { get; set; }
            public string? Marca { get; set; }
            public string? Genero { get; set; }
            public int? CategoriaID { get; set; }
            public decimal? Precio { get; set; }
            public decimal? Costo { get; set; }
            public int? Porcentaje_descuento { get; set; }
            public string? Estado { get; set; }
            public DateTime? Creado_en { get; set; }
            public DateTime? Actualizado_en { get; set; }
        }
    }

}
