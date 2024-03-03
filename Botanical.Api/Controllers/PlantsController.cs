using Botanical.Application.Features.Plants.Commands.CreatePlant;
using Botanical.Application.Features.Plants.Queries.GetPlantDetail;
using Botanical.Application.Features.Plants.Queries.GetPlantList;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Botanical.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlantsController : ControllerBase
    {
        private readonly IMediator _mediator;

        [HttpGet]
        public async Task<ActionResult<List<PlantList>>> GetAllPlants()
        {
            var plants = await _mediator.Send(new GetPlantListQuery());
            return Ok(plants);
        }

        [HttpGet("{id}", Name = "Id")]
        public async Task<ActionResult<PlantDetail>> GetEventById(Guid id)
        {
            var getPlantDetailQuery = new GetPlantDetailQuery() { Id = id };
            var plantDetail = await _mediator.Send(getPlantDetailQuery);
            return Ok(plantDetail);
        }

        [HttpPost(Name = "AddPlant")]
        public async Task<ActionResult<Guid>> Create(CreatePlantCommand createPlantCommand)
        {
            var plantId = await _mediator.Send(createPlantCommand);
            return Ok(plantId);
        }
    }
}
