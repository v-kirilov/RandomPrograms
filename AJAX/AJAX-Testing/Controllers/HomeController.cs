using AJAX_Testing.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Text.Json.Serialization;

namespace AJAX_Testing.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public static List<Student> students = new List<Student>();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            students = new List<Student>();
            students.Add(new Student()
            {
                Id = 1,
                Email = "Pesho@outlook.com",
                Name = "Pesho"
            });
            students.Add(new Student()
            {
                Id = 2,
                Email = "Tosho@outlook.com",
                Name = "Tosho"
            });
            students.Add(new Student()
            {
                Id = 3,
                Email = "Gosho@outlook.com",
                Name = "Gosho"
            });
        }
        [HttpGet]
        public IActionResult GetDetailsById(int id)
        {
            var student = students.Where(x => x.Id == id).FirstOrDefault();
            JsonResponseViewModel model = new JsonResponseViewModel();
            if (student != null)
            {
                model.ResponseCode = 0;
                model.ResponseMessage = JsonConvert.SerializeObject(student);
            }
            else
            {
                model.ResponseCode = 1;
                model.ResponseMessage = "No record available";
            }
            return Json(model);
        }

        [HttpPost]
        public IActionResult InsertStudent(IFormCollection formcollection)
        {
            var student = new Student();
            student.Email = formcollection["email"];
            student.Name = formcollection["name"];
            student.Id = students.Count()+1;
            JsonResponseViewModel model = new JsonResponseViewModel();
            students.Add(student);
            if (student != null)
            {
                model.ResponseCode = 0;
                model.ResponseMessage = JsonConvert.SerializeObject(student);
            }
            else
            {
                model.ResponseCode = 1;
                model.ResponseMessage = "No record available";
            }
            return Json(model);
        }

        [HttpPut]
        public IActionResult UpdateStudent(IFormCollection formcollection)
        {
            var student = students.Where(x => x.Name == formcollection["name"]).FirstOrDefault();
            
            JsonResponseViewModel model = new JsonResponseViewModel();
            if (student != null)
            {
            student.Email = formcollection["email"];
                model.ResponseCode = 0;
                model.ResponseMessage = JsonConvert.SerializeObject(student);
            }
            else
            {
                model.ResponseCode = 1;
                model.ResponseMessage = "No record available";
            }
            return Json(model);
        }

        [HttpDelete]
        public IActionResult DeleteStudent(IFormCollection fomrcolection)
        {
            var student = students.Where(x => x.Name == fomrcolection["name"]).FirstOrDefault();
            int id =int.Parse( fomrcolection["id"]);
            JsonResponseViewModel model = new JsonResponseViewModel();
            if (student != null)
            {
                students.Remove(student);
                model.ResponseCode = 0;
                model.ResponseMessage = "Student deleted";

            }
            else
            {
                model.ResponseCode = 1;
                model.ResponseMessage = "No record available";
            }
            return Json(model);
        }

        public IActionResult Index()
        {
            return View(students);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}