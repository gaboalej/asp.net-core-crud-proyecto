using ProyectoCrud.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoCrud.Datos.DatosContext;
using System.ComponentModel;

namespace ProyectoCrud.Datos.Repositories
{

    
    public class ProductosRepositories : IGenericRepository<Producto>
    {
        private readonly NegocioDbContext _dbcontext;

        public ProductosRepositories(NegocioDbContext context)
        {
            _dbcontext = context;
        }


        public async Task<bool> delete( int id)
        {
            Producto modelo = _dbcontext.Productos.First(p => p.Id == id);
            _dbcontext.Productos.Remove(modelo);
            await _dbcontext.SaveChangesAsync();


            return true;
        }

        public async Task<Producto> get(int id)
        {
            return await _dbcontext.Productos.FindAsync(id);
        }

        public async Task<IQueryable<Producto>> GetAll()
        {
            IQueryable<Producto>queryProductoSQL=_dbcontext.Productos;
            return queryProductoSQL;
        }

        public async Task<bool> insert(Producto Modelo)
        {
            _dbcontext.Productos.Add(Modelo);
            await _dbcontext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> update(Producto Modelo)
        {
            _dbcontext.Productos.Update(Modelo);
            await _dbcontext.SaveChangesAsync();
            return true;
        }
    }
}
