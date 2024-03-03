using AutoMapper;
using Botanical.Application.Contracts.Persistence;
using Domain.Entities;
using MediatR;

namespace Botanical.Application.Features.Plants.Commands.CreatePlant
{
    public class CreatePlantCommandHandler(IPlantsRepository plantsRepository, IMapper mapper) : IRequestHandler<CreatePlantCommand, Guid>
    {
        private readonly IPlantsRepository PlantsRepository = plantsRepository;
        private readonly IMapper Mapper = mapper;

        public async Task<Guid> Handle(CreatePlantCommand request, CancellationToken cancellationToken)
        {
            var plant = Mapper.Map<Plant>(request);

            plant = await PlantsRepository.AddAsync(plant);

            return plant.Id;
        }
    }
}