using Cleiteam.Domain.Entities;
using System.Linq.Expressions;

namespace Cleiteam.Domain.Interfaces.Repository
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task Incluir(T entity);
        Task Alterar(T entity);
        Task<T> SelecionarPorId(Guid id);
        Task<List<T>> SelecionarTudo();
        Task<T> Buscar(Expression<Func<T, bool>> predicate);
        Task<List<T>> BuscarVarios(Expression<Func<T, bool>> predicate);
        Task Remover(T entity);
    }
}