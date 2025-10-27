using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Metadata;
using RentACar.Application.Features.Brands.Dtos;
using RentACar.Application.Interfaces.Repositories;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace RentACar.Application.Features.Brands.Commands
{
    public class CreateBrandCommand : IRequest<CreateBrandDto>
    {
        public string Name { get; set; }


        public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommand, CreateBrandDto>
        {
            private readonly IBrandRepository _brandRepository;
            private readonly IMapper _mapper;

            public CreateBrandCommandHandler(IBrandRepository brandRepository, IMapper mapper)
            {
                _brandRepository = brandRepository;
                _mapper = mapper;
            }

            public async Task<CreateBrandDto> Handle(CreateBrandCommand createBrandCommand, CancellationToken cancellationToken)
            {
                Brand brand = _mapper.Map<Brand>(createBrandCommand);
                Brand createdBrand = await _brandRepository.AddAsync(brand);
                return _mapper.Map<CreateBrandDto>(createdBrand);
            }
        }
    }
}
