using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nzwalks.API.Models.DTO
{
    public class Region1
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public double Area { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }
        public long Population { get; set; }
    }
}
