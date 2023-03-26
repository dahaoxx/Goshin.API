namespace Goshin.API.Models.Response;

public class LectureInfoResponse
{
    public string Name { get; set; } = string.Empty;
    public string Number { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTimeOffset Date { get; set; }
}