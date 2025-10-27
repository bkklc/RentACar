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
    public class UpdateBodyTypeCommand : IRequest<UpdateBodyTypeDto>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }


        public class UpdateBodyTypeCommandHandler : IRequestHandler<UpdateBodyTypeCommand, UpdateBodyTypeDto>
        {
            private readonly IBodyTypeRepository _bodyTypeRepository;
            private readonly IMapper _mapper;

            public UpdateBodyTypeCommandHandler(IBodyTypeRepository bodyTypeRepository, IMapper mapper)
            {
                _bodyTypeRepository = bodyTypeRepository;
                _mapper = mapper;
            }

            public async Task<UpdateBodyTypeDto> Handle(UpdateBodyTypeCommand updateBodyTypeCommand, CancellationToken cancellationToken)
            {
                BodyType bodyType = await _bodyTypeRepository.GetByIdAsync(updateBodyTypeCommand.Id);

                if (bodyType == null)
                    throw new Exception("BodyType not found");

                _mapper.Map(updateBodyTypeCommand, bodyType);

                await _bodyTypeRepository.UpdateAsync(bodyType);

                return _mapper.Map<UpdateBodyTypeDto>(bodyType);

            }
        }
    }
}
