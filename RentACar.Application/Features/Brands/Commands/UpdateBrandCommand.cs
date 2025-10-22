using MediatR;
using RentACar.Application.Features.Brands.Dtos;
using RentACar.Application.Interfaces.Repositories;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Application.Features.Brands.Commands
{
    public class UpdateBrandCommand : IRequest<UpdateBrandDto>
    {
        public Guid Id { get; set; }        
        public string Name { get; set; }        


        public class UpdateBrandCommandHandler : IRequestHandler<UpdateBrandCommand, UpdateBrandDto>
        {
            private readonly IBrandRepository _brandRepository;

            public UpdateBrandCommandHandler(IBrandRepository brandRepository)
            {
                _brandRepository = brandRepository;
            }

            public async Task<UpdateBrandDto> Handle(UpdateBrandCommand updateBrandCommand, CancellationToken cancellationToken)
            {
                Brand brand =  _brandRepository.GetByIdAsync(updateBrandCommand.Id).Result;

                if (brand == null)
                    throw new Exception("Brand not found");

                brand.Name = updateBrandCommand.Name;


                await _brandRepository.UpdateAsync(brand);
                UpdateBrandDto updateBrandDto = new()
                {
                    Id = brand.Id,                    
                    Name = brand.Name,                   
                };
                return updateBrandDto;
            }
        }


    }
}
