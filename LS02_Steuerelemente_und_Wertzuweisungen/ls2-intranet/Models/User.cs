namespace ls2_intranet.Models
{
    public class User
    {
        public long UserId { get; set; }

        public string DisplayName { get; set; }
        public int UserPin { get; set; }
        public bool UserActive { get; set; }
        public string UserRole { get; set; }
        public long LoginId { get; set; }
    }
}