using Edu_Camp.Models;
using Edu_Camp.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Edu_Camp.Controllers
{
    public class StudentController : Controller
    {
        IStudentService studentService;
        public StudentController(IStudentService studentService)
        {
            this.studentService = studentService;
        }
        // GET: StudentController
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        
        public ActionResult AddStudent(Student newStudent)
        {
            studentService.Add(newStudent);
         
            return View();
        }


    }
}

      
