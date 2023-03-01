using Microsoft.EntityFrameworkCore;
using Nzwalks.API.Data;
using Nzwalks.API.Models.Domain;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nzwalks.API.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private static NzwalksDBContest nzwalksDBContext;

        public RegionRepository(NzwalksDBContest nzwalksDBContext)
        {
            RegionRepository.nzwalksDBContext = nzwalksDBContext;
        }
        public async Task<IEnumerable<Region>> GetAllAsync()

        {
           return await nzwalksDBContext.Regions.ToListAsync();

        }
    }
}
