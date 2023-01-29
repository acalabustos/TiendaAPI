using APIService.IServices;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace APIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BrandController : ControllerBase
    {
        private readonly ILogger<BrandController> _logger;
        private readonly IBrandService _brandService;
        public BrandController(ILogger<BrandController> logger, IBrandService brandService)
        {
            _logger = logger;
            _brandService = brandService;
        }

        [HttpPost(Name = "InsertBrand")]
        public int Post([FromBody] BrandItem brandItem)
        {
            //     _userService.ValidateCredentials(userItem);
            return _brandService.InsertBrand(brandItem);
        }
    }
}
