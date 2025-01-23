using EBaking_API.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EBaking_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InstallmentController : ControllerBase
    {
        private readonly IInstallmentService _installmentService;

        public InstallmentController(IInstallmentService installmentService)
        {
            _installmentService = installmentService;
        }

        [HttpPost]
        public async Task<ActionResult<string>> RequestInstallment(int transactionId, int numberOfInstallments)
        {
            var result = await _installmentService.RequestInstallmentAsync(transactionId, numberOfInstallments);
            return Ok(result);
        }
    }
}
