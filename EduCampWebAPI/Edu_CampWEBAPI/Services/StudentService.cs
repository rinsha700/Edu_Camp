using Edu_CampWEBAPI.Data;
using Edu_CampWEBAPI.Models;
using Edu_CampWEBAPI.Services.Interface;

namespace Edu_CampWEBAPI.Services
{
    public class StudentService : IStudentService
    {
        EduCampWebApiDbContext eduCampWebApiDbContext;
        public StudentService(EduCampWebApiDbContext eduCampWebApiDbContext)
        {
            this.eduCampWebApiDbContext = eduCampWebApiDbContext;
        }
        public Student Add(Student student)
        {
          eduCampWebApiDbContext.Students.Add(student);
            eduCampWebApiDbContext.SaveChanges();
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
            return eduCampWebApiDbContext.Students.ToList();
        }

        public Student Update(int id, Student student)
        {
            throw new NotImplementedException();
        }
    }
}
