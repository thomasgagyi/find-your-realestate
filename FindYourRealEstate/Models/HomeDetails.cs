namespace FindYourRealEstate.Models
{
    public class HomeDetails
    {
        public required string HomeImageUrl { get; set; }
        public required string HomeLayoutImageUrl { get; set; }
        public required string HomeName { get; set; }
        public required string HomeStatus { get; set; }
        public required int NumBeds { get; set; }
        public required int NumBaths { get; set; }
        public required int NumCars { get; set; }
        public required string Additional { get; set; }
        public required string BedsIconUrl { get; set; }
        public required string BathsIconUrl { get; set; }
        public required string CarsIconUrl { get; set; }
    }
}