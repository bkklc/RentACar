using MediatR;
using RentACar.Application.Features.Brands.Dtos;
using RentACar.Application.Interfaces.Repositories;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Application.Features.Brands.Queries
{
    public class GetAllBrandQuery : IRequest<GetAllBrandList>
    {

        public class GetAllBrandQueryHandler : IRequestHandler<GetAllBrandQuery, GetAllBrandList>
        {

            private readonly IBrandRepository _brandRepository;

            public GetAllBrandQueryHandler(IBrandRepository brandRepository)
            {
                _brandRepository = brandRepository;
            }

            public async Task<GetAllBrandList> Handle(GetAllBrandQuery request, CancellationToken cancellationToken)
            {
                var brands = await _brandRepository.GetAllAsync();

                var response = new GetAllBrandList
                {
                    Items = brands.Select(b => new BrandListItemDto
                    {
                        Id = b.Id,
                        Name = b.Name
                    }).ToList()
                };

                return response;




            }
            
        }

    }
}
