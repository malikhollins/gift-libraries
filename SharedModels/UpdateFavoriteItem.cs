namespace SharedModels
{
    public class UpdateFavoriteItem
    {
        public int UserId { get; set; }

        public int ListId { get; set; }

        public int ItemId { get; set; }

        public bool Favorited { get; set; }
    }
}
