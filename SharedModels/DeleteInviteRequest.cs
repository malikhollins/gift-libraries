namespace SharedModels
{
    public class DeleteInviteRequest
    {
        public int UserId { get; set; }

        public int HouseId { get; set; }

        public int UserInviteToDelete { get; set; }
    }
}
