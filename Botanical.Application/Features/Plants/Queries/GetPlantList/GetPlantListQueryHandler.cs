using AutoMapper;
using Botanical.Application.Contracts.Persistence;
using MediatR;

namespace Botanical.Application.Features.Plants.Queries.GetPlantList
{
    public class GetPlantListQueryHandler(
        IMapper mapper,
        IAsyncRepository<List<PlantList>> plantRepository) : IRequestHandler<GetPlantListQuery, List<PlantList>>
    {
        public IAsyncRepository<List<PlantList>> PlantRepository { get; } = plantRepository;
        public IMapper Mapper { get; } = mapper;

        public async Task<List<PlantList>> Handle(GetPlantListQuery request, CancellationToken cancellationToken)
        {
            var plants = await PlantRepository.ListAllAsync();

            var plantList = Mapper.Map<List<PlantList>>(plants);

            return plantList;

        }
    }
}
