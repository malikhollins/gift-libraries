namespace SharedModels
{
    public class UpdateItemRequest
    {
        public int UserId { get; set; }

        public int ListId { get; set; }

        public int ItemId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Link { get; set; }

        public double Price { get; set; }
    }
}
