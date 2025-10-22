using MediatR;
using RentACar.Application.Features.Brands.Dtos;
using RentACar.Application.Interfaces.Repositories;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Application.Features.Brands.Commands
{
    public class DeleteBrandCommand : IRequest<DeleteBrandDto>
    {
        public Guid Id { get; set; }


        public class DeleteBrandCommandHandler : IRequestHandler<DeleteBrandCommand, DeleteBrandDto>
        {

            private readonly IBrandRepository _brandRepository;

            public DeleteBrandCommandHandler(IBrandRepository brandRepository)
            {
                _brandRepository = brandRepository;
            }

            public async Task<DeleteBrandDto> Handle(DeleteBrandCommand deleteBrandCommand, CancellationToken cancellationToken)
            {
                Brand brand = _brandRepository.GetByIdAsync(deleteBrandCommand.Id).Result;
                await _brandRepository.DeleteAsync(brand);
                DeleteBrandDto deleteBrandDto = new()
                {
                    Id = brand.Id,
                    Name = brand.Name,
                    DeletedDate = DateTime.UtcNow
                };
                return deleteBrandDto;
            }
        }


    }
}
