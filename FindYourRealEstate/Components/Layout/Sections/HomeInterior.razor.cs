using Microsoft.AspNetCore.Components;

namespace FindYourRealEstate.Components.Layout.Sections
{
    public partial class HomeInterior
    {
        [Parameter]
        public required string VideoUrl { get; set; }
        [Parameter]
        public required string VideoOverlayText { get; set; } = "";

    }
}