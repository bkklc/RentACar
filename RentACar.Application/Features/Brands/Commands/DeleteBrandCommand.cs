using AutoMapper;
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
            private readonly IMapper _mapper;

            public DeleteBrandCommandHandler(IBrandRepository brandRepository, IMapper mapper)
            {
                _brandRepository = brandRepository;
                _mapper = mapper;
            }

            public async Task<DeleteBrandDto> Handle(DeleteBrandCommand deleteBrandCommand, CancellationToken cancellationToken)
            {
                Brand brand = await _brandRepository.GetByIdAsync(deleteBrandCommand.Id);

                if (brand == null)
                    throw new Exception("Brand not found");

                await _brandRepository.DeleteAsync(brand);

                return _mapper.Map<DeleteBrandDto>(brand);
            }
        }


    }
}
