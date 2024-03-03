using MediatR;

namespace Botanical.Application.Features.Plants.Queries.GetPlantDetail
{
    public class GetPlantDetailQuery : IRequest<PlantDetail>
    {
        public Guid Id { get; set; }
    }
}
