using Livre.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Livre.Data
{
    public class FilmContext : IdentityDbContext
    {
        public FilmContext(DbContextOptions<FilmContext> options) : base(options)
        {

        }
        public DbSet<Film> Films { get; set; }
    }
}
