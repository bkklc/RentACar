using MediatR;
using RentACar.Application.Features.BodyTypes.Dtos;
using RentACar.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Application.Features.BodyTypes.Queries
{
    public class GetAllBodyTypeQuery : IRequest<GetAllBodyTypeList>
    {

        public class GetAllBodyTypeQueryHandler : IRequestHandler<GetAllBodyTypeQuery, GetAllBodyTypeList>
        {
            private readonly IBodyTypeRepository _bodyTypeRepository;
            public GetAllBodyTypeQueryHandler(IBodyTypeRepository bodyTypeRepository)
            {
                _bodyTypeRepository = bodyTypeRepository;
            }
            public async Task<GetAllBodyTypeList> Handle(GetAllBodyTypeQuery getAllBodyTypeQuery, CancellationToken cancellationToken)
            {
                var bodyTypes = await _bodyTypeRepository.GetAllAsync();
                var getAllBodyTypeList = new GetAllBodyTypeList
                {
                    BodyTypeLists = bodyTypes.Select(bt => new BodyTypeListItemDto
                    {
                        Id = bt.Id,
                        Name = bt.Name
                    }).ToList()
                };
                return getAllBodyTypeList;

            }

        }
    }
}