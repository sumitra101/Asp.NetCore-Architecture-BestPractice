using EventTicket.TicketManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventTicket.TicketManagement.Application.Contracts.Persistence
{
    internal interface ICategoryRepository : IAsyncRepository<Category>
    {
    }
}
