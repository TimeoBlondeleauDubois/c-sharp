using ASPNET.Data;
using ASPNET.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ASPNET.Services
{
    public class ServiceStudent : IServiceStudent
    {
        private readonly ApplicationDbContext _context;

        public ServiceStudent(ApplicationDbContext context)
        {
             _context = context;
        }

        public async Task<IEnumerable<Student>> GetAllStudentsAsync()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task<Student> GetStudentByIdAsync(Guid id)
        {
            return await _context.Students.FindAsync(id);
        }

        public async Task<Student> CreateStudentAsync(Student student)
        {
            await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();
            return student;
        }

        public async Task<Student> UpdateStudentAsync(Student student)
        {
            _context.Students.Update(student);
            await _context.SaveChangesAsync();
            return student;
        }

        public async Task<Student> DeleteStudentAsync(Guid id)
        {
            var student = await _context.Students.FindAsync(id);
            _context.Students.Remove(student);
            await _context.SaveChangesAsync();
            return student;
        }
    }
}
