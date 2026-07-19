using System;
using System.Collections.Generic;
using System.Linq;

namespace myforfeit;

public class TemptationOccurrence
{
    public Guid Id { get; set; } = Guid.NewGuid(); // Unique ID for each occurrence
    public DateTime Timestamp { get; set; }
    public string Comment { get; set; } = string.Empty;
}

public class TemptationEntry
{
    public string Name { get; set; } = string.Empty;
    public List<TemptationOccurrence> Occurrences { get; set; } = new List<TemptationOccurrence>();

    public int Count => Occurrences.Count;
}
