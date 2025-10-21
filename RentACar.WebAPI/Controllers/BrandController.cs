using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentACar.Application.Features.Brands.Commands;
using RentACar.Application.Features.Brands.Dtos;
using RentACar.Application.Features.Brands.Queries;

namespace RentACar.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateBrandCommand createBrandCommand)
        {
            var result = await Mediator.Send(createBrandCommand);
            return Created("", result);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateBrandCommand updateBrandCommand)
        {
            UpdateBrandDto updateBrandDto = await Mediator!.Send(updateBrandCommand);
            return Ok(updateBrandDto);
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete([FromQuery] DeleteBrandCommand deleteBrandCommand)
        {
            DeleteBrandDto deleteBrandDto = await Mediator!.Send(deleteBrandCommand);
            return Ok(deleteBrandDto);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdBrandQuery getByIdBrandQuery)
        {
            GetByIdBrandDto getByIdDto = await Mediator!.Send(getByIdBrandQuery);
            return Ok(getByIdDto);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await Mediator.Send(new GetAllBrandQuery());
            return Ok(result);
        }


    }
}
