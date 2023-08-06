using SoundBox.Application.Contracts;
using SoundBox.Application.Models;
using SoundBox.Infrastructure.Persistence.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundBox.Application.Services;
public class ArtistService : IArtistService
{
    private readonly ChinookDbContext _db;

    public ArtistService(ChinookDbContext db)
    {
        _db = db;
    }

    public void Create(ArtistCreateDto model)
    {
        //TODO: Validation
        _db.Artists.Add(new Artist { Name = model.Name });
        _db.SaveChanges();
    }

    public IList<ArtistDto> GetAll()
    {
        return _db.Artists
            .Select(a => new ArtistDto
            {
                ArtistId = a.ArtistId,
                Name = a.Name
            }).ToList();
    }

    public ArtistDto GetById(long id)
    {
        var artist = _db.Artists.Find(id);
        //TODO: check if artist null
        return new ArtistDto { ArtistId=artist.ArtistId, Name=artist.Name };
    }

    public void Remove(ArtistRemoveDto model)
    {
        var artist = _db.Artists.Find(model.Id);

        //TODO: Null Check

        _db.Artists.Remove(artist);
        _db.SaveChanges();
    }

    public void Update(ArtistDto model)
    {
        var artist = _db.Artists.Find(model.ArtistId);

        //TODO: Null Check
        artist.Name = model.Name;
        _db.SaveChanges();
    }
}
