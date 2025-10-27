using AutoMapper;
using MediatR;
using RentACar.Application.Features.Campaigns.Dtos;
using RentACar.Application.Interfaces.Repositories;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Application.Features.Campaigns.Commands
{
    public class DeleteCampaignCommand : IRequest<DeleteCampaignDto>
    {
        public Guid Id { get; set; }

        public class DeleteCampaignCommandHandler : IRequestHandler<DeleteCampaignCommand, DeleteCampaignDto>
        {
            private readonly ICampaignRepository _campaignRepository;
            private readonly IMapper _mapper;

            public DeleteCampaignCommandHandler(ICampaignRepository campaignRepository, IMapper mapper)
            {
                _campaignRepository = campaignRepository;
                _mapper = mapper;
            }

            public async Task<DeleteCampaignDto> Handle(DeleteCampaignCommand deleteCampaignCommand, CancellationToken cancellationToken)
            {
                Campaign? campaign = await _campaignRepository.GetByIdAsync(deleteCampaignCommand.Id);

                if (campaign == null)
                    throw new Exception("Campaign not found");

                await _campaignRepository.DeleteAsync(campaign);

                return _mapper.Map<DeleteCampaignDto>(campaign);
            }
        }
    }
}
