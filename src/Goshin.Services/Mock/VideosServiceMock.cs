using Goshin.Domain.Enums;
using Goshin.Domain.Models;
using Goshin.Services.Contracts;

namespace Goshin.Services.Mock;

public class VideosServiceMock : IVideosService
{
    public async Task<IEnumerable<Video>> GetByClassPaginatedAsync(Level level, int page, int pageSize)
    {
        return await Task.FromResult(new List<Video>
        {
            new() { Title = "Video 1", Url = "test.com/video/1", ThumbnailUrl = "test.com/thumbnail/1" },
            new() { Title = "Video 2", Url = "test.com/video/2", ThumbnailUrl = "test.com/thumbnail/2" },
            new() { Title = "Video 3", Url = "test.com/video/3", ThumbnailUrl = "test.com/thumbnail/3" },
            new() { Title = "Video 4", Url = "test.com/video/4", ThumbnailUrl = "test.com/thumbnail/4" },
            new() { Title = "Video 5", Url = "test.com/video/5", ThumbnailUrl = "test.com/thumbnail/5" },
        });
    }
}