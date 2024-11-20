using FindYourRealEstate.Models;

namespace FindYourRealEstate.Components.Data
{
    public static class ContactInformationData
    {
        public static string rightContentImageUrl => "https://raw.githubusercontent.com/thomasgagyi/find-your-realestate/refs/heads/master/FindYourRealEstate/Resources/Images/s2.jpg";
        public static ContactInfo contactInfoData = new ContactInfo
        {
            Address = "23 Anywhere St.",
            City = "Any City, ST 12345",
            PhoneNumber = "(123) 456-7890",
            Email = "hello@reallygreatsite.com",

            MondayToFriday = "9:00 am to 6:00 pm",
            Saturday = "9:00 am to 12 noon",
            AddittionalInfo = "Sunday by appointment only.",

            FacebookIconUrl = "https://raw.githubusercontent.com/thomasgagyi/find-your-realestate/refs/heads/master/FindYourRealEstate/Resources/Images/fb.png",
            InstagramIconUrl = "https://raw.githubusercontent.com/thomasgagyi/find-your-realestate/refs/heads/master/FindYourRealEstate/Resources/Images/in.png",
            TwitterIconUrl = "https://raw.githubusercontent.com/thomasgagyi/find-your-realestate/refs/heads/master/FindYourRealEstate/Resources/Images/tw.png"
        };
    }
}
