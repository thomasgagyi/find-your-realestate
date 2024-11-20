using Microsoft.AspNetCore.Components;
using FindYourRealEstate.Models;

namespace FindYourRealEstate.Components.Layout.Sections
{
    public partial class HomesTriplet
    {
        [Parameter]
        public required string HomesTripletType { get; set; }
        [Parameter]
        public required HomeDetails HomeDetailsLeft { get; set; }
        [Parameter]
        public required HomeDetails HomeDetailsMiddle { get; set; }
        [Parameter]
        public required HomeDetails HomeDetailsRight { get; set; }
        [Parameter]
        public required string BackgroundColor { get; set; }

        [Parameter]
        public required string HomeDetailsPageLeft { get; set; }
        [Parameter]
        public required string HomeDetailsPageMiddle { get; set; }
        [Parameter]
        public required string HomeDetailsPageRight { get; set; }
    }
}