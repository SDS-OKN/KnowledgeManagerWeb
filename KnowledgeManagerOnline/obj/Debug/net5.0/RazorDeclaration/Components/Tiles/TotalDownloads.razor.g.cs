// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace KnowledgeManagerOnline.Components.Tiles
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\sapap\source\repos\KnowledgeManagerOnline\KnowledgeManagerOnline\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sapap\source\repos\KnowledgeManagerOnline\KnowledgeManagerOnline\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sapap\source\repos\KnowledgeManagerOnline\KnowledgeManagerOnline\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sapap\source\repos\KnowledgeManagerOnline\KnowledgeManagerOnline\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sapap\source\repos\KnowledgeManagerOnline\KnowledgeManagerOnline\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sapap\source\repos\KnowledgeManagerOnline\KnowledgeManagerOnline\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\sapap\source\repos\KnowledgeManagerOnline\KnowledgeManagerOnline\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sapap\source\repos\KnowledgeManagerOnline\KnowledgeManagerOnline\_Imports.razor"
using KnowledgeManagerOnline;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\sapap\source\repos\KnowledgeManagerOnline\KnowledgeManagerOnline\_Imports.razor"
using KnowledgeManagerOnline.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\sapap\source\repos\KnowledgeManagerOnline\KnowledgeManagerOnline\_Imports.razor"
using Telerik.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\sapap\source\repos\KnowledgeManagerOnline\KnowledgeManagerOnline\_Imports.razor"
using Telerik.Blazor.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\sapap\source\repos\KnowledgeManagerOnline\KnowledgeManagerOnline\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\sapap\source\repos\KnowledgeManagerOnline\KnowledgeManagerOnline\Components\Tiles\TotalDownloads.razor"
using KnowledgeManagerOnline.Services;

#line default
#line hidden
#nullable disable
    public partial class TotalDownloads : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\Users\sapap\source\repos\KnowledgeManagerOnline\KnowledgeManagerOnline\Components\Tiles\TotalDownloads.razor"
      
    int Downloads { get; set; }
    protected override async Task OnInitializedAsync()
    {
        Downloads = await _dataService.GetDownloads();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DashboardDataService _dataService { get; set; }
    }
}
#pragma warning restore 1591