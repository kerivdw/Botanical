namespace Botanical.Application.Features.Plants.Queries.GetPlantList
{
    public class PlantList
    {
        public required string CommonName { get; set; }

        public string? BotanicalName { get; set; }

        public required string Type { get; set; }
    }
}
