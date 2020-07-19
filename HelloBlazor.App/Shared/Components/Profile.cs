
using Microsoft.AspNetCore.Components;

namespace HelloBlazor.App.Shared.Components
{
    public class ProfileBase:ComponentBase{
       
        [Parameter]
        public RenderFragment ChildContent {get;set;}
    }
}