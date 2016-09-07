using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.Entities.Dto.CategoriasDto
{
    public class CategoriaUpdateDto
    {
        public long Id { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
    }
}
