using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Aktiviteters.Any()) return;
            
            var activities = new List<Aktiviteter>
            {
                new Aktiviteter
                {
                    Titel = "Første aktivitet",
                    Dato = DateTime.Now.AddMonths(-2),
                    Beskrivelse = "Denne aktivitet er to måneder gammel",
                    Kategori = "bajer",
                    By = "Aalborg",
                    Mødested = "West End",
                },
                new Aktiviteter
                {
                    Titel = "Past Activity 2",
                    Dato = DateTime.Now.AddMonths(-1),
                    Beskrivelse = "Activity 1 month ago",
                    Kategori = "culture",
                    By = "Paris",
                    Mødested = "Louvre",
                },
                new Aktiviteter
                {
                    Titel = "Future Activity 1",
                    Dato = DateTime.Now.AddMonths(1),
                    Beskrivelse = "Activity 1 month in future",
                    Kategori = "culture",
                    By = "London",
                    Mødested = "Natural History Museum",
                }
               
            };

            await context.Aktiviteters.AddRangeAsync(activities);
            await context.SaveChangesAsync();
        }
    }
}