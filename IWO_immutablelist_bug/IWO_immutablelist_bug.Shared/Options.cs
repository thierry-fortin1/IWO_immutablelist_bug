using System.Collections.Generic;
using System.Collections.Immutable;

namespace IWO_immutablelist_bug
{
    public record Options
    {
        public List<string> HiddenZones { get; init; } = new List<string>();
    }
}
