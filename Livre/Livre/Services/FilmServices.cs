using ASPNET.Services;
using Livre.Data;
using Livre.Models.Entities;
using Microsoft.EntityFrameworkCore;

public class FilmServices : IFilmServices
{
    private readonly FilmContext _context;

    public FilmServices(FilmContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Film>> GetAllFilmsAsync()
    {
        return await _context.Films.ToListAsync();
    }

    public async Task<Film> GetFilmByIdAsync(int id)
    {
        return await _context.Films.FindAsync(id);
    }

    public async Task<Film> CreateFilmAsync(Film Film)
    {
        await _context.Films.AddAsync(Film);
        await _context.SaveChangesAsync();
        return Film;
    }

    public async Task<Film> UpdateFilmAsync(Film Film)
    {
        _context.Films.Update(Film);
        await _context.SaveChangesAsync();
        return Film;
    }

    public async Task<Film> DeleteFilmAsync(int id)
    {
        var Film = await _context.Films.FindAsync(id);
        _context.Films.Remove(Film);
        await _context.SaveChangesAsync();
        return Film;
    }
}