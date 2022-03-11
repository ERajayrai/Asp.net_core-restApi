
using AspNetCoreWebApi.EmployeeData;
using AspNetCoreWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetCoreWebApi.Controllers
{
    
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeData _mployeeData;
        public EmployeeController(IEmployeeData employeeData)
        {
            _mployeeData = employeeData;
        }

        // GET: api/<EmployeeController>

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetEmployees()
        {
            return Ok(_mployeeData.GetEmployees());
        }
        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetEmployee(Guid id) {
            var employee = _mployeeData.GetEmployee(id);
            if (employee != null)
            {
                return Ok(employee);
            }
            return NotFound("Employee with id");
        
        }
        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult SetEmployee(Employee emlpoyee)
        {
            _mployeeData.AddEmployee(emlpoyee);
            return Created(HttpContext.Request.Scheme+"://"+HttpContext.Request.Host+"/"+ emlpoyee.id,emlpoyee);
        }
        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult DeleteEmployee(Guid id)
        {
            var employee = _mployeeData.GetEmployee(id);
            if(employee != null)
            {
                _mployeeData.DeleteEmployee(employee);
                return Ok();
            }
            return NotFound("not found id") ;
        }
        [HttpPatch]
        [Route("api/[controller]/{id}")]
        public IActionResult EditeEmployee(Guid id ,Employee employee)
        {

            var exitingEmployee = _mployeeData.GetEmployee(id);
            if(exitingEmployee != null)

            {
                employee.id = exitingEmployee.id;
                _mployeeData.EditeEmployee(employee);
                
            }
                return  Ok(employee); 
        }


    }
}
