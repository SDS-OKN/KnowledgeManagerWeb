// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace KnowledgeManagerOnline.Pages
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
#line 2 "C:\Users\sapap\source\repos\KnowledgeManagerOnline\KnowledgeManagerOnline\Pages\Test1.razor"
using KnowledgeManagerOnline.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sapap\source\repos\KnowledgeManagerOnline\KnowledgeManagerOnline\Pages\Test1.razor"
using KnowledgeManagerOnline.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sapap\source\repos\KnowledgeManagerOnline\KnowledgeManagerOnline\Pages\Test1.razor"
using KnowledgeManagerOnline.Components.Tiles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sapap\source\repos\KnowledgeManagerOnline\KnowledgeManagerOnline\Pages\Test1.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Test1")]
    public partial class Test1 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Users\sapap\source\repos\KnowledgeManagerOnline\KnowledgeManagerOnline\Pages\Test1.razor"
       

    [Parameter]
    public string ChatId { get; set; } = "chatComp1";


    // DotNetObjectReference<ChatComponent> chatRazorComponent { get; set; }



    [JSInvokable]
    public async void RaiseResponseChat(string userId, string chatText)
    {
        Console.WriteLine(userId);
        Console.WriteLine(chatText);
        //return "made it";
    }


    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            //if (chatRazorComponent == null)
            //{
            //    chatRazorComponent = DotNetObjectReference.Create(this);
            //}
            var result = await JSRuntime.InvokeAsync<string>("createChatWidget", "createChat", DotNetObjectReference.Create(this), ChatId);
            Console.WriteLine(result);
        }
    }
    public void Dispose()
    {
        //JSRuntime.InvokeVoidAsync("destroyWidgets", chatRazorComponent);
        //if (chatRazorComponent != null)
        //{
        //    chatRazorComponent.Dispose();
        //}
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
