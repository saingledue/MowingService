using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// using ApiDemoApp.Models;
using DataLibrary.Data;
using DataLibrary.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MowingServiceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeData _employeeData;

        public EmployeeController(IEmployeeData employeeData)
        {
            _employeeData = employeeData;
        }

        [HttpGet("")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetEmployeeAll()
        {
            var employee = await _employeeData.GetEmployeeAll();

            if (employee != null)
            {
                return Ok(employee);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        [ValidateModel]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateEmployee(EmployeeModel employee)
        {
            var employeeId = await _employeeData.CreateEmployee(employee);

            return Ok(new { EmployeeId = employeeId });
        }

        [HttpGet("{employeeId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetEmployeeByEmployeeId(int employeeId)
        {
            if (employeeId == 0)
            {
                return BadRequest();
            }

            var employee = await _employeeData.GetEmployeeByEmployeeId(employeeId);

            if (employee != null)
            {
                return Ok(employee);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPut]
        [ValidateModel]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateEmployeeByEmployeeId([FromBody] EmployeeModel employee)
        {
            await _employeeData.UpdateEmployeeByEmployeeId(employee);

            return Ok();
        }

        [HttpDelete("{employeeId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeleteEmployeeByEmployeeId(int employeeId)
        {
            await _employeeData.DeleteEmployeeByEmployeeId(employeeId);

            return Ok();
        }
    }
}
