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
    public class UpdateBrandCommand : IRequest<UpdateBrandDto>
    {
        public Guid Id { get; set; }        
        public string Name { get; set; }        


        public class UpdateBrandCommandHandler : IRequestHandler<UpdateBrandCommand, UpdateBrandDto>
        {
            private readonly IBrandRepository _brandRepository;
            private readonly IMapper _mapper;

            public UpdateBrandCommandHandler(IBrandRepository brandRepository, IMapper mapper)
            {
                _brandRepository = brandRepository;
                _mapper = mapper;
            }

            public async Task<UpdateBrandDto> Handle(UpdateBrandCommand updateBrandCommand, CancellationToken cancellationToken)
            {
                Brand? brand = await _brandRepository.GetByIdAsync(updateBrandCommand.Id);

                if (brand == null)
                    throw new Exception("Brand not found");

                _mapper.Map(updateBrandCommand, brand);

                await _brandRepository.UpdateAsync(brand);

                return _mapper.Map<UpdateBrandDto>(brand);
            }
        }


    }
}
