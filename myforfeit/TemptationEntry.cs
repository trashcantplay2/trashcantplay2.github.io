using System;
using System.Collections.Generic;
using System.Linq;

namespace myforfeit;

public class TemptationEntry
{
    public string Name { get; set; } = string.Empty;
    public List<DateTime> Timestamps { get; set; } = new List<DateTime>();

    // Count is now a calculated property based on the number of timestamps
    public int Count => Timestamps.Count;
}
