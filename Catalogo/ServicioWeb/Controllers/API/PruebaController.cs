using ServicioWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServicioWeb.Controllers.API
{
    public class PruebaController : ApiController
    {
        // GET: api/Prueba
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Prueba/5
        public string Get(int id)
        {
            return id.ToString();
        }
        //Creacion de registros
        // POST: api/Prueba
        public IHttpActionResult Post(Dato dato)
        {
            if (dato.Id == 1)
            {
                return Ok();
            }
            else { return BadRequest(); }
        }

        // PUT: api/Prueba/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Prueba/5
        public void Delete(int id)
        {
        }
    }
}
