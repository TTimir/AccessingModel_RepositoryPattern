using EX_AccessModel.Models;
using EX_AccessModel.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EX_AccessModel.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StudentRepository _studentRepository = null; // Repository Pattern
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _studentRepository = new StudentRepository();
        }

        public List<StudModel> getAllStudent()
        {
            return _studentRepository.getAllStudents();
        }

        public StudModel getByID(int id)
        {
            return _studentRepository.getStudentByID(id);
        }

        public IActionResult Index()
        {
            //var student = new List<StudModel>()
            //{
            //    new StudModel { StudID=01, Name="Raj", Age=21, Field="BA" },
            //    new StudModel { StudID=02, Name="Ayush", Age=20, Field="BSC" },
            //    new StudModel { StudID=03, Name="Smit", Age=22, Field="BBA" },
            //    new StudModel { StudID=04, Name="Ram", Age=22, Field="BCA" },
            //};

            //ViewBag.Student = student;

            return View();
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
