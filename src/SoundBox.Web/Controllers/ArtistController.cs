using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SoundBox.Application.Contracts;

namespace SoundBox.Web.Controllers;
//[Route("api/[controller]")]
//[ApiController]
public class ArtistController : ControllerBase
{
    private readonly IArtistService _artistService;

    public ArtistController(IArtistService artistService)
    {
        _artistService = artistService;
    }

    [Route("api/artists")]
    public IActionResult GetAll()
    {
        var model=_artistService.GetAll();
        return Ok(model);
    }
}
