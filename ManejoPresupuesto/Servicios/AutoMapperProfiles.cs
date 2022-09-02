using AutoMapper;
using ManejoPresupuesto.Models.ViewModels;

namespace ManejoPresupuesto.Servicios
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Cuenta, CuentaCreacionViewModel>();

            CreateMap<Transaccion, TransaccionActualizacionViewModel>().ReverseMap();

            
        }
    }
}
