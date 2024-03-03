using MediatR;

namespace Botanical.Application.Features.Plants.Commands.CreatePlant
{
    public class CreatePlantCommand : IRequest<Guid>
    {
        public required string CommonName { get; set; }

        public string? BotanicalName { get; set; }

        public required string Type { get; set; }
    }
}
