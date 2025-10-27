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
    public class UpdateCampaignCommand : IRequest<UpdateCampaignDto>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal DiscountRate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
        public int? MinRentalDays { get; set; }
        public int? MaxRentalDays { get; set; }

        public class UpdateCampaignCommandHandler : IRequestHandler<UpdateCampaignCommand, UpdateCampaignDto>
        {
            private readonly ICampaignRepository _campaignRepository;
            private readonly IMapper _mapper;

            public UpdateCampaignCommandHandler(ICampaignRepository campaignRepository, IMapper mapper)
            {
                _campaignRepository = campaignRepository;
                _mapper = mapper;
            }

            public async Task<UpdateCampaignDto> Handle(UpdateCampaignCommand updateCampaignCommand, CancellationToken cancellationToken)
            {
                Campaign? campaign = await _campaignRepository.GetByIdAsync(updateCampaignCommand.Id);

                if (campaign == null)
                    throw new Exception("Campaign not found");

                _mapper.Map(updateCampaignCommand, campaign);

                await _campaignRepository.UpdateAsync(campaign);

                return _mapper.Map<UpdateCampaignDto>(campaign);
            }
        }
    }
}
