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

    public async Task<IEnumerable<Film>> GetFilms()
    {
        return await _context.Films.ToListAsync();
    }

    public async Task<Film> GetFilm(int id)
    {
        return await _context.Films.FindAsync(id);
    }

    public async Task<Film> AddFilm(Film film)
    {
        _context.Films.Add(film);
        await _context.SaveChangesAsync();
        return film;
    }

    public async Task<Film> UpdateFilm(Film film)
    {
        _context.Entry(film).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return film;
    }

    public async Task<Film> DeleteFilm(int id)
    {
        var film = await _context.Films.FindAsync(id);
        if (film == null)
        {
            return null;
        }

        _context.Films.Remove(film);
        await _context.SaveChangesAsync();
        return film;
    }
}