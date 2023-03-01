using AutoMapper;
using DocumentFormat.OpenXml.Office.CustomUI;
using DocumentFormat.OpenXml.Office2010.Excel;
using Microsoft.AspNetCore.Mvc;
using Nzwalks.API.Models.Domain;
using Nzwalks.API.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nzwalks.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegionsController : Controller
    {
        private readonly IRegionRepository regionRepository;
        private readonly IMapper mapper;
        private static readonly object regions;

        public RegionsController(IRegionRepository regionRepository,IMapper mapper)
        {
            this.regionRepository = regionRepository;
           this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllRegions()
        {
            var regions = await regionRepository.GetAllAsync();

            ////return DTO Regions
            //var regionsDTO = new List<Models.DTO.Region1>();

            //regions.ToList().ForEach(region =>
            //{
            //    var regionDTO = new Models.DTO.Region1()
            //    {
            //        Id = region.Id,
            //        Code = region.code,
            //        Name = region.Name,
            //        Area = region.Area,
            //        Lat = region.Lat,
            //        Long= region.Long,
            //        Population = region.Population,

            //    };
            //    regionsDTO.Add(regionDTO);

            //});
            
                //new Region
                //{
                //    Id = Guid.NewGuid(),
                //    Name = "Wellington",
                //    Code = "WLG",
                //    Area = 2255777,
                //    Lat = -1.8822,
                //    Long = 299.980,
                //    Population = 999999,
                //};
                //new Region
                //{
                //    Id = Guid.NewGuid(),
                //    Name = "Scotland",
                //    Code = "Sct",
                //    Area = 2255777,
                //    Lat = -1.880,
                //    Long = 200.980,
                //    Population = 888089,
                //};

            }
           var regionsDTO =  mapper.Map<List<Models.DTO.Region1>>(regions);
            return Ok(regionsDTO);
            

        }
    }
}