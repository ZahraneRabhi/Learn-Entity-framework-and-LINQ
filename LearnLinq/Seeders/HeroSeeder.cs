using LearnLinq.Models;
using System.Collections.Generic;

namespace LearnLinq.Seeders
{
    /// <summary>
    /// Provides a way to seed the database with hardcoded heroes
    /// </summary>
    public static class HeroSeeder
    {
        /// <summary>
        /// Seeds the database with a list of hardcoded heroes
        /// </summary>
        /// <returns>A list of heroes</returns>
        public static List<Hero> SeedHeroes()
        {
            return new List<Hero>
            {
                new Hero { Name = "Homelander", Description = "Leader of The Seven", Threat = "High" },
                new Hero { Name = "Soldier Boy", Description = "Hates Commies", Threat = "High" },
                new Hero { Name = "Queen Maeve", Description = "Warrior with superhuman strength and durability", Threat = "High" },
                new Hero { Name = "A-Train", Description = "Speedster, good redemption arc", Threat = "Medium" },
                new Hero { Name = "The Deep(The Peak)", Description = "A schizo Aquaman, dumb but funny as hell", Threat = "Low" },
                new Hero { Name = "Black Noir 2", Description = "Funny as hell ngl", Threat = "High" },
                new Hero { Name = "Stormfront", Description = "a7la stormfront", Threat = "High" }
            };
        }
    }
}
