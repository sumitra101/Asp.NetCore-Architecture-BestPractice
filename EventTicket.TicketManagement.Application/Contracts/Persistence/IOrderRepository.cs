using EventTicket.TicketManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventTicket.TicketManagement.Application.Contracts.Persistence
{
    public interface IOrderRepository : IAsyncRepository<Order>
    {
    }
}
