using AutoMapper;
using MediatR;
using RentACar.Application.Features.Campaigns.Dtos;
using RentACar.Application.Interfaces.Repositories;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Application.Features.Campaigns.Queries
{
    public class GetByIdCampaignQuery : IRequest<GetByIdCampaignDto>
    {
        public Guid Id { get; set; }

        public class GetByIdCampaignQueryHandler : IRequestHandler<GetByIdCampaignQuery, GetByIdCampaignDto>
        {
            private readonly ICampaignRepository _campaignRepository;
            private readonly IMapper _mapper;

            public GetByIdCampaignQueryHandler(ICampaignRepository campaignRepository, IMapper mapper)
            {
                _campaignRepository = campaignRepository;
                _mapper = mapper;
            }

            public async Task<GetByIdCampaignDto> Handle(GetByIdCampaignQuery getByIdCampaignQuery, CancellationToken cancellationToken)
            {
                Campaign? campaign = await _campaignRepository.GetByIdAsync(getByIdCampaignQuery.Id);

                if (campaign == null)
                    throw new Exception("Campaign not found");

                return _mapper.Map<GetByIdCampaignDto>(campaign);
            }
        }
    }
}
