using AutoMapper;
using GraphQL.Dto;
using GraphQL.Entities;

namespace GraphQL.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Guest, GuestModel>();
        CreateMap<Room, RoomModel>();
        CreateMap<Reservation, ReservationModel>();
    }
}