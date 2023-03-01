using Nzwalks.API.Data;
using Nzwalks.API.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Nzwalks.API.Repositories
{
    public interface IRegionRepository
    {
        Task<IEnumerable<Region>> GetAllAsync();
    }




    //public class regionRepository: IRegionRepository
    //{
    //    private object nzwalksDBContext;

    //    public regionRepository(NzwalksDBContest nzwalksDBContext)
    //    {
    //        RegionRepository.nzwalksDBContext = nzwalksDBContext;
    //    }
    //   public override IEnumerable<Region> GetAll()

    //    {
    //        nzwalksDBContext.Regions.ToList();

    //    }

    //    void IRegionRepository.GetAll()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
