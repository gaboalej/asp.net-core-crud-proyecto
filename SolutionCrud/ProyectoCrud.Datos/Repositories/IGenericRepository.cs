using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCrud.Datos.Repositories
{
    public interface IGenericRepository<TEntityModel> where TEntityModel : class
    {

        Task<bool>insert (TEntityModel Modelo);
        Task<bool>update (TEntityModel Modelo);
        Task<bool>delete (int id);
        Task<TEntityModel> get (int id);
        Task<IQueryable<TEntityModel>> GetAll ();



    }
}
