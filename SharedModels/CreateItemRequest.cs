namespace SharedModels
{
    public class CreateItemRequest
    {
        public int ListId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public string? Link { get; set; }
    }
}
