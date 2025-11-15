namespace SharedModels
{
    public class UpdateFavoriteItemRequest
    {
        public int UserId { get; set; }

        public int ListId { get; set; }

        public int ItemId { get; set; }

        public bool Favorited { get; set; }
    }
}
