using FindYourRealEstate.Models;
using Microsoft.AspNetCore.Components;
using FindYourRealEstate.Components.Layout.Sections;

namespace FindYourRealEstate.Components.Layout.PageLayouts
{
    public partial class HomeOverview
    {
        [Parameter]
        public required HomeDetails Details { get; set; }
    }
}