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

    public class PortfolioController : ControllerBase
    {
        private readonly IPortfolioData _portfolioData;

        public PortfolioController(IPortfolioData portfolioData)
        {
            _portfolioData = portfolioData;
        }

        [HttpGet("")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetPortfolioAll()
        {
            var portfolio = await _portfolioData.GetPortfolio();

            if (portfolio != null)
            {
                return Ok(portfolio);
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
        public async Task<IActionResult> CreatePortfolio(PortfolioModel portfolio)
        {
            var portfolioId = await _portfolioData.CreatePortfolio(portfolio);

            return Ok(new { PortfolioId = portfolioId });
        }

        [HttpGet("{portfolioId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetPortfolioByPortfolioId(int portfolioId)
        {
            if (portfolioId == 0)
            {
                return BadRequest();
            }

            var portfolio = await _portfolioData.GetPortfolioByPortfolioId(portfolioId);

            if (portfolio != null)
            {
                return Ok(portfolio);
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
        public async Task<IActionResult> UpdatePortfolioByPortfolioId([FromBody] PortfolioModel portfolio)
        {
            await _portfolioData.UpdatePortfolioByPortfolioId(portfolio);

            return Ok();
        }

        [HttpDelete("{portfolioId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeletePortfolioByPortfolioId(int portfolioId)
        {
            await _portfolioData.DeletePortfolioByPortfolioId(portfolioId);

            return Ok();
        }
    }
}
