using Livre.Models.Entities;

public  interface IFilmServices
{
    Task<IEnumerable<Film>> GetFilms();
    Task<Film> GetFilm(int id);
    Task<Film> AddFilm(Film film);
    Task<Film> UpdateFilm(Film film);
    Task<Film> DeleteFilm(int id);
}   