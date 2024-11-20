using FindYourRealEstate.Models;
using Microsoft.AspNetCore.Components;

namespace FindYourRealEstate.Components.Layout
{
    public partial class MainPage
    {
        public Review reviewLeft = new Review
        {
            ReviewBody = "Boost your product and service's credibility by adding testimonials from your clients. People love recommendations so feedback from others who've tried it is invaluable.",
            Author = "Powell Finwood"
        };

        public Review reviewMiddle = new Review
        {
            ReviewBody = "Boost your product and service's credibility by adding testimonials from your clients. People love recommendations so feedback from others who've tried it is invaluable.\r\n\r\nBoost your product and service's credibility by adding testimonials from your clients. \r\n",
            Author = "Ingrid Correa"
        };

        public Review reviewRight = new Review
        {
            ReviewBody = "Boost your product and service's credibility by adding testimonials from your clients.",
            Author = "Hannah Elmore"
        };

        #region Featured_Listings

        public HomeDetails homeDetailsRight = new HomeDetails
        {
            HomeImageUrl = "https://raw.githubusercontent.com/thomasgagyi/find-your-realestate/refs/heads/master/FindYourRealEstate/Resources/Images/rigH.jpg",
            HomeLayoutImageUrl = "missing",
            HomeName = "7 Walderlane Hill",
            HomeStatus = "House for rent",
            NumBeds = 2,
            NumBaths = 2,
            NumCars = 1,
            Additional = "This property uses green technology",
            BedsIconUrl = "https://raw.githubusercontent.com/thomasgagyi/find-your-realestate/refs/heads/master/FindYourRealEstate/Resources/Images/tl.png",
            BathsIconUrl = "https://raw.githubusercontent.com/thomasgagyi/find-your-realestate/refs/heads/master/FindYourRealEstate/Resources/Images/ba.png",
            CarsIconUrl = "https://raw.githubusercontent.com/thomasgagyi/find-your-realestate/refs/heads/master/FindYourRealEstate/Resources/Images/ca.png"
        };
        #endregion Featured_Listings

        #region Open_Houses
        public HomeDetails homeDetailsLeftOH = new HomeDetails
        {
            HomeImageUrl = "https://raw.githubusercontent.com/thomasgagyi/find-your-realestate/refs/heads/master/FindYourRealEstate/Resources/Images/lefR.jpg",
            HomeLayoutImageUrl = "missing",
            HomeName = "88 Grayervine Hill",
            HomeStatus = "House for rent",
            NumBeds = 3,
            NumBaths = 2,
            NumCars = 3,
            Additional = "This property is wheelchair accessible",
            BedsIconUrl = "https://raw.githubusercontent.com/thomasgagyi/find-your-realestate/refs/heads/master/FindYourRealEstate/Resources/Images/tl.png",
            BathsIconUrl = "https://raw.githubusercontent.com/thomasgagyi/find-your-realestate/refs/heads/master/FindYourRealEstate/Resources/Images/ba.png",
            CarsIconUrl = "https://raw.githubusercontent.com/thomasgagyi/find-your-realestate/refs/heads/master/FindYourRealEstate/Resources/Images/ca.png"
        };

        public HomeDetails homeDetailsMiddleOH = new HomeDetails
        {
            HomeImageUrl = "https://raw.githubusercontent.com/thomasgagyi/find-your-realestate/refs/heads/master/FindYourRealEstate/Resources/Images/midR.jpg",
            HomeLayoutImageUrl = "missing",
            HomeName = "901 Vinestone Drive",
            HomeStatus = "House for lease",
            NumBeds = 4,
            NumBaths = 3,
            NumCars = 1,
            Additional = "This property is wheelchair accessible",
            BedsIconUrl = "https://raw.githubusercontent.com/thomasgagyi/find-your-realestate/refs/heads/master/FindYourRealEstate/Resources/Images/tl.png",
            BathsIconUrl = "https://raw.githubusercontent.com/thomasgagyi/find-your-realestate/refs/heads/master/FindYourRealEstate/Resources/Images/ba.png",
            CarsIconUrl = "https://raw.githubusercontent.com/thomasgagyi/find-your-realestate/refs/heads/master/FindYourRealEstate/Resources/Images/ca.png"
        };

        public HomeDetails homeDetailsRightOH = new HomeDetails
        {
            HomeImageUrl = "https://raw.githubusercontent.com/thomasgagyi/find-your-realestate/refs/heads/master/FindYourRealEstate/Resources/Images/rigR.jpg",
            HomeLayoutImageUrl = "missing",
            HomeName = "1203 S. Milenna Avenue",
            HomeStatus = "House for lease",
            NumBeds = 2,
            NumBaths = 2,
            NumCars = 1,
            Additional = "This property is wheelchair accessible",
            BedsIconUrl = "https://raw.githubusercontent.com/thomasgagyi/find-your-realestate/refs/heads/master/FindYourRealEstate/Resources/Images/tl.png",
            BathsIconUrl = "https://raw.githubusercontent.com/thomasgagyi/find-your-realestate/refs/heads/master/FindYourRealEstate/Resources/Images/ba.png",
            CarsIconUrl = "https://raw.githubusercontent.com/thomasgagyi/find-your-realestate/refs/heads/master/FindYourRealEstate/Resources/Images/ca.png"
        };
        #endregion Open_Houses

        public ContactInfo contactInfo = new ContactInfo
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