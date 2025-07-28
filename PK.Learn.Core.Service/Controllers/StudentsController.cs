using Microsoft.AspNetCore.Mvc;
using PK.Learn.Core.Service.Models;

namespace PK.Learn.Core.Service.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public void GetStudentById(int id,string name)
        {


        }
    }
}
