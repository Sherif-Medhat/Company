using Comapny.BLL.repository;
using Company.DAL.Models;
using Company.PL.Dtos;
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
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateDpartmentDto model)
        {
            
            if (ModelState.IsValid) 
            {
                var department = new Department()
                {
                    Name = model.Name,
                    Code = model.Code,
                    CreateAt = model.CreateAt,
                };
                var count = _departmentrepository.Add(department);
                if (count > 0) 
                {

                }

            }
            return View();
        }
    }
}
