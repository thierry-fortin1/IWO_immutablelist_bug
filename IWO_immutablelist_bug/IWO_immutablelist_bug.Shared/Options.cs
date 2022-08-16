using System.Collections.Generic;
using System.Collections.Immutable;

namespace IWO_immutablelist_bug
{
    public record Options
    {
        public List<string> _list { get; init; } = new List<string>();
        public ImmutableList<string> _immutableList { get; init; } = ImmutableList<string>.Empty;
    }
}
