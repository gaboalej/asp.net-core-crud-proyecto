using ProyectoCrud.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoCrud.Datos.Repositories;

namespace ProyectoCrud.Negocio.Service
{
    public class ProductoService : IProductoService
    {
        private readonly IGenericRepository<Producto> _productorepository;
        public ProductoService(IGenericRepository<Producto> productorepository)
        {

            _productorepository = productorepository;

            
        }
        public async Task<bool> delete(int id)
        {
            return await _productorepository.delete(id);
        }

        public async Task<Producto> get(int id)
        {
           return await _productorepository.get(id);
        }

        public async Task<IQueryable<Producto>> GetAll()
        {
            return await _productorepository.GetAll();
        }

        public async Task<Producto> getnombreproducto(string nombreproducto)
        {
            IQueryable<Producto>QueryProductoSQL = await _productorepository.GetAll();
            Producto producto = QueryProductoSQL.Where(p => p.NombreProducto == nombreproducto).FirstOrDefault();

            return producto;
        }

        public async Task<bool> insert(Producto Modelo)
        {
            return await _productorepository.insert(Modelo);
        }

        public async Task<bool> update(Producto Modelo)
        {
            return await _productorepository.update(Modelo);
        }
    }
}
