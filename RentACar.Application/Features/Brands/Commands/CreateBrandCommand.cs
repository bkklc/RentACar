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
    public class CreateBrandCommand : IRequest<CreatedBrandDto>
    {
        public string Name { get; set; }


        public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommand, CreatedBrandDto>
        {
            private readonly IBrandRepository _brandRepository;

            public CreateBrandCommandHandler(IBrandRepository brandRepository)
            {
                _brandRepository = brandRepository;
            }

            public async Task<CreatedBrandDto> Handle(CreateBrandCommand request, CancellationToken cancellationToken)
            {
                var brand = new Brand
                {
                    Name = request.Name
                };

                var createdBrand = await _brandRepository.AddAsync(brand);

                var createdBrandDto = new CreatedBrandDto
                {
                    Id = createdBrand.Id,
                    BrandName = createdBrand.Name,
                    CreatedDate = createdBrand.CreatedDate
                };

                return createdBrandDto;
            }
        }
    }
}
