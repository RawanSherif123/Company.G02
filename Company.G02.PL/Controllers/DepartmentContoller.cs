using Company.G02.BLL.Interfaces;
using Company.G02.BLL.Repositiries;
using Microsoft.AspNetCore.Mvc;

namespace Company.G02.PL.Controllers
{
    public class DepartmentContoller : Controller
    {
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentContoller( IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
           var departments =  _departmentRepository.GetAll();
            return View(departments);
        }
    }
}
