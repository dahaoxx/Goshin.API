﻿using Goshin.Domain.Models;

namespace Goshin.Services.Contracts;

public interface IEventService
{
    Task<Event> GetByIdAsync(Guid id);
    Task<List<Event>> GetAllAsync();
}