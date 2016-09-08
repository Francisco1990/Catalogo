using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalogo.Entities.Dto;
using Catalogo.Entities;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Catalogo.Data.Interface;
using Catalogo.Entities.Dto.CategoriasDto;

namespace Catalogo.Data.Cetegoria
{
    public class CategoriaData : ICategoriaData
    {
        private Catalogo_Model _Context;

        public CategoriaData()
        {
            _Context = new Catalogo_Model();
        }

        public CategoriaListDto Crear(CategoriaListDto entidadDto)
        {
            throw new NotImplementedException();
        }

        public bool Editar(CategoriaListDto parametroDto)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(CategoriaListDto parametroDto)
        {
            throw new NotImplementedException();
        }

        public List<CategoriaListDto> Obtener()
        {
            throw new NotImplementedException();
        }

        public CategoriaListDto Obtener(int id)
        {
            throw new NotImplementedException();
        }


        //public async Task<List<CategoriaDto>> ListCategoria()
        //{
        //    return await _Context.Categoria.ProjectTo<CategoriaDto>
        //}   


    }
}
