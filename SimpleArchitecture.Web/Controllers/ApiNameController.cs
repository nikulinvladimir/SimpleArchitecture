using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleArchitecture.Web.Interfaces;

namespace SimpleArchitecture.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiNameController : ControllerBase
    {
        ISimpleDataService _simpleDataService;

        public ApiNameController(ISimpleDataService simpleDataService)
        {
            _simpleDataService = simpleDataService;
        }


        [HttpGet("Models")]
        public async Task<IActionResult> GetModels()
        {
            var result = await _simpleDataService.GetModels();

            return Ok(result);
        }
    }
}
