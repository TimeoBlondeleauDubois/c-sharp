using Microsoft.AspNetCore.Mvc;
using ASPNET.Models.Entities;
using ASPNET.Services;


namespace ASPNET.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IServiceStudent _ServiceStudent;

        public StudentsController(IServiceStudent ServiceStudent)
        {
            _ServiceStudent = ServiceStudent;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Add(Student student)
        {
            await _ServiceStudent.CreateStudentAsync(student);

            return RedirectToAction(nameof (List));
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var students = await _ServiceStudent.GetAllStudentsAsync();

            return View(students);
        }

        [HttpGet]

        public async Task<IActionResult> GetStudentByIdAsync(Guid id)
        {
            var students = await _ServiceStudent.GetStudentByIdAsync(id);

            return View();
		}

        [HttpGet]

        public async Task<IActionResult> Edit(Guid id)
        {
            var student = await _ServiceStudent.GetStudentByIdAsync(id);

            return View(student);
        }

        [HttpPost]

        public async Task<IActionResult> Edit(Student studentViewModel)
        {
            var student = await _ServiceStudent.UpdateStudentAsync(studentViewModel);

            return RedirectToAction("List", "Students");
        }

        [HttpPost]

		public async Task<IActionResult> Delete(Guid id)
		{
            var student = await _ServiceStudent.DeleteStudentAsync(id);

            return RedirectToAction("List", "Students");
		}
	}
}
