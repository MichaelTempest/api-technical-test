using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace employee_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Employee Get()
        {
            return new Employee();
        }
    }
}
