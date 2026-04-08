using Sheenam.Data;
using Sheenam.Models;
using System.Data;
using Dapper;

namespace Sheenam.Repositories
{
    public class StudentReository : IStudentRepository
    {
        private readonly ApplicationDbContext _dbContext;
        private IDbConnection _dbConnection;
        public StudentReository(ApplicationDbContext applicationDbContext)
        {
           _dbContext = applicationDbContext;
            this._dbConnection = _dbContext.GetDbConnection();
        }

       public Task CreateStudentAync(Student student)
        {
           string sql= "INSERT INTO Students (FirstName, LastName, Age) VALUES (@FirstName, @LastName, @Age)";
            var parameters = new { student.FirsName, student.LastName, student.Age };
            return _dbConnection.ExecuteAsync(sql, parameters);
        }
       public Task<List<Student>> GetAllStudentsAsync()
        {}
        public Task<Student> GetStudentByIdAsync(int id)
        {

        }
        public Task UpdateStudentAsync(Student student)
        {

        }
        public  Task DeleteStudentAsync(int id)
        {

        }
    }
}
