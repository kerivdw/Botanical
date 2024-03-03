namespace Domain.Entities
{
    public sealed class Plant
    {
        public Guid Id { get; set; }

        public required string CommonName { get; set; }

        public string? BotanicalName { get; set; }

        public required string Type { get; set; }

    }
}
