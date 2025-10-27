using AutoMapper;
using MediatR;
using RentACar.Application.Features.BodyTypes.Dtos;
using RentACar.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Application.Features.BodyTypes.Queries
{
    public class GetAllBodyTypeQuery : IRequest<List<GetAllBodyTypeListDto>>
    {
        public class GetAllBodyTypeQueryHandler : IRequestHandler<GetAllBodyTypeQuery, List<GetAllBodyTypeListDto>>
        {
            private readonly IBodyTypeRepository _bodyTypeRepository;
            private readonly IMapper _mapper;

            public GetAllBodyTypeQueryHandler(IBodyTypeRepository bodyTypeRepository, IMapper mapper)
            {
                _bodyTypeRepository = bodyTypeRepository;
                _mapper = mapper;
            }

            public async Task<List<GetAllBodyTypeListDto>> Handle(GetAllBodyTypeQuery request, CancellationToken cancellationToken)
            {
                var bodyTypes = await _bodyTypeRepository.GetAllAsync();
                return _mapper.Map<List<GetAllBodyTypeListDto>>(bodyTypes);
            }
        }
    }
}