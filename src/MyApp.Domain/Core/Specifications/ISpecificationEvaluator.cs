using System.Linq;
using MyApp.Domain.Core.Models;

namespace MyApp.Domain.Core.Specifications
{
    public interface ISpecificationEvaluator<T> where T : BaseEntity
    {
        IQueryable<T> GetQuery(IQueryable<T> inputQuery, ISpecification<T> specification);
    }
}
