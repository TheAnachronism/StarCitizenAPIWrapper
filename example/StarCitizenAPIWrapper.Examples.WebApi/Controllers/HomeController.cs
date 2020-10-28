using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StarCitizenAPIWrapper.Library;
using StarCitizenAPIWrapper.Library.Helpers;

namespace StarCitizenAPIWrapper.Example.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IStarCitizenClient _starCitizenClient;
        public HomeController(IStarCitizenClient starCitizenClient)
        {
            _starCitizenClient = starCitizenClient;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var request = new ShipRequestBuilder().WithName("890");
            return Ok(await _starCitizenClient.GetShips(request.Build()));
        }
    }
}
