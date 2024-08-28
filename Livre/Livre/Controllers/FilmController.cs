using Livre.Models.Entities;
using Microsoft.AspNetCore.Mvc;

public class FilmController : Controller
{
    private readonly IFilmServices _filmServices;

    public FilmController(IFilmServices filmServices)
    {
        _filmServices = filmServices;
    }

    [HttpGet]

    public async Task<IActionResult> Index()
    {
        var films = await _filmServices.GetFilms();
        return View(films);
    }

    [HttpGet]

    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]

    public async Task<IActionResult> Add(Film film)
    {
        if (ModelState.IsValid)
        {
            await _filmServices.AddFilm(film);
            return RedirectToAction("Index");
        }
        return View(film);
    }

    [HttpGet]

    public async Task<IActionResult> Edit(int id)
    {
        var film = await _filmServices.GetFilm(id);
        if (film == null)
        {
            return NotFound();
        }
        return View(film);
    }

    [HttpPost]

    public async Task<IActionResult> Edit(Film film)
    {
        if (ModelState.IsValid)
        {
            await _filmServices.UpdateFilm(film);
            return RedirectToAction("Index");
        }
        return View(film);
    }

    [HttpGet]

    public async Task<IActionResult> Delete(int id)
    {
        var film = await _filmServices.GetFilm(id);
        if (film == null)
        {
            return NotFound();
        }
        return View(film);
    }

    [HttpPost]

    public async Task<IActionResult> Delete(Film film)
    {
        await _filmServices.DeleteFilm(film.Id);
        return RedirectToAction("Index");
    }
}