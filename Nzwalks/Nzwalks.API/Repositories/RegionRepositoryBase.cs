using Nzwalks.API.Models.Domain;
using System.Collections.Generic;

namespace Nzwalks.API.Repositories
{
    public abstract class RegionRepositoryBase
    {
        private readonly NzwalksDBContest nzwalksDbContext;
        private readonly NzwalksDBContest nzwalksDbContext;

        public abstract IEnumerable<Region> GetAll();
        public abstract IEnumerable<Region> GetAll();
    }
}