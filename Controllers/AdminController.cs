using Microsoft.AspNetCore.Mvc;
using OCD_task.Repository;
using OCD_task.ViewModel;

namespace OCD_task.Controllers
{
    public class AdminController : Controller
    {
        private readonly IRepository _repository;

        public AdminController(IRepository repository)
        {
            _repository = repository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<EmployeeVM> Employee = await _repository.GetEmployees();
            return View(Employee);
        }
    }
}
