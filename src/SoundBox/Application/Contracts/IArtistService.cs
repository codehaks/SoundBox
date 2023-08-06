using SoundBox.Application.Models;
using SoundBox.Infrastructure.Persistence.DataModel;

namespace SoundBox.Application.Contracts;
public interface IArtistService
{
    IList<ArtistDto> GetAll();
}