using Microsoft.AspNetCore.Mvc;
using Capstone_BE.Business.Interface;
using Capstone_BE.Business.Model;

namespace Capstone_BE.API.Controllers
{
    [Route("api/[controller]")]
    //[Authorize] // Nào code xong mở lại Authorize
    [ApiController]
    public class ExampleController : ControllerBase
    {
        private readonly IExampleService _service;
        public ExampleController(IExampleService service)
        {
            _service = service;
        }

        /// <summary>
        /// Comment API
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        //[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ResultModel))]
        [HttpGet("ExampleFunction")]
        public async Task<IActionResult> ExampleFunction()
        {
            var result = await _service.ExampleFunction();

            if (result.IsSuccess && result.Code == 200) return Ok(result);
            return BadRequest(result);
        }
    }
}
