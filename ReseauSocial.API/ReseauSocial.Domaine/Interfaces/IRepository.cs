using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ReseauSocial.Domaine.Interfaces
{
   public interface IRepository<T> : IDisposable where T : class
    {
        Task CreateAsync(T entity);
        Task DeleteAsync(Guid id);
        Task DeleteAsync(T entity);
        Task UpdateAsync(T entity);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetAsync(Guid id);
        Task<T> Authentification(string mail, string password);
    }
}
