using ITSLocation.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace ITSLocation.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostalCodesController : ControllerBase
    {
        private readonly PostalCodeService _postalCodeService;

        public PostalCodesController(PostalCodeService postalCodeService)
        {
            _postalCodeService = postalCodeService;
        }

        [HttpGet("{code}")]
        public IActionResult GetPostalCode(string code)
        {
            var postalCode = _postalCodeService.GetPostalCode(code);
            if (postalCode == null)
            {
                return NotFound();
            }
            return Ok(postalCode);
        }
    }
}
