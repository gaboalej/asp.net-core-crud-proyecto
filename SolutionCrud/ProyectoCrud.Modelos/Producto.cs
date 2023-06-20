using System;
using System.Collections.Generic;

namespace ProyectoCrud.Modelos
{

    public partial class Producto
    {
        public int Id { get; set; }

        public string NombreProducto { get; set; } = null!;

        public string Descripcion { get; set; } = null!;

        public string Marca { get; set; } = null!;

        public decimal? Precio { get; set; }

        public int? Stock { get; set; }

        public bool? Activo { get; set; }
    }
}