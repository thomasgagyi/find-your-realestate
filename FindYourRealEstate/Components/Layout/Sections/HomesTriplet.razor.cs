using Microsoft.AspNetCore.Components;
using FindYourRealEstate.Models;
using System.Drawing;

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
    }
}