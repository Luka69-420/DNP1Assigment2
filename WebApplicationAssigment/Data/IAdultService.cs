﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace WebApplicationAssigment.Data
{
    public interface IAdultService
    {
        Task<IList<Adult>> GetAdultsAsync();
        Task PostAdultAsync();
        void RemoveAdult(int adultId);
    }
}