using Edu_Camp.Data;
using Edu_Camp.Models;
using Edu_Camp.Service.Interface;

namespace Edu_Camp.Service
{
    public class StudentService : IStudentService
    {
        EduCampDbContext eduCampDbContext;
        public StudentService(EduCampDbContext eduCampDbContext)
        {
            this.eduCampDbContext=eduCampDbContext;
        }
        public Student Add(Student student)
        {
           eduCampDbContext.Add(student);
            eduCampDbContext.SaveChanges();

            return student;
        }

        public Student Delete(int id, Student student)
        {
            throw new NotImplementedException();
        }

        public Student Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public Student Update(int id, Student student)
        {
            throw new NotImplementedException();
        }
    }
}