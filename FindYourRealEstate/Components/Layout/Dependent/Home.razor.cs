using Microsoft.AspNetCore.Components;
using FindYourRealEstate.Models;

namespace FindYourRealEstate.Components.Layout.Dependent
{
    public partial class Home
    {
        [Parameter]
        public required HomeDetails Details { get; set; }
    }
}