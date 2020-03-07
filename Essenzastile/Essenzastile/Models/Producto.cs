using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Essenzastile.Models
{
    public class Producto
    {
        long CodigoProducto { get; set; }
        string DescripcionProducto { get; set; }
        string DescripcionLarga { get; set; }
        decimal PrecioCompra { get; set; }
        decimal PrecioVenta { get; set; }
        string EstadoProducto { get; set; }
        int Categoria { get; set; }
        int SubCategoria { get; set; }
        int Marca { get; set; }
        DateTime FechaCreacion { get; set; }
        string rutaImagen { get; set; }
    }
}