using Microsoft.EntityFrameworkCore;
using Nzwalks.API.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nzwalks.API.Data
{
    public class NzwalksDBContest : DbContext
    {
        public NzwalksDBContest(DbContextOptions<NzwalksDBContest> options) : base(options)
        {

        }

        public DbSet<Region> Regions { get; set; }
        public DbSet<Walks> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }
        protected override void OnModelCreating(ModelBuilder ModelBuilder)
        {
        }

    }
}
        
 

