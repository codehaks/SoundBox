using SoundBox.Infrastructure.Persistence.DataModel;

namespace SoundBox.Application.Contracts;
public interface IArtistService
{
    IList<Artist> GetAll();
}