using SoundBox.Application.Models;
using SoundBox.Infrastructure.Persistence.DataModel;

namespace SoundBox.Application.Contracts;
public interface IArtistService
{
    IList<ArtistDto> GetAll();
    ArtistDto GetById(long id);

    void Create(ArtistCreateDto model);
    void Remove(ArtistRemoveDto model);
    void Update(ArtistDto model);
}