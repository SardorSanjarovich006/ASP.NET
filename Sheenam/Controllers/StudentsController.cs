using Microsoft.AspNetCore.Mvc;
using Sheenam.Models;
using Sheenam.Data;

namespace Sheenam.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentsController:ControllerBase
    {
        private ApplicationDbContext _dbcontext;
        public StudentsController(ApplicationDbContext context)
        {
            _dbcontext = context;
        }

        private static List<Student> students =
            [
            new Student{Id=1,FirsName="Sardor",LastName="Jonimqulov",Age=19},
            new Student{Id=2,FirsName="Eldor",LastName="Ro'ziyev",Age =19},
            new Student{Id=1,FirsName="Ilyos",LastName="To'dayev",Age=20},
            new Student{Id=2,FirsName="Ahror",LastName="Ziyodullayev",Age =17}
            ];


        [HttpGet]
        public List<Student> GetAllStudents()
        {
            return students;    
        }


        [HttpGet("{id}")]
        public Student GetStudentById(int id)
        {
            return students.FirstOrDefault(x =>x.Id==id)  ;
        }


        [HttpPost]
        public bool PostStudent(Student student)
        {
            students.Add(student);
            return true;
        }

        [HttpPut]
        public bool PutStudent(Student student)
        {
            var maybeStudent = students.FirstOrDefault(student => student.Id == student.Id);
            if (maybeStudent is null)
            {
                return false;
            }
           
            maybeStudent.FirsName = student.FirsName;
            maybeStudent.LastName = student.LastName;
            maybeStudent.Age = student.Age;

            return true;
        }

        [HttpDelete("{id}")]
        public bool DeleteStudentById(int id)
        {
            var student=students.First(x => x.Id==id);
            if (student is null)
            {
                return false;
            }
            students.Remove(student);
            return true;
        }
    }
}
