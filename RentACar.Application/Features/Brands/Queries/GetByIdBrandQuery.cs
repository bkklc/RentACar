using MediatR;
using RentACar.Application.Features.Brands.Dtos;
using RentACar.Application.Interfaces.Repositories;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Application.Features.Brands.Queries
{
    public class GetByIdBrandQuery : IRequest<GetByIdBrandDto>
    {
        public Guid Id  { get; set; }

        public class GetByIdBrandQueryHandler : IRequestHandler<GetByIdBrandQuery, GetByIdBrandDto>
        {
            private readonly IBrandRepository _brandRepository;

            public GetByIdBrandQueryHandler(IBrandRepository brandRepository)
            {
                _brandRepository = brandRepository;
            }

            public async Task<GetByIdBrandDto> Handle(GetByIdBrandQuery getByIdBrandQuery, CancellationToken cancellationToken)
            {
                Brand brand = await _brandRepository.GetByIdAsync(getByIdBrandQuery.Id);

                GetByIdBrandDto getByIdBrandDto = new GetByIdBrandDto
                {
                    Id = brand.Id,
                    Name = brand.Name
                };

                return getByIdBrandDto;
            }
        }
    }
}
