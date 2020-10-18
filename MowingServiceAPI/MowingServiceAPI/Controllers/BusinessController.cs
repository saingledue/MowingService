using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// using ApiDemoApp.Models;
using DataLibrary.Data;
using DataLibrary.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MowingServiceAPI.Models;

namespace MowingServiceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class BusinessController : ControllerBase
    {
        private readonly IBusinessData _businessData;

        public BusinessController(IBusinessData businessData)
        {
            _businessData = businessData;
        }

        [HttpGet("")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetBusinessAll()
        {
            var business = await _businessData.GetBusiness();

            if (business != null)
            {
                return Ok(business);
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
        public async Task<IActionResult> CreateBusiness(BusinessModel business)
        {
            var businessId = await _businessData.CreateBusiness(business);

            return Ok(new { BusinessId = businessId });
        }

        [HttpGet("{businessId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetBusinessByBusinessId(int businessId)
        {
            if (businessId == 0)
            {
                return BadRequest();
            }

            var business = await _businessData.GetBusinessByBusinessId(businessId);

            if (business != null)
            {
                //var output = new
                //{
                //    Business = business,
                //    MiscInfo = businessStuffs
                //};

                // return Ok(output);
                
                return Ok(business);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPut]
        // [ValidateModel]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateBusinessByBusinessId([FromBody] BusinessModel business)
        {
            await _businessData.UpdateBusinessByBusinessId(business);
            // await _businessData.UpdateBusinessByBusinessId(business.BusinessId, business.Location, business.OpenHours, business.CloseHours);
            return Ok();
        }

        [HttpDelete("{businessId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeleteBusinessByBusinessId(int businessId)
        {
            await _businessData.DeleteBusinessByBusinessId(businessId);

            return Ok();
        }
    }
}
