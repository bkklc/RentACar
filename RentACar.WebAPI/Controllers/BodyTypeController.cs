using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentACar.Application.Features.BodyTypes.Commands;
using RentACar.Application.Features.BodyTypes.Dtos;
using RentACar.Application.Features.BodyTypes.Queries;

namespace RentACar.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BodyTypeController : BaseController
    {

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateBodyTypeCommand createBodyTypeCommand)
        {
            var bodyType = await Mediator.Send(createBodyTypeCommand);
            return Created("", bodyType);

        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var bodyTypes = await Mediator.Send(new GetAllBodyTypeQuery());
            return Ok(bodyTypes);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdBodyTypeQuery getByIdBodyTypeQuery)
        {
            GetByIdBodyTypeDto getByIdDto = await Mediator!.Send(getByIdBodyTypeQuery);
            return Ok(getByIdDto);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateBodyTypeCommand updateBodyTypeCommand)
        {
            UpdateBodyTypeDto updateBodyTypeDto = await Mediator!.Send(updateBodyTypeCommand);
            return Ok(updateBodyTypeDto);
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete([FromQuery] DeleteBodyTypeCommand deleteBodyTypeCommand)
        {
            DeleteBodyTypeDto deleteBodyTypeDto = await Mediator!.Send(deleteBodyTypeCommand);
            return Ok(deleteBodyTypeDto);
        }
    }
}
