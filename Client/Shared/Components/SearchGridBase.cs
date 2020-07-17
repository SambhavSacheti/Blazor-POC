using System.Collections.Generic;
using Microsoft.AspNetCore.Components;

namespace HelloBlazor.Shared.Components
{
    public class SearchGridBase : ComponentBase
    {

        [Parameter]
        public List<PublicApiEntry> ApiEntries { get; set; }

        [Parameter]
        public int RecordsPerPage { get; set; }

        [Parameter]
        public PublicApiEntry SelectedApiEntry { get; set; }

        [Parameter]
        public bool IsDatagridVisible { get; set; }

        protected void RowSelected(PublicApiEntry apiEntry)
        {
            SelectedApiEntry = apiEntry;
            StateHasChanged();

        }


    }
}