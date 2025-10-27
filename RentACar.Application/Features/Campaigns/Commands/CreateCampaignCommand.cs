using AutoMapper;
using MediatR;
using RentACar.Application.Features.Campaigns.Dtos;
using RentACar.Application.Interfaces.Repositories;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace RentACar.Application.Features.Campaigns.Commands
{
    public class CreateCampaignCommand : IRequest<CreateCampaignDto>        
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal DiscountRate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
        public int? MinRentalDays { get; set; }
        public int? MaxRentalDays { get; set; }


        public class CreateCampaignCommandHandler : IRequestHandler<CreateCampaignCommand, CreateCampaignDto>
        {
            private readonly ICampaignRepository _campaignRepository;
            private readonly IMapper _mapper;

            public CreateCampaignCommandHandler(ICampaignRepository campaignRepository, IMapper mapper)
            {
                _campaignRepository = campaignRepository;
                _mapper = mapper;
            }

            public async Task<CreateCampaignDto> Handle(CreateCampaignCommand createCampaignCommand, CancellationToken cancellationToken)
            {
                
                Campaign campaign = _mapper.Map<Campaign>(createCampaignCommand);

                
                Campaign createdCampaign = await _campaignRepository.AddAsync(campaign);

                
                return _mapper.Map<CreateCampaignDto>(createdCampaign);


            }
        }
    }
}
