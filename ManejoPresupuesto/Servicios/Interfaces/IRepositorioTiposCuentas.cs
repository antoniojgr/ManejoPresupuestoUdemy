﻿using ManejoPresupuesto.Models.ViewModels;

namespace ManejoPresupuesto.Servicios.Interfaces
{
    public interface IRepositorioTiposCuentas
    {
        Task Actualizar(TipoCuenta tipoCuenta);
        Task Borrar(int id);
        Task Crear(TipoCuenta tipoCuenta);

        Task<bool> Existe(string nombre, int usuarioId, int id = 0);

        Task<IEnumerable<TipoCuenta>> Obtener(int usuarioId);

        Task<TipoCuenta> ObtenerPorId(int id, int usuarioId);
        Task Ordenar(IEnumerable<TipoCuenta> tipoCuentasOrdenados);
    }
}
