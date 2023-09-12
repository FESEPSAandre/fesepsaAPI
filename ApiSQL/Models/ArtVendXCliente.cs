using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiSQL.Models
{
    public class ArtVendXCliente
    {
        public String CodigoArticulo { get; set; }
        public String DescripcionArticulo { get; set; }
        public String NombreMarca { get; set; }
        public String PrecioLista { get; set; }
    }
}