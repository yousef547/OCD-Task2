using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OCD_task.ViewModel
{
    public class EmployeeVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Address { get; set; }

        public string Email { get; set; }
        public string phone { get; set; }
        public string Job { get; set; }
    }
}
