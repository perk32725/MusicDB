using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MVC1.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MusicDBContext(
                serviceProvider.GetRequiredService<DbContextOptions<MusicDBContext>>()))
            {
                // Look for any MusicDB entries:
                if (context.Album.Any())
                {
                    return;   // DB has been seeded
                }

                context.AddRange(
                    new MusicDB
                    {
                        Album = "Emerson, Lake, & Palmer",
                        Artist = "Emerson, Lake, & Palmer"
                    },
                    new MusicDB
                    {
                        Album = "Tarkus",
                        Artist = "Emerson, Lake, & Palmer"
                    },
                    new MusicDB
                    {
                        Album = "Pictures At An Exhibition",
                        Artist = "Emerson, Lake, & Palmer"
                    },
                    new MusicDB
                    {
                        Album = "Trilogy",
                        Artist = "Emerson, Lake, & Palmer"
                    },
                    new MusicDB
                    {
                        Album = "Brain Salad Surgery",
                        Artist = "Emerson, Lake, & Palmer"
                    }

                );
                context.SaveChanges();
            }
        }
    }
}