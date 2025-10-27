using AutoMapper;
using MediatR;
using RentACar.Application.Features.Brands.Dtos;
using RentACar.Application.Interfaces.Repositories;

namespace RentACar.Application.Features.Brands.Queries
{
    public class GetAllBrandQuery : IRequest<List<GetAllBrandListDto>>
    {
        public class GetAllBrandQueryHandler : IRequestHandler<GetAllBrandQuery, List<GetAllBrandListDto>>
        {
            private readonly IBrandRepository _brandRepository;
            private readonly IMapper _mapper;

            public GetAllBrandQueryHandler(IBrandRepository brandRepository, IMapper mapper)
            {
                _brandRepository = brandRepository;
                _mapper = mapper;
            }

            public async Task<List<GetAllBrandListDto>> Handle(GetAllBrandQuery request, CancellationToken cancellationToken)
            {
                var brands = await _brandRepository.GetAllAsync();
                return _mapper.Map<List<GetAllBrandListDto>>(brands);
            }
        }
    }
}
