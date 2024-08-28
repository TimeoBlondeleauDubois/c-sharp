using Livre.Models.Entities;

namespace ASPNET.Services
{
    public interface IFilmServices
    {
        Task<IEnumerable<Film>> GetAllFilmsAsync();
        Task<Film> GetFilmByIdAsync(int id);
        Task<Film> CreateFilmAsync(Film Film);
        Task<Film> UpdateFilmAsync(Film Film);
        Task<Film> DeleteFilmAsync(int id);
    }
}