namespace Goshin.API.Models.Response;

public class LectureResponse
{
    public string Name { get; set; } = string.Empty;
    public DateTimeOffset Date { get; set; }
    public string Number { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public IEnumerable<VideoResponse> Videos { get; set; } = new List<VideoResponse>();
}