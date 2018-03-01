using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class UsuarioDataProvider : GenericDataProvider
    {
        public static Usuario getById(int id)
        {
            Usuario usuario = new Usuario();

            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter("id_usuario", id);

            DataTable usuarioResult = executeQueryProc(ConfiguracionDataProvider.obtenerCadenaConexion(), "usuariosGetById", parametros);

            usuario = Mapear(usuarioResult.Rows[0]);

            return usuario;
        }

        private static Usuario Mapear(DataRow lector)
        {
            Usuario usuario = new Usuario();

            usuario.id_usuario = lector["id_usuario"] != null ? Convert.ToInt32(lector["id_usuario"].ToString()) : 0;
            usuario.login_name = lector["login_name"] != null ? lector["login_name"].ToString() : "";
            usuario.password = lector["password"] != null ? lector["password"].ToString() : "";
            usuario.token_clave = lector["token_clave"] != null ? lector["token_clave"].ToString() : "";
            usuario.fecha_alta = lector["fecha_alta"] != null ? Convert.ToDateTime(lector["fecha_alta"].ToString()) : new DateTime();
            usuario.email = lector["email"] != null ? lector["email"].ToString() : "";
            usuario.habilitado = lector["habilitado"] != null ? Convert.ToBoolean(lector["habilitado"].ToString()) : false;

            return usuario;
            
        }
    }
}
