namespace myforfeit;

public class Contract
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Title { get; set; } = string.Empty;
    public DateTime Deadline { get; set; } = DateTime.Now.AddDays(1);
    public bool IsCompleted { get; set; }
    public bool NotificationSent { get; set; }
    public int Stakes { get; set; } = 5; // Default to $5
}
