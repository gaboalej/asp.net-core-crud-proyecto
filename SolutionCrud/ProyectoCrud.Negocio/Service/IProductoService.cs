using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoCrud.Modelos;

namespace ProyectoCrud.Negocio.Service
{
    public interface IProductoService
    {

        Task<bool> insert(Producto Modelo);
        Task<bool> update(Producto Modelo);
        Task<bool> delete(int id);
        Task<Producto> get(int id);
        Task<IQueryable<Producto>> GetAll();
        Task<Producto> getnombreproducto(string nombreproducto);

    }
}
