using AutoMapper;
using RentACar.Application.Features.Campaigns.Commands;
using RentACar.Application.Features.Campaigns.Dtos;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Application.Features.Campaigns.Profiles
{
    public class CampaignProfile : Profile
    {
        public CampaignProfile()
        {
            // Command → Entity
            CreateMap<CreateCampaignCommand, Campaign>();
            CreateMap<UpdateCampaignCommand, Campaign>();

            // Entity ↔ DTO
            CreateMap<Campaign, CreateCampaignDto>().ReverseMap();
            CreateMap<Campaign, UpdateCampaignDto>().ReverseMap();
            CreateMap<Campaign, DeleteCampaignDto>().ReverseMap();
            CreateMap<Campaign, GetByIdCampaignDto>().ReverseMap();
            CreateMap<Campaign, GetAllCampaignListDto>().ReverseMap();

        }
    }
}
