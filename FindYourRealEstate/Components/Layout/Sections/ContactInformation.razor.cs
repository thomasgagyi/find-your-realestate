using FindYourRealEstate.Models;
using Microsoft.AspNetCore.Components;

namespace FindYourRealEstate.Components.Layout.Sections
{
    public partial class ContactInformation
    {
        [Parameter]
        public required ContactInfo ContactInfo { get; set; }
        [Parameter]
        public required string RightContentImageUrl { get; set; }
    }
}