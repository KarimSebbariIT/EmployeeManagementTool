using EmployeeManagement.Domain.Models.Employee;
using EmployeeManagement.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet("GetEmployees")]
        public async Task<ActionResult<List<EmployeeModel>>> GetEmployees()
        {
            return await _employeeService.GetEmployees();
        }

        [HttpPost("CreateEmployee")]
        public async Task<ActionResult<EmployeeCreateResponseModel>> CreateEmployee(EmployeeCreateModel employeeCreateModel)
        {
            var result = await _employeeService.CreateEmployee(employeeCreateModel);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpPut("UpdateEmployee")]
        public async Task<ActionResult<EmployeeUpdateResponseModel>> UpdateEmployee(EmployeeUpdateModel employeeUpdateModel)
        {
            var result = await _employeeService.UpdateEmployee(employeeUpdateModel);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpDelete("DeleteEmployee")]
        public async Task<ActionResult<EmployeeDeleteResponseModel>> DeleteEmployee(int id)
        {
            var result = await _employeeService.DeleteEmployee(id);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }




    }
}
