using Sheenam.Models;
using Sheenam.Repositories;
using Dapper;

namespace Sheenam.Services
{
    public class StudentService:IStudentService
    {
        private readonly IStudentRepository studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
           this.studentRepository = studentRepository;
        }
        public async Task CreateStudentAync(Student student)
        { 
           if (student == null)
            {
                throw new ArgumentNullException(nameof(student));   
            }
           
           await studentRepository.CreateStudentAsync(student);
        }
        public Task<List<Student>> GetAllStudentsAsync()
        { }
        public Task<Student> GetStudentByIdAsync(int id)
        {

        }
        public Task UpdateStudentAsync(Student student)
        {

        }
        public Task DeleteStudentAsync(int id)
        {

        }

    }
}
