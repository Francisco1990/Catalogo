using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.Entities.Dto.ProductosDto
{
    public class ProductoCambiaEstadoDto
    {
        public long Id { get; set; }

        public bool Activo { get; set; }
    }
}
