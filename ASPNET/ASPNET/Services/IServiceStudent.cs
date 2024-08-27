using ASPNET.Models.Entities;

namespace ASPNET.Services
{
    public interface IServiceStudent
    {
        Task<IEnumerable<Student>> GetAllStudentsAsync();
        Task<Student> GetStudentByIdAsync(Guid id);
        Task<Student> CreateStudentAsync(Student student);
        Task<Student> UpdateStudentAsync(Student student);
        Task<Student> DeleteStudentAsync(Guid id);
    }
}
