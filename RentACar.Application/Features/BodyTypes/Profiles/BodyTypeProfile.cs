using AutoMapper;
using RentACar.Application.Features.BodyTypes.Commands;
using RentACar.Application.Features.BodyTypes.Dtos;
using RentACar.Application.Features.Campaigns.Dtos;
using RentACar.Domain.Entities;

namespace RentACar.Application.Features.BodyTypes.Profiles
{
    public class BodyTypeProfile : Profile
    {
        public BodyTypeProfile()
        {
            // Command → Entity
            CreateMap<CreateBodyTypeCommand, BodyType>();
            CreateMap<UpdateBodyTypeCommand, BodyType>();

            // Entity ↔ DTO
            CreateMap<BodyType, CreateBodyTypeDto>().ReverseMap();
            CreateMap<BodyType, UpdateBodyTypeDto>().ReverseMap();
            CreateMap<BodyType, DeleteBodyTypeDto>().ReverseMap();
            CreateMap<BodyType, GetByIdBodyTypeDto>().ReverseMap();
            CreateMap<BodyType, GetAllBodyTypeListDto>().ReverseMap();
        }
    }
}
