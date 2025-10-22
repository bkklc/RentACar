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

            public CreateBrandCommandHandler(IBrandRepository brandRepository)
            {
                _brandRepository = brandRepository;
            }

            public async Task<CreateBrandDto> Handle(CreateBrandCommand createBrandCommand, CancellationToken cancellationToken)
            {
                var brand = new Brand
                {
                    Name = createBrandCommand.Name
                };

                var createdBrand = await _brandRepository.AddAsync(brand);

                var createdBrandDto = new CreateBrandDto
                {
                    Id = createdBrand.Id,
                    Name = createdBrand.Name,
                    CreatedDate = createdBrand.CreatedDate
                };

                return createdBrandDto;
            }
        }
    }
}
