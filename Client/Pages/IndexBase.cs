using System.Collections.Generic;
using Microsoft.AspNetCore.Components;

namespace HelloBlazor.Pages
{
    public class IndexBase : ComponentBase
    {
        protected List<PublicApiEntry> publicApiEntries;
        protected int recordsPerPage = 6;
        protected PublicApiEntry selectedApiEntry;
        protected bool datagridVisible = true;


        protected void checkChange(bool value)
        {
            datagridVisible = value;
            StateHasChanged();
        }

        protected void recordsCountChange(int value)
        {
             recordsPerPage = value;
             datagridVisible = false;
            StateHasChanged();

        }

    }
}