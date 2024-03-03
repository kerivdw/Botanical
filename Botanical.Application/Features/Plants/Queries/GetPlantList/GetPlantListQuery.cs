using MediatR;

namespace Botanical.Application.Features.Plants.Queries.GetPlantList
{
    public class GetPlantListQuery : IRequest<List<PlantList>>
    {
    }
}
