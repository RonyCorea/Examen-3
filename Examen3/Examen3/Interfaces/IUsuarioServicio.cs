using Modelos;

namespace Examen3.Interfaces
{
    public interface IUsuarioServicio
    {
        Task<Usuario> GetPorCodigo(string codigo);
    }
}
