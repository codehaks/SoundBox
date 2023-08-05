using System;
using System.Collections.Generic;

namespace SoundBox.Infrastructure.Persistence.DataModel;

public partial class MediaType
{
    public long MediaTypeId { get; set; }

    public string? Name { get; set; }
}
