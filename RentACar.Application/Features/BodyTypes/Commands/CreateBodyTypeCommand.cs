using AutoMapper;
using MediatR;
using RentACar.Application.Features.BodyTypes.Dtos;
using RentACar.Application.Interfaces.Repositories;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Application.Features.BodyTypes.Commands
{
    public class CreateBodyTypeCommand : IRequest<CreateBodyTypeDto>
    {
        public string Name { get; set; }


        public class CreateBodyTypeCommandHandler : IRequestHandler<CreateBodyTypeCommand, CreateBodyTypeDto>
        {

            private readonly IBodyTypeRepository _bodyTypeRepository;
            private readonly IMapper _mapper;

            public CreateBodyTypeCommandHandler(IBodyTypeRepository bodyTypeRepository, IMapper mapper)
            {
                _bodyTypeRepository = bodyTypeRepository;
                _mapper = mapper;
            }

            public async Task<CreateBodyTypeDto> Handle(CreateBodyTypeCommand createBodyTypeCommand, CancellationToken cancellationToken)
            {

                BodyType bodyType = _mapper.Map<BodyType>(createBodyTypeCommand);
                BodyType createdBodyType = await _bodyTypeRepository.AddAsync(bodyType);
                return _mapper.Map<CreateBodyTypeDto>(createdBodyType);
            }
        }


    }
}
