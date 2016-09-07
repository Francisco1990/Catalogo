using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalogo.Entities.Dto;
using Catalogo.Entities;
using AutoMapper;
using AutoMapper.QueryableExtensions;


namespace Catalogo.Data.Cetegoria
{
    public class CategoriaData
    {
        private Catalogo_Model _Context;

        public CategoriaData()
        {
            _Context = new Catalogo_Model();
        }
             
    
        //public async Task<List<CategoriaDto>> ListCategoria()
        //{
        //    return await _Context.Categoria.ProjectTo<CategoriaDto>
        //}   
    }
}
