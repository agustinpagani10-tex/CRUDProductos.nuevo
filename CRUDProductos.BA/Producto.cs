using System;
using System.Collections.Generic;
using System.Text;

namespace CRUDProductos.BA
{
    public class Producto
    {
        public string Codigo { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }

        public string Renglon()
        {
            return $"Código: {Codigo} - Nombre: {Nombre} - Precio: {Precio} - Cantidad: {Cantidad}";
        }
    }
}
