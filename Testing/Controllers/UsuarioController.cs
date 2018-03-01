using Entidades.Entidades;
using Newtonsoft.Json;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Testing.Controllers
{
    public class UsuarioController : ApiController
    {
        // GET api/usuario
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/usuario/5
        [AllowAnonymous]
        public string Get(int id)
        {
            UsuarioService serviceUsuario = new UsuarioService();
            Usuario user = serviceUsuario.getById(id);

            string output = JsonConvert.SerializeObject(user);

            return output;
        }

        // POST api/usuario
        public void Post([FromBody]string value)
        {
        }

        // PUT api/usuario/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/usuario/5
        public void Delete(int id)
        {
        }
    }
}
