using ManejoPresupuesto.Models.ViewModels;

namespace ManejoPresupuesto.Servicios.Interfaces
{
    public interface IRepositorioUsuarios
    {
        Task<Usuario> BuscarUsuarioPorEmail(string emailNormalizado);
        Task<int> CrearUsuario(Usuario usuario);
    }
}
