namespace Goshin.API.Models.Response;

public class ScheduleResponse // TODO: Replace with real model
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
}