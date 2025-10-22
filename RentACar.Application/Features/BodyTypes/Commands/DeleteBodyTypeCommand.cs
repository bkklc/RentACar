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
            public DeleteBodyTypeCommandHandler(IBodyTypeRepository bodyTypeRepository)
            {
                _bodyTypeRepository = bodyTypeRepository;
            }
            public async Task<DeleteBodyTypeDto> Handle(DeleteBodyTypeCommand deleteBodyTypeCommand, CancellationToken cancellationToken)
            {
                BodyType bodyType = await _bodyTypeRepository.GetByIdAsync(deleteBodyTypeCommand.Id);
                await _bodyTypeRepository.DeleteAsync(bodyType);
                DeleteBodyTypeDto deleteBodyTypeDto = new()
                {
                    Id = bodyType.Id,
                    Name = bodyType.Name,
                    DeletedDate = DateTime.UtcNow
                };
                return deleteBodyTypeDto;
            }
        }
    }
}
