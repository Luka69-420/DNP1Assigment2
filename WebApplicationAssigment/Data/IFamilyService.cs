using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace WebApplicationAssigment.Data
{
    public interface IFamilyService
    {
        Task<IList<Family>> GetFamilies();
        Family AddFamily(Family family);
        Task RemoveFamily(int HouseNo);
    }
}