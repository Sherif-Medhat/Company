using Comapny.BLL.repository;
using Microsoft.AspNetCore.Mvc;

namespace Company.PL.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepository _departmentrepository;
        public DepartmentController(IDepartmentRepository depatrmentRepository)
        {
            _departmentrepository = depatrmentRepository;
        }
        [HttpGet]
        public IActionResult Index()
        {
            
            var departments = _departmentrepository.GetAll();
            return View(departments);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
