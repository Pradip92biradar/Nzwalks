using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nzwalks.API.Models.Domain
{
    public class Walks
    {
        public Guid Id { get; set; }
       public Guid RegionId { get; set; }
       public Guid DifficultyId { get; set; }
        public string Name { get; set; }
        public double length { get; set; }

        //Navigation Properties
        public Region Region { get; set; }
        public WalkDifficulty WalkDifficulty { get; set; }
    }
}
