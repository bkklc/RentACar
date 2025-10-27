using AutoMapper;
using MediatR;
using RentACar.Application.Features.Brands.Dtos;
using RentACar.Application.Interfaces.Repositories;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace RentACar.Application.Features.Brands.Queries
{
    public class GetByIdBrandQuery : IRequest<GetByIdBrandDto>
    {
        public Guid Id { get; set; }

        public class GetByIdBrandQueryHandler : IRequestHandler<GetByIdBrandQuery, GetByIdBrandDto>
        {
            private readonly IBrandRepository _brandRepository;
            private readonly IMapper _mapper;

            public GetByIdBrandQueryHandler(IBrandRepository brandRepository, IMapper mapper)
            {
                _brandRepository = brandRepository;
                _mapper = mapper;
            }

            public async Task<GetByIdBrandDto> Handle(GetByIdBrandQuery getByIdBrandQuery, CancellationToken cancellationToken)
            {
                Brand? brand = await _brandRepository.GetByIdAsync(getByIdBrandQuery.Id)
            ?? throw new Exception("Brand not found");

                return _mapper.Map<GetByIdBrandDto>(brand);
            }
        }
    }
}
