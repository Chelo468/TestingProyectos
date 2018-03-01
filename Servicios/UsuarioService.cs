using Datos;
using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class UsuarioService
    {
        public Usuario getById(int idUsuario)
        {
            Usuario usuario = UsuarioDataProvider.getById(idUsuario);

            return usuario;
        }
    }
}
