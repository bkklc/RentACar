using AutoMapper;
using MediatR;
using RentACar.Application.Features.BodyTypes.Dtos;
using RentACar.Application.Interfaces.Repositories;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Application.Features.BodyTypes.Queries
{
    public class GetByIdBodyTypeQuery : IRequest<GetByIdBodyTypeDto>
    {
        public Guid Id { get; set; }


        public class GetByIdBodyTypeQueryHandler : IRequestHandler<GetByIdBodyTypeQuery, GetByIdBodyTypeDto>
        {
            private readonly IBodyTypeRepository _bodyTypeRepository;
            private readonly IMapper _mapper;

            public GetByIdBodyTypeQueryHandler(IBodyTypeRepository bodyTypeRepository, IMapper mapper)
            {
                _bodyTypeRepository = bodyTypeRepository;
                _mapper = mapper;
            }

            public async Task<GetByIdBodyTypeDto> Handle(GetByIdBodyTypeQuery getByIdBodyTypeQuery, CancellationToken cancellationToken)
            {
                BodyType bodyType = await _bodyTypeRepository.GetByIdAsync(getByIdBodyTypeQuery.Id);

                if (bodyType == null)
                    throw new Exception("BodyType not found");

                return _mapper.Map<GetByIdBodyTypeDto>(bodyType);

            }
        }
    }
}
