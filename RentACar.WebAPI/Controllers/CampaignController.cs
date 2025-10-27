using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentACar.Application.Features.Campaigns.Commands;
using RentACar.Application.Features.Campaigns.Dtos;
using RentACar.Application.Features.Campaigns.Queries;

namespace RentACar.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampaignController : BaseController
    {

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCampaignCommand createCampaignCommand)
        {
            var Campaign = await Mediator.Send(createCampaignCommand);
            return Created("", Campaign);

        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var Campaigns = await Mediator.Send(new GetAllCampaignQuery());
            return Ok(Campaigns);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdCampaignQuery getByIdCampaignQuery)
        {
            GetByIdCampaignDto getByIdDto = await Mediator!.Send(getByIdCampaignQuery);
            return Ok(getByIdDto);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateCampaignCommand updateCampaignCommand)
        {
            UpdateCampaignDto updateCampaignDto = await Mediator!.Send(updateCampaignCommand);
            return Ok(updateCampaignDto);
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete([FromQuery] DeleteCampaignCommand deleteCampaignCommand)
        {
            DeleteCampaignDto deleteCampaignDto = await Mediator!.Send(deleteCampaignCommand);
            return Ok(deleteCampaignDto);
        }

    }
}
