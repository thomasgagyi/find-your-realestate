namespace FindYourRealEstate.Models
{
    public class ContactInfo
    {
        public required string Address { get; set; }
        public required string City { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Email { get; set; }

        public required string MondayToFriday { get; set; }
        public required string Saturday { get; set; }
        public required string AddittionalInfo { get; set; }

        public required string FacebookIconUrl { get; set; }
        public required string InstagramIconUrl { get; set; }
        public required string TwitterIconUrl { get; set; }
    }
}