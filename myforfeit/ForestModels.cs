using System;
using System.Collections.Generic;

namespace myforfeit;

public enum TreeState
{
    Growing,
    Grown,
    Withered
}

public class Tree
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime PlantedAt { get; set; }
    public TimeSpan Duration { get; set; }
    public TreeState State { get; set; }
    public string PlantType { get; set; } = "🌳";

    // New properties for pause/resume
    public bool IsPaused { get; set; }
    public TimeSpan PausedDuration { get; set; }
    public DateTime? LastPausedAt { get; set; }
}
