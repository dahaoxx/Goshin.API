using Goshin.API.Models.Response;
using Goshin.Domain.Models;

namespace Goshin.API.Mappers;

public static class VideoMapper
{
    public static VideoResponse ToResponse(this Video video)
        => new()
        {
            Title = video.Title,
            Url = video.Url,
            ThumbnailUrl = video.ThumbnailUrl,
        };
}