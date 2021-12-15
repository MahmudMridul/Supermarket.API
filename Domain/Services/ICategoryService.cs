using System.Collections.Generic;
using Supermarket.API.Domain.Models;
using System.Threading.Tasks;

namespace Supermarket.API.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}