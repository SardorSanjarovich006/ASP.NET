using Sheenam.Models;

namespace Sheenam.Repositories
{
    public interface IStudentRepository
    {
        Task CreateStudentAync(Student student);
        Task<List<Student>> GetAllStudentsAsync();
        Task<Student> GetStudentByIdAsync(int id);  
        Task UpdateStudentAsync(Student student);   
        Task DeleteStudentAsync(int id);   
    }
}
