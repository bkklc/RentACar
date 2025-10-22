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

            public UpdateBodyTypeCommandHandler(IBodyTypeRepository bodyTypeRepository)
            {
                _bodyTypeRepository = bodyTypeRepository;
            }

            public async Task<UpdateBodyTypeDto> Handle(UpdateBodyTypeCommand updateBodyTypeCommand, CancellationToken cancellationToken)
            {
                BodyType bodyType = _bodyTypeRepository.GetByIdAsync(updateBodyTypeCommand.Id).Result;

                if (bodyType == null)
                {
                    throw new Exception("BodyType not found");
                }

                bodyType.Name = updateBodyTypeCommand.Name;

                await _bodyTypeRepository.UpdateAsync(bodyType);

                UpdateBodyTypeDto updateBodyTypeDto = new()
                {
                    Id = bodyType.Id,
                    Name = bodyType.Name,
                    
                };

                return updateBodyTypeDto;

            }
        }
    }
}
