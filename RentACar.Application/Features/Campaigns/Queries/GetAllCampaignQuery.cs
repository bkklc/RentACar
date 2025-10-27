using AutoMapper;
using MediatR;
using RentACar.Application.Features.Campaigns.Dtos;
using RentACar.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Application.Features.Campaigns.Queries
{
    public class GetAllCampaignQuery : IRequest<List<GetAllCampaignListDto>>
    {
        public class GetAllCampaignQueryHandler : IRequestHandler<GetAllCampaignQuery, List<GetAllCampaignListDto>>
        {
            private readonly ICampaignRepository _campaignRepository;
            private readonly IMapper _mapper;

            public GetAllCampaignQueryHandler(ICampaignRepository campaignRepository, IMapper mapper)
            {
                _campaignRepository = campaignRepository;
                _mapper = mapper;
            }

            public async Task<List<GetAllCampaignListDto>> Handle(GetAllCampaignQuery getAllCampaignQuery, CancellationToken cancellationToken)
            {
                var campaigns = await _campaignRepository.GetAllAsync();

                return _mapper.Map<List<GetAllCampaignListDto>>(campaigns);
            }
        }
    }
}
