using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using OCD_task.Repository;
using OCD_task.ViewModel;

namespace OCD_task.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IRepository _repository;
        private readonly IEmailSender _emailSender;


        public EmployeeController(IRepository repository, IEmailSender emailSender)
        {
            _repository = repository;
            _emailSender= emailSender;
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(EmployeeVM model)
        {

            if (await _repository.GetProductByEmail(model.Email))
            {
                ViewData["Message"] = "exist email";
                return View(model);

            }
            if (ModelState.IsValid)
            {
                var res = await _repository.CreateUpdateProduct(model);
                ViewData["Message"] = "Done Create Employee";
                _emailSender.SendEmailAsync(model.Email, "New Employee", $"<h2>Welcome #{model.Name} Created Successfully ... Email : {model.Email} </h2>");

                return View();
            }
            return View(model);
        }
    }
}
