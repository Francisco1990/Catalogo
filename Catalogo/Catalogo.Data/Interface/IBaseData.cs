using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalogo.Data.Cetegoria;

namespace Catalogo.Data
{
    public interface IBaseData<T>  //class generic
    {
        /*
            obtener todos
            obtener uno por id
            crear
            editar
            eliminar
         */

        List<T> Obtener();

        T Obtener(int id);

        T Crear(T entidadDto);

        bool Editar(T parametroDto);

        bool Eliminar(T parametroDto);

    }
}
