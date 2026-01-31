namespace SharedModels
{
    public class CreateInviteRequest
    {
        public int UserId { get; set; }
        public int HouseId { get; set; }
        public int UserToInvite { get; set; }
    }
}
