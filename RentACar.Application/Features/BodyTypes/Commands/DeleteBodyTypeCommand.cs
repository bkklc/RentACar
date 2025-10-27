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
    public class DeleteBodyTypeCommand : IRequest<DeleteBodyTypeDto>
    {
        public Guid Id { get; set; }

        public class DeleteBodyTypeCommandHandler : IRequestHandler<DeleteBodyTypeCommand, DeleteBodyTypeDto>
        {
            private readonly IBodyTypeRepository _bodyTypeRepository;
            private readonly IMapper _mapper;

            public DeleteBodyTypeCommandHandler(IBodyTypeRepository bodyTypeRepository, IMapper mapper)
            {
                _bodyTypeRepository = bodyTypeRepository;
                _mapper = mapper;
            }
            public async Task<DeleteBodyTypeDto> Handle(DeleteBodyTypeCommand deleteBodyTypeCommand, CancellationToken cancellationToken)
            {
                BodyType bodyType = await _bodyTypeRepository.GetByIdAsync(deleteBodyTypeCommand.Id);

                if (bodyType == null)
                    throw new Exception("BodyType not found");

                await _bodyTypeRepository.DeleteAsync(bodyType);

                return _mapper.Map<DeleteBodyTypeDto>(bodyType);
            }
        }
    }
}
