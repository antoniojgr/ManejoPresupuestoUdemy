using Microsoft.AspNetCore.Mvc.Rendering;

namespace ManejoPresupuesto.Models.ViewModels
{
    public class CuentaCreacionViewModel : Cuenta
    {
        public IEnumerable<SelectListItem> TiposCuentas { get; set; }
    }
}
