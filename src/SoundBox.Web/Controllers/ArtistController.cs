using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SoundBox.Application.Contracts;
using SoundBox.Application.Models;

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

    [Route("api/artist/{id}")]
    public ArtistDto GetById(long id)
    {
        var model = _artistService.GetById(id);
        return model; //Ok(model);
    }

    [HttpPost]
    [Route("api/artist")]
    public IActionResult AddArtist([FromBody] ArtistCreateDto model)
    {
       _artistService.Create(model);
        return Ok();
    }

    [HttpDelete]
    [Route("api/artist")]
    public IActionResult RemoveArtist([FromBody] ArtistRemoveDto model)
    {
        _artistService.Remove(model);
        return Ok();
    }

    [HttpPut]
    [Route("api/artist")]
    public IActionResult UpdateArtist([FromBody] ArtistDto model)
    {
        _artistService.Update(model);
        return Ok();
    }
}


