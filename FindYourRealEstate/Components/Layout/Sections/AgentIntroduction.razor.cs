using Microsoft.AspNetCore.Components;

namespace FindYourRealEstate.Components.Layout.Sections
{
    public partial class AgentIntroduction
    {
        [Parameter]
        public required string AgentImageUrl { get; set; }
        [Parameter]
        public required string AgentIntroText { get; set; }

    }
}