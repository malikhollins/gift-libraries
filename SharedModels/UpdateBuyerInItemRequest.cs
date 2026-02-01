namespace SharedModels
{
    public class UpdateBuyerInItemRequest
    {
        public int ItemId { get; set; }

        public int ListId { get; set; }

        public int? BuyerId { get; set; } 
    }
}
