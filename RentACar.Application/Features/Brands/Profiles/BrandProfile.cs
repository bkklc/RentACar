using AutoMapper;
using RentACar.Application.Features.Brands.Commands;
using RentACar.Application.Features.Brands.Dtos;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Application.Features.Brands.Profiles
{
    public class BrandMappingProfile : Profile
    {
        public BrandMappingProfile()
        {
            // Command → Entity
            CreateMap<CreateBrandCommand, Brand>();
            CreateMap<UpdateBrandCommand, Brand>();

            // Entity ↔ DTO
            CreateMap<Brand, CreateBrandDto>().ReverseMap();
            CreateMap<Brand, UpdateBrandDto>().ReverseMap();
            CreateMap<Brand, DeleteBrandDto>().ReverseMap();
            CreateMap<Brand, GetByIdBrandDto>().ReverseMap();
            CreateMap<Brand, GetAllBrandListDto>().ReverseMap();
        }
    }
}
