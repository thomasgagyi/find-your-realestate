using Microsoft.AspNetCore.Components;
using FindYourRealEstate.Models;

namespace FindYourRealEstate.Components.Layout.Sections
{
    public partial class HomeDescription
    {
        [Parameter]
        public required HomeDetails Details { get; set; }
    }
}