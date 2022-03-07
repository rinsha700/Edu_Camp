using Edu_CampWEBAPI.Models;

namespace Edu_CampWEBAPI.Services.Interface
{
    public interface IStudentService
    {
        public Student Add(Student student);
        public List<Student> GetAll();
        public Student Get(int id);
        public Student Update(int id, Student student);
        public Student Delete(int id, Student student);
    }
}

