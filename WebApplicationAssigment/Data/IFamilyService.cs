using System.Collections.Generic;
using Models;

namespace WebApplicationAssigment.Data
{
    public interface IFamilyService
    {
        IList<Family> GetFamilies();
        Family AddFamily(Family family);
        void RemoveFamily(int HouseNo);
    }
}