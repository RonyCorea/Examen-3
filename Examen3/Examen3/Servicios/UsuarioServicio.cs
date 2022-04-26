using Datos.Interfaces;
using Datos.Repositorios;
using Examen3.Data;
using Examen3.Interfaces;
using Modelos;

namespace Examen3.Servicios
{
    public class UsuarioServicio : IUsuarioServicio
    {

        private readonly MySQLConfiguration _configuration;
        private IUsuarioRepositorio usuarioRepositorio;

        public UsuarioServicio(MySQLConfiguration configuration)
        {
            _configuration = configuration;
            usuarioRepositorio = new UsuarioRepositorio(configuration.CadenaConexion);
        }
        public Task<Usuario> GetPorCodigo(string codigo)
        {
            throw new NotImplementedException();
        }
    }
}
