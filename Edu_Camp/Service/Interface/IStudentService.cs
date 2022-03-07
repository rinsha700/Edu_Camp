using Edu_Camp.Models;

namespace Edu_Camp.Service.Interface
{
    public interface IStudentService
    {
        public Student Add(Student student);
        public List<Student> GetAll();
        public Student Get(int id);
        public Student Update(int id, Student student);  
        public Student Delete(int id,Student student);
        
    }
}
