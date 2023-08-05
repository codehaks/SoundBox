using System;
using System.Collections.Generic;

namespace SoundBox.Infrastructure.Persistence.DataModel;

public partial class Playlist
{
    public long PlaylistId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Track> Tracks { get; set; } = new List<Track>();
}
