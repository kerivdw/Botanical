using AutoMapper;
using Botanical.Application.Contracts.Persistence;
using Domain.Entities;
using MediatR;

namespace Botanical.Application.Features.Plants.Queries.GetPlantDetail
{
    public class GetPlantDetailQueryHandler(
        IMapper mapper,
        IAsyncRepository<Plant> plantRepository) : IRequestHandler<GetPlantDetailQuery, PlantDetail>
    {
        private readonly IAsyncRepository<Plant> PlantRepository = plantRepository;
        private readonly IMapper Mapper = mapper;

        public async Task<PlantDetail> Handle(GetPlantDetailQuery request, CancellationToken cancellationToken)
        {
            var plant = await PlantRepository.GetByIdAsync(request.Id);

            var plantDetails = Mapper.Map<PlantDetail>(plant);

            return plantDetails;
        }
    }
}
