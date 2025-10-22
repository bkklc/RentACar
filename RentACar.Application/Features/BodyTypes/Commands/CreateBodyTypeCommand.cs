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

            public CreateBodyTypeCommandHandler(IBodyTypeRepository bodyTypeRepository)
            {
                _bodyTypeRepository = bodyTypeRepository;
            }

            public async Task<CreateBodyTypeDto> Handle(CreateBodyTypeCommand createBodyTypeCommand, CancellationToken cancellationToken)
            {

                var  bodyType = new BodyType
                {
                    Name = createBodyTypeCommand.Name,
                };

                var createdBodyType = await _bodyTypeRepository.AddAsync(bodyType);

                var createdBodyTypeDto = new CreateBodyTypeDto
                {
                    Id = createdBodyType.Id,
                    Name = createdBodyType.Name,
                    CreatedDate = createdBodyType.CreatedDate
                };


                return createdBodyTypeDto;
            }
        }


    }
}
