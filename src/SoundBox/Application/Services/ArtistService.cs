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

    public IList<ArtistDto> GetAll()
    {
        return _db.Artists
            .Select(a => new ArtistDto
            {
                ArtistId = a.ArtistId,
                Name = a.Name
            }).ToList();
    }
}
