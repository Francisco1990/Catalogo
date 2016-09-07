using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.Entities.Dto.CategoriasDto
{
    public class CategoriaListDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Descripcion { get; set; }
    }
}
