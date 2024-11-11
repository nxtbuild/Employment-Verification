using EmploymentVerification.Models;
using EmploymentVerification.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace EmploymentVerification.API.Controllers
{
    [Route("api/verify-employment")]
    [ApiController]
    public class EmploymentVerificationController : ControllerBase
    {
        private readonly IEmploymentVerificationService _verificationService;

        public EmploymentVerificationController(IEmploymentVerificationService verificationService)
        {
            _verificationService = verificationService;
        }

        [HttpPost]
        public IActionResult VerifyEmployment([FromBody] EmploymentVerificationRequest request)
        {
            try
            {
                var result = _verificationService.VerifyEmployment(request);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "An error occurred while processing the request.", Details = ex.Message });
            }
        }


    }
}
