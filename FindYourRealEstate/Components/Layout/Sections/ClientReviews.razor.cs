using FindYourRealEstate.Models;
using Microsoft.AspNetCore.Components;

namespace FindYourRealEstate.Components.Layout.Sections
{
    public partial class ClientReviews
    {
        [Parameter]
        public required Review ReviewLeft { get; set; }
        [Parameter]
        public required Review ReviewMiddle { get; set; }
        [Parameter]
        public required Review ReviewRight { get; set; }
    }
}