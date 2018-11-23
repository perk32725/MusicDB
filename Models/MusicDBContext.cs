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

        public DbSet<MusicDB> Album { get; set; }
        public DbSet<MusicDB> Artist { get; set; }
    }
}
