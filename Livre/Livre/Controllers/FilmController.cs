using ASPNET.Services;
using Livre.Models.Entities;
using Microsoft.AspNetCore.Mvc;

public class FilmController : Controller
{
    private readonly IFilmServices _ServiceFilm;

    public FilmController(IFilmServices filmServices)
    {
        _ServiceFilm = filmServices;
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]

    public async Task<IActionResult> Add(Film film)
    {
        await _ServiceFilm.CreateFilmAsync(film);

        return RedirectToAction(nameof(List));
    }

    [HttpGet]
    public async Task<IActionResult> List()
    {
        var Film = await _ServiceFilm.GetAllFilmsAsync();

        return View(Film);
    }

    [HttpGet]

    public async Task<IActionResult> GetStudentByIdAsync(int id)
    {
        var Film = await _ServiceFilm.GetFilmByIdAsync(id);

        return View(Film);
    }

    [HttpGet]

    public async Task<IActionResult> Edit(int id)
    {
        var student = await _ServiceFilm.GetFilmByIdAsync(id);

        return View(student);
    }

    [HttpPost]

    public async Task<IActionResult> Edit(Film studentViewModel)
    {
        var student = await _ServiceFilm.UpdateFilmAsync(studentViewModel);

        return RedirectToAction("List", "Film");
    }

    [HttpPost]

    public async Task<IActionResult> Delete(int id)
    {
        var student = await _ServiceFilm.DeleteFilmAsync(id);

        return RedirectToAction("List", "Film");
    }
}
