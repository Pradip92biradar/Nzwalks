using AutoMapper;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nzwalks.API.Profiles
{
    public class RegionsProfile:Profile
    {
       public RegionsProfile()
        {
            CreateMap<Models.Domain.Region, Models.DTO.Region1>()
                //.ForMember(dest=>dest.Id,Options =>Options.MapFrom(Src=>Src.Id));
            .ReverseMap();
        }
    }
}
