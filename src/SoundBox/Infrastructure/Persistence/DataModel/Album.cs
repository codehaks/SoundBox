﻿using System;
using System.Collections.Generic;

namespace SoundBox.Infrastructure.Persistence.DataModel;

public partial class Album
{
    public long AlbumId { get; set; }

    public string Title { get; set; } = null!;

    public long ArtistId { get; set; }

    public virtual Artist Artist { get; set; } = null!;

    public virtual ICollection<Track> Tracks { get; set; } = new List<Track>();
}
