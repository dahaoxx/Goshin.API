using Goshin.Domain.Enums;
using Goshin.Domain.Models;

namespace Goshin.Services.Contracts;

public interface IScheduleService
{
    Task<Schedule> GetByClassAsync(ScheduleClass scheduleClass);
}