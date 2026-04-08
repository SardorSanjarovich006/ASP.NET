using Sheenam.Models;

namespace Sheenam.Services
{
    public interface IStudentService
    {
        Task CreateStudentAync(Student student);
        Task<List<Student>> GetAllStudentsAsync();
        Task<Student> GetStudentByIdAsync(int id);
        Task UpdateStudentAsync(Student student);
        Task DeleteStudentAsync(int id);
    }
}
