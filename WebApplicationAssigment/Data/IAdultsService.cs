using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace WebApplication.Data
{
    public interface IAdultsService
    {
        Task<IList<Adult>> GetAdultsAsync();
        Task<Adult> AddAdultsAsync(Adult adult);
        Task<Adult> DeleteAdultAsync(int id);
    }
}