﻿using Microsoft.AspNetCore.Mvc;
using LearnLinq.Models;
using LearnLinq.Data;
using Microsoft.EntityFrameworkCore;
using LearnLinq.Seeders;

namespace LearnLinq.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroesController : ControllerBase
    {
        private readonly AppDbContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="HeroesController"/> class
        /// </summary>
        /// <param name="context">The database context</param>
        public HeroesController(AppDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Gets the list of all heroes
        /// </summary>
        /// <returns>A list of heroes</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hero>>> GetHeroes()
        {
            return await _context.Heroes.ToListAsync();
        }

        /// <summary>
        /// Adds a new hero to the database
        /// </summary>
        /// <param name="hero">The hero to add</param>
        /// <returns>A newly created hero</returns>
        [HttpPost]
        public async Task<ActionResult<Hero>> PostHero(Hero hero)
        {
            _context.Heroes.Add(hero);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetHeroes), new { id = hero.Id }, hero);
        }

        /// <summary>
        /// Deletes all heroes from the database
        /// </summary>
        /// <returns>No content</returns>
        [HttpDelete("all")]
        public async Task<IActionResult> DeleteAllHeroes()
        {
            var heroes = await _context.Heroes.ToListAsync();
            _context.Heroes.RemoveRange(heroes);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        /// <summary>
        /// Seeds the database with a list of hardcoded heroes
        /// </summary>
        /// <returns>The list of seeded heroes</returns>
        [HttpPost("seed-heroes")]
        public async Task<ActionResult<Hero>> SeedHeroes()
        {
            var heroes = HeroSeeder.SeedHeroes();
            _context.Heroes.AddRange(heroes);
            await _context.SaveChangesAsync();
            return Ok(heroes);
        }
    }
}
