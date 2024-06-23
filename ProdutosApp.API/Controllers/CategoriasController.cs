using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProdutosApp.Domain.Dtos;
using ProdutosApp.Domain.Interfaces.Services;

namespace ProdutosApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly ICategoriaDomainService _categoriaDomainService;

        public CategoriasController(ICategoriaDomainService categoriaDomainService)
        {
            _categoriaDomainService = categoriaDomainService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<CategoriasResponseDto>), 200)]
        public IActionResult Get()
        {
            return StatusCode(200, _categoriaDomainService.GetAll());
        }
    }
}
