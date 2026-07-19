using System;
using System.Collections.Generic;

namespace myforfeit;

// Represents a single goal or task
public class DailyTask
{
    public string Text { get; set; } = string.Empty;
    public string AreaName { get; set; } = string.Empty;
    public bool IsCompleted { get; set; }
}

// A container for all daily items and the date they were generated for
public class DailyList
{
    public DateTime DateGenerated { get; set; }
    public List<DailyTask> Goals { get; set; } = new List<DailyTask>();
    public List<DailyTask> Routines { get; set; } = new List<DailyTask>();
}
