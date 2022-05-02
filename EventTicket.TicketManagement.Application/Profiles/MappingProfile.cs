using AutoMapper;
using EventTicket.TicketManagement.Application.Features.Events;
using EventTicket.TicketManagement.Application.Features.Events.Models;
using EventTicket.TicketManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventTicket.TicketManagement.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, EventListVm>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Category, CategoryDto>();

        }
    }
}
