using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SoundBox.Infrastructure.Persistence.DataModel;

public partial class Artist
{
    public long ArtistId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Album> Albums { get; set; } = new List<Album>();
}
