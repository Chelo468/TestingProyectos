using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ConfiguracionDataProvider
    {
        public static string obtenerCadenaConexion()
        {
            return @"Data Source=.\sqlexpress;Initial Catalog=testingProyectos;Integrated Security=True";
        }
    }
}
