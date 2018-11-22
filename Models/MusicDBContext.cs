using System;
using Microsoft.EntityFrameworkCore;

namespace MVC1.Models
{
    public class MusicDBContext : DbContext
    {
        public MusicDBContext(DbContextOptions<MusicDBContext> options)
            : base(options)
        {
        }

        public DbSet<MVC1.Models.MusicDB> Album { get; set; }
        public DbSet<MVC1.Models.MusicDB> Artist { get; set; }

    }
}
