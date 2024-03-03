namespace Botanical.Application.Features.Plants.Queries.GetPlantDetail
{
    public class PlantDetail
    {
        public required string CommonName { get; set; }

        public string? BotanicalName { get; set; }

        public required string Type { get; set; }

    }
}
