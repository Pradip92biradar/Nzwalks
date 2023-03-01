using Nzwalks.API.Models.Domain;
using System.Collections.Generic;

namespace Nzwalks.API.Repositories
{
    public interface IRegionRepository
    {
        void GetAll();
        IEnumerable<Region> GetAll();
        IEnumerable<Region> GetAllAsync();
    }
}