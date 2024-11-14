using Microsoft.AspNetCore.Components;

namespace FindYourRealEstate.Components.Layout.Sections
{
    public partial class Hero
    {
        [Parameter]
        public required string BackgroundImageUrl { get; set; }
        [Parameter]
        public required string HeroWelcomeText { get; set; }

    }
}