using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using ASPNET.Data;
using ASPNET.Models.ViewModels;
using ASPNET.Models.Entities;


namespace ASPNET.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public StudentsController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Add(AddStudentViewModel addStudentViewModel)
        {
            var student = new Student
            {
                Name = addStudentViewModel.Name,
                Email = addStudentViewModel.Email,
                Phone = addStudentViewModel.Phone,
                Subscribed = addStudentViewModel.Subscribed,
            };

            await dbContext.Students.AddAsync(student);

            await dbContext.SaveChangesAsync();

            return View();
        }
    }
}
