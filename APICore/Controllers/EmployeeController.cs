using APICore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APICore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        EmployeeContext ec;
        public EmployeeController (EmployeeContext ec) { 
          this.ec = ec;
        }
        [HttpPost]
        public string One(Employees e1)
        {
            ec.Employee.Add(e1);
            ec.SaveChanges();
            return "Registration Succefully";
        }
    }
}
