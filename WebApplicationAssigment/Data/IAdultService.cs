using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace WebApplicationAssigment.Data
{
    public interface IAdultService
    {
        Task<IList<Adult>> GetAdultsAsync();
        Task PostAdultAsync(Adult adult);
        Task RemoveAdult(int adultId);
    }
}